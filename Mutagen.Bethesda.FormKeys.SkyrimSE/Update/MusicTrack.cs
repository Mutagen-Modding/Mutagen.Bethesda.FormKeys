namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class MusicTrack
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccMUSDungeonOblivion05 => ModKey.MakeFormKey(0x3052);
            public static FormKey ccMUSDungeonOblivion04 => ModKey.MakeFormKey(0x3051);
            public static FormKey ccMUSDungeonOblivion03 => ModKey.MakeFormKey(0x3050);
            public static FormKey ccMUSDungeonOblivion02 => ModKey.MakeFormKey(0x304f);
            public static FormKey ccMUSDungeonOblivion01 => ModKey.MakeFormKey(0x304e);
            public static FormKey MUSCombatBossUmbra01 => ModKey.MakeFormKey(0x301d);
        }
    }
}
