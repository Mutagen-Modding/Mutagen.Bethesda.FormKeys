using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class PlacedNpc
        {
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> NDAmragorRef => Construct(0x11f6);
            public static FormLink<IPlacedNpcGetter> NDSirThedretRef => Construct(0x1443);
            public static FormLink<IPlacedNpcGetter> NDKellenRef => Construct(0x11ff);
            public static FormLink<IPlacedNpcGetter> NDChardeRef => Construct(0x13e4);
            public static FormLink<IPlacedNpcGetter> ND08ErrandilDeadREF => Construct(0x1418);
            public static FormLink<IPlacedNpcGetter> NDTalk1Ref => Construct(0x16d5);
            public static FormLink<IPlacedNpcGetter> NDTalk2Ref => Construct(0x16d4);
            public static FormLink<IPlacedNpcGetter> NDFemaleNPC1 => Construct(0x16d3);
            public static FormLink<IPlacedNpcGetter> NDCarodusOholinRef => Construct(0x16e1);
            public static FormLink<IPlacedNpcGetter> NDAronVerethiRef => Construct(0x16dc);
            public static FormLink<IPlacedNpcGetter> TB => Construct(0x1bfd);
            public static FormLink<IPlacedNpcGetter> NDErisSenimRef => Construct(0x1c00);
            public static FormLink<IPlacedNpcGetter> NDBeemKiurzRef => Construct(0x1bff);
            public static FormLink<IPlacedNpcGetter> NDSirAmielREF => Construct(0x1c79);
            public static FormLink<IPlacedNpcGetter> NDSirJuncanREF => Construct(0x1c78);
            public static FormLink<IPlacedNpcGetter> NDSirHenrikREF => Construct(0x1c77);
            public static FormLink<IPlacedNpcGetter> NDSirRalvasREF => Construct(0x1c76);
            public static FormLink<IPlacedNpcGetter> NDSirCasimirREF => Construct(0x1c75);
            public static FormLink<IPlacedNpcGetter> NDSirGregoryREF => Construct(0x1c74);
            public static FormLink<IPlacedNpcGetter> NDSirTorolfREF => Construct(0x1c73);
            public static FormLink<IPlacedNpcGetter> NDSirCaiusREF => Construct(0x1c72);
            public static FormLink<IPlacedNpcGetter> NDSirBerichREF => Construct(0x1c71);
            public static FormLink<IPlacedNpcGetter> NDKnight1GenericREF => Construct(0x1a8f);
            public static FormLink<IPlacedNpcGetter> NDKnight2GenericREF => Construct(0x1a8e);
            public static FormLink<IPlacedNpcGetter> NDKnight3GenericREF => Construct(0x1a8d);
            public static FormLink<IPlacedNpcGetter> NDKnight4GenericREF => Construct(0x1a8c);
            public static FormLink<IPlacedNpcGetter> NDKnight5GenericREF => Construct(0x1a8b);
            public static FormLink<IPlacedNpcGetter> NDKnight6GenericREF => Construct(0x1a8a);
            public static FormLink<IPlacedNpcGetter> NDKnight7GenericREF => Construct(0x1a89);
            public static FormLink<IPlacedNpcGetter> NDKnight8GenericREF => Construct(0x1a88);
            public static FormLink<IPlacedNpcGetter> NDSergiusTerrianusRef => Construct(0x1a85);
            public static FormLink<IPlacedNpcGetter> NDKintherRef => Construct(0x1cf0);
            public static FormLink<IPlacedNpcGetter> NDEsbernRef => Construct(0x1cef);
            public static FormLink<IPlacedNpcGetter> NDIniusColusRef => Construct(0x1cee);
            public static FormLink<IPlacedNpcGetter> NDAreldurRef => Construct(0x21fa);
            public static FormLink<IPlacedNpcGetter> ND01PelinalGhostREF => Construct(0x26a6);
            public static FormLink<IPlacedNpcGetter> NDAvitaVesniaRef => Construct(0x26a1);
            public static FormLink<IPlacedNpcGetter> NDSirRodericREF => Construct(0x269a);
            public static FormLink<IPlacedNpcGetter> NDLathonREF => Construct(0x2699);
            public static FormLink<IPlacedNpcGetter> NDJesperRef => Construct(0x2691);
            public static FormLink<IPlacedNpcGetter> NDStanetRef => Construct(0x2690);
            public static FormLink<IPlacedNpcGetter> ND05ConjurerExteriorRef => Construct(0x268b);
            public static FormLink<IPlacedNpcGetter> NDGeimundREF => Construct(0x2687);
            public static FormLink<IPlacedNpcGetter> NDGukimirREF => Construct(0x2686);
            public static FormLink<IPlacedNpcGetter> NDBrellinRef => Construct(0x267d);
            public static FormLink<IPlacedNpcGetter> NDProphetREF => Construct(0x28f5);
        }
    }
}
