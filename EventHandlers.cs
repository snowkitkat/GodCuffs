using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using PluginAPI.Events;

namespace PluginTemplate
{
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using PlayerRoles;

    /// <summary>
    /// General event handlers.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">The <see cref="Plugin{TConfig}"/> class reference.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void onHurting(HurtingEventArgs ev)
        {
            if (ev.Player.IsCuffed && plugin.Config.Whitelist.Contains(ev.Player.Role) && ev.Attacker.Role.Team != Team.SCPs)
            {
                ev.IsAllowed = false;
                ev.Attacker.ShowHint("<color=lime>You cannot damage detained Civilians!</color>");
            }
        }
    }
}