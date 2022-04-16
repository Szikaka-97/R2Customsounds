using BepInEx;
using HarmonyLib;

namespace R2CustomSounds
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class CorePlugin : BaseUnityPlugin
    {
        public static CorePlugin instance;

        private void Awake() {
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            instance = this;

            Harmony.CreateAndPatchAll(typeof(ModAudioManager));
        }
    }
}
