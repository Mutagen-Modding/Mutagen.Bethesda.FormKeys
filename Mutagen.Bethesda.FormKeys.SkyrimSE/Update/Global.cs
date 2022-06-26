// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Global
        {
            private static FormLink<IGlobalGetter> Construct(uint id) => new FormLink<IGlobalGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGlobalGetter> Survival_ModeEnabledShared => Construct(0x314a);
            public static FormLink<IGlobalGetter> CCHorseArmorCostSwapOnly => Construct(0x30dc);
            public static FormLink<IGlobalGetter> CCHorseArmorCost => Construct(0x30cf);
            public static FormLink<IGlobalGetter> CCHorseArmorIsInstalled => Construct(0x30b9);
            public static FormLink<IGlobalGetter> CCHorseArmorIsInstalledElven => Construct(0x30b8);
            public static FormLink<IGlobalGetter> CCHorseArmorIsInstalledSteel => Construct(0x30b7);
            public static FormLink<IGlobalGetter> PetFramework_AllowPetInventory => Construct(0x2f29);
            public static FormLink<IGlobalGetter> PetFramework_AllowPetCombat => Construct(0x2f28);
            public static FormLink<IGlobalGetter> PetFramework_MaxPets => Construct(0x2f27);
            public static FormLink<IGlobalGetter> Survival_ExhaustionAttributePenaltyPercent => Construct(0x2ee0);
            public static FormLink<IGlobalGetter> Survival_HungerAttributePenaltyPercent => Construct(0x2edf);
            public static FormLink<IGlobalGetter> Survival_ColdAttributePenaltyPercent => Construct(0x2ede);
            public static FormLink<IGlobalGetter> Survival_TemperatureLevel => Construct(0x2edd);
            public static FormLink<IGlobalGetter> OghmaInfiniumBookHasBeenRead => Construct(0x9de);
            public static FormLink<IGlobalGetter> RiftenUngrienGlobal => Construct(0x9db);
            public static FormLink<IGlobalGetter> WEDL06LetrushKilled => Construct(0x99c);
        }
    }
}
