using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class PlacedObject
        {
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> TGCrown15MoveToMarker => Construct(0x811);
            public static FormLink<IPlacedObjectGetter> PetFramework_BreezehomeMarker => Construct(0x2f35);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolA1 => Construct(0x9b7);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolB3 => Construct(0x9b6);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolB1 => Construct(0x9b5);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolB003 => Construct(0x9b4);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolA3 => Construct(0x9b3);
            public static FormLink<IPlacedObjectGetter> PetFramework_VlindrelMarker => Construct(0x2f39);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolA3 => Construct(0x9b2);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolA2 => Construct(0x9b1);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolA1 => Construct(0x9b0);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolB3 => Construct(0x9af);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolB1 => Construct(0x9ae);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolB2 => Construct(0x9ad);
            public static FormLink<IPlacedObjectGetter> ccEEJSSE003_EntranceBlocker_NavCutVolume => Construct(0x2fce);
            public static FormLink<IPlacedObjectGetter> PetFramework_HjerimMarker => Construct(0x2f36);
            public static FormLink<IPlacedObjectGetter> ccBGSSSE003_BoneWolfZombieREF => Construct(0x3026);
            public static FormLink<IPlacedObjectGetter> PetFramework_ProudspireMarker => Construct(0x2f38);
            public static FormLink<IPlacedObjectGetter> PetFramework_HoneysideMarker => Construct(0x2f37);
            public static FormLink<IPlacedObjectGetter> EEJSSE004_WaririorDoor => Construct(0x3058);
            public static FormLink<IPlacedObjectGetter> PetFramework_DawnstarMarker => Construct(0x2f34);
            public static FormLink<IPlacedObjectGetter> PetFramework_WinterholdMarker => Construct(0x2f32);
            public static FormLink<IPlacedObjectGetter> ccBGSSSE040_NavCutVolume => Construct(0x309e);
            public static FormLink<IPlacedObjectGetter> ccBGSSSE040_EntranceBlocker => Construct(0x309d);
            public static FormLink<IPlacedObjectGetter> ccBGSSSE016_EntranceNavCut => Construct(0x304c);
            public static FormLink<IPlacedObjectGetter> ccBGSSSE016_EntranceBlocker => Construct(0x304a);
            public static FormLink<IPlacedObjectGetter> ccTWBSSE001_EntranceBlocker_NavCutVolume => Construct(0x2f71);
            public static FormLink<IPlacedObjectGetter> ccTWBSSE001_EntranceBlocker => Construct(0x2f70);
            public static FormLink<IPlacedObjectGetter> PetFramework_WindhelmMarker => Construct(0x2f2f);
            public static FormLink<IPlacedObjectGetter> PetFramework_RiftenMarker => Construct(0x2f30);
            public static FormLink<IPlacedObjectGetter> PetFramework_MarkarthMarker => Construct(0x2f33);
            public static FormLink<IPlacedObjectGetter> PetFramework_WhiterunMarker => Construct(0x2f2e);
            public static FormLink<IPlacedObjectGetter> ccBGSSSE025_DungeonEntrance => Construct(0x3057);
            public static FormLink<IPlacedObjectGetter> PetFramework_SolitudeMarker => Construct(0x2f31);
        }
    }
}
