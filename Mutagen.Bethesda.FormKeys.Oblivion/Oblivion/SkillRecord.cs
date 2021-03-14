using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class SkillRecord
        {
            private static FormLink<ISkillRecordGetter> Construct(uint id) => new FormLink<ISkillRecordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISkillRecordGetter> SkillAlchemy => Construct(0x44);
            public static FormLink<ISkillRecordGetter> SkillAlteration => Construct(0x45);
            public static FormLink<ISkillRecordGetter> SkillConjuration => Construct(0x46);
            public static FormLink<ISkillRecordGetter> SkillDestruction => Construct(0x47);
            public static FormLink<ISkillRecordGetter> SkillIllusion => Construct(0x48);
            public static FormLink<ISkillRecordGetter> SkillMysticism => Construct(0x49);
            public static FormLink<ISkillRecordGetter> SkillRestoration => Construct(0x4a);
            public static FormLink<ISkillRecordGetter> SkillAcrobatics => Construct(0x4b);
            public static FormLink<ISkillRecordGetter> SkillLightArmor => Construct(0x4c);
            public static FormLink<ISkillRecordGetter> SkillMarksman => Construct(0x4d);
            public static FormLink<ISkillRecordGetter> SkillMercantile => Construct(0x4e);
            public static FormLink<ISkillRecordGetter> SkillSecurity => Construct(0x4f);
            public static FormLink<ISkillRecordGetter> SkillSneak => Construct(0x50);
            public static FormLink<ISkillRecordGetter> SkillSpeechcraft => Construct(0x51);
            public static FormLink<ISkillRecordGetter> SkillArmorer => Construct(0x3d);
            public static FormLink<ISkillRecordGetter> SkillAthletics => Construct(0x3e);
            public static FormLink<ISkillRecordGetter> SkillBlade => Construct(0x3f);
            public static FormLink<ISkillRecordGetter> SkillBlock => Construct(0x40);
            public static FormLink<ISkillRecordGetter> SkillBlunt => Construct(0x41);
            public static FormLink<ISkillRecordGetter> SkillHandToHand => Construct(0x42);
            public static FormLink<ISkillRecordGetter> SkillHeavyArmor => Construct(0x43);
        }
    }
}
