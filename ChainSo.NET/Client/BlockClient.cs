using System.Threading.Tasks;
using ChainSo.NET.Model;
using ChainSo.NET.Model.Error;

namespace ChainSo.NET
{
    public class BlockClient : AbstractClient
    {
        private const string GetBlockHashUrl = "https://chain.so/api/v2/get_blockhash/{0}/{1}";
        private const string GetBlockUrl = "https://chain.so/api/v2/get_block/{0}/{1}";
        private const string GetBlockDisplayDataUrl = "https://chain.so/api/v2/get_block/{0}/{1}";

        #region Constructors

        public BlockClient() : base() { }

        public BlockClient(bool useProxy) : base(useProxy) { }

        #endregion Constructors

        #region Block Hash

        public async Task<BlockHash> GetBlockHashAsync(Network network, long height)
        {
            BlockHash response = await GetQuery<BlockHash, BlockHashError>(string.Format(GetBlockHashUrl, network._network, height));
            return response;
        }

        public BlockHash GetBlockHash(Network network, long height)
        {
            return GetBlockHashAsync(network, height).Result;
        }

        #endregion Block Hash

        #region Block 

        public async Task<Block> GetBlockAsync(Network network, long height)
        {
            Block response = await GetQuery<Block, BlockError>(string.Format(GetBlockUrl, network._network, height));
            return response;
        }

        public Block GetBlock(Network network, long height)
        {
            return GetBlockAsync(network, height).Result;
        }

        public async Task<Block> GetBlockAsync(Network network, string hash)
        {
            Block response = await GetQuery<Block, BlockError>(string.Format(GetBlockUrl, network._network, hash));
            return response;
        }

        public Block GetBlock(Network network, string hash)
        {
            return GetBlockAsync(network, hash).Result;
        }

        #endregion Block 

        #region Block Display Data

        public async Task<BlockDisplayData> GetDisplayDataAsync(Network network, long height)
        {
            BlockDisplayData response = await GetQuery<BlockDisplayData, CommonError>(string.Format(GetBlockDisplayDataUrl, network._network, height));
            return response;
        }

        public BlockDisplayData GetDisplayData(Network network, long height)
        {
            return GetDisplayDataAsync(network, height).Result;
        }

        public async Task<BlockDisplayData> GetDisplayDataAsync(Network network, string hash)
        {
            BlockDisplayData response = await GetQuery<BlockDisplayData, CommonError>(string.Format(GetBlockDisplayDataUrl, network._network, hash));
            return response;
        }

        public BlockDisplayData GetDisplayData(Network network, string hash)
        {
            return GetDisplayDataAsync(network, hash).Result;
        }

        #endregion Block Display Data
    }
}
