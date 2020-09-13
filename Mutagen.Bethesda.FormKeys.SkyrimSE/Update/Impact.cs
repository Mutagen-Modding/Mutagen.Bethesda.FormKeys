namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Impact
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey NPCHorseIdleRearUpImpact => ModKey.MakeFormKey(0x2f7e);
            public static FormKey NPCHorseIdleTailImpact => ModKey.MakeFormKey(0x2f7d);
            public static FormKey NPCHorseIdlePawImpact => ModKey.MakeFormKey(0x2f7c);
            public static FormKey NPCHorseIdleHeadShakeImpact => ModKey.MakeFormKey(0x2f7b);
            public static FormKey NPCHorseIdleHead03Impact => ModKey.MakeFormKey(0x2f7a);
            public static FormKey NPCHorseIdleHead01BImpact => ModKey.MakeFormKey(0x2f79);
            public static FormKey NPCHorseIdleHead01AImpact => ModKey.MakeFormKey(0x2f78);
            public static FormKey NPCHorseIdleGrazeImpact => ModKey.MakeFormKey(0x2f77);
            public static FormKey NPCHorseAttack2Impact => ModKey.MakeFormKey(0x2f76);
            public static FormKey NPCHorseAttackImpact => ModKey.MakeFormKey(0x2f75);
            public static FormKey NPCWolfAggroWarningImpact => ModKey.MakeFormKey(0x2f4f);
            public static FormKey NPCWolfHowlDistantImpact => ModKey.MakeFormKey(0x2f4c);
            public static FormKey NPCWolfHowlImpact => ModKey.MakeFormKey(0x2f49);
            public static FormKey NPCWolfAttackPowerShortImpact => ModKey.MakeFormKey(0x2f40);
            public static FormKey NPCWolfAttackPowerImpact => ModKey.MakeFormKey(0x2f3f);
            public static FormKey NPCWolfAttackBImpact => ModKey.MakeFormKey(0x2f3e);
            public static FormKey NPCWolfAttackAImpact => ModKey.MakeFormKey(0x2f3d);
        }
    }
}
