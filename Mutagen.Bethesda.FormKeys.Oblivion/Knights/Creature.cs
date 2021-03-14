using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Creature
        {
            private static FormLink<ICreatureGetter> Construct(uint id) => new FormLink<ICreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICreatureGetter> ND04Auroran5 => Construct(0xf89);
            public static FormLink<ICreatureGetter> ND04Auroran4 => Construct(0xf8a);
            public static FormLink<ICreatureGetter> ND04Auroran3 => Construct(0xf8b);
            public static FormLink<ICreatureGetter> ND04Auroran2 => Construct(0xf8c);
            public static FormLink<ICreatureGetter> ND04Auroran1 => Construct(0xf8d);
            public static FormLink<ICreatureGetter> ND08Auroran5 => Construct(0xf8e);
            public static FormLink<ICreatureGetter> ND08Auroran4 => Construct(0xf8f);
            public static FormLink<ICreatureGetter> ND08Auroran3 => Construct(0xf90);
            public static FormLink<ICreatureGetter> ND08Auroran2 => Construct(0xf91);
            public static FormLink<ICreatureGetter> ND08Auroran1 => Construct(0xf92);
            public static FormLink<ICreatureGetter> TestNDAyleidMinionCreatures => Construct(0xf93);
            public static FormLink<ICreatureGetter> TestNDAyleidBossCreatures => Construct(0xf94);
            public static FormLink<ICreatureGetter> ND10AuroranOrbStayTEMPLATE => Construct(0xf95);
            public static FormLink<ICreatureGetter> ND08Wraith5 => Construct(0xf96);
            public static FormLink<ICreatureGetter> ND08Wraith4 => Construct(0xf97);
            public static FormLink<ICreatureGetter> ND08Wraith3 => Construct(0xf98);
            public static FormLink<ICreatureGetter> ND08Wraith2 => Construct(0xf99);
            public static FormLink<ICreatureGetter> NDUmaril1 => Construct(0xf9a);
            public static FormLink<ICreatureGetter> NDUmaril8 => Construct(0xf9b);
            public static FormLink<ICreatureGetter> NDUmaril7 => Construct(0xf9c);
            public static FormLink<ICreatureGetter> NDUmaril6 => Construct(0xf9d);
            public static FormLink<ICreatureGetter> NDUmaril5 => Construct(0xf9e);
            public static FormLink<ICreatureGetter> NDUmaril4 => Construct(0xf9f);
            public static FormLink<ICreatureGetter> NDUmaril3 => Construct(0xfa0);
            public static FormLink<ICreatureGetter> NDUmaril2 => Construct(0xfa1);
            public static FormLink<ICreatureGetter> NDAuroran5 => Construct(0xfa2);
            public static FormLink<ICreatureGetter> NDAuroran4 => Construct(0xfa3);
            public static FormLink<ICreatureGetter> NDAuroran3 => Construct(0xfa4);
            public static FormLink<ICreatureGetter> NDAuroran1 => Construct(0xfa5);
            public static FormLink<ICreatureGetter> NDAuroran2 => Construct(0xfa6);
            public static FormLink<ICreatureGetter> NDPrioryHorsePaint => Construct(0xfa7);
            public static FormLink<ICreatureGetter> NDPrioryHorseBay => Construct(0xfa8);
            public static FormLink<ICreatureGetter> NDPrioryHorseChestnut => Construct(0xfa9);
            public static FormLink<ICreatureGetter> ND10AuroranBattleTEMPLATE => Construct(0xfaa);
            public static FormLink<ICreatureGetter> ND10AuroranOrbRunTEMPLATE => Construct(0xfab);
            public static FormLink<ICreatureGetter> ND08Minion => Construct(0xfac);
            public static FormLink<ICreatureGetter> NDKynarethSpriggan => Construct(0xfad);
            public static FormLink<ICreatureGetter> ND10AuroranLieutenantTEMPLATE => Construct(0xfae);
            public static FormLink<ICreatureGetter> ND04Minion => Construct(0xfaf);
            public static FormLink<ICreatureGetter> ND03Bear => Construct(0xfb0);
            public static FormLink<ICreatureGetter> ND10UmarilRealTEMPLATE => Construct(0xfb1);
            public static FormLink<ICreatureGetter> ND08Wraith1 => Construct(0xfb2);
            public static FormLink<ICreatureGetter> ND01SirAmielSkeleton => Construct(0xfb3);
            public static FormLink<ICreatureGetter> ND10UmarilSpiritTEMPLATE => Construct(0xfb4);
        }
    }
}
