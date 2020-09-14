namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVileAltarBasin => ModKey.MakeFormKey(0x1378);
            public static FormKey LairVileFontofRenewal => ModKey.MakeFormKey(0x30e7);
        }
    }
}
