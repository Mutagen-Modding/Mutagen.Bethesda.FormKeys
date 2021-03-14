using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Faction
        {
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> NDOriginalKnightsFaction => Construct(0xce8);
            public static FormLink<IFactionGetter> NDGarlasMalatarVeterans => Construct(0xce9);
            public static FormLink<IFactionGetter> NDPredators => Construct(0xcea);
            public static FormLink<IFactionGetter> NDGhostKnightFaction => Construct(0xceb);
            public static FormLink<IFactionGetter> ND10MinionFaction => Construct(0xcec);
            public static FormLink<IFactionGetter> NDSirRodericFaction => Construct(0xced);
            public static FormLink<IFactionGetter> NDKnightsoftheNine => Construct(0xcee);
        }
    }
}
