using BTCPayServer.Client.Models;

namespace BTCPayServer.Plugins.Custodians.Kraken.Kraken;

public class KrakenAssetPair: AssetPairData
{
    public string PairCode { get; }
    
    public KrakenAssetPair(string AssetBought, string AssetSold, string PairCode, decimal minimumTradeQty) : base(AssetBought, AssetSold, minimumTradeQty)
    {
        this.PairCode = PairCode;
    }
}
