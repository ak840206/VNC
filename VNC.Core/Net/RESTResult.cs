using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace VNC.Core.Net
{
    public class RESTResult<T> : INotifyPropertyChanged where T : class
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private int _count;

        public int Count
        {
            get => _count;
            set
            {
                if (_count == value)
                    return;
                _count = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        private T _selectedItem;

        public T SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem == value)
                    return;
                _selectedItem = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
            }
        }

        private ObservableCollection<T> _items = new ObservableCollection<T>();

        public ObservableCollection<T> ResultItems
        {
            get => _items;
            set
            {
                if (_items == value)
                    return;
                _items = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ResultItems)));
            }
        }

        public ObservableCollection<RequestResponseInfo> RequestResponseExchange { get; set; }
            = new ObservableCollection<RequestResponseInfo>();

        // TODO(crhodes)
        // Clean this up with different mechanisms to provide AuthenticationHeaderValue

        public void InitializeHttpClient(HttpClient client, string personalAccessToken)
        {
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            //var username = @"Christopher.Rhodes@bd.com";
            //var password = @"xxxxxxxx";

            //string base64PAT = Convert.ToBase64String(
            //        ASCIIEncoding.ASCII.GetBytes($"{username}:{password}"));

            string base64PAT = Convert.ToBase64String(
                    ASCIIEncoding.ASCII.GetBytes(
                        string.Format("{0}:{1}", "", personalAccessToken)));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64PAT);
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("NTLM");
        }

        public RequestResponseInfo InitializeExchange(HttpClient client, string requestUri)
        {
            RequestResponseInfo exchange = new RequestResponseInfo();

            exchange.Uri = requestUri;
            exchange.RequestHeaders.AddRange(client.DefaultRequestHeaders);

            return exchange;
        }

        public void RecordExchangeResponse(HttpResponseMessage response, RequestResponseInfo exchange)
        {
            var statusCode = response.StatusCode;
            var statusCode2 = (int)response.StatusCode;

            exchange.Response = response;
            exchange.ResponseStatusCode = statusCode2;

            exchange.ResponseContentHeaders.AddRange(response.Content.Headers);
            exchange.ResponseHeaders.AddRange(response.Headers);

            RequestResponseExchange.Add(exchange);
        }

        public RequestResponseInfo ContinueExchange(HttpClient client, string requestUri)
        {
            RequestResponseInfo exchange = new RequestResponseInfo();

            exchange.Uri = requestUri;
            exchange.RequestHeaders.AddRange(client.DefaultRequestHeaders);

            return exchange;
        }
    }
}
