using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class APlaced
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IAPlacedGetter> Construct(uint id) => new FormLink<IAPlacedGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAPlacedGetter> TGCrown15MoveToMarker => Construct(0x811);
            public static FormLink<IAPlacedGetter> PetFramework_BreezehomeMarker => Construct(0x2f35);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolA1 => Construct(0x9b7);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolB3 => Construct(0x9b6);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolB1 => Construct(0x9b5);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolB003 => Construct(0x9b4);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolA3 => Construct(0x9b3);
            public static FormLink<IAPlacedGetter> PetFramework_VlindrelMarker => Construct(0x2f39);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolA3 => Construct(0x9b2);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolA2 => Construct(0x9b1);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolA1 => Construct(0x9b0);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolB3 => Construct(0x9af);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolB1 => Construct(0x9ae);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolB2 => Construct(0x9ad);
            public static FormLink<IAPlacedGetter> ccEEJSSE003_EntranceBlocker_NavCutVolume => Construct(0x2fce);
            public static FormLink<IAPlacedGetter> PetFramework_HjerimMarker => Construct(0x2f36);
            public static FormLink<IAPlacedGetter> ccBGSSSE003_BoneWolfZombieREF => Construct(0x3026);
            public static FormLink<IAPlacedGetter> PetFramework_ProudspireMarker => Construct(0x2f38);
            public static FormLink<IAPlacedGetter> PetFramework_HoneysideMarker => Construct(0x2f37);
            public static FormLink<IAPlacedGetter> EEJSSE004_WaririorDoor => Construct(0x3058);
            public static FormLink<IAPlacedGetter> PetFramework_DawnstarMarker => Construct(0x2f34);
            public static FormLink<IAPlacedGetter> PetFramework_WinterholdMarker => Construct(0x2f32);
            public static FormLink<IAPlacedGetter> ccBGSSSE040_NavCutVolume => Construct(0x309e);
            public static FormLink<IAPlacedGetter> ccBGSSSE040_EntranceBlocker => Construct(0x309d);
            public static FormLink<IAPlacedGetter> ccBGSSSE016_EntranceNavCut => Construct(0x304c);
            public static FormLink<IAPlacedGetter> ccBGSSSE016_EntranceBlocker => Construct(0x304a);
            public static FormLink<IAPlacedGetter> ccTWBSSE001_EntranceBlocker_NavCutVolume => Construct(0x2f71);
            public static FormLink<IAPlacedGetter> ccTWBSSE001_EntranceBlocker => Construct(0x2f70);
            public static FormLink<IAPlacedGetter> PetFramework_WindhelmMarker => Construct(0x2f2f);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1SonsA => Construct(0x9ac);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1SonsB => Construct(0x9ab);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2SonsA => Construct(0x9aa);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2SonsB => Construct(0x9a9);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1ImperialA => Construct(0x9a8);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1ImperialB => Construct(0x9a7);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2ImperialA => Construct(0x9a6);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2ImperialB => Construct(0x9a5);
            public static FormLink<IAPlacedGetter> PetFramework_RiftenMarker => Construct(0x2f30);
            public static FormLink<IAPlacedGetter> PetFramework_MarkarthMarker => Construct(0x2f33);
            public static FormLink<IAPlacedGetter> PetFramework_WhiterunMarker => Construct(0x2f2e);
            public static FormLink<IAPlacedGetter> ccBGSSSE025_DungeonEntrance => Construct(0x3057);
            public static FormLink<IAPlacedGetter> PetFramework_SolitudeMarker => Construct(0x2f31);
        }
    }
}
