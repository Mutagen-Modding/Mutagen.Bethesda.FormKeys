using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class PlacedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> FrostcragRingBox => Construct(0xf0b1);
            public static FormLink<IPlacedObjectGetter> FrostCragAlchBuffRef => Construct(0xf0b7);
            public static FormLink<IPlacedObjectGetter> FCSpireTelepadFrom2to1 => Construct(0xf0b4);
            public static FormLink<IPlacedObjectGetter> FCSpireTelepadFrom2toRoof => Construct(0xf0b6);
            public static FormLink<IPlacedObjectGetter> FrostCragAlchemyParentREF => Construct(0xf0b2);
            public static FormLink<IPlacedObjectGetter> FrostCragBedroomParentREF => Construct(0xf0b3);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireSpellsBeforeRef => Construct(0xee2e);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireEnchBeforeRef => Construct(0xee2f);
            public static FormLink<IPlacedObjectGetter> FCSpireStarterMarker => Construct(0xefc5);
            public static FormLink<IPlacedObjectGetter> FrostcragStormAtronachBirthMarker => Construct(0xefb4);
            public static FormLink<IPlacedObjectGetter> FrostcragFrostAtronachBirthMarker => Construct(0xefb5);
            public static FormLink<IPlacedObjectGetter> FrostcragFireAtronachBirthMarker => Construct(0xefb3);
            public static FormLink<IPlacedObjectGetter> FrostcragAtronachAltarRef => Construct(0xefb6);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireMemoirsRef => Construct(0xefbf);
            public static FormLink<IPlacedObjectGetter> FCSpireTelepadFrom1to2 => Construct(0xefc8);
            public static FormLink<IPlacedObjectGetter> FCSpireTelepadFrom1to3 => Construct(0xefc7);
            public static FormLink<IPlacedObjectGetter> FrostCragMiniParent01 => Construct(0xefc9);
            public static FormLink<IPlacedObjectGetter> FrostCragMiniParent02 => Construct(0xefca);
            public static FormLink<IPlacedObjectGetter> FrostCragMiniParent03 => Construct(0xefcb);
            public static FormLink<IPlacedObjectGetter> FrostCragLibraryParentREF => Construct(0xefcc);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireEnchAfterRef => Construct(0xefb1);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireSpellsAfterRef => Construct(0xefb2);
            public static FormLink<IPlacedObjectGetter> FrostcragAtronachRef => Construct(0xee2a);
            public static FormLink<IPlacedObjectGetter> FrostCragDONOTDELETERef01 => Construct(0x13fe9);
            public static FormLink<IPlacedObjectGetter> FrostCragDONOTDELETERef02 => Construct(0x13fe6);
            public static FormLink<IPlacedObjectGetter> FCSpireTelepadFromVaultto1 => Construct(0xf169);
            public static FormLink<IPlacedObjectGetter> topBarrel => Construct(0xf167);
            public static FormLink<IPlacedObjectGetter> FrostCragVaultParentREF => Construct(0xf168);
            public static FormLink<IPlacedObjectGetter> LennasaanTombstone => Construct(0xf65c);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireAddonsRef => Construct(0x124f);
            public static FormLink<IPlacedObjectGetter> DLCFrostcragArrivalMarker => Construct(0x1312f);
            public static FormLink<IPlacedObjectGetter> BrumaPadRef => Construct(0xbd28);
            public static FormLink<IPlacedObjectGetter> FrostcragSpireMapMarker => Construct(0xd51);
        }
    }
}
