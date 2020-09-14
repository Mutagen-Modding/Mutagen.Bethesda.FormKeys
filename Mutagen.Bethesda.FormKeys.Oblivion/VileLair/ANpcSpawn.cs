namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVilePrisoner => ModKey.MakeFormKey(0xdb1);
            public static FormKey RowleyEardwulf => ModKey.MakeFormKey(0x3286);
            public static FormKey LairVileMinion => ModKey.MakeFormKey(0xe1b);
        }
    }
}
