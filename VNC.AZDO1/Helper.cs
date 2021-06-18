using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

using VNC;
using VNC.Core;

namespace VNC.AZDO1
{
    public class Helper
    {
        private static VssCredentials _vssCredentials = null;

        public static VssCredentials GetVssCredentials()
        {
            VssCredentials credentials = null;
            string userName = default;
            string password = default;

            if (_vssCredentials is null)
            {
                // PAT
                //_vssCredentials = new VssBasicCredential(string.Empty, "<pat>");

                // UserName/Password
                //_vssCredentials = new VssAadCredential(userName, password);

                // Logon
                _vssCredentials = new VssClientCredentials();
            }

            return _vssCredentials;
        }

        public static async Task<IList<WorkItem>> QueryWorkItemInfoById(string organization, int id)
        {
            var uri = new Uri($"https://dev.azure.com/{organization}");
            var credentials = GetVssCredentials();

            //var project = "VNC Agile";

            var wiql = new Wiql()
            {
                // NOTE: Even if other columns are specified, only the ID & URL are available in the WorkItemReference
                Query = "Select [Id] " +
                    "From WorkItems " +
                    "Where Id = " + id
            };

            using (var httpClient = new WorkItemTrackingHttpClient(uri, credentials))
            {
                // execute the query to get the list of work items in the results
                var result = await httpClient.QueryByWiqlAsync(wiql).ConfigureAwait(false);
                var ids = result.WorkItems.Select(item => item.Id).ToArray();

                // some error handling
                if (ids.Length == 0)
                {
                    return Array.Empty<WorkItem>();
                }

                // TODO(crhodes)
                // How can we efficiently get more details depending on WorkItem Type

                string[] fields = GetFieldList();

                // Get WorkItem details (fields) for the ids found in query
                return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
            }
        }

        public static async Task<int> QueryRelatedBugsById(string organization, int id)
        {
            var uri = new Uri($"https://dev.azure.com/{organization}");
            var credentials = GetVssCredentials();

            //var project = "VNC Agile";

            var wiql = new Wiql()
            {
                // NOTE: Even if other columns are specified, only the ID & URL are available in the WorkItemReference
                Query = "Select [Id]"
                    + " FROM WorkItemLinks"
                    + $" WHERE ([Source].[System.Id] = {id} )"
                    + $" AND ([Target].[System.WorkItemType] = 'Bug' )"
                    + " MODE (MustContain)"
            };

            using (var httpClient = new WorkItemTrackingHttpClient(uri, credentials))
            {
                // execute the query to get the list of work items in the results
                var result = await httpClient.QueryByWiqlAsync(wiql).ConfigureAwait(false);

                int relatedBugs = result.WorkItemRelations.Count();

                return relatedBugs > 0 ? relatedBugs - 1 : 0;
            }
        }

        //public static async Task<IList<WorkItem>> QueryWorkItemInfoByTeam(string organization, string teamProject, 
        //    string state = "")
        //{
        //    var uri = new Uri($"https://dev.azure.com/{organization}");
        //    var credentials = GetVssCredentials();

        //    //var project = "VNC Agile";

        //    var wiql = new Wiql()
        //    {
        //        // NOTE: Even if other columns are specified, only the ID & URL are available in the WorkItemReference
        //        Query = "Select [Id] " +
        //            "From WorkItems " +
        //            "Where [System.TeamProject] == " + $"{ teamProject.WrapInSngQuotes() }"
        //    };

        //    if (state.Equals("NotClosed"))
        //    {
        //        wiql.Query += $" AND [System.State] <> 'Closed'";
        //    }

        //    using (var httpClient = new WorkItemTrackingHttpClient(uri, credentials))
        //    {
        //        // execute the query to get the list of work items in the results
        //        var result = await httpClient.QueryByWiqlAsync(wiql).ConfigureAwait(false);
        //        var ids = result.WorkItems.Select(item => item.Id).ToArray();

        //        // some error handling
        //        if (ids.Length == 0)
        //        {
        //            return Array.Empty<WorkItem>();
        //        }

        //        string[] fields = GetFieldList();

        //        // Get WorkItem details (fields) for the ids found in query
        //        return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
        //    }
        //}

        public static async Task<IList<WorkItem>> QueryWorkItemInfoByTeam(string organization, string teamProject,
            string workItemType, string state = "",
            string areaPath = "", string iterationPath = "")
        {
            var uri = new Uri($"https://dev.azure.com/{organization}");
            var credentials = GetVssCredentials();

            //var project = "VNC Agile";

            var wiql = new Wiql()
            {
                // NOTE: Even if other columns are specified, only the ID & URL are available in the WorkItemReference
                Query = "Select [Id] "
                    + "From WorkItems"
                    + $" WHERE [System.TeamProject] = '{ teamProject }'"
            };

            if (!string.IsNullOrEmpty(workItemType))
            {
                wiql.Query += $"AND [System.WorkItemType] = '{workItemType}'";
            }

            if (! string.IsNullOrEmpty(state))
            {
                if (state.Equals("NotClosed"))
                {
                    wiql.Query += " AND [System.State] <> 'Closed'";
                }
                else
                {
                    wiql.Query += $" AND [System.State] <> '{state}'";
                }
            }

            if (!string.IsNullOrEmpty(areaPath))
            {
                wiql.Query += $" AND [System.AreaPath] = '{areaPath}'";
            }

            if (!string.IsNullOrEmpty(iterationPath))
            {
                wiql.Query += $" AND [System.IterationPath] = '{iterationPath}'";
            }

            using (var httpClient = new WorkItemTrackingHttpClient(uri, credentials))
            {
                // execute the query to get the list of work items in the results
                var result = await httpClient.QueryByWiqlAsync(wiql).ConfigureAwait(false);
                var ids = result.WorkItems.Select(item => item.Id).ToArray();

                // some error handling
                if (ids.Length == 0)
                {
                    return Array.Empty<WorkItem>();
                }

                string[] fields = GetFieldList();

                // Get WorkItem details (fields) for the ids found in query

                if (ids.Length < 200)
                {
                    return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
                }
                else
                {
                    List<WorkItem> allResults = new List<WorkItem>();
                    List<WorkItem> partialResults;

                    for (int i = 0; i < ids.Length; i++)
                    {
                        partialResults = await httpClient.GetWorkItemsAsync(ids.Skip(i).Take(200), fields, result.AsOf).ConfigureAwait(false);
                        allResults.AddRange(partialResults);
                        i += 200;
                    }

                    return allResults;
                }
            }
        }

        public static async Task<IList<WorkItem>> QueryWorkItemLinks(string organization, int id, int relatedLinkCount)
        {
            var uri = new Uri($"https://dev.azure.com/{organization}");
            var credentials = GetVssCredentials();

            //var project = "VNC Agile";


            var wiql = new Wiql()
            {
                // NOTE: Even if other columns are specified, only the ID & URL are available in the WorkItemReference
                Query = "Select [Id] "
                    + "From WorkItemLinks "
                    + "Where Source.[System.Id] = " + id
            };


            //if (relatedLinkCount > 250)
            //{
            //    MessageBox.Show($"Great than 250 Links ({relatedLinkCount}), removing Test Cases");
            //    wiql.Query += " AND Target.[System.WorkItemType] <> 'Test Case'";
            //}

            // NOTE(crhodes)
            // This works but still get BadRequest Exception when trying to get Test Cases back
            // from release 918783.  Maybe do multiple queries

            // " AND Target.[System.WorkItemType] = 'Test Case'"

            using (var httpClient = new WorkItemTrackingHttpClient(uri, credentials))
            {
                // execute the query to get the list of work items in the results
                var result = await httpClient.QueryByWiqlAsync(wiql).ConfigureAwait(false);
                var ids = result.WorkItemRelations.Select(item => item.Target.Id).Distinct().ToArray();

                // some error handling
                if (ids.Length == 0)
                {
                    return Array.Empty<WorkItem>();
                }

                //if (ids.Length > 250)
                //{
                //    MessageBox.Show($"Great than 250 Links ({ids.Length}), removing Test Cases");
                //}

                string[] fields = GetFieldList();

                // Get WorkItem details (fields) for the ids found in query
                //return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
                // HACK(crhodes)
                // Try taking fewer to get beyond exceptions and bad requests

                if (ids.Length < 200)
                {
                    return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
                }
                else
                {
                    List<WorkItem> allResults = new List<WorkItem>();
                    List<WorkItem> partialResults;

                    for (int i = 0; i < ids.Length; i++)
                    {
                        partialResults = await httpClient.GetWorkItemsAsync(ids.Skip(i).Take(200), fields, result.AsOf).ConfigureAwait(false);
                        allResults.AddRange(partialResults);
                        i += 200;
                    }

                    return allResults;
                }
            }
        }

        public static string GetOrganizationNameFromUrl(string url)
        {
            // HACK(crhodes)
            // Use regular expressions
            // Just get Organization
            // Url
            // https://dev.azure.com/VNC-Development/VNC%20Agile/_workitems/edit/44/
            // Organization
            // VNC-Development

            Regex regEx = new Regex(@"(https://dev.azure.com/)([^/]*)(/.*$)", RegexOptions.IgnoreCase);
            Match match = regEx.Match(url);

            return match.Success ? match.Groups[2].Value : "???";
        }

        private static string[] GetFieldList(string workItemType = "")
        {
            //build a list of the fields we want to see
            //switch (workItemType)
            //{
            //    case "Bug":
            //        return new[]
            //        {
            //            "System.Id", "System.TeamProject"
            //            , "System.WorkItemType"
            //            , "System.Title", "System.State"
            //            , "System.CreatedDate", "System.CreatedBy"
            //            , "System.ChangedDate", "System.ChangedBy"
            //            , "System.RelatedLinkCount", "System.ExternalLinkCount"
            //            , "System.RemoteLinkCount", "System.HyperLinkCount"
            //            , "System.AreaPath", "System.IterationPath"
            //            , "Cardinal.Defect.FieldIssue"
            //        };

            //    case "User Story":
            //        return new[]
            //        {
            //            "System.Id", "System.TeamProject"
            //            , "System.WorkItemType"
            //            , "System.Title", "System.State"
            //            , "System.CreatedDate", "System.CreatedBy"
            //            , "System.ChangedDate", "System.ChangedBy"
            //            , "System.RelatedLinkCount", "System.ExternalLinkCount"
            //            , "System.RemoteLinkCount", "System.HyperLinkCount"
            //            , "System.AreaPath", "System.IterationPath"
            //        };
            //        break;

            //    default:
            //        return new[]
            //        {
            //            "System.Id", "System.TeamProject"
            //            , "System.WorkItemType"
            //            , "System.Title", "System.State"
            //            , "System.CreatedDate", "System.CreatedBy"
            //            , "System.ChangedDate", "System.ChangedBy"
            //            , "System.RelatedLinkCount", "System.ExternalLinkCount"
            //            , "System.RemoteLinkCount", "System.HyperLinkCount"
            //            , "System.AreaPath", "System.IterationPath"
            //            , "Cardinal.Defect.FieldIssue"
            //            , "Microsoft.VSTS.CMMI.TaskType"
            //        };

            //}

            // NOTE(crhodes)
            // It is ok to ask for fields that don't exist for a WorkItem.
            // They are populated if there is data in the field, otherwise ignored.
            // No need to figure out which fields to ask for based on WorkItemType

            return new[]
            {
                // These are common across all WIT
                "System.Id", "System.TeamProject"
                , "System.WorkItemType"
                , "System.Title", "System.State"
                , "System.CreatedDate", "System.CreatedBy"
                , "System.ChangedDate", "System.ChangedBy"
                , "System.RelatedLinkCount", "System.ExternalLinkCount"
                , "System.RemoteLinkCount", "System.HyperLinkCount"
                , "System.AreaPath", "System.IterationPath"
                // This is for Bug
                , "Cardinal.Defect.FieldIssue"
                // This is for User Story
                , "Microsoft.VSTS.CMMI.TaskType"
            };
        }
    }
}
