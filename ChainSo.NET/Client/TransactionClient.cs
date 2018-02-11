using System.Threading.Tasks;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Data;
using ChainSo.NET.Model.Data.Transaction;
using ChainSo.NET.Model.Error;

namespace ChainSo.NET.Client
{
    public class TransactionClient : AbstractClient
    {
        private const string GetConfidenceUrl = "https://chain.so/api/v2/get_confidence/{0}/{1}";
        private const string GetTxInputsUrl = "https://chain.so/api/v2/get_tx_inputs/{0}/{1}/{2}";
        private const string GetTxOutputsUrl = "https://chain.so/api/v2/get_tx_outputs/{0}/{1}/{2}";
        private const string GetTxUrl = "https://chain.so/api/v2/get_tx/{0}/{1}";
        private const string IsTxConfirmedUrl = "https://chain.so/api/v2/is_tx_confirmed/{0}/{1}";
        private const string IsTxOutputSpentUrl = "https://chain.so/api/v2/is_tx_spent/{0}/{1}/{2}";
        private const string GetDisplayDataUrl = "https://chain.so/api/v2/tx/{0}/{1}";

        #region Constructors

        public TransactionClient() : base() { }

        public TransactionClient(bool useProxy) : base(useProxy) { }

        #endregion Constructors

        #region Get Confidence

        public async Task<Confidence> GetConfidenceAsync(Network network, string transactionId)
        {
            Confidence response = await GetQuery<Confidence, TxidError>(string.Format(GetConfidenceUrl, network._network, transactionId));
            return response;
        }

        public Confidence GetConfidence(Network network, string transactionId)
        {
            return GetConfidenceAsync(network, transactionId).Result;
        }

        #endregion Get Confidence

        #region Get Tx Inputs

        public async Task<TxInputs> GetTxInputsAsync(Network network, string transactionId, int? inputNum = null)
        {
            TxInputs response = await GetQuery<TxInputs, TxidInputError>(string.Format(GetTxInputsUrl, network._network, transactionId, inputNum));
            return response;
        }

        public TxInputs GetTxInputs(Network network, string transactionId, int? inputNum = null)
        {
            return GetTxInputsAsync(network, transactionId, inputNum).Result;
        }

        #endregion Get Tx Inputs

        #region Get Tx Outputs

        public async Task<TxOutputs> GetTxOutputsAsync(Network network, string transactionId, int? outputNum = null)
        {
            TxOutputs response = await GetQuery<TxOutputs, TxidOutputError>(string.Format(GetTxOutputsUrl, network._network, transactionId, outputNum));
            return response;
        }

        public TxOutputs GetTxOutputs(Network network, string transactionId, int? outputNum = null)
        {
            return GetTxOutputsAsync(network, transactionId, outputNum).Result;
        }

        #endregion Get Tx Outputs

        #region Get Tx

        public async Task<Tx> GetTxAsync(Network network, string transactionId)
        {
            Tx response = await GetQuery<Tx, TxidError>(string.Format(GetTxUrl, network._network, transactionId));
            return response;
        }

        public Tx GetTx(Network network, string transactionId)
        {
            return GetTxAsync(network, transactionId).Result;
        }

        #endregion Get Tx

        #region Is Tx Confirmed

        public async Task<TxConfirmed> IsTxConfirmedAsync(Network network, string transactionId)
        {
            TxConfirmed response = await GetQuery<TxConfirmed, TxidError>(string.Format(IsTxConfirmedUrl, network._network, transactionId));
            return response;
        }

        public TxConfirmed IsTxConfirmed(Network network, string transactionId)
        {
            return IsTxConfirmedAsync(network, transactionId).Result;
        }

        #endregion Is Tx Confirmed

        #region Is Tx Output Spent

        public async Task<TxOutputSpent> IsTxOutputSpentAsync(Network network, string transactionId, int outputNum)
        {
            TxOutputSpent response = await GetQuery<TxOutputSpent, TxidOutputError>(string.Format(IsTxOutputSpentUrl, network._network, transactionId, outputNum));
            return response;
        }

        public TxOutputSpent IsTxOutputSpent(Network network, string transactionId, int outputNum)
        {
            return IsTxOutputSpentAsync(network, transactionId, outputNum).Result;
        }

        #endregion Is Tx Output Spent

        #region Get Display Data

        public async Task<TransactionDisplayData> GetDisplayDataAsync(Network network, string transactionId)
        {
            TransactionDisplayData response = await GetQuery<TransactionDisplayData, CommonError>(string.Format(GetDisplayDataUrl, network._network, transactionId));
            return response;
        }

        public TransactionDisplayData GetDisplayData(Network network, string transactionId)
        {
            return GetDisplayDataAsync(network, transactionId).Result;
        }

        #endregion Get Display Data
    }
}
