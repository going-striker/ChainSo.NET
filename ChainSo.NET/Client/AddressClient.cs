using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Error;

namespace ChainSo.NET
{
    public class AddressClient : AbstractClient
    {
        private const string GetBalanceUrl = "https://chain.so/api/v2/get_address_balance/{0}/{1}/{2}";
        private const string GetReceivedValueUrl = "https://chain.so/api/v2/get_address_received/{0}/{1}";
        private const string GetSpentValueUrl = "https://chain.so/api/v2/get_address_spent/{0}/{1}";
        private const string GetUnspentTxUrl = "https://chain.so/api/v2/get_tx_unspent/{0}/{1}";
        private const string GetReceivedTxUrl = "https://chain.so/api/v2/get_tx_received/{0}/{1}/{2}";
        private const string GetSpentTxUrl = "https://chain.so/api/v2/get_tx_spent/{0}/{1}/{2}";
        private const string IsAddressValidUrl = "https://chain.so/api/v2/is_address_valid/{0}/{1}";
        private const string GetDisplayDataUrl = "https://chain.so/api/v2/address/{0}/{1}";

        #region Constructors

        public AddressClient() : base() { }

        public AddressClient(bool useProxy) : base(useProxy) { }

        #endregion Constructors

        #region Get Balance

        public async Task<Balance> GetBalanceAsync(Network network, string address, int minimumConfirmations = 0)
        {
            Balance response = await GetQuery<Balance, AddressError>(string.Format(GetBalanceUrl, network._network, address, minimumConfirmations));
            return response;
        }

        public Balance GetBalance(Network network, string address, int minimumConfirmations = 0)
        {
            return GetBalanceAsync(network, address, minimumConfirmations).Result;
        }

        #endregion Get Balance

        #region Get Received Value
        public async Task<ReceivedValue> GetReceivedValueAsync(Network network, string address)
        {
            ReceivedValue response = await GetQuery<ReceivedValue, AddressReceivedValueError>(string.Format(GetReceivedValueUrl, network._network, address));
            return response;
        }
        public ReceivedValue GetReceivedValue(Network network, string address)
        {
            return GetReceivedValueAsync(network, address).Result;
        }

        #endregion Get Received Value

        #region Get Spent Value

        public async Task<SpentValue> GetSpentValueAsync(Network network, string address)
        {
            SpentValue response = await GetQuery<SpentValue, AddressSentValueError>(string.Format(GetSpentValueUrl, network._network, address));
            return response;
        }

        public SpentValue GetSpentValue(Network network, string address)
        {
            return GetSpentValueAsync(network, address).Result;
        }

        #endregion Get Spent Value
        
        #region Get Unspent Tx

        public async Task<OutputTx> GetUnspentTxAsync(Network network, string address, string afterTxid = null)
        {
            OutputTx response = await GetQuery<OutputTx, AddressAfterTxError>(string.Format(GetUnspentTxUrl, network._network, address, afterTxid));
            return response;
        }

        public OutputTx GetUnspentTx(Network network, string address, string afterTxid = null)
        {
            return GetUnspentTxAsync(network, address, afterTxid).Result;
        }

        #endregion Get Unspent Tx

        #region Get Received Tx

        public async Task<OutputTx> GetReceivedTxAsync(Network network, string address, string afterTxid = null)
        {
            OutputTx response = await GetQuery<OutputTx, AddressAfterTxError>(string.Format(GetReceivedTxUrl, network._network, address, afterTxid));
            return response;
        }

        public OutputTx GetReceivedTx(Network network, string address, string afterTxid = null)
        {
            return GetReceivedTxAsync(network, address, afterTxid).Result;
        }

        #endregion Get Received Tx

        #region Get Spent Tx

        public async Task<InputTx> GetSpentTxAsync(Network network, string address, string afterTxid = null)
        {
            InputTx response = await GetQuery<InputTx, AddressAfterTxError>(string.Format(GetSpentTxUrl, network._network, address, afterTxid));
            return response;
        }

        public InputTx GetSpentTx(Network network, string address, string afterTxid = null)
        {
            return GetSpentTxAsync(network, address, afterTxid).Result;
        }

        #endregion Get Balance

        #region Is Address Valid

        public async Task<AddressValid> IsAddressValidAsync(Network network, string address)
        {
            AddressValid response = await GetQuery<AddressValid, AddressValid>(string.Format(IsAddressValidUrl, network._network, address));
            return response;
        }

        public AddressValid IsAddressValid(Network network, string address)
        {
            return IsAddressValidAsync(network, address).Result;
        }

        #endregion Is Address Valid

        #region Get Display Data

        public async Task<AddressDisplayData> GetDisplayDataAsync(Network network, string address)
        {
            AddressDisplayData response = await GetQuery<AddressDisplayData, CommonError>(string.Format(GetDisplayDataUrl, network._network, address));
            return response;
        }

        public AddressDisplayData GetDisplayData(Network network, string address)
        {
            return GetDisplayDataAsync(network, address).Result;
        }

        #endregion Get Display Data

    }
}
