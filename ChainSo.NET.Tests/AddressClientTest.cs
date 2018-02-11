using System;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Error;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainSo.NET.Tests
{
    [TestClass]
    public class AddressClientTest
    {
        #region Valid

        [TestMethod]
        public void simple_synchronous_call_getbalance_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            Balance result = client.GetBalance(Network.Doge, "DFundmtrigzA6E25Swr2pRe4Eb79bGP8G1", 500);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DFundmtrigzA6E25Swr2pRe4Eb79bGP8G1");
        }

        [TestMethod]
        public void simple_synchronous_call_getreceivedvalue_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            ReceivedValue result = client.GetReceivedValue(Network.Doge, "DFundmtrigzA6E25Swr2pRe4Eb79bGP8G1");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DFundmtrigzA6E25Swr2pRe4Eb79bGP8G1");
        }

        [TestMethod]
        public void simple_synchronous_call_getspentvalue_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            SpentValue result = client.GetSpentValue(Network.Doge, "DFundmtrigzA6E25Swr2pRe4Eb79bGP8G1");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DFundmtrigzA6E25Swr2pRe4Eb79bGP8G1");
        }

        [TestMethod]
        public void simple_synchronous_call_getunspenttx_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            OutputTx result = client.GetUnspentTx(Network.Doge, "DRapidDiBYggT1zdrELnVhNDqyAHn89cRi", "e83d147c3bcd87c6efd5270896a179f6ecb1de8b8c8cc324645c5a14129baf8c");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DRapidDiBYggT1zdrELnVhNDqyAHn89cRi");
        }

        [TestMethod]
        public void simple_synchronous_call_getreceivedtx_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            OutputTx result = client.GetReceivedTx(Network.Doge, "DRapidDiBYggT1zdrELnVhNDqyAHn89cRi", "e83d147c3bcd87c6efd5270896a179f6ecb1de8b8c8cc324645c5a14129baf8c");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DRapidDiBYggT1zdrELnVhNDqyAHn89cRi");
        }

        [TestMethod]
        public void simple_synchronous_call_getspenttx_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            InputTx result = client.GetSpentTx(Network.Doge, "DRapidDiBYggT1zdrELnVhNDqyAHn89cRi", "e83d147c3bcd87c6efd5270896a179f6ecb1de8b8c8cc324645c5a14129baf8c");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DRapidDiBYggT1zdrELnVhNDqyAHn89cRi");
        }

        [TestMethod]
        public void simple_synchronous_call_isaddressvalid_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            AddressValid result = client.IsAddressValid(Network.Doge, "DM7Yo7YqPtgMsGgphX9RAZFXFhu6Kd6JTT");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DM7Yo7YqPtgMsGgphX9RAZFXFhu6Kd6JTT");
            Assert.IsTrue(result.Data.IsValid);
        }

        [TestMethod]
        public void simple_synchronous_call_getdisplaydata_returns_result_with_proxy()
        {
            AddressClient client = new AddressClient();
            AddressDisplayData result = client.GetDisplayData(Network.Doge, "DM7Yo7YqPtgMsGgphX9RAZFXFhu6Kd6JTT");
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(result.Data.Address == "DM7Yo7YqPtgMsGgphX9RAZFXFhu6Kd6JTT");
        }
        #endregion Valid

        #region Errors

        [TestMethod]
        public void should_simple_synchronous_call_getbalance_with_bad_address_throws_exception()
        {
            AddressClient client = new AddressClient();
            ExceptionWithMessage<AddressError> typedException = null;
            try
            {
                client.GetBalance(Network.Doge, Consts.Wrong, 1000000);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<AddressError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Address == "A valid address is required");
        }

        [TestMethod]
        public void should_simple_synchronous_call_getreceivedvalue_with_bad_address_throws_exception()
        {
            AddressClient client = new AddressClient();
            ExceptionWithMessage<AddressReceivedValueError> typedException = null;
            try
            {
                client.GetReceivedValue(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<AddressReceivedValueError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Address == Consts.ValidAddressRequired);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getspentvalue_with_bad_address_throws_exception()
        {
            AddressClient client = new AddressClient();
            ExceptionWithMessage<AddressSentValueError> typedException = null;
            try
            {
                client.GetSpentValue(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<AddressSentValueError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.Address == Consts.ValidAddressRequired);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getunspenttx_with_bad_address_throws_exception()
        {
            AddressClient client = new AddressClient();
            ExceptionWithMessage<AddressAfterTxError> typedException = null;
            try
            {
                client.GetUnspentTx(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<AddressAfterTxError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.AfterTx == "Get unspent transactions after this transaction ID.");
        }

        [TestMethod]
        public void should_simple_synchronous_call_getreceivedtx_with_bad_address_throws_exception()
        {
            AddressClient client = new AddressClient();
            ExceptionWithMessage<AddressAfterTxError> typedException = null;
            try
            {
                client.GetReceivedTx(Network.Doge, Consts.Wrong, "e83d147c3bcd87c6efd5270896a179f6ecb1de8b8c8cc324645c5a14129baf8c");
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<AddressAfterTxError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.AfterTx == "Return 100 transactions that occurred after this Transaction ID");
        }

        [TestMethod]
        public void should_simple_synchronous_call_getspenttx_with_bad_address_throws_exception()
        {
            AddressClient client = new AddressClient();
            ExceptionWithMessage<AddressAfterTxError> typedException = null;
            try
            {
                client.GetSpentTx(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<AddressAfterTxError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
            Assert.IsTrue(typedException.ErrorMessage.Data.AfterTx == "Retrieve 100 transactions that occurred after this transaction ID");
        }

        [TestMethod]
        public void should_simple_synchronous_call_isaddressvalid_with_bad_address_returns_false()
        {
            AddressClient client = new AddressClient();
            AddressValid result = client.IsAddressValid(Network.Doge, Consts.Wrong);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Success);
            Assert.IsTrue(!result.Data.IsValid);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getaddressdisplaydata_hash_with_bad_address_returns_fail()
        {
            AddressClient client = new AddressClient();
            AddressDisplayData result = client.GetDisplayData(Network.Doge, Consts.Wrong);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == Consts.Fail);
        }

        #endregion Errors
    }
}
