namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Sound
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey AMBOrreryRoomLP => ModKey.MakeFormKey(0x126b26);
            public static FormKey AMBOrreryButtonPush => ModKey.MakeFormKey(0x126b27);
            public static FormKey AMBOrreryStartup => ModKey.MakeFormKey(0x126b28);
            public static FormKey AMBOrreryLP => ModKey.MakeFormKey(0x126b29);
            public static FormKey AMBOrreryGearsMediumLP => ModKey.MakeFormKey(0x126b2a);
            public static FormKey AMBOrreryGearsSmallLP => ModKey.MakeFormKey(0x126b2b);
        }
    }
}
