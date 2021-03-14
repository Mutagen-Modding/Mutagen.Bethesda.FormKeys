using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class AIPackage
        {
            private static FormLink<IAIPackageGetter> Construct(uint id) => new FormLink<IAIPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAIPackageGetter> DL9CommanderBreakfast => Construct(0x1a0c);
            public static FormLink<IAIPackageGetter> DL9CommanderDinner => Construct(0x1a0d);
            public static FormLink<IAIPackageGetter> DL9ActorRunPackage => Construct(0x2d18);
            public static FormLink<IAIPackageGetter> DL9MoragTongAssassination => Construct(0x252e);
            public static FormLink<IAIPackageGetter> DL9Train01Package => Construct(0x14de);
            public static FormLink<IAIPackageGetter> DL9Patrol07package => Construct(0x1b97);
            public static FormLink<IAIPackageGetter> DL9Patrol06Top => Construct(0x1b98);
            public static FormLink<IAIPackageGetter> DL9LaborPackage01 => Construct(0x1b9b);
            public static FormLink<IAIPackageGetter> DL9Train03Package => Construct(0x14e2);
            public static FormLink<IAIPackageGetter> DL9ForgeMasterAmbush => Construct(0x21d5);
            public static FormLink<IAIPackageGetter> DL9Train02Package => Construct(0x14e0);
            public static FormLink<IAIPackageGetter> DL9ArcheryPractice => Construct(0x1510);
            public static FormLink<IAIPackageGetter> DL9MoragTongPostKill => Construct(0x2533);
            public static FormLink<IAIPackageGetter> DL9GardenerRakePackage => Construct(0xd5f);
            public static FormLink<IAIPackageGetter> DL9BasicSitting512 => Construct(0x19a6);
            public static FormLink<IAIPackageGetter> DL9ChampionPursuePC => Construct(0x5fc2);
            public static FormLink<IAIPackageGetter> DL9Patrol08package => Construct(0x3505);
            public static FormLink<IAIPackageGetter> DL9Patrol01FirePit => Construct(0x1a72);
            public static FormLink<IAIPackageGetter> DL9Patrol09package => Construct(0x350a);
            public static FormLink<IAIPackageGetter> DL9Patrol10package => Construct(0x350d);
            public static FormLink<IAIPackageGetter> DL9BasicEating512 => Construct(0x1ada);
            public static FormLink<IAIPackageGetter> DL9Patrol03Chokepoint => Construct(0xd72);
            public static FormLink<IAIPackageGetter> DL9LaborPackage02 => Construct(0x3513);
            public static FormLink<IAIPackageGetter> DL9Patrol02Mines => Construct(0xd73);
            public static FormLink<IAIPackageGetter> DL9Patrol11package => Construct(0x351a);
            public static FormLink<IAIPackageGetter> DL9Patrol04Veranda => Construct(0xd7c);
            public static FormLink<IAIPackageGetter> DL9LaborPackage03 => Construct(0x3521);
            public static FormLink<IAIPackageGetter> DL9LaborPackage04 => Construct(0x3524);
            public static FormLink<IAIPackageGetter> DL9Patrol04FoodStore => Construct(0xd7d);
            public static FormLink<IAIPackageGetter> DL9BasicSleeping512 => Construct(0x4ad5);
            public static FormLink<IAIPackageGetter> DL9Patrol12package => Construct(0x3535);
            public static FormLink<IAIPackageGetter> DL9Patrol01Mines => Construct(0x1a73);
            public static FormLink<IAIPackageGetter> DL9Patrol13package => Construct(0x354b);
            public static FormLink<IAIPackageGetter> DL9Patrol14package => Construct(0x354c);
            public static FormLink<IAIPackageGetter> DL9Patrol05Top => Construct(0xd92);
            public static FormLink<IAIPackageGetter> CL9InstructorPackage => Construct(0x14e6);
            public static FormLink<IAIPackageGetter> DL9BasicNapNight512 => Construct(0x1ade);
            public static FormLink<IAIPackageGetter> DL9BasicNapMorning512 => Construct(0x1adf);
            public static FormLink<IAIPackageGetter> DL9DrothanStudyMarker => Construct(0x2190);
            public static FormLink<IAIPackageGetter> DL9TraineesSleepPackage => Construct(0x1375);
            public static FormLink<IAIPackageGetter> DL9EatAtLocation10pm => Construct(0x1376);
            public static FormLink<IAIPackageGetter> DL9ChampStayPutPackage => Construct(0xa192);
            public static FormLink<IAIPackageGetter> DL9BasicNapDay512 => Construct(0x1ae0);
            public static FormLink<IAIPackageGetter> DL9BasicNapDayWakeup512 => Construct(0x1af8);
            public static FormLink<IAIPackageGetter> DL9BasicNapMorningWakeup512 => Construct(0x1af9);
            public static FormLink<IAIPackageGetter> DL9BasicNapNightWakeup512 => Construct(0x1afb);
            public static FormLink<IAIPackageGetter> DL9CommanderTrain => Construct(0x1a09);
            public static FormLink<IAIPackageGetter> DL9CommanderSleep => Construct(0x1a0a);
            public static FormLink<IAIPackageGetter> DL9Patrol01bottom => Construct(0x1b31);
        }
    }
}
