using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Door
        {
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> BattlehornCastleFortAgedNDoor01WineCeller => Construct(0x4334);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01Tax => Construct(0x432b);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01Vintner => Construct(0x5a96);
            public static FormLink<IDoorGetter> BattlehornCastleDoor02Master => Construct(0x432c);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01MenAtArms => Construct(0x432d);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01Storage => Construct(0x432e);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01SleepingQuarters => Construct(0x432f);
            public static FormLink<IDoorGetter> BattlehornCastleTrapDoor01 => Construct(0x16f55);
            public static FormLink<IDoorGetter> BattlehornCastleDoorMinimalUse => Construct(0x1743d);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01Kitchen => Construct(0x4330);
            public static FormLink<IDoorGetter> BattlehornCastleDoor01TrainingRoom => Construct(0x4331);
        }
    }
}
