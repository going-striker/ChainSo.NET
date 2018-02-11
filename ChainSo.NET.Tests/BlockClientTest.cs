using System;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Error;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChainSo.NET.Tests
{
    [TestClass]
    public class BlockClientTest
    {
        #region Valid

        [TestMethod]
        public void simple_synchronous_call_getblockhash_returns_result_with_proxy()
        {
            BlockClient client = new BlockClient(true);
            BlockHash hash = client.GetBlockHash(Network.Doge, 200000);
            Assert.IsNotNull(hash);
            Assert.IsTrue(hash.Status == Consts.Success);
            Assert.IsTrue(hash.Data.Blockhash == "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
        }

        [TestMethod]
        public void simple_synchronous_call_getblock_height_returns_result_with_proxy()
        {
            BlockClient client = new BlockClient(true);
            Block block = client.GetBlock(Network.Doge, 200000);
            Assert.IsNotNull(block);
            Assert.IsTrue(block.Status == Consts.Success);
            Assert.IsTrue(block.Data.Blockhash == "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
            Assert.IsTrue(block.Data.Size == 20686);
        }

        [TestMethod]
        public void simple_synchronous_call_getblock_hash_returns_result_with_proxy()
        {
            BlockClient client = new BlockClient(true);
            Block block = client.GetBlock(Network.Doge,
                "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
            Assert.IsNotNull(block);
            Assert.IsTrue(block.Status == Consts.Success);
            Assert.IsTrue(block.Data.Blockhash == "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
            Assert.IsTrue(block.Data.Size == 20686);
        }

        [TestMethod]
        public void simple_synchronous_call_getblockdisplaydata_height_returns_result_with_proxy()
        {
            BlockClient client = new BlockClient(true);
            BlockDisplayData block = client.GetDisplayData(Network.Doge, 200000);
            Assert.IsNotNull(block);
            Assert.IsTrue(block.Status == Consts.Success);
            Assert.IsTrue(block.Data.Blockhash == "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
            Assert.IsTrue(block.Data.Size == 20686);
        }


        [TestMethod]
        public void simple_synchronous_call_getblockdisplaydata_hash_returns_result_with_proxy()
        {
            BlockClient client = new BlockClient(true);
            BlockDisplayData block = client.GetDisplayData(Network.Doge,
                "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
            Assert.IsNotNull(block);
            Assert.IsTrue(block.Status == Consts.Success);
            Assert.IsTrue(block.Data.Blockhash == "092fd3e76db5ff35fbfefe48d5c53ca26e799f0654a4036ddd5fd78de77418c2");
            Assert.IsTrue(block.Data.Size == 20686);
        }

        #endregion Valid

        #region Errors

        [TestMethod]
        public void should_simple_synchronous_call_getblockhash_with_bad_height_throws_exception()
        {
            BlockClient client = new BlockClient(true);
            ExceptionWithMessage<BlockHashError> typedException = null;
            try
            {
                client.GetBlockHash(Network.Doge, -1);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<BlockHashError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getblock_height_with_bad_height_throws_exception()
        {
            BlockClient client = new BlockClient(true);
            ExceptionWithMessage<BlockError> typedException = null;
            try
            {
                client.GetBlock(Network.Doge, -1);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<BlockError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getblock_hash_with_bad_height_throws_exception()
        {
            BlockClient client = new BlockClient(true);
            ExceptionWithMessage<BlockError> typedException = null;
            try
            {
                client.GetBlock(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<BlockError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
        }

        [TestMethod]
        public void should_simple_synchronous_call_getblockdisplaydata_height_with_bad_height_throws_exception()
        {
            BlockClient client = new BlockClient(true);
            ExceptionWithMessage<CommonError> typedException = null;
            try
            {
                client.GetDisplayData(Network.Doge, -1);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<CommonError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
        }


        [TestMethod]
        public void should_simple_synchronous_call_getblockdisplaydata_hash_with_bad_height_throws_exception()
        {
            BlockClient client = new BlockClient(true);
            ExceptionWithMessage<CommonError> typedException = null;
            try
            {
                client.GetDisplayData(Network.Doge, Consts.Wrong);
            }
            catch (Exception e)
            {
                typedException = e?.InnerException as ExceptionWithMessage<CommonError>;
            }
            Assert.IsNotNull(typedException);
            Assert.IsNotNull(typedException.ErrorMessage);
            Assert.IsTrue(typedException.ErrorMessage.Status == Consts.Fail);
        }

        #endregion Errors
    }
}
