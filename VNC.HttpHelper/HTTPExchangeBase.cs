using System.Collections.ObjectModel;
using System.Net.Http;

using Prism.Events;
using Prism.Services.Dialogs;

using VNC.Core.Mvvm;

namespace VNC.HttpHelper
{
    public class HTTPExchangeBase : EventViewModelBase, IInstanceCountVM
    {
        public HTTPExchangeBase(
            IEventAggregator eventAggregator,
            IDialogService dialogService) : base(eventAggregator, dialogService)
        {
            InstanceCountVM++;
        }

        public ObservableCollection<RequestResponseInfo> RequestResponseExchange { get; set; }
            = new ObservableCollection<RequestResponseInfo>();

        private string _requestUri;

        public string RequestUri
        {
            get => _requestUri;
            set
            {
                if (_requestUri == value)
                    return;
                _requestUri = value;
                OnPropertyChanged();
            }
        }

        public RequestResponseInfo InitializeExchange(HttpClient client, string requestUri)
        {
            RequestUri = requestUri;

            RequestResponseExchange.Clear();
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

        #region IInstanceCount

        private static int _instanceCountVM;

        public int InstanceCountVM
        {
            get => _instanceCountVM;
            set => _instanceCountVM = value;
        }

        #endregion
    }
}
