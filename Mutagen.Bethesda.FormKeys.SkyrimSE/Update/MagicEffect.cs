using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class MagicEffect
        {
            private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMagicEffectGetter> PetFramework_PetMuffle => Construct(0x2f20);
            public static FormLink<IMagicEffectGetter> Survival_FireCloakFreezingWaterDesc => Construct(0x2ee9);
            public static FormLink<IMagicEffectGetter> Survival_FoodFortifyWarmth => Construct(0x2ee6);
            public static FormLink<IMagicEffectGetter> Survival_FoodRestoreCold => Construct(0x2ee5);
            public static FormLink<IMagicEffectGetter> Survival_FoodRestoreHungerLarge => Construct(0x2ee4);
            public static FormLink<IMagicEffectGetter> Survival_FoodRestoreHungerMedium => Construct(0x2ee3);
            public static FormLink<IMagicEffectGetter> Survival_FoodRestoreHungerSmall => Construct(0x2ee2);
            public static FormLink<IMagicEffectGetter> Survival_FoodRestoreHungerVerySmall => Construct(0x2ee1);
            public static FormLink<IMagicEffectGetter> MS12WhitePhialEffect => Construct(0x9d6);
            public static FormLink<IMagicEffectGetter> EnchSummonStormThrall => Construct(0x845);
            public static FormLink<IMagicEffectGetter> EnchSummonFrostThrall => Construct(0x844);
            public static FormLink<IMagicEffectGetter> EnchSummonFlameThrall => Construct(0x843);
            public static FormLink<IMagicEffectGetter> EnchSummonStormAtronach => Construct(0x842);
            public static FormLink<IMagicEffectGetter> EnchSummonFrostAtronach => Construct(0x841);
            public static FormLink<IMagicEffectGetter> EnchSummonFlameAtronach => Construct(0x840);
        }
    }
}
