using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitUIPluginInterfaces;

namespace GitUI.SettingsDialog
{
    /// <summary>
    /// Used to display a specific settings page
    /// 
    /// nice-to-have: extend with attributes to jump to specific control on settingspage
    /// </summary>
    public class SettingsPageReference
    {

        private readonly Section _section;
        private readonly Type _settingsPageType;
        private readonly IGitPlugin _gitPlugin;

        /// <summary>
        /// References the first page of GitExt settings or Plugin settings
        /// </summary>
        /// <param name="section"></param>
        public SettingsPageReference(Section section)
        {
            _section = section;
        }

        /// <summary>
        /// References a specific page of GitExt settings
        /// </summary>
        /// <param name="settingsPageType"></param>
        public SettingsPageReference(Type settingsPageType)
        {
            _settingsPageType = settingsPageType;
        }

        /// <summary>
        /// References a settings page for the given IGitPlugin
        /// </summary>
        /// <param name="gitPlugin"></param>
        public SettingsPageReference(IGitPlugin gitPlugin)
        {
            _gitPlugin = gitPlugin;
        }

        /// <summary>
        /// if not null then the other two properties are null
        /// </summary>
        public Section SettingsSection { get { return _section; } }

        /// <summary>
        /// if not null then the other two properties are null
        /// </summary>
        public Type SettingsPageType { get { return _settingsPageType; } }

        /// <summary>
        /// if not null then the other two properties are null
        /// </summary>
        public IGitPlugin GitExtPlugin { get { return _gitPlugin; } }

        /// <summary>
        /// references a root node from the settings tree
        /// </summary>
        public enum Section
        {
            GitExtensionsSettings,
            PluginsSettings
        }
    }
}
