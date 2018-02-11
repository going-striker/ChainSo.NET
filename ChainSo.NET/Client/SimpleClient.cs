using System.Collections.Generic;
using System.Threading.Tasks;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Data;
using ChainSo.NET.Model.Error;

namespace ChainSo.NET
{
    public class SimpleClient : AbstractClient
    {
        private const string GetNetworkInfoUrl = "https://chain.so/api/v2/get_info/{0}";
        private const string GetShortAddressUrl = "https://chain.so/api/v2/short/{0}/{1}";
        private const string GetPriceUrl = "https://chain.so/api/v2/get_price/{0}/{1}";
        private const string SendTransactionUrl = "https://chain.so/api/v2/send_tx/{0}";

        #region Constructors

        public SimpleClient() : base() { }

        public SimpleClient(bool useProxy) : base(useProxy) { }

        #endregion Constructors

        #region Network Info

        public async Task<NetworkInfo> GetNetworkInfoAsync(Network network)
        {
            NetworkInfo response = await GetQuery<NetworkInfo, NetworkInfo>(string.Format(GetNetworkInfoUrl, network._network));
            return response;
        }

        public NetworkInfo GetNetworkInfo(Network network)
        {
            return GetNetworkInfoAsync(network).Result;
        }

        #endregion Network Info

        #region Short Address

        public async Task<ShortAddress> GetShortAddressAsync(Network network, string address)
        {
            ShortAddress response = await GetQuery<ShortAddress, CommonError>(string.Format(GetShortAddressUrl, network._network, address));
            return response;
        }

        public ShortAddress GetShortAddress(Network network, string address)
        {
            return GetShortAddressAsync(network, address).Result;
        }

        #endregion Short Address

        #region Prices

        public async Task<Price> GetPricesAsync(Network network, string currency)
        {
            Price response = await GetQuery<Price, CommonError>(string.Format(GetPriceUrl, network._network, currency));
            return response;
        }

        public Price GetPrices(Network network, string currency)
        {
            return GetPricesAsync(network, currency).Result;
        }

        #endregion Prices

        #region Send Tx

        public async Task<SendTransaction> SendTxAsync(Network network, string txHex)
        {
            List<KeyValuePair<string, string>> postParam = new List<KeyValuePair<string, string>>(new [] { new KeyValuePair<string, string>("tx_hex", txHex) });
            SendTransaction response =
                await PostQuery<SendTransaction, SendTransactionError>(string.Format(SendTransactionUrl, network._network), postParam);
            return response;
        }

        public SendTransaction SendTx(Network network, string txHex)
        {
            return SendTxAsync(network, txHex).Result;
        }

        #endregion Send Tx
    }
}
