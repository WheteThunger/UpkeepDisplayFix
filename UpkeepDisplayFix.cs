namespace Oxide.Plugins
{
    [Info("Upkeep Display Fix", "WhiteThunder", "1.0.0")]
    [Description("Fixes upkeep displayed in the Tool Cupboard UI to properly take into account decay scale.")]
    internal class UpkeepDisplayFix : CovalencePlugin
    {
        private void OnEntitySaved(BuildingPrivlidge buildingPrivilege, BaseNetworkable.SaveInfo saveInfo)
        {
            saveInfo.msg.buildingPrivilege.upkeepPeriodMinutes /= ConVar.Decay.scale;
            saveInfo.msg.buildingPrivilege.protectedMinutes /= ConVar.Decay.scale;
        }
    }
}
