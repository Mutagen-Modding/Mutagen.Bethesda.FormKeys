using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class PlacedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> DL9VillageReinforcementsMarker => Construct(0x1334);
            public static FormLink<IPlacedObjectGetter> DL902PatrolTrainingRoomMarker => Construct(0x1b33);
            public static FormLink<IPlacedObjectGetter> DL9TrainingMarker01 => Construct(0x14d2);
            public static FormLink<IPlacedObjectGetter> DL9TrainingMarker02 => Construct(0x14d5);
            public static FormLink<IPlacedObjectGetter> DL9TrainingMarker03 => Construct(0x14d6);
            public static FormLink<IPlacedObjectGetter> DL9InstructingMarker => Construct(0x14d4);
            public static FormLink<IPlacedObjectGetter> DL902PatrolFireMarker => Construct(0x1585);
            public static FormLink<IPlacedObjectGetter> DL902PatrolMineMarker => Construct(0x1586);
            public static FormLink<IPlacedObjectGetter> DL902PatrolStairMarker => Construct(0x1584);
            public static FormLink<IPlacedObjectGetter> DL902PatrolOverlookMarker => Construct(0x1587);
            public static FormLink<IPlacedObjectGetter> DL9c08VampireMiddle01REF => Construct(0x64fe);
            public static FormLink<IPlacedObjectGetter> DL9c08VampireBossREF => Construct(0x5564);
            public static FormLink<IPlacedObjectGetter> DL9QuickDeath01MarkerREF => Construct(0x27f2);
            public static FormLink<IPlacedObjectGetter> DL9c08CampfireSpawnerREF => Construct(0x2021);
            public static FormLink<IPlacedObjectGetter> DL9c08DisableCollision03REF => Construct(0x5569);
            public static FormLink<IPlacedObjectGetter> DL9c08Collision03REF => Construct(0x5567);
            public static FormLink<IPlacedObjectGetter> DL9c08battle03REF => Construct(0x5566);
            public static FormLink<IPlacedObjectGetter> DL9c08TrigDisableCollision02REF => Construct(0x553e);
            public static FormLink<IPlacedObjectGetter> DL9c08Battle02CollisionREF => Construct(0x5538);
            public static FormLink<IPlacedObjectGetter> DL9c08Battle02SpawnMarkerREF => Construct(0x5537);
            public static FormLink<IPlacedObjectGetter> DL9c08TrigDisableCollision01REF => Construct(0x500c);
            public static FormLink<IPlacedObjectGetter> DL9c08CollisionBox01REF => Construct(0x5003);
            public static FormLink<IPlacedObjectGetter> DL9c08battle01REF => Construct(0x500d);
            public static FormLink<IPlacedObjectGetter> DL9c08MainEntranceREF => Construct(0x13f3);
            public static FormLink<IPlacedObjectGetter> DL9c08Collision04REF => Construct(0x5568);
            public static FormLink<IPlacedObjectGetter> DL9testguy01REF => Construct(0x5533);
            public static FormLink<IPlacedObjectGetter> DL9Patrol07goalMarker => Construct(0x1b96);
            public static FormLink<IPlacedObjectGetter> DL9Patrol07homeMarker => Construct(0x1b95);
            public static FormLink<IPlacedObjectGetter> DL9Cell1to2 => Construct(0xe0b);
            public static FormLink<IPlacedObjectGetter> DL9Patrol05FirepitMarker => Construct(0xd90);
            public static FormLink<IPlacedObjectGetter> DL9Patrol05TopMarker => Construct(0xd8f);
            public static FormLink<IPlacedObjectGetter> DL9ActorBackstageMarker => Construct(0x2d11);
            public static FormLink<IPlacedObjectGetter> DL9HeartChestREF => Construct(0x1af0);
            public static FormLink<IPlacedObjectGetter> RazorLightREF => Construct(0x1979);
            public static FormLink<IPlacedObjectGetter> DL9RakeRazorREF => Construct(0x1ab1);
            public static FormLink<IPlacedObjectGetter> DL9ChampionCollBoxesMarker => Construct(0x1b0b);
            public static FormLink<IPlacedObjectGetter> DL9FrathenDrothanMarker => Construct(0x13dc);
            public static FormLink<IPlacedObjectGetter> DL9RazorBeamREF => Construct(0x197a);
            public static FormLink<IPlacedObjectGetter> DL9ChampHeadingREF => Construct(0x13c5);
            public static FormLink<IPlacedObjectGetter> DL9ChampionCoffin => Construct(0x1a2b);
            public static FormLink<IPlacedObjectGetter> DL9RazorGateREF => Construct(0x197e);
            public static FormLink<IPlacedObjectGetter> DL9MoragCellREF => Construct(0x1a88);
            public static FormLink<IPlacedObjectGetter> DL9Patrol06marker => Construct(0x1b91);
            public static FormLink<IPlacedObjectGetter> DL9Patrol06HomeMarker => Construct(0x1b90);
            public static FormLink<IPlacedObjectGetter> DL9c05BossSpawner01REF => Construct(0xee5);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker01b => Construct(0x3502);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker01a => Construct(0x3501);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker02b => Construct(0x3506);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker02a => Construct(0x3507);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker03b => Construct(0x32c0);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker03a => Construct(0x350b);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker04b => Construct(0x3514);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker04a => Construct(0x3515);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker05b => Construct(0x3533);
            public static FormLink<IPlacedObjectGetter> DL9c05PatrolMarker05a => Construct(0x3534);
            public static FormLink<IPlacedObjectGetter> DL9RearDoor => Construct(0x3436);
            public static FormLink<IPlacedObjectGetter> DL9CommanderBezoarREF => Construct(0x1a15);
            public static FormLink<IPlacedObjectGetter> DL9BezoarCommMarkerREF => Construct(0xa18e);
            public static FormLink<IPlacedObjectGetter> DL9CommanderMarker => Construct(0x1a06);
            public static FormLink<IPlacedObjectGetter> DL9CommanderEatMarker => Construct(0x1a0b);
            public static FormLink<IPlacedObjectGetter> DL9c06SecretBlack05REF => Construct(0x3f24);
            public static FormLink<IPlacedObjectGetter> DL9c06SecretBlack04REF => Construct(0x3f37);
            public static FormLink<IPlacedObjectGetter> DL9c06SecretBlack02REF => Construct(0x3f33);
            public static FormLink<IPlacedObjectGetter> DL9c06SecretBlack03REF => Construct(0x3f2e);
            public static FormLink<IPlacedObjectGetter> DL9c06SecretBlack01REF => Construct(0x3f36);
            public static FormLink<IPlacedObjectGetter> DL9c06ForgeEnemySpawnerREF => Construct(0x5aab);
            public static FormLink<IPlacedObjectGetter> DL9c06PatrolMarker01b => Construct(0x3543);
            public static FormLink<IPlacedObjectGetter> DL9c06PatrolMarker01a => Construct(0x3544);
            public static FormLink<IPlacedObjectGetter> DL9c06PatrolMarker02b => Construct(0x3545);
            public static FormLink<IPlacedObjectGetter> DL9c06PatrolMarker02a => Construct(0x3546);
            public static FormLink<IPlacedObjectGetter> DL9ForgeMasterBezoarREF => Construct(0x5674);
            public static FormLink<IPlacedObjectGetter> DL9BezoarFMstrMarkerREF => Construct(0xa18f);
            public static FormLink<IPlacedObjectGetter> DL9ForgeBezoarMarker => Construct(0xee6);
            public static FormLink<IPlacedObjectGetter> DL9ShantyBedsmarker => Construct(0x1374);
            public static FormLink<IPlacedObjectGetter> DL9ArcheryMarker => Construct(0x1505);
            public static FormLink<IPlacedObjectGetter> DL9BezoarDoorMarker => Construct(0x2524);
            public static FormLink<IPlacedObjectGetter> DL9BezoarLight01 => Construct(0x2036);
            public static FormLink<IPlacedObjectGetter> DL9BezoarLight02 => Construct(0x2535);
            public static FormLink<IPlacedObjectGetter> DL9Cell3to2Upper => Construct(0x1578);
            public static FormLink<IPlacedObjectGetter> DL9Bezoar01REF => Construct(0x202e);
            public static FormLink<IPlacedObjectGetter> DL9Bezoar02REF => Construct(0x253e);
            public static FormLink<IPlacedObjectGetter> DL9gardenMarker => Construct(0xd6b);
            public static FormLink<IPlacedObjectGetter> DL9PatioMarker => Construct(0xd6f);
            public static FormLink<IPlacedObjectGetter> DL9WatchPostMarker => Construct(0xd6d);
            public static FormLink<IPlacedObjectGetter> DL9foodStoreMarker => Construct(0xd6e);
            public static FormLink<IPlacedObjectGetter> DL9LowPassMarker => Construct(0xd6c);
            public static FormLink<IPlacedObjectGetter> DL9GardenTendingMarker => Construct(0xd1f);
            public static FormLink<IPlacedObjectGetter> DL9Cell3to2lower => Construct(0x1576);
            public static FormLink<IPlacedObjectGetter> DL09Door => Construct(0x206a);
            public static FormLink<IPlacedObjectGetter> DL09MapMarker => Construct(0x206b);
            public static FormLink<IPlacedObjectGetter> DL09Exterior02DoorREF => Construct(0x2093);
        }
    }
}
