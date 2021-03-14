using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class PlacedObject
        {
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> LairVileMinionPrayerMarker => Construct(0x5bb0);
            public static FormLink<IPlacedObjectGetter> LairVileDoor4to3 => Construct(0x5b54);
            public static FormLink<IPlacedObjectGetter> LairVileMinionUseChest => Construct(0x147f4);
            public static FormLink<IPlacedObjectGetter> LairVileMinionChestRef => Construct(0x1430d);
            public static FormLink<IPlacedObjectGetter> DeepscornHollowJournalRef => Construct(0x5098);
            public static FormLink<IPlacedObjectGetter> LairVileMinionBed => Construct(0xd78);
            public static FormLink<IPlacedObjectGetter> LairVileMinionStockMarker => Construct(0xe2e);
            public static FormLink<IPlacedObjectGetter> LairVileBoxingMarker => Construct(0xe1d);
            public static FormLink<IPlacedObjectGetter> LairVileTendingMarker => Construct(0xe1e);
            public static FormLink<IPlacedObjectGetter> LairVileTallSack => Construct(0x1452);
            public static FormLink<IPlacedObjectGetter> LairVileMinionLeavesMarker => Construct(0x9216);
            public static FormLink<IPlacedObjectGetter> LairVileD2to3 => Construct(0x21bb);
            public static FormLink<IPlacedObjectGetter> LairVile2to1 => Construct(0x15fb);
            public static FormLink<IPlacedObjectGetter> LairVilePrisonMarker => Construct(0x15ed);
            public static FormLink<IPlacedObjectGetter> LairVileExitLadderRef => Construct(0x920a);
            public static FormLink<IPlacedObjectGetter> LairVileMinionReturnsMarker => Construct(0x9215);
            public static FormLink<IPlacedObjectGetter> LairVileStudy => Construct(0x21b5);
            public static FormLink<IPlacedObjectGetter> LairVileDiningArea => Construct(0x21b6);
            public static FormLink<IPlacedObjectGetter> LairVileBedroomMarker => Construct(0x21c2);
            public static FormLink<IPlacedObjectGetter> LairVileArmoireREF => Construct(0x60b2);
            public static FormLink<IPlacedObjectGetter> LairVileTarisStool => Construct(0x3285);
            public static FormLink<IPlacedObjectGetter> LairVileTarisHangoutMarker => Construct(0x3289);
            public static FormLink<IPlacedObjectGetter> DeepscornAddonsRef => Construct(0x65b0);
            public static FormLink<IPlacedObjectGetter> DeepscornHollowMapMarker => Construct(0x1342);
            public static FormLink<IPlacedObjectGetter> LairVileOutdoorHangout => Construct(0x379e);
            public static FormLink<IPlacedObjectGetter> LairVileSurfaceDoorRef => Construct(0x9213);
        }
    }
}
