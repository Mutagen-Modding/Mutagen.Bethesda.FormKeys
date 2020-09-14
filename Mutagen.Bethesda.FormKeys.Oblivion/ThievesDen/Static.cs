namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey redsaberinterior => ModKey.MakeFormKey(0x138cd);
            public static FormKey pirateflag02 => ModKey.MakeFormKey(0x138d2);
            public static FormKey redsaberTop01 => ModKey.MakeFormKey(0x138ca);
            public static FormKey pirateflag => ModKey.MakeFormKey(0x138cb);
            public static FormKey redsaber01 => ModKey.MakeFormKey(0x138cc);
        }
    }
}
