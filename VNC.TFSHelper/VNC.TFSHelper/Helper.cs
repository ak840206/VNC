
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace VNC.TFS
{
    public static class Helper
    {

        #region Main Function Routines
        
        public static TfsConfigurationServer Get_ConfigurationServer(
            string tfsUri)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            Uri uri = new Uri(tfsUri);
            TfsConfigurationServer configurationServer;

            try
            {
                configurationServer = TfsConfigurationServerFactory.GetConfigurationServer(uri);
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch
            {
                throw;
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return configurationServer;
        }

        //public static TeamProject Get_TeamProject(TfsTeamProjectCollection teamProjectCollection, string teamProjectName)
        //{
        //    teamProjectCollection.CatalogNode.QueryChildren();


        //    TeamProject teamProject = null;

        //    return teamProject;
        //}

        public static TeamProject Get_TeamProject(
            VersionControlServer vcServer, 
            string teamProjectName)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            TeamProject teamProject = default;

            try
            {
                teamProject = vcServer.GetTeamProject(teamProjectName);
            }
            catch (VersionControlException vce)
            {
                //throw;
                //teamProject = null;
            }
            catch (TimeoutException te)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return teamProject;
        }

        public static TfsTeamProjectCollection Get_TeamProjectCollection(
            string tfsUri, 
            string teamProjectCollection)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            //TfsTeamProjectCollection proj_coll = new TfsTeamProjectCollection(new Uri("http://NvnTfsserver:8080/tfs/defaultcollection/"),
            //                      new System.Net.NetworkCredential(username, password));
            //proj_coll.EnsureAuthenticated();

            Uri uri = new Uri(string.Format("{0}/{1}", tfsUri, teamProjectCollection));

            TfsTeamProjectCollection tpc;

            try
            {
                tpc = new TfsTeamProjectCollection(uri);
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch
            {
                throw;
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return tpc;
        }

        public static TfsTeamProjectCollection Get_TeamProjectCollection(
            TfsConfigurationServer configurationServer,
            CatalogNode teamProjectCollectionNode)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            Guid collectionId = new Guid(teamProjectCollectionNode.Resource.Properties["InstanceId"]);

            TfsTeamProjectCollection teamProjectCollection;

            try
            {
                teamProjectCollection = configurationServer.GetTeamProjectCollection(collectionId);
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch
            {
                throw;
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return teamProjectCollection;
        }

        public static ReadOnlyCollection<CatalogNode> Get_TeamProjectCollectionNodes(
            string tfsUri)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            TfsConfigurationServer configurationServer = Get_ConfigurationServer(tfsUri);

            var result = configurationServer.CatalogNode.QueryChildren(new[] { CatalogResourceTypes.ProjectCollection }, false, CatalogQueryOptions.None);

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return result;
        }

        public static ReadOnlyCollection<CatalogNode> Get_TeamProjectCollectionNodes(
            TfsConfigurationServer configurationServer)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            var result = configurationServer.CatalogNode.QueryChildren(
                new[] { CatalogResourceTypes.ProjectCollection }, false, CatalogQueryOptions.None);

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return result;
        }

        public static VersionControlServer Get_VersionControlServer(
            string tfsUri, string teamProjectCollection)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            TfsTeamProjectCollection tpc = Get_TeamProjectCollection(tfsUri, teamProjectCollection);

            VersionControlServer vcServer = tpc.GetService<VersionControlServer>();

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return vcServer;
        }

        public static VersionControlServer Get_VersionControlServer(
            TfsTeamProjectCollection teamProjectColleciton)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            VersionControlServer vcServer = teamProjectColleciton.GetService<VersionControlServer>();

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return vcServer;
        }

        public static WorkItemStore Get_WorkItemStore(
            TfsTeamProjectCollection teamProjectCollection)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            WorkItemStore wiStore = teamProjectCollection.GetService<WorkItemStore>();

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return wiStore;
        }

        public static WorkItemStore Get_WorkItemStore(
            string tfsUri, string teamProjectCollection)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            TfsConfigurationServer tfsConfigServer = Get_ConfigurationServer(tfsUri);

            ReadOnlyCollection<CatalogNode> teamProjectCollectionNodes = Get_TeamProjectCollectionNodes(tfsConfigServer);

            TfsTeamProjectCollection tpc = Get_TeamProjectCollection(tfsUri, teamProjectCollection);

            WorkItemStore wiStore = tpc.GetService<WorkItemStore>();

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return wiStore;
        }

        public static WorkItem RetrieveWorkItem(int id, WorkItemStore workItemStore)
        {
            Int64 startTicks = Log.DOMAINSERVICES("Enter", Common.LOG_APPNAME);

            WorkItem workItem = null;

            string queryWI = 
                "Select [Id], [Created Date], [Changed Date], [Revised Date]"
                + " From WorkItems"
                + $" Where [System.Id] = '{id}'";

            WorkItemCollection queryResultsWI = workItemStore.Query(queryWI);

            if (queryResultsWI.Count == 1)
            {
                workItem = queryResultsWI[0];
            }

            Log.DOMAINSERVICES("Exit", Common.LOG_APPNAME, startTicks);

            return workItem;
        }

        #endregion
    }
}
