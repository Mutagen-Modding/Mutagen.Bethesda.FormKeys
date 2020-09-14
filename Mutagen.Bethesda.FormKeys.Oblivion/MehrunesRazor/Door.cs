namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9HiddenDoor => ModKey.MakeFormKey(0x353f);
            public static FormKey DL9DrothanClosetDoor => ModKey.MakeFormKey(0x14fd);
            public static FormKey DL9StewardDoor => ModKey.MakeFormKey(0x158a);
        }
    }
}
