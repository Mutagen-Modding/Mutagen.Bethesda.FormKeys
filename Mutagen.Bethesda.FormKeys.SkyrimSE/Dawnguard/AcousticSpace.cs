namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class AcousticSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1IntFalmerValleyLargeStoneBossChapel => ModKey.MakeFormKey(0x14c61);
            public static FormKey IntVampireCastleGuildhall => ModKey.MakeFormKey(0xf695);
            public static FormKey IntDungeonDLC1DarkfallPassageAcousticSpace => ModKey.MakeFormKey(0x18421);
            public static FormKey DLC1IntDarkDungeonCave => ModKey.MakeFormKey(0x6b0d);
        }
    }
}
