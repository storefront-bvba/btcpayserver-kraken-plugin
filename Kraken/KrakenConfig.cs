namespace BTCPayServer.Plugins.Custodians.Kraken.Kraken;

public class KrakenConfig
{
    public string ApiKey { get; set; }
    public string PrivateKey { get; set; }

    public Dictionary<string, string> WithdrawToStoreWalletAddressLabels { get; set; } = new();

    public KrakenConfig()
    {
    }

    public KrakenConfig(string apiKey, string privateKey, Dictionary<string,string> withdrawToStoreWalletAddressLabels)
    {
        ApiKey = apiKey;
        PrivateKey = privateKey;
        WithdrawToStoreWalletAddressLabels = withdrawToStoreWalletAddressLabels;
    }

}
