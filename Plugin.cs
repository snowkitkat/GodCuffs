namespace PluginTemplate
{
    using System;
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;

    /// <inheritdoc />
    public class Plugin : Plugin<Config>
    {
		private EventHandlers eventHandlers;
		
        /// <inheritdoc/>
        public override string Author { get; } = "Snow";

        /// <inheritdoc/>
        public override string Name { get; } = "PluginTemplate";

        /// <inheritdoc/>
        public override string Prefix { get; } = "PluginTemplate";

        /// <inheritdoc/>
        public override Version Version { get; } = new Version(1, 0, 0);

        /// <inheritdoc/>
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.Hurting += eventHandlers.onHurting;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            PlayerHandlers.Hurting -= eventHandlers.onHurting;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}