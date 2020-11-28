namespace Oxide.Plugins
{
    [Info("Upkeep Display Fix", "WhiteThunder", "0.1.0")]
    [Description("Fixes the Tool Cupboard UI to properly take into account decay scale.")]
    internal class UpkeepDisplayFix : CovalencePlugin
    {
        private void OnEntitySaved(BuildingPrivlidge buildingPrivilege, BaseNetworkable.SaveInfo saveInfo)
        {
            if (saveInfo.forDisk)
                return;

            saveInfo.msg.buildingPrivilege.upkeepPeriodMinutes /= ConVar.Decay.scale;
            saveInfo.msg.buildingPrivilege.protectedMinutes /= ConVar.Decay.scale;
        }
    }
}
