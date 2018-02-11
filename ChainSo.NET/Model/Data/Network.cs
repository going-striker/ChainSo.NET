namespace ChainSo.NET.Model
{
    internal enum NetworkEnum
    {
        BTC,
        DASH,
        DOGE,
        LTC,
        BTCTEST,
        DASHTEST,
        DOGETEST,
        LTCTEST
    }

    public class Network
    {
        public static Network Bitcoin = new Network(NetworkEnum.BTC);
        public static Network Dash = new Network(NetworkEnum.DASH);
        public static Network Doge = new Network(NetworkEnum.DOGE);
        public static Network Litecoin = new Network(NetworkEnum.LTC);
        public static Network BitcoinTest = new Network(NetworkEnum.BTCTEST);
        public static Network DashTest = new Network(NetworkEnum.DASHTEST);
        public static Network DogeTest = new Network(NetworkEnum.DOGETEST);
        public static Network LitecoinTest = new Network(NetworkEnum.LTCTEST);

        internal NetworkEnum _network;

        private Network(NetworkEnum network)
        {
            _network = network;
        }
    }
}
