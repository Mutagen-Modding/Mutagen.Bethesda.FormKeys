namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Ingestible
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1BloodPotion => ModKey.MakeFormKey(0x18ef3);
            public static FormKey DLC1FoodSoulHuskExtract => ModKey.MakeFormKey(0x15a1e);
            public static FormKey DLC1FoodSoulHusk => ModKey.MakeFormKey(0x14dc4);
            public static FormKey DLC1RedwaterDenSkooma => ModKey.MakeFormKey(0x1391d);
        }
    }
}
