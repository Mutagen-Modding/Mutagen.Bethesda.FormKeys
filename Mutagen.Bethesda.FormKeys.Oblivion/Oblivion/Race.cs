namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Race
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            public static FormKey Sheogorath => ModKey.MakeFormKey(0x5308e);
            public static FormKey GoldenSaint => ModKey.MakeFormKey(0x1208f);
            public static FormKey DarkSeducer => ModKey.MakeFormKey(0x1208e);
            public static FormKey VampireRace => ModKey.MakeFormKey(0x19);
            public static FormKey Dremora => ModKey.MakeFormKey(0x38010);
            public static FormKey Argonian => ModKey.MakeFormKey(0x23fe9);
            public static FormKey Nord => ModKey.MakeFormKey(0x224fd);
            public static FormKey Breton => ModKey.MakeFormKey(0x224fc);
            public static FormKey WoodElf => ModKey.MakeFormKey(0x223c8);
            public static FormKey Khajiit => ModKey.MakeFormKey(0x223c7);
            public static FormKey DarkElf => ModKey.MakeFormKey(0x191c1);
            public static FormKey Orc => ModKey.MakeFormKey(0x191c0);
            public static FormKey HighElf => ModKey.MakeFormKey(0x19204);
            public static FormKey Redguard => ModKey.MakeFormKey(0xd43);
            public static FormKey Imperial => ModKey.MakeFormKey(0x907);
        }
    }
}
