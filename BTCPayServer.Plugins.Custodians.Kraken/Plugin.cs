using BTCPayServer.Abstractions.Contracts;
using BTCPayServer.Abstractions.Custodians;
using BTCPayServer.Abstractions.Models;
using BTCPayServer.Plugins.Custodians.Kraken.Kraken;
using Microsoft.Extensions.DependencyInjection;

namespace BTCPayServer.Plugins.Custodians.Kraken
{
    
    public class Plugin : BaseBTCPayServerPlugin
    {
        public override IBTCPayServerPlugin.PluginDependency[] Dependencies { get; } = new[]
        {
            new IBTCPayServerPlugin.PluginDependency { Identifier = nameof(BTCPayServer), Condition = ">=1.8.2" }
        };
        
        public override void Execute(IServiceCollection services)
        {
            services.AddSingleton<KrakenExchange>();
            services.AddSingleton<ICustodian, KrakenExchange>(provider => provider.GetRequiredService<KrakenExchange>());
        }
    }
}
