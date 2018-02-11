using System;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Error;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainSo.NET.Tests
{
    [TestClass]
    public class SimpleClientTest
    {
        #region Valid

        [TestMethod]
        public void simple_synchronous_call_getnetworkinfo_returns_result()
        {
            SimpleClient client = new SimpleClient();
            NetworkInfo network = client.GetNetworkInfo(Network.BitcoinTest);
            Assert.IsNotNull(network);
            Assert.IsTrue(network.Status == Consts.Success);
        }

        [TestMethod]
        public void simple_synchronous_call_getprices_returns_result()
        {
            SimpleClient client = new SimpleClient();
            Price prices = client.GetPrices(Network.Bitcoin, "EUR");
            Assert.IsNotNull(prices);
            Assert.IsTrue(prices.Status == Consts.Success);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getprices_with_bad_address_returns_empty_list()
        {
            SimpleClient client = new SimpleClient();
            Price prices = client.GetPrices(Network.Bitcoin, Consts.Wrong);
            Assert.IsNotNull(prices);
            Assert.IsTrue(prices.Status == Consts.Success);
            Assert.IsTrue(prices.Data.Prices.Count == 0);
        }


        #endregion Valid

        #region Errors

        [TestMethod]
        public void simple_synchronous_call_getshortaddress_returns_result()
        {
            SimpleClient client = new SimpleClient();
            ShortAddress address = client.GetShortAddress(Network.Doge, "DSfnDweXHwQmUYhprkNpmGo3nuvKepF851");
            Assert.IsTrue(address != null && address.Status == Consts.Success);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getshortaddress_with_bad_address_throws_exception()
        {
            SimpleClient client = new SimpleClient();
            ExceptionWithMessage<CommonError> typedException = null;
            try
            {
                client.GetShortAddress(Network.BitcoinTest, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<CommonError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Code == 404);
            Assert.IsTrue(typedException.ErrorMessage.Message == "Invalid long/short address");
        }

        #endregion Errors

    }
}
