namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey ArchitectureOrreryDoorFrame => ModKey.MakeFormKey(0x11eb57);
        }
    }
}
