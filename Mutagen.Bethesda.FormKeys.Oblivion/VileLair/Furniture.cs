namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Furniture
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVileCoffinBed => ModKey.MakeFormKey(0x1360);
        }
    }
}
