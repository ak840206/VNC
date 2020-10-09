using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.SharePoint.Client;

using VNCSP = VNC.SP;

namespace Test_SPHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors and Load
        
        public MainWindow()
        {
            InitializeComponent();
            LoadControlContents();
        }

        #endregion

        #region Event Handlers

        private void btnDisplayContentTypes_Click(object sender, RoutedEventArgs e)
        {
            var uri = spSiteCollection_Picker.Uri;

            IEnumerable<ContentType> contentTypes = VNCSP.Helper.GetContentTypes(uri);

            dataGrid_ContentTypes.ItemsSource = contentTypes;
        }
        
        private void btnDisplayLibraries_Click(object sender, RoutedEventArgs e)
        {
            var uri = spSiteCollection_Picker.Uri;

            IEnumerable<Microsoft.SharePoint.Client.List> lists = VNCSP.Helper.GetDocumentLibraries(uri);

            dataGrid_Libraries.ItemsSource = lists;
        }

        private void btnDisplayLists_Click(object sender, RoutedEventArgs e)
        {
            var uri = spSiteCollection_Picker.Uri;

            IEnumerable<Microsoft.SharePoint.Client.List> lists = VNCSP.Helper.GetLists(uri);

            dataGrid_Lists.ItemsSource = lists;
        }

        private void btnDisplaySiteColumns_Click(object sender, RoutedEventArgs e)
        {
            var uri = spSiteCollection_Picker.Uri;

            IEnumerable<Field> siteColumns = VNCSP.Helper.GetSiteColumns(uri);

            dataGrid_SiteColumns.ItemsSource = siteColumns;
        }

        private void btnProvisionSite_Click(object sender, RoutedEventArgs e)
        {
            VNCSP.Helper.ProvisionSite(teSiteCollectionUri.Text);
        }

        private void spSiteCollection_Picker_ControlChanged()
        {
            teSiteCollectionUri.Text = spSiteCollection_Picker.Uri;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            spSiteCollection_Picker.ControlChanged += spSiteCollection_Picker_ControlChanged;
        }

        #endregion
        
        #region Utility Routines
        
        private void LoadControlContents()
        {
            try
            {
                spSiteCollection_Picker.PopulateControlFromFile(Common.cCONFIG_FILE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

    
    }
}
