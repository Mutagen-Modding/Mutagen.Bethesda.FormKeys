namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class MusicType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey MUSCombatBossDLC1 => ModKey.MakeFormKey(0x126a0);
            public static FormKey MUSExploreDLCFalmerValley => ModKey.MakeFormKey(0xef94);
            public static FormKey MUSDungeonDLCVampireCastle => ModKey.MakeFormKey(0xeeb9);
            public static FormKey MUSEclipse => ModKey.MakeFormKey(0x19bb5);
            public static FormKey MUSExploreDLCSoulCairn => ModKey.MakeFormKey(0x7012);
        }
    }
}
