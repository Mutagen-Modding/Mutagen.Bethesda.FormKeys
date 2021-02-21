using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class VoiceType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IVoiceTypeGetter> Construct(uint id) => new FormLink<IVoiceTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IVoiceTypeGetter> CrMistmanVoice => Construct(0x11cd6);
            public static FormLink<IVoiceTypeGetter> CrDogHusky => Construct(0x11687);
            public static FormLink<IVoiceTypeGetter> CrDogDeathHound => Construct(0x11681);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueDexion => Construct(0x181c3);
            public static FormLink<IVoiceTypeGetter> DLC1FemaleVampire => Construct(0x176f8);
            public static FormLink<IVoiceTypeGetter> DLC1MaleVampire => Construct(0x176f7);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueGelebor => Construct(0x1681d);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueSnowElfGhost => Construct(0x1667d);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueVyrthur => Construct(0x14fc2);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueJiub => Construct(0x1400a);
            public static FormLink<IVoiceTypeGetter> CrGargoyleVoice => Construct(0xf8ae);
            public static FormLink<IVoiceTypeGetter> DLC1LD_FemaleNordUniqueKatria => Construct(0xa2bd);
            public static FormLink<IVoiceTypeGetter> CrChaurusInsectVoice => Construct(0x9400);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueHarkon => Construct(0x7d86);
            public static FormLink<IVoiceTypeGetter> DLC1FemaleUniqueFura => Construct(0x7c48);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueGaran => Construct(0x7c47);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueFlorentius => Construct(0x7c46);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueGunmar => Construct(0x7c45);
            public static FormLink<IVoiceTypeGetter> DLC1MaleUniqueIsran => Construct(0x7c44);
            public static FormLink<IVoiceTypeGetter> DLC1FemaleUniqueValerica => Construct(0x7a32);
            public static FormLink<IVoiceTypeGetter> DLC1SeranaVoice => Construct(0x2b6f);
        }
    }
}
