namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey ArchitectureOrreryDoor => ModKey.MakeFormKey(0x11eb5a);
        }
    }
}
