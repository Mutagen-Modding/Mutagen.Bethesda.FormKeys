namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9BravilWall => ModKey.MakeFormKey(0x142f);
            public static FormKey DL9StaticCellDoor => ModKey.MakeFormKey(0x1ab6);
            public static FormKey DL9StaticShovel => ModKey.MakeFormKey(0x2ce7);
        }
    }
}
