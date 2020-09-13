namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Footstep
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey NPCHorseRearUpFootstep => ModKey.MakeFormKey(0x2f92);
            public static FormKey NPCHorseIdleTailFootstep => ModKey.MakeFormKey(0x2f91);
            public static FormKey NPCHorseIdlePawFootstep => ModKey.MakeFormKey(0x2f90);
            public static FormKey NPCHorseIdleHeadShakeFootstep => ModKey.MakeFormKey(0x2f8f);
            public static FormKey NPCHorseIdleHead03Footstep => ModKey.MakeFormKey(0x2f8e);
            public static FormKey NPCHorseIdleHead01BFootstep => ModKey.MakeFormKey(0x2f8d);
            public static FormKey NPCHorseIdleHead01AFootstep => ModKey.MakeFormKey(0x2f8c);
            public static FormKey NPCHorseIdleGrazeFootstep => ModKey.MakeFormKey(0x2f8b);
            public static FormKey NPCHorseAttack2Footstep => ModKey.MakeFormKey(0x2f8a);
            public static FormKey NPCHorseAttackFootstep => ModKey.MakeFormKey(0x2f89);
            public static FormKey NPCWolfAggroWarningFootstep => ModKey.MakeFormKey(0x2f51);
            public static FormKey NPCWolfHowlDistantFootstep => ModKey.MakeFormKey(0x2f4e);
            public static FormKey NPCWolfHowlFootstep => ModKey.MakeFormKey(0x2f4b);
            public static FormKey NPCWolfAttackPowerShortFootstep => ModKey.MakeFormKey(0x2f48);
            public static FormKey NPCWolfAttackPowerFootstep => ModKey.MakeFormKey(0x2f47);
            public static FormKey NPCWolfAttackBFootstep => ModKey.MakeFormKey(0x2f46);
            public static FormKey NPCWolfAttackAFootstep => ModKey.MakeFormKey(0x2f45);
        }
    }
}
