namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey BattlehornCastleFortAgedNDoor01WineCeller => ModKey.MakeFormKey(0x4334);
            public static FormKey BattlehornCastleDoor01Tax => ModKey.MakeFormKey(0x432b);
            public static FormKey BattlehornCastleDoor01Vintner => ModKey.MakeFormKey(0x5a96);
            public static FormKey BattlehornCastleDoor02Master => ModKey.MakeFormKey(0x432c);
            public static FormKey BattlehornCastleDoor01MenAtArms => ModKey.MakeFormKey(0x432d);
            public static FormKey BattlehornCastleDoor01Storage => ModKey.MakeFormKey(0x432e);
            public static FormKey BattlehornCastleDoor01SleepingQuarters => ModKey.MakeFormKey(0x432f);
            public static FormKey BattlehornCastleTrapDoor01 => ModKey.MakeFormKey(0x16f55);
            public static FormKey BattlehornCastleDoorMinimalUse => ModKey.MakeFormKey(0x1743d);
            public static FormKey BattlehornCastleDoor01Kitchen => ModKey.MakeFormKey(0x4330);
            public static FormKey BattlehornCastleDoor01TrainingRoom => ModKey.MakeFormKey(0x4331);
        }
    }
}
