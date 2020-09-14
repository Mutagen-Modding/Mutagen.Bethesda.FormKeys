namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey ArchitectureOrreryConsole => ModKey.MakeFormKey(0x11eb5e);
            public static FormKey ArchitectureOrreryConsoleButton => ModKey.MakeFormKey(0x11eb5f);
            public static FormKey ArchitectureOrreryDome => ModKey.MakeFormKey(0x11eb60);
            public static FormKey ArchitectureOrreryPanel => ModKey.MakeFormKey(0x11eb61);
            public static FormKey ArchitectureOrreryStars => ModKey.MakeFormKey(0x11eb62);
            public static FormKey DLCOrreryConsole => ModKey.MakeFormKey(0x11d291);
            public static FormKey ArchitectureOrrery => ModKey.MakeFormKey(0x11eb5d);
            public static FormKey ArchitectureOrreryIris => ModKey.MakeFormKey(0x1283b2);
            public static FormKey DLCOrreryACTSoundStartup => ModKey.MakeFormKey(0x12d22c);
            public static FormKey DLCOrreryACTSoundMain => ModKey.MakeFormKey(0x12d22d);
            public static FormKey DLCOrreryACTSoundGearsSmall => ModKey.MakeFormKey(0x12d22e);
            public static FormKey DLCOrreryACTSoundGearsMed => ModKey.MakeFormKey(0x12d22f);
            public static FormKey DLCOrreryACTSoundGearLoop => ModKey.MakeFormKey(0x12d230);
            public static FormKey DLCOrreryACTSoundRoomLP => ModKey.MakeFormKey(0x12d231);
        }
    }
}
