namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class DualCastData
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey doomSerpentDualCastData => ModKey.MakeFormKey(0xe5f62);
            public static FormKey FrostStormDualCastData => ModKey.MakeFormKey(0x201f3);
        }
    }
}
