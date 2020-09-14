namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9NerfDetectionDisease => ModKey.MakeFormKey(0x2728);
            public static FormKey DL9AbFastKill => ModKey.MakeFormKey(0x27eb);
            public static FormKey DL9AbChampFX => ModKey.MakeFormKey(0x1a25);
            public static FormKey DL9DisPrion => ModKey.MakeFormKey(0x2729);
        }
    }
}
