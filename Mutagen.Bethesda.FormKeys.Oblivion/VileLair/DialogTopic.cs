namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class DialogTopic
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey DeepscornSlay => ModKey.MakeFormKey(0x7973);
            public static FormKey DeepscornDone => ModKey.MakeFormKey(0x7975);
            public static FormKey DeepscornNm => ModKey.MakeFormKey(0xefc1);
        }
    }
}
