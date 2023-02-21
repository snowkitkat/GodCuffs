using System.Collections.Generic;
using Exiled.Events.Handlers;
using Exiled.API.Features.Roles;
using PlayerRoles;

namespace PluginTemplate
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
    /// Gets or sets a value indicating whether debug messages should be shown in the console.
    /// </summary>
        [Description("Whether debug logs should be shown in the console.")]
        public bool Debug { get; set; }

        [Description("Whitelist which roles do not die to other human classes while cuffed.")]
        public List<RoleTypeId> Whitelist = new List<RoleTypeId>
        {
            RoleTypeId.Scientist, RoleTypeId.ClassD
        };
    }
}