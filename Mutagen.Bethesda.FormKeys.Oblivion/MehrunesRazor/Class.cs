namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Class
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9ForgeMasterClass => ModKey.MakeFormKey(0x272d);
        }
    }
}
