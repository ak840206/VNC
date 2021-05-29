using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

                string[] fields = GetFieldList();

                // Get WorkItem details (fields) for the ids found in query
                return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
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


            if (relatedLinkCount > 250)
            {
                MessageBox.Show($"Great than 250 Links ({relatedLinkCount}), removing Test Cases");
                wiql.Query += " AND Target.[System.WorkItemType] <> 'Test Case'";
            }

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
                return await httpClient.GetWorkItemsAsync(ids, fields, result.AsOf).ConfigureAwait(false);
                // HACK(crhodes)
                // Try taking fewer to get beyond exceptions and bad requests
                //return await httpClient.GetWorkItemsAsync(ids.Take(200), fields, result.AsOf).ConfigureAwait(false);
            }
        }

        private static string[] GetFieldList()
        {
            //build a list of the fields we want to see
            return new[]
            {
                "System.Id", "System.TeamProject"
                , "System.WorkItemType"
                , "System.Title", "System.State"
                , "System.CreatedDate", "System.CreatedBy"
                , "System.ChangedDate", "System.ChangedBy"
                , "System.RelatedLinkCount", "System.ExternalLinkCount"
                , "System.RemoteLinkCount", "System.HyperLinkCount"
            };

            //return new[]
            //{
            //    "System.Id"
            //};
        }
    }
}
