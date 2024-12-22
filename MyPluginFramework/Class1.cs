using System;

namespace PluginSystem {

    /// Defines the interface that all plugins must implement.
    public interface IPlugin
    {
        /// Executes the plugin's functionality.
        void Execute();
    }
}
