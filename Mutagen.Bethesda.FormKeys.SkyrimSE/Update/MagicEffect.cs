namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class MagicEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_PetMuffle => ModKey.MakeFormKey(0x2f20);
            public static FormKey Survival_FireCloakFreezingWaterDesc => ModKey.MakeFormKey(0x2ee9);
            public static FormKey Survival_FoodFortifyWarmth => ModKey.MakeFormKey(0x2ee6);
            public static FormKey Survival_FoodRestoreCold => ModKey.MakeFormKey(0x2ee5);
            public static FormKey Survival_FoodRestoreHungerLarge => ModKey.MakeFormKey(0x2ee4);
            public static FormKey Survival_FoodRestoreHungerMedium => ModKey.MakeFormKey(0x2ee3);
            public static FormKey Survival_FoodRestoreHungerSmall => ModKey.MakeFormKey(0x2ee2);
            public static FormKey Survival_FoodRestoreHungerVerySmall => ModKey.MakeFormKey(0x2ee1);
            public static FormKey MS12WhitePhialEffect => ModKey.MakeFormKey(0x9d6);
            public static FormKey EnchSummonStormThrall => ModKey.MakeFormKey(0x845);
            public static FormKey EnchSummonFrostThrall => ModKey.MakeFormKey(0x844);
            public static FormKey EnchSummonFlameThrall => ModKey.MakeFormKey(0x843);
            public static FormKey EnchSummonStormAtronach => ModKey.MakeFormKey(0x842);
            public static FormKey EnchSummonFrostAtronach => ModKey.MakeFormKey(0x841);
            public static FormKey EnchSummonFlameAtronach => ModKey.MakeFormKey(0x840);
        }
    }
}
