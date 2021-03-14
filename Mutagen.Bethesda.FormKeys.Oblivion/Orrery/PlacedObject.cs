using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class PlacedObject
        {
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> DLCOrreryACTSoundGearsSmallRef => Construct(0x12d236);
            public static FormLink<IPlacedObjectGetter> DLCOrreryACTSoundStartupRef => Construct(0x12d233);
            public static FormLink<IPlacedObjectGetter> DLCOrreryACTSoundMainRef => Construct(0x12d234);
            public static FormLink<IPlacedObjectGetter> DLCOrreryACTSoundGearLoopRef => Construct(0x12d237);
            public static FormLink<IPlacedObjectGetter> DLCOrreryACTSoundGearsMedRef => Construct(0x12d235);
            public static FormLink<IPlacedObjectGetter> DLCOrreryBothielWanderMark => Construct(0x123018);
            public static FormLink<IPlacedObjectGetter> DLCOrreryBothielRepairMark => Construct(0x123017);
            public static FormLink<IPlacedObjectGetter> DLCOrreryPanelRef => Construct(0x121790);
            public static FormLink<IPlacedObjectGetter> DLCOrreryConsoleButtonRef => Construct(0x121792);
            public static FormLink<IPlacedObjectGetter> DLCOrreryConsoleRef2 => Construct(0x121791);
            public static FormLink<IPlacedObjectGetter> DLCOrreryStarsRef => Construct(0x12178e);
            public static FormLink<IPlacedObjectGetter> DLCOrreryRef => Construct(0x121793);
            public static FormLink<IPlacedObjectGetter> DLCOrreryDomeRef => Construct(0x12178f);
            public static FormLink<IPlacedObjectGetter> DLCOrreryInteriorDoorRef => Construct(0x11e157);
            public static FormLink<IPlacedObjectGetter> DLCOrreryConsoleRef => Construct(0x11d292);
            public static FormLink<IPlacedObjectGetter> DLCOrreryPanelLightRef1 => Construct(0x1243b6);
            public static FormLink<IPlacedObjectGetter> DLCOrreryPanelLightRef2 => Construct(0x1243b8);
            public static FormLink<IPlacedObjectGetter> DLCOrreryDomeLightRef2 => Construct(0x1243ba);
            public static FormLink<IPlacedObjectGetter> DLCOrreryDomeLightRef1 => Construct(0x1243bc);
            public static FormLink<IPlacedObjectGetter> DLCOrreryDomeLightRef3 => Construct(0x1243bb);
            public static FormLink<IPlacedObjectGetter> DLCOrreryIrisRef => Construct(0x1283b3);
            public static FormLink<IPlacedObjectGetter> DLCOrreryOldDoorRef1 => Construct(0x122648);
            public static FormLink<IPlacedObjectGetter> DLCOrreryACTSoundRoomLPRef => Construct(0x12d238);
            public static FormLink<IPlacedObjectGetter> DLCOrreryDoorRef => Construct(0x11e156);
        }
    }
}
