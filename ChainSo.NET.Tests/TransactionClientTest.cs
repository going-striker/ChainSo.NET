using System;
using System.Linq;
using ChainSo.NET.Client;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Data;
using ChainSo.NET.Model.Data.Transaction;
using ChainSo.NET.Model.Error;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainSo.NET.Tests
{
    [TestClass]
    public class TransactionClientTest
    {
        #region Valid

        [TestMethod]
        public void simple_synchronous_call_getconfidence_returns_result()
        {
            TransactionClient client = new TransactionClient();
            Confidence result = client.GetConfidence(Network.Bitcoin, "871265cc6efa69a749282321b19a22d3ed6cccff1995d1ce34323a6006b943eb");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "871265cc6efa69a749282321b19a22d3ed6cccff1995d1ce34323a6006b943eb");
        }

        [TestMethod]
        public void simple_synchronous_call_gettxinputs_returns_result()
        {
            TransactionClient client = new TransactionClient();
            TxInputs result = client.GetTxInputs(Network.Doge, "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
        }

        [TestMethod]
        public void simple_synchronous_call_gettxoutputs_returns_result()
        {
            TransactionClient client = new TransactionClient();
            TxOutputs result = client.GetTxOutputs(Network.Doge, "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
        }

        [TestMethod]
        public void simple_synchronous_call_gettx_returns_result()
        {
            TransactionClient client = new TransactionClient();
            Tx result = client.GetTx(Network.Doge, "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsTrue(result.Data.Time == 1398122840);
        }

        [TestMethod]
        public void simple_synchronous_call_istxconfirmed_returns_result()
        {
            TransactionClient client = new TransactionClient();
            TxConfirmed result = client.IsTxConfirmed(Network.Doge, "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsTrue(result.Data.IsConfirmed);
        }

        [TestMethod]
        public void simple_synchronous_call_istxspent_returns_result()
        {
            int outputNum = 0;
            TransactionClient client = new TransactionClient();
            TxOutputSpent result = client.IsTxOutputSpent(Network.Doge, "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b", outputNum);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsTrue(result.Data.OutputNo == outputNum);
            Assert.IsTrue(result.Data.IsSpent);
        }

        [TestMethod]
        public void simple_synchronous_call_getdisplaydata_returns_result()
        {
            TransactionClient client = new TransactionClient();
            TransactionDisplayData result = client.GetDisplayData(Network.Doge, "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Txid == "6f47f0b2e1ec762698a9b62fa23b98881b03d052c9d8cb1d16bb0b04eb3b7c5b");
            Assert.IsTrue(result.Data.BlockNo == 191172);
            Assert.IsTrue(result.Data.Time == 1398122840);
            Assert.IsTrue(result.Data.Inputs.Count > 0);
            Assert.IsTrue(result.Data.Outputs.Count > 0);
        }

        #endregion Valid

        #region Errors

        [TestMethod]
        public void should_simple_synchronous_call_getconfidence_with_bad_address_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            ExceptionWithMessage<TxidError> typedException = null;
            try
            {
                client.GetConfidence(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<TxidError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Txid == Consts.ValidTxHashRequired);
        }

        [TestMethod]
        public void should_simple_synchronous_call_gettxinputs_with_bad_address_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            ExceptionWithMessage<TxidInputError> typedException = null;
            try
            {
                client.GetTxInputs(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<TxidInputError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Txid == Consts.ValidTxHashRequired);
            Assert.IsTrue(typedException.ErrorMessage.Data.InputNo == "Valid input number (optional)");
        }

        [TestMethod]
        public void should_simple_synchronous_call_gettxoutputs_with_bad_address_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            ExceptionWithMessage<TxidOutputError> typedException = null;
            try
            {
                client.GetTxOutputs(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<TxidOutputError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Txid == Consts.ValidTxHashRequired);
            Assert.IsTrue(typedException.ErrorMessage.Data.OutputNo == "Valid output number (optional)");
        }

        [TestMethod]
        public void should_simple_synchronous_call_gettx_with_bad_address_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            ExceptionWithMessage<TxidError> typedException = null;
            try
            {
                client.GetTx(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<TxidError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Txid == Consts.ValidTxHashRequired);
        }

        [TestMethod]
        public void should_simple_synchronous_call_istxconfirmed_with_bad_address_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            ExceptionWithMessage<TxidError> typedException = null;
            try
            {
                client.IsTxConfirmed(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<TxidError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            string withUppercaseFirst = Consts.ValidTxHashRequired.First().ToString().ToUpper() + String.Join("", Consts.ValidTxHashRequired.ToLower().Skip(1));
            Assert.IsTrue(typedException.ErrorMessage.Data.Txid == withUppercaseFirst);
        }

        [TestMethod]
        public void should_simple_synchronous_call_istxoutputspent_with_bad_address_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            ExceptionWithMessage<TxidOutputError> typedException = null;
            try
            {
                client.IsTxOutputSpent(Network.Doge, Consts.Wrong, 0);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<TxidOutputError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            string withUppercaseFirst = Consts.ValidTxHashRequired.First().ToString().ToUpper() + String.Join("", Consts.ValidTxHashRequired.ToLower().Skip(1));
            Assert.IsTrue(typedException.ErrorMessage.Data.Txid == withUppercaseFirst);
            Assert.IsTrue(typedException.ErrorMessage.Data.OutputNo == "Valid output number is required");
        }

        [TestMethod]
        public void should_simple_synchronous_call_getblockdisplaydata_hash_with_bad_height_throws_exception()
        {
            TransactionClient client = new TransactionClient();
            Exception ex = null;
            try
            {
                client.GetDisplayData(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.IsNotNull(ex);
        }

        #endregion Errors
    }
}
