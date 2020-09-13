namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class MusicType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccMUSDungeonOblivion => ModKey.MakeFormKey(0x3053);
            public static FormKey MUSCombatBossUmbra => ModKey.MakeFormKey(0x301e);
        }
    }
}
