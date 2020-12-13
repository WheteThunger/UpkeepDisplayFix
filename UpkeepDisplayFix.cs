namespace Oxide.Plugins
{
    [Info("Upkeep Display Fix", "WhiteThunder", "1.0.0")]
    [Description("Fixes display bug where Tool Cupboard upkeep doesn't factor in decay scale.")]
    internal class UpkeepDisplayFix : CovalencePlugin
    {
        private void OnEntitySaved(BuildingPrivlidge buildingPrivilege, BaseNetworkable.SaveInfo saveInfo)
        {
            saveInfo.msg.buildingPrivilege.upkeepPeriodMinutes /= ConVar.Decay.scale;
            saveInfo.msg.buildingPrivilege.protectedMinutes /= ConVar.Decay.scale;
        }
    }
}
