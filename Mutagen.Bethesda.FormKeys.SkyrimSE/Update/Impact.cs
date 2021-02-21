using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Impact
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IImpactGetter> Construct(uint id) => new FormLink<IImpactGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactGetter> NPCHorseIdleRearUpImpact => Construct(0x2f7e);
            public static FormLink<IImpactGetter> NPCHorseIdleTailImpact => Construct(0x2f7d);
            public static FormLink<IImpactGetter> NPCHorseIdlePawImpact => Construct(0x2f7c);
            public static FormLink<IImpactGetter> NPCHorseIdleHeadShakeImpact => Construct(0x2f7b);
            public static FormLink<IImpactGetter> NPCHorseIdleHead03Impact => Construct(0x2f7a);
            public static FormLink<IImpactGetter> NPCHorseIdleHead01BImpact => Construct(0x2f79);
            public static FormLink<IImpactGetter> NPCHorseIdleHead01AImpact => Construct(0x2f78);
            public static FormLink<IImpactGetter> NPCHorseIdleGrazeImpact => Construct(0x2f77);
            public static FormLink<IImpactGetter> NPCHorseAttack2Impact => Construct(0x2f76);
            public static FormLink<IImpactGetter> NPCHorseAttackImpact => Construct(0x2f75);
            public static FormLink<IImpactGetter> NPCWolfAggroWarningImpact => Construct(0x2f4f);
            public static FormLink<IImpactGetter> NPCWolfHowlDistantImpact => Construct(0x2f4c);
            public static FormLink<IImpactGetter> NPCWolfHowlImpact => Construct(0x2f49);
            public static FormLink<IImpactGetter> NPCWolfAttackPowerShortImpact => Construct(0x2f40);
            public static FormLink<IImpactGetter> NPCWolfAttackPowerImpact => Construct(0x2f3f);
            public static FormLink<IImpactGetter> NPCWolfAttackBImpact => Construct(0x2f3e);
            public static FormLink<IImpactGetter> NPCWolfAttackAImpact => Construct(0x2f3d);
        }
    }
}
