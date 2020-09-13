namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Global
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_AllowPetInventory => ModKey.MakeFormKey(0x2f29);
            public static FormKey PetFramework_AllowPetCombat => ModKey.MakeFormKey(0x2f28);
            public static FormKey PetFramework_MaxPets => ModKey.MakeFormKey(0x2f27);
            public static FormKey Survival_ExhaustionAttributePenaltyPercent => ModKey.MakeFormKey(0x2ee0);
            public static FormKey Survival_HungerAttributePenaltyPercent => ModKey.MakeFormKey(0x2edf);
            public static FormKey Survival_ColdAttributePenaltyPercent => ModKey.MakeFormKey(0x2ede);
            public static FormKey Survival_TemperatureLevel => ModKey.MakeFormKey(0x2edd);
            public static FormKey OghmaInfiniumBookHasBeenRead => ModKey.MakeFormKey(0x9de);
            public static FormKey RiftenUngrienGlobal => ModKey.MakeFormKey(0x9db);
            public static FormKey WEDL06LetrushKilled => ModKey.MakeFormKey(0x99c);
        }
    }
}
