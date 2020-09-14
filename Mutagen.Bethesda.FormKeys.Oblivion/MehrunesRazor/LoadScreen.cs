namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class LoadScreen
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9VillageLoadDoor => ModKey.MakeFormKey(0x1b8d);
            public static FormKey DL9extLoadDoor => ModKey.MakeFormKey(0x1567);
            public static FormKey DL9MinesLoadDoor => ModKey.MakeFormKey(0x1b87);
            public static FormKey DL9CommuneLoadDoor => ModKey.MakeFormKey(0x1b88);
        }
    }
}
