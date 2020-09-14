namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVile04 => ModKey.MakeFormKey(0x5a65);
            public static FormKey LairVile01 => ModKey.MakeFormKey(0xce6);
            public static FormKey LairVile02 => ModKey.MakeFormKey(0x13c8);
            public static FormKey LairVile03 => ModKey.MakeFormKey(0x208f);
        }
    }
}
