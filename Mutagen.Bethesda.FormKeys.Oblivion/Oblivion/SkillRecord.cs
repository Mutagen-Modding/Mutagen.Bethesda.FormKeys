namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class SkillRecord
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            public static FormKey SkillAlchemy => ModKey.MakeFormKey(0x44);
            public static FormKey SkillAlteration => ModKey.MakeFormKey(0x45);
            public static FormKey SkillConjuration => ModKey.MakeFormKey(0x46);
            public static FormKey SkillDestruction => ModKey.MakeFormKey(0x47);
            public static FormKey SkillIllusion => ModKey.MakeFormKey(0x48);
            public static FormKey SkillMysticism => ModKey.MakeFormKey(0x49);
            public static FormKey SkillRestoration => ModKey.MakeFormKey(0x4a);
            public static FormKey SkillAcrobatics => ModKey.MakeFormKey(0x4b);
            public static FormKey SkillLightArmor => ModKey.MakeFormKey(0x4c);
            public static FormKey SkillMarksman => ModKey.MakeFormKey(0x4d);
            public static FormKey SkillMercantile => ModKey.MakeFormKey(0x4e);
            public static FormKey SkillSecurity => ModKey.MakeFormKey(0x4f);
            public static FormKey SkillSneak => ModKey.MakeFormKey(0x50);
            public static FormKey SkillSpeechcraft => ModKey.MakeFormKey(0x51);
            public static FormKey SkillArmorer => ModKey.MakeFormKey(0x3d);
            public static FormKey SkillAthletics => ModKey.MakeFormKey(0x3e);
            public static FormKey SkillBlade => ModKey.MakeFormKey(0x3f);
            public static FormKey SkillBlock => ModKey.MakeFormKey(0x40);
            public static FormKey SkillBlunt => ModKey.MakeFormKey(0x41);
            public static FormKey SkillHandToHand => ModKey.MakeFormKey(0x42);
            public static FormKey SkillHeavyArmor => ModKey.MakeFormKey(0x43);
        }
    }
}
