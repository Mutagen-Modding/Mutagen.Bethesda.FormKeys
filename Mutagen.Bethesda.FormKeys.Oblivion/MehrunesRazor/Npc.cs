using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> DL9MoragTongAssassin => Construct(0x1aad);
            public static FormLink<INpcGetter> DL9FrathenDrothan => Construct(0x218e);
            public static FormLink<INpcGetter> DL9RecruitDead01 => Construct(0x64fb);
            public static FormLink<INpcGetter> DL9Trainer01 => Construct(0x14e7);
            public static FormLink<INpcGetter> DL9ForgeMaster => Construct(0x272e);
            public static FormLink<INpcGetter> DL9Soldier01 => Construct(0x14ae);
            public static FormLink<INpcGetter> DL9Apprentice01 => Construct(0x3a2c);
            public static FormLink<INpcGetter> DL9Apprentice02 => Construct(0x3a2f);
            public static FormLink<INpcGetter> DL9Soldier02 => Construct(0x1adb);
            public static FormLink<INpcGetter> DL9SleepyRecruit => Construct(0x4ad6);
            public static FormLink<INpcGetter> DL9DeadVampire01 => Construct(0x4ae3);
            public static FormLink<INpcGetter> DL9DeadVampire02 => Construct(0x4ae4);
            public static FormLink<INpcGetter> DL9DeadVampire03 => Construct(0x4ae5);
            public static FormLink<INpcGetter> DL9DeadVeteran02 => Construct(0x4ae6);
            public static FormLink<INpcGetter> DL9DeadVeteran03 => Construct(0x4ae7);
            public static FormLink<INpcGetter> DL9Soldier03 => Construct(0x1add);
            public static FormLink<INpcGetter> DL9Patrol01 => Construct(0x158b);
            public static FormLink<INpcGetter> DL9SoldierNoPackage01 => Construct(0x5542);
            public static FormLink<INpcGetter> DL9SoldierNoPackage02 => Construct(0x5544);
            public static FormLink<INpcGetter> DL9Steward => Construct(0x5fad);
            public static FormLink<INpcGetter> DL9ArgonianGardener => Construct(0xd5e);
            public static FormLink<INpcGetter> DL9Recruit02 => Construct(0xd83);
            public static FormLink<INpcGetter> DL9Soldier04 => Construct(0x5fb0);
            public static FormLink<INpcGetter> DL9Recruit04 => Construct(0x5fb1);
            public static FormLink<INpcGetter> DL9TraineeArchery => Construct(0xd84);
            public static FormLink<INpcGetter> DL9Recruit03 => Construct(0xd85);
            public static FormLink<INpcGetter> DL9Veteran02 => Construct(0xd86);
            public static FormLink<INpcGetter> DL9Veteran03 => Construct(0xd87);
            public static FormLink<INpcGetter> DL9Patrol05 => Construct(0xd98);
            public static FormLink<INpcGetter> DL9Patrol02 => Construct(0x1b35);
            public static FormLink<INpcGetter> DL9LaborerKhajiit02 => Construct(0x274d);
            public static FormLink<INpcGetter> DL9LaborerKhajiit03 => Construct(0x274e);
            public static FormLink<INpcGetter> DL9LaborerArgonian01 => Construct(0x274f);
            public static FormLink<INpcGetter> DL9LaborerArgonian02 => Construct(0x2750);
            public static FormLink<INpcGetter> DL9Patrol06 => Construct(0x1b8e);
            public static FormLink<INpcGetter> DL9Patrol07 => Construct(0x1b94);
            public static FormLink<INpcGetter> DL9LaborerCustom01 => Construct(0x1b9c);
            public static FormLink<INpcGetter> DL9LaborerArgonian03 => Construct(0x2751);
            public static FormLink<INpcGetter> DL9DeadVeteranOnScript01 => Construct(0x27ea);
            public static FormLink<INpcGetter> DL9Recruit01 => Construct(0x14ce);
            public static FormLink<INpcGetter> DL9Patrol03 => Construct(0xd71);
            public static FormLink<INpcGetter> DL9Patrol08 => Construct(0x3503);
            public static FormLink<INpcGetter> DL9Patrol09 => Construct(0x3508);
            public static FormLink<INpcGetter> DL9Patrol10 => Construct(0x350e);
            public static FormLink<INpcGetter> DL9LaborerCustom02 => Construct(0x3510);
            public static FormLink<INpcGetter> DL9Patrol11 => Construct(0x3516);
            public static FormLink<INpcGetter> DL9LaborerCustom03 => Construct(0x351f);
            public static FormLink<INpcGetter> DL9LaborerCustom04 => Construct(0x3526);
            public static FormLink<INpcGetter> DL9Patrol12 => Construct(0x352e);
            public static FormLink<INpcGetter> DL9Patrol13 => Construct(0x3549);
            public static FormLink<INpcGetter> DL9Patrol14 => Construct(0x354e);
            public static FormLink<INpcGetter> DL9Patrol04 => Construct(0xd7e);
            public static FormLink<INpcGetter> DL9Veteran01 => Construct(0x14cf);
            public static FormLink<INpcGetter> DL9Champion1 => Construct(0x1982);
            public static FormLink<INpcGetter> DL9Actor01 => Construct(0x2d0f);
            public static FormLink<INpcGetter> DL9Actor02 => Construct(0x2d16);
            public static FormLink<INpcGetter> DL9Actor03 => Construct(0x2d17);
            public static FormLink<INpcGetter> DL9Trainee01 => Construct(0x14df);
            public static FormLink<INpcGetter> DL9Trainee02 => Construct(0x14e1);
            public static FormLink<INpcGetter> DL9LaborerKhajiit01 => Construct(0x19fa);
            public static FormLink<INpcGetter> DL9BossCommander => Construct(0x1a07);
            public static FormLink<INpcGetter> DL9DeadVeteran => Construct(0x2d23);
            public static FormLink<INpcGetter> DL9Trainee03 => Construct(0x14e3);
        }
    }
}