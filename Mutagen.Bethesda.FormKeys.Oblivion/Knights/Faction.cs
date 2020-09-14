namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey NDOriginalKnightsFaction => ModKey.MakeFormKey(0xce8);
            public static FormKey NDGarlasMalatarVeterans => ModKey.MakeFormKey(0xce9);
            public static FormKey NDPredators => ModKey.MakeFormKey(0xcea);
            public static FormKey NDGhostKnightFaction => ModKey.MakeFormKey(0xceb);
            public static FormKey ND10MinionFaction => ModKey.MakeFormKey(0xcec);
            public static FormKey NDSirRodericFaction => ModKey.MakeFormKey(0xced);
            public static FormKey NDKnightsoftheNine => ModKey.MakeFormKey(0xcee);
        }
    }
}
