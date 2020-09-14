namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVileMinionREF => ModKey.MakeFormKey(0xe1c);
            public static FormKey LairVilePrisonerREF => ModKey.MakeFormKey(0x1410);
            public static FormKey RowleyEardwulfRef => ModKey.MakeFormKey(0x3288);
        }
    }
}
