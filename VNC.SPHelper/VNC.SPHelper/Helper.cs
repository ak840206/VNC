using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Xml.Linq;

using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Publishing;
using Microsoft.Win32;

namespace VNC.SP
{
    public class Helper
    {
        #region Main Methods

        private static void AddListItems(XElement rawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in rawXML.Element(elementName).Elements("List")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format. Ex: {ex}");
                return;
            }

            Web web = ctx.Web;

            ListCollection lists = web.Lists;

            ctx.Load(web.Lists);
            ctx.ExecuteQuery();

            foreach (var xList in elements)
            {
                WriteDiagnosticOutput("Adding items to List>" + xList.ToString());

                List list = web.Lists.GetByTitle(xList.Attribute("Title").Value);

                // Populate the list with rows.

                string attributeName;
                //string attributeType;
                string attributeValue;

                foreach (var xListItem in xList.Elements("ListItem"))
                {
                    WriteDiagnosticOutput("   Add ListItem>" + xListItem.ToString());

                    try
                    {
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem newListItem = list.AddItem(itemInfo);

                        foreach (var dataField in xListItem.Elements("Field"))
                        {
                            attributeName = dataField.Attribute("Name").Value;
                            //attributeType = dataField.Attribute("Type").Value;
                            attributeValue = dataField.Attribute("Value").Value;

                            newListItem[attributeName] = attributeValue;
                        }

                        newListItem.Update();

                        ctx.ExecuteQuery();
                    }
                    catch (Exception ex)
                    {
                        WriteDiagnosticOutput(ex.ToString());
                    }
                }
            }
        }

        public static void CreateSiteColumn(ClientContext ctx, Web web, string schemaXml, AddFieldOptions addFieldOptions, bool addToDefaultView=false)
        {
            try
            {
                web.Fields.AddFieldAsXml(schemaXml, addToDefaultView, addFieldOptions);
                ctx.ExecuteQuery();
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput(ex.ToString());
            }
        }

        public static void UpdateSiteColumn(ClientContext ctx, Web web, XElement xField)
        {
            //try
            //{
            //    Field field = web.Fields.Where(x => x.StaticName == xField.Attribute("Name").Value).First();

            //    field.
            //    web.Fields.AddFieldAsXml(schemaXml, addToDefaultView, addFieldOptions);
            //    ctx.ExecuteQuery();
            //}
            //catch (Exception ex)
            //{
            //    WriteDiagnosticOutput(ex.ToString());
            //}
        }

        private static void DeleteListItems(XElement rawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in rawXML.Element(elementName).Elements("List")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format. Ex: {ex}");
                return;
            }

            Web web = ctx.Web;

            ListCollection lists = web.Lists;

            ctx.Load(web.Lists);
            ctx.ExecuteQuery();

            foreach (var xList in elements)
            {
                WriteDiagnosticOutput("Deleting items from List>" + xList.ToString());

                List list = web.Lists.GetByTitle(xList.Attribute("Title").Value);

                if (xList.Attribute("DeleteAllItems").Value == "true")
                {
                    WriteDiagnosticOutput("   Deleting All Items>" + xList.Attribute("DeleteAllItems").Value);

                }
                //string attributeName;
                //string attributeType;
                //string attributeValue;

                foreach (var xListItem in xList.Elements("ListItem"))
                {
                    WriteDiagnosticOutput("   Delete ListItem>" + xListItem.ToString());

                    //try
                    //{
                        //ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        //ListItem newListItem = list.AddItem(itemInfo);

                        //foreach (var dataField in xListItem.Elements("Field"))
                        //{
                        //    attributeName = dataField.Attribute("Name").Value;
                        //    //attributeType = dataField.Attribute("Type").Value;
                        //    attributeValue = dataField.Attribute("Value").Value;

                        //    newListItem[attributeName] = attributeValue;
                        //}

                        //newListItem.Update();

                    //    //ctx.ExecuteQuery();
                    //}
                    //catch (Exception ex)
                    //{
                    //    WriteDiagnosticOutput(ex.ToString());
                    //}
                }
            }
        }

        public static ClientContext GetClientContext(string uri)
        {
            return new ClientContext(uri);
        }

        public static ClientContext GetClientContext(string Uri, string domain, string user, string password)
        {
            var ctx = new ClientContext(Uri);

            ctx.AuthenticationMode = ClientAuthenticationMode.Default;
            ctx.Credentials = new NetworkCredential(user, password, domain);

            return ctx;
        }

        public static IEnumerable<ContentType> GetContentTypes(string uri)
        {
            var ctx = GetClientContext(uri);

            return GetContentTypes(ctx, ctx.Web);
        }

        public static IEnumerable<ContentType> GetContentTypes(ClientContext ctx, Web web)
        {
            IEnumerable<ContentType> contentTypes;

            ctx.Load(web.ContentTypes);
            ctx.ExecuteQuery();

            contentTypes = web.ContentTypes;

            return contentTypes;
        }

        public static IEnumerable<List> GetDocumentLibraries(string uri)
        {
            var ctx = GetClientContext(uri);

            return GetDocumentLibraries(ctx, ctx.Web);
        }

        public static IEnumerable<List> GetDocumentLibraries(ClientContext ctx, Web web)
        {
            IEnumerable<List> doclibs = ctx.LoadQuery(web.Lists.Where
                (list => list.BaseType == BaseType.DocumentLibrary));

            ctx.ExecuteQuery();

            return doclibs;
        }

        public static IEnumerable<List> GetLists(string uri)
        {
            var ctx = GetClientContext(uri);

            return GetLists(ctx, ctx.Web);
        }


        public static IEnumerable<List> GetLists(ClientContext ctx, Web web)
        {
            IEnumerable<List> lists = ctx.LoadQuery(web.Lists.Where
                (list => list.BaseType == BaseType.GenericList));

            ctx.ExecuteQuery();

            return lists;
        }

        public static IEnumerable<Field> GetSiteColumns(string uri)
        {
            var ctx = GetClientContext(uri);

            return GetSiteColumns(ctx, ctx.Web);
        }

        public static IEnumerable<Field> GetSiteColumns(ClientContext ctx, Web web)
        {
            FieldCollection fields;

            ctx.Load(web.Fields);

            ctx.ExecuteQuery();

            fields = web.Fields;
            //ctx.ExecuteQuery();

            return fields;
        }

        public static void ProvisionSite(string siteCollectionUri)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (true == openFileDialog1.ShowDialog())
            {
                string fileName = openFileDialog1.FileName;

                ProvisionSiteFromFile(fileName, "SharePointProvisioning", siteCollectionUri);
            }
        }

        private static void AddFieldsToContentType(ClientContext ctx, Web web, XElement xContentType, string contentTypeName)
        {
            ctx.Load(web);
            ctx.ExecuteQuery();

            ContentType cType = web.ContentTypes.GetById(GetContentTypeId(ctx, contentTypeName));

            var siteColumns = xContentType.Elements("Field");

            foreach (XElement xField in siteColumns)
            {
                WriteDiagnosticOutput("Add Field to ContentType> " + xField.ToString());

                Field addField = web.Fields.GetByInternalNameOrTitle(xField.Attribute("Name").Value);

                cType.FieldLinks.Add(new FieldLinkCreationInformation { Field = addField });

                //cType.Update(true);
            }

            cType.Update(true);
            ctx.ExecuteQuery();
        }


        private static void CreateContentType(ClientContext ctx, Web web, XElement xContentType)
        {
            try
            {
                // TODO(crhodes): This needs work as "supposedly" you are only supposed to set Id or parentContentTypeName

                ContentTypeCreationInformation newContentType = new ContentTypeCreationInformation();

                string contentTypeName = xContentType.Attribute("Name").Value;

                newContentType.Name = contentTypeName;
                newContentType.Group = xContentType.Attribute("Group").Value;

                if (xContentType.Attribute("Id") != null)
                {
                    newContentType.Id = xContentType.Attribute("Id").Value;
                }

                if (xContentType.Attribute("ParentContentType") != null)
                {
                    string parentContentTypeName = xContentType.Attribute("ParentContentType").Value;

                    var contentTypes = ctx.LoadQuery(web.ContentTypes.Where(ct => ct.Name == parentContentTypeName));
                    ctx.ExecuteQuery();

                    newContentType.ParentContentType = contentTypes.FirstOrDefault();
                }

                web.ContentTypes.Add(newContentType);
                ctx.ExecuteQuery();

                // Now add any fields that were specified

                AddFieldsToContentType(ctx, web, xContentType, contentTypeName);
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput(ex.ToString());
            }
        }

        private static void AddContentTypes(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("ContentType")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Add ContentType>" + itemName);

                CreateContentType(ctx, ctx.Web, itemName);
            }
        }

        private static void AddLibraries(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Library")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            Web web = ctx.Web;

            foreach (var xLibrary in elements)
            {
                ListCreationInformation listCreationInfo = new ListCreationInformation();

                listCreationInfo.Title = xLibrary.Attribute("Title").Value;
                listCreationInfo.Description = xLibrary.Attribute("Description").Value;
                listCreationInfo.TemplateType = (int)ListTemplateType.DocumentLibrary;

                WriteDiagnosticOutput("Add Library>" + xLibrary.ToString());

                List newLibrary = web.Lists.Add(listCreationInfo);
                ctx.ExecuteQuery();
            }
        }

        private static FieldLookupValue[] GetMultiLookupIds(string siteColumnName, string attributeValues)
        {
            FieldLookupValue[] results = null;

            string[] lookupValues = attributeValues.Split(',');

            foreach (string value in lookupValues)
            {

                WriteDiagnosticOutput(value);
            }
            
            return results;
        }

        private static int GetLookupId(string siteColumnName, string attributeValue)
        {
            // Cheat for now and force use of numeric values

            int result = int.Parse(attributeValue);

            // TODO(crhodes): Lookup value in underlying list.  Need to figure out how to go from siteColumnName
            // to underlying list.
            
            return result;
        }

        private static void UpdateListItemFields(ClientContext ctx, XElement xListItem, ListItem newListItem)
        {
            string attributeName;
            //string attributeType;
            string attributeValue;

          
            foreach (var dataField in xListItem.Elements("Field"))
            {
                attributeName = dataField.Attribute("Name").Value;
                //attributeType = dataField.Attribute("Type").Value;
                attributeValue = dataField.Attribute("Value").Value;

                if (dataField.Attribute("Type") != null)
                {
                    switch (dataField.Attribute("Type").Value)
                    {
                        case "Lookup":
                            // TODO(crhodes): Need to handle lookup fields differently

                            FieldLookupValue flv = new FieldLookupValue();
                            //FieldLookupValue flv = newListItem[attributeName] as FieldLookupValue;

                            // TODO(crhodes): Hard code for now.  We know the field name, e.g. FAPageType
                            // need to get number for value and learn how to handle multiple values.
                            //  Hard code capability for now
                            flv.LookupId = GetLookupId(attributeName, attributeValue);
                            
                            newListItem[attributeName] = flv;

                            break;

                        case "MultiLookup":
                            throw new System.InvalidOperationException("MultiLookup not supported yet");

                        default:
                            throw new System.ArgumentOutOfRangeException("Field Type not recognized");
                    };
                }
                else
                {
                    newListItem[attributeName] = attributeValue;
                }
            }

            newListItem.Update();

            //newListItem["FA_x0020_Page_x0020_Image"] = @"<img alt="""" src=""/sites/FAITSF/SiteAssets/FAITDeliveryFramework-Master.vsdx-L0-ServiceDevelopment.png"" style=""BORDER: 0px solid; "">";

            //newListItem.Update();

            try
            {
                WriteDiagnosticOutput("   UpdateListItemFields");
                ctx.ExecuteQuery();
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput(ex.ToString());
                throw ex;
            }
        }

        private static void PopulateList(ClientContext ctx, List list, XElement xList)
        {
            foreach (var xListItem in xList.Elements("ListItem"))
            {
                WriteDiagnosticOutput("   Add ListItem>" + xListItem.ToString());

                try
                {
                    ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                    ListItem newListItem = list.AddItem(itemInfo);

                    UpdateListItemFields(ctx, xListItem, newListItem);
                }
                catch (Exception ex)
                {
                    WriteDiagnosticOutput(ex.ToString());
                    throw ex;
                }
            }
        }

        private static void CreateList(ClientContext ctx, Web web, XElement xList)
        {
            ListCreationInformation listCreationInfo = new ListCreationInformation();

            listCreationInfo.Title = xList.Attribute("Title").Value;
            listCreationInfo.Description = xList.Attribute("Description").Value;
            listCreationInfo.TemplateType = (int)ListTemplateType.GenericList;
            //listCreationInfo.TemplateType = (int)ListTemplateType.NoListTemplate;

            WriteDiagnosticOutput("Add List>" + xList.ToString());

            List newList = web.Lists.Add(listCreationInfo);
            ctx.ExecuteQuery();

            // Add fields to the newly created list.

            foreach (var xField in xList.Elements("Field"))
            {
                WriteDiagnosticOutput("   Add Field>" + xField.ToString());

                try
                {
                    int addFieldOptions = (int)AddFieldOptions.DefaultValue;

                    int.TryParse(xField.Attribute("AddFieldOptions").Value, out addFieldOptions);

                    bool addToDefaultView = (addFieldOptions & (int)AddFieldOptions.AddFieldToDefaultView) > 0;


                    Field field = newList.Fields.AddFieldAsXml(xField.ToString(), addToDefaultView, (AddFieldOptions)addFieldOptions);

                    ctx.ExecuteQuery();
                    WriteDiagnosticOutput("   Added Field>" + xField.ToString());
                }
                catch (Exception ex)
                {
                    WriteDiagnosticOutput(ex.ToString());
                }
            }

            // Populate the list with rows.

            PopulateList(ctx, newList, xList);
        }

        private static void AddLists(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("List")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            Web web = ctx.Web;

            foreach (var xList in elements)
            {
                CreateList(ctx, web, xList);
            }
        }

        private static void CreateWikiPage(ClientContext ctx, Web web, XElement xPage)
        {
            ctx.Load(web);
            ctx.Load(web.Lists);

            string pageName = xPage.Attribute("Name").Value;
            //string layoutPageName = xPage.Attribute("LayoutPageName").Value;
            string pageLibrary = xPage.Attribute("PageLibrary").Value;

            List targetLibrary = web.Lists.GetByTitle(pageLibrary);
            ctx.Load(targetLibrary.RootFolder, x => x.ServerRelativeUrl);
            ctx.ExecuteQuery();

            var targetLibraryUrl = targetLibrary.RootFolder.ServerRelativeUrl;
            var newWikiPageUrl = targetLibraryUrl + "/" + pageName;
            var currentPageFile = web.GetFileByServerRelativeUrl(newWikiPageUrl);

            ctx.Load(currentPageFile, x => x.Exists);
            ctx.ExecuteQuery();

            if (! currentPageFile.Exists)
            {
            	var newPage = targetLibrary.RootFolder.Files.AddTemplateFile(newWikiPageUrl, TemplateFileType.WikiPage);
                ctx.Load(newPage);
                ctx.ExecuteQuery();
            }
        }

        private static void CreateWebPartPage(ClientContext ctx, Web web, XElement xPage)
        {
            //ctx.Load(web);
            //ctx.Load(web.Lists);

            //string pageName = xPage.Attribute("Name").Value;
            //string webPartTemplate = xPage.Attribute("WebPartTemplate").Value;
            //string pageLibrary = xPage.Attribute("PageLibrary").Value;

            // TODO(crhodes): Need mechanism to ge webPartTemplates into something that can be loaded below
            // See GetBytes
            // May need to pass on this for now

            //List targetLibrary = web.Lists.GetByTitle(pageLibrary);

            //var file = new FileCreationInformation
            //{
            //    Url = pageName,
            //    Content = Encoding.UTF8.GetBytes(webPartTemplate),
            //    Overwrite = true
            //};

            //ctx.Load(targetLibrary.RootFolder.Files.Add(file));
            //ctx.ExecuteQuery();
        }

        private static string GetContentTypeId(ClientContext ctx, string contentTypeName)
        {
            Web web = ctx.Web;

            var cTypes = ctx.LoadQuery(web.ContentTypes.Where(ctype => ctype.Name == contentTypeName));
            ctx.ExecuteQuery();

            var foundCType = cTypes.FirstOrDefault();

            return foundCType.Id.ToString();
        }

        private static void CreatePublishingPage(ClientContext ctx, Web web, XElement xPage)
        {
            const string publishingPageTemplate = "<%@ Page Inherits=\"Microsoft.SharePoint.Publishing.TemplateRedirectionPage,Microsoft.SharePoint.Publishing,Version=14.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c\" %> <%@ Reference VirtualPath=\"~TemplatePageUrl\" %> <%@ Reference VirtualPath=\"~masterurl/custom.master\" %>";
            Web webSite = web;
            ctx.Load(webSite);

            string pageName = xPage.Attribute("Name").Value;
            string layoutPageName = xPage.Attribute("LayoutPageName").Value;
            string pageLibrary = xPage.Attribute("PageLibrary").Value;
            string contentType = xPage.Attribute("ContentType").Value;
            string contentTypeId = GetContentTypeId(ctx, contentType);

            List targetLibrary = web.Lists.GetByTitle(pageLibrary);

            // TODO(crhodes): May want to check if page exists and not overwrite

            var file = new FileCreationInformation
            {
                Url = pageName,
                Content = Encoding.UTF8.GetBytes(publishingPageTemplate),
                Overwrite = true
            };

            var publishingPage = targetLibrary.RootFolder.Files.Add(file);
            var pageItem = publishingPage.ListItemAllFields;

            if ( ! ctx.Site.IsPropertyAvailable("ServerRelativeUrl"))
            {
                ctx.Load(ctx.Site);
                ctx.ExecuteQuery();
            }

            string publishingPageLayout = string.Format("{0}/_catalogs/masterpage/{1}", ctx.Site.ServerRelativeUrl, layoutPageName);

            pageItem["PublishingPageLayout"] = publishingPageLayout;
            pageItem["ContentTypeId"] = contentTypeId;

            pageItem.Update();
            ctx.ExecuteQuery();

            // Now update any fields that were specified

            XElement listItem = null;

            if ((listItem = xPage.Element("ListItem")) != null)
            {
                UpdateListItemFields(ctx, listItem, pageItem);
            }
        }

        private static void CreatePublishingPage2013(ClientContext ctx, Web web, XElement xPage)
        {
            Web webSite = web;
            ctx.Load(webSite);

            PublishingWeb pubWeb = PublishingWeb.GetPublishingWeb(ctx, webSite);
            ctx.Load(pubWeb);

            string pageName = xPage.Attribute("Name").Value;
            string layoutPageName = xPage.Attribute("LayoutPageName").Value;
            string pageLibrary = xPage.Attribute("PageLibrary").Value;

            if (pubWeb != null)
            {
                // Get library to hold new page

                List targetLibrary = webSite.Lists.GetByTitle(pageLibrary);

                ListItemCollection existingPages = targetLibrary.GetItems(CamlQuery.CreateAllItemsQuery());

                ctx.Load(existingPages, items => items.Include(item => item.DisplayName).Where(obj => obj.DisplayName == pageName));
                ctx.ExecuteQuery();

                if (existingPages != null && existingPages.Count > 0)
                {
                	// Page already exists
                }
                else
                {
                    // Get publishing page layouts

                    List publishingLayouts = ctx.Web.Lists.GetByTitle("Master Page Gallery");

                    ListItemCollection layoutPages = publishingLayouts.GetItems(CamlQuery.CreateAllItemsQuery());
                    ctx.Load(layoutPages, items => items.Include(item => item.DisplayName).Where(obj => obj.DisplayName == layoutPageName));
                    ctx.ExecuteQuery();

                    ListItem layoutPage = layoutPages.Where(x => x.DisplayName == layoutPageName).FirstOrDefault();
                    ctx.Load(layoutPage);

                    // Create a publishing page

                    PublishingPageInformation newPublishingPageInfo = new PublishingPageInformation();
                    newPublishingPageInfo.Name = pageName;
                    newPublishingPageInfo.PageLayoutListItem = layoutPage;

                    PublishingPage newPublishingPage = pubWeb.AddPublishingPage(newPublishingPageInfo);

                    newPublishingPage.ListItem.File.CheckIn(string.Empty, CheckinType.MajorCheckIn);
                    newPublishingPage.ListItem.File.Publish(string.Empty);
                    newPublishingPage.ListItem.File.Approve(string.Empty);

                    ctx.Load(newPublishingPage);
                    ctx.Load(newPublishingPage.ListItem.File, obj => obj.ServerRelativeUrl);

                    ctx.ExecuteQuery();
                }
            }
        }

        private static void AddPages(XElement _RawXML, string elementName, ClientContext ctx)
        {
            XElement addPages = null;

            try
            {
                if ((addPages = _RawXML.Element(elementName)) == null) { return; }
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            if (addPages.Elements("WikiPage") != null)
            {

                foreach (var xPage in addPages.Elements("WikiPage"))
                {
                    WriteDiagnosticOutput("Add Page>" + xPage.ToString());

                    CreateWikiPage(ctx, ctx.Web, xPage);
                }
            }

            if (addPages.Elements("WebPartPage") != null)
            {
                foreach (var xPage in addPages.Elements("WebPartPage"))
                {
                    WriteDiagnosticOutput("Add Page>" + xPage.ToString());

                    CreateWebPartPage(ctx, ctx.Web, xPage);
                }
            }

            if (addPages.Elements("PublishingPage") != null)
            {
                var publishingPages = addPages.Elements("PublishingPage");

                foreach (var xPage in publishingPages)
                {
                    WriteDiagnosticOutput("Add PublishingPage>" + xPage.ToString());

                    try
                    {
                        CreatePublishingPage(ctx, ctx.Web, xPage);
                    }
                    catch (Exception ex)
                    {
                        WriteDiagnosticOutput(ex.ToString());
                    }
                }
            }
        }

        private static string GetListId(string listName, ClientContext ctx)
        {
            Web web = ctx.Web;

            var lists = ctx.LoadQuery(web.Lists.Where(list => list.Title == listName));
            ctx.ExecuteQuery();

            var foundList = lists.FirstOrDefault();

            // Search for list matching listName

            return foundList.Id.ToString();
        }

        private static XElement ReplaceListNameWithListId(XElement xField, string listId)
        {
            XElement newField = xField;

            newField.Add(new XAttribute("List", listId));

            newField.Attribute("ListName").Remove();

            return newField;            
        }

        private static void AddSiteColumns(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Field")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var xField in elements)
            {
                WriteDiagnosticOutput("Add SiteColumn>" + xField);

                XElement newField = xField;

                if (xField.Attribute("ListName") != null)
                {
                    string listName = xField.Attribute("ListName").Value;

                    if (listName != null)
                    {
                        string listId = GetListId(listName, ctx);
                        newField = ReplaceListNameWithListId(xField, listId);
                    }
                }

                CreateSiteColumn(ctx, ctx.Web, newField.ToString(), AddFieldOptions.DefaultValue, false);
            }
        }

        private static void AddWebs(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Web")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Add Web>" + itemName);
            }
        }

        private static void DeleteContentType(ClientContext ctx, Web web, string contentTypeName)
        {
            // Need to find the Id of the 

            ctx.Load(web.ContentTypes);
            ctx.ExecuteQuery();

            try
            {
                //ContentType contentType = web.ContentTypes.GetById(contentTypeId);
                ContentType contentType = web.ContentTypes.Where(ct => ct.Name == contentTypeName).First();
                contentType.DeleteObject();
                ctx.ExecuteQuery();
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput(ex.ToString());
            }
        }

        private static void DeleteContentTypes(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("ContentType")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Delete ContentType>" + itemName);

                DeleteContentType(ctx, ctx.Web, itemName.Attribute("Name").Value);
            }
        }

        private static void DeleteLibraries(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Library")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Delete Library>" + itemName);
            }
        }

        private static void DeleteLists(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("List")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            Web web = ctx.Web;

            ListCollection lists = web.Lists;

            ctx.Load(web.Lists);
            ctx.ExecuteQuery();

            foreach (var xList in elements)
            {
                WriteDiagnosticOutput("Delete List>" + xList.ToString());

                List list = web.Lists.GetByTitle(xList.Attribute("Title").Value);

                //try
                //{
                //    var exists = list.Title;
                //}
                //catch (PropertyOrFieldNotInitializedException)
                //{
                //    // Could not find list. Does not exist.
                //    continue;
                //}

                try
                {
                    list.DeleteObject();
                    ctx.ExecuteQuery();
                }
                catch (Exception ex)
                {
                    WriteDiagnosticOutput(ex.ToString());
                }
            }
        }

        private static void DeletePages(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Page")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Delete Page>" + itemName);
            }
        }

        private static void DeleteSiteColumn(ClientContext ctx, Web web, Guid siteColumnId)
        {
            try
            {
                Field siteColumn = web.Fields.GetById(siteColumnId);
                siteColumn.DeleteObject();
                ctx.ExecuteQuery();
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput(ex.ToString());
            }
        }

        private static void DeleteSiteColumn(ClientContext ctx, Web web, string siteColumnName)
        {
            try
            {
                Field siteColumn = web.Fields.GetByInternalNameOrTitle(siteColumnName);
                siteColumn.DeleteObject();
                ctx.ExecuteQuery();
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput(ex.ToString());
            }
        }

        private static void DeleteSiteColumns(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Field")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Delete SiteColumn>" + itemName);

                DeleteSiteColumn(ctx, ctx.Web, itemName.Attribute("Name").Value);
            }
        }

        private static void DeleteWebs(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Web")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;

            }

            foreach (var itemName in elements)
            {
                WriteDiagnosticOutput("Delete Web>" + itemName);

                
            }
        }

        private static void UpdateSiteColumns(XElement _RawXML, string elementName, ClientContext ctx)
        {
            IEnumerable<XElement> elements = null;

            try
            {
                elements =
                    from item in _RawXML.Element(elementName).Elements("Field")
                    select item;
            }
            catch (Exception ex)
            {
                WriteDiagnosticOutput($"Could not parse {elementName} elements.  Check format.  Ex: {ex}");
                return;
            }

            foreach (var xField in elements)
            {
                WriteDiagnosticOutput("Update SiteColumn>" + xField);

                //XElement newField = xField;

                //if (xField.Attribute("ListName") != null)
                //{
                //    string listName = xField.Attribute("ListName").Value;

                //    if (listName != null)
                //    {
                //        string listId = GetListId(listName, ctx);
                //        newField = ReplaceListNameWithListId(xField, listId);
                //    }
                //}

                UpdateSiteColumn(ctx, ctx.Web, xField);
            }
        }

        #region Utility Routines
        
        #endregion
        
        public static void ProvisionSiteFromFile(string fileName, string section, string siteCollectionUri)
        {
            XElement _RawXML;

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string fileXML = streamReader.ReadToEnd();

                try
                {
                    _RawXML = XDocument.Parse(fileXML).Descendants(section).Single();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            string webUri = _RawXML.Attribute("WebUri").Value;

            if (siteCollectionUri.Length > 0 && webUri != siteCollectionUri)
            {
            	var result = MessageBox.Show("WebUri and SiteCollectionUri do not match.  Use SiteCollection URI?", "Select URI for Provisioning", MessageBoxButton.YesNo);

                if (MessageBoxResult.Yes == result)
                {
                	webUri = siteCollectionUri;
                }
            }

            using (ClientContext ctx = new ClientContext(webUri))
            {
                DeleteWebs(_RawXML, "DeleteWebs", ctx);
                AddWebs(_RawXML, "AddWebs", ctx);

                DeleteSiteColumns(_RawXML, "DeleteSiteColumns", ctx);
                AddSiteColumns(_RawXML, "AddSiteColumns", ctx);
                UpdateSiteColumns(_RawXML, "UpdateSiteColumns", ctx);

                DeleteContentTypes(_RawXML, "DeleteContentTypes", ctx);
                AddContentTypes(_RawXML, "AddContentTypes", ctx);

                DeleteLists(_RawXML, "DeleteLists", ctx);
                AddLists(_RawXML, "AddLists", ctx);

                DeleteListItems(_RawXML, "DeleteListItems", ctx);
                AddListItems(_RawXML, "AddListItems", ctx);

                DeleteLibraries(_RawXML, "DeleteLibraries", ctx);
                AddLibraries(_RawXML, "AddLibraries", ctx);

                DeletePages(_RawXML, "DeletePages", ctx);
                AddPages(_RawXML, "AddPages", ctx);
            }
        }

        #endregion

        #region Private Methods
        
        private static void WriteDiagnosticOutput(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        #endregion
     
    }
}
