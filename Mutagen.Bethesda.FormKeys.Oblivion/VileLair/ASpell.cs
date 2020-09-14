namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVileShrineBlessing01 => ModKey.MakeFormKey(0xa5d6);
            public static FormKey LairVileShrineBlessing => ModKey.MakeFormKey(0x1379);
            public static FormKey LairVileAbChokeberry => ModKey.MakeFormKey(0x9bff);
            public static FormKey LairVileShrineBlessing03 => ModKey.MakeFormKey(0xa5d0);
            public static FormKey LairVileShrineBlessing02 => ModKey.MakeFormKey(0xa5d4);
        }
    }
}
