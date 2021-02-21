using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> ArchitectureOrreryConsole => Construct(0x11eb5e);
            public static FormLink<IActivatorGetter> ArchitectureOrreryConsoleButton => Construct(0x11eb5f);
            public static FormLink<IActivatorGetter> ArchitectureOrreryDome => Construct(0x11eb60);
            public static FormLink<IActivatorGetter> ArchitectureOrreryPanel => Construct(0x11eb61);
            public static FormLink<IActivatorGetter> ArchitectureOrreryStars => Construct(0x11eb62);
            public static FormLink<IActivatorGetter> DLCOrreryConsole => Construct(0x11d291);
            public static FormLink<IActivatorGetter> ArchitectureOrrery => Construct(0x11eb5d);
            public static FormLink<IActivatorGetter> ArchitectureOrreryIris => Construct(0x1283b2);
            public static FormLink<IActivatorGetter> DLCOrreryACTSoundStartup => Construct(0x12d22c);
            public static FormLink<IActivatorGetter> DLCOrreryACTSoundMain => Construct(0x12d22d);
            public static FormLink<IActivatorGetter> DLCOrreryACTSoundGearsSmall => Construct(0x12d22e);
            public static FormLink<IActivatorGetter> DLCOrreryACTSoundGearsMed => Construct(0x12d22f);
            public static FormLink<IActivatorGetter> DLCOrreryACTSoundGearLoop => Construct(0x12d230);
            public static FormLink<IActivatorGetter> DLCOrreryACTSoundRoomLP => Construct(0x12d231);
        }
    }
}
