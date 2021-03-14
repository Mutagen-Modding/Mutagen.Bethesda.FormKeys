using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Grass
        {
            private static FormLink<IGrassGetter> Construct(uint id) => new FormLink<IGrassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGrassGetter> DGrass03 => Construct(0x50aa0);
            public static FormLink<IGrassGetter> DSeaGrass01 => Construct(0x43de4);
            public static FormLink<IGrassGetter> MSeaGrass01 => Construct(0x43de1);
            public static FormLink<IGrassGetter> DGrass02 => Construct(0x1b013);
            public static FormLink<IGrassGetter> DGrass01 => Construct(0x1b012);
            public static FormLink<IGrassGetter> MGrass03 => Construct(0x1affe);
            public static FormLink<IGrassGetter> MGrassFern02 => Construct(0x1affd);
            public static FormLink<IGrassGetter> MGrassFern01 => Construct(0x1affc);
            public static FormLink<IGrassGetter> PlantsJMGorseGrass01 => Construct(0xc8b3);
            public static FormLink<IGrassGetter> OblivionBurntgrass01 => Construct(0xc7964);
            public static FormLink<IGrassGetter> GroundCoverBWMediumGrass01 => Construct(0x6554b);
            public static FormLink<IGrassGetter> BWCattail01BelowSeaLevel => Construct(0x184e2d);
            public static FormLink<IGrassGetter> UnderWaterSeaWeed02 => Construct(0x11a314);
            public static FormLink<IGrassGetter> UnderWaterSeaWeed01 => Construct(0x11a313);
            public static FormLink<IGrassGetter> UnderWaterSeaGrass01 => Construct(0x11a312);
            public static FormLink<IGrassGetter> GroundCoverHeatherBlue => Construct(0x115df4);
            public static FormLink<IGrassGetter> GroundCoverHeatherPurple => Construct(0x115df3);
            public static FormLink<IGrassGetter> GroundCoverMediumGrass02 => Construct(0x115df2);
            public static FormLink<IGrassGetter> WWSageGrassPurple02 => Construct(0x115de0);
            public static FormLink<IGrassGetter> WWSageGrassPurple01 => Construct(0x115ddf);
            public static FormLink<IGrassGetter> WWSageGrassRed01 => Construct(0x115ddd);
            public static FormLink<IGrassGetter> WWSageGrass01 => Construct(0x115dd0);
            public static FormLink<IGrassGetter> BWCattail03 => Construct(0xff65d);
            public static FormLink<IGrassGetter> BRMediumGrassYellow01 => Construct(0xff5e4);
            public static FormLink<IGrassGetter> GroundCoverNVLongGrass01 => Construct(0xe7823);
            public static FormLink<IGrassGetter> GroundCoverNVMediumGrass01 => Construct(0xe7820);
            public static FormLink<IGrassGetter> NVFern01 => Construct(0xe781f);
            public static FormLink<IGrassGetter> GCGorseGrassYellow02 => Construct(0xc8ba2);
            public static FormLink<IGrassGetter> GCGorseGrassWhite02 => Construct(0xc8ba1);
            public static FormLink<IGrassGetter> GCGorseGrassOrange02 => Construct(0xc8ba0);
            public static FormLink<IGrassGetter> GCGorseGrass02 => Construct(0xc8b9f);
            public static FormLink<IGrassGetter> CPFern06 => Construct(0x9063c);
            public static FormLink<IGrassGetter> CPFern05 => Construct(0x9063b);
            public static FormLink<IGrassGetter> GCGorseGrassOrange01 => Construct(0x3abf0);
            public static FormLink<IGrassGetter> GCGorseGrassWhite01 => Construct(0x3abea);
            public static FormLink<IGrassGetter> GCGorseGrassYellow01 => Construct(0x3abe6);
            public static FormLink<IGrassGetter> GCGorseGrass01 => Construct(0x3abe1);
            public static FormLink<IGrassGetter> BWFern06 => Construct(0x8e0a0);
            public static FormLink<IGrassGetter> BWGroundCover03 => Construct(0x8e09f);
            public static FormLink<IGrassGetter> CPGroundCover03 => Construct(0x8c281);
            public static FormLink<IGrassGetter> CPFern02 => Construct(0x8c280);
            public static FormLink<IGrassGetter> CPGroundCoverHeatherWhite => Construct(0x5dcec);
            public static FormLink<IGrassGetter> CPGroundCoverHeatherPink => Construct(0x5dceb);
            public static FormLink<IGrassGetter> CPGroundCover02 => Construct(0x5dce7);
            public static FormLink<IGrassGetter> CPGroundCover01 => Construct(0x5dce6);
            public static FormLink<IGrassGetter> CPFern04 => Construct(0x5dce5);
            public static FormLink<IGrassGetter> CPFern03 => Construct(0x5dce4);
            public static FormLink<IGrassGetter> CPFern01 => Construct(0x5dce3);
            public static FormLink<IGrassGetter> GroundCoverHeatherRed => Construct(0x9dab5);
            public static FormLink<IGrassGetter> GroundCoverHeatherWhite => Construct(0x9dab4);
            public static FormLink<IGrassGetter> GroundCoverHeatherPink => Construct(0x9dab3);
            public static FormLink<IGrassGetter> BWCattail02 => Construct(0x984c9);
            public static FormLink<IGrassGetter> BWCattail01 => Construct(0x984c8);
            public static FormLink<IGrassGetter> PlantsGroundCoverGCPineappleWeed01 => Construct(0x91c46);
            public static FormLink<IGrassGetter> PlantsGroundCoverGCPineappleWeed02 => Construct(0x91c45);
            public static FormLink<IGrassGetter> GCPoppyYellowSU02 => Construct(0x91a66);
            public static FormLink<IGrassGetter> GCPoppyOrangeSU02 => Construct(0x91a65);
            public static FormLink<IGrassGetter> GCPoppyRedSU02 => Construct(0x91a64);
            public static FormLink<IGrassGetter> GCLongGrass06 => Construct(0x91a63);
            public static FormLink<IGrassGetter> GCLongGrass05 => Construct(0x91a62);
            public static FormLink<IGrassGetter> GCLongGrass04 => Construct(0x91a61);
            public static FormLink<IGrassGetter> JMMediumGrassSnow02 => Construct(0x3cecf);
            public static FormLink<IGrassGetter> JMMediumGrassSnow01 => Construct(0x3cece);
            public static FormLink<IGrassGetter> JMMediumGrass02 => Construct(0x3cecd);
            public static FormLink<IGrassGetter> JMMediumGrass01 => Construct(0x3cecc);
            public static FormLink<IGrassGetter> BWGroundCover02 => Construct(0x3ceca);
            public static FormLink<IGrassGetter> BWGroundCover01 => Construct(0x3cec9);
            public static FormLink<IGrassGetter> BWFern05 => Construct(0x3cec8);
            public static FormLink<IGrassGetter> BWFern04 => Construct(0x3cec7);
            public static FormLink<IGrassGetter> BWFern03 => Construct(0x3cec6);
            public static FormLink<IGrassGetter> BWFern02 => Construct(0x3cec5);
            public static FormLink<IGrassGetter> BWFern01 => Construct(0x3cec4);
            public static FormLink<IGrassGetter> OblivionMoldGrass01 => Construct(0x228dd);
            public static FormLink<IGrassGetter> GCLongGrass03 => Construct(0x1ff20);
            public static FormLink<IGrassGetter> GCPoppyOrangeSU => Construct(0x1ff19);
            public static FormLink<IGrassGetter> GCPoppyYellowSU => Construct(0x1ff18);
            public static FormLink<IGrassGetter> GCPoppyRedSU => Construct(0x1ff17);
            public static FormLink<IGrassGetter> GCLongGrass02 => Construct(0x1e552);
            public static FormLink<IGrassGetter> GCLongGrass01 => Construct(0x1d44d);
            public static FormLink<IGrassGetter> MS14WildDaisy06 => Construct(0x162a0);
            public static FormLink<IGrassGetter> MS14WildDaisy05 => Construct(0x1629f);
            public static FormLink<IGrassGetter> MS14WildDaisy04 => Construct(0x1629e);
            public static FormLink<IGrassGetter> MS14WildDaisy03 => Construct(0x1629d);
            public static FormLink<IGrassGetter> MS14WildDaisy02 => Construct(0x1629c);
            public static FormLink<IGrassGetter> MS14WildDaisy01 => Construct(0x1629b);
            public static FormLink<IGrassGetter> MS14LongGrass01 => Construct(0x1629a);
            public static FormLink<IGrassGetter> GroundCoverGroundIvy02 => Construct(0x9741);
            public static FormLink<IGrassGetter> GroundCoverGroundIvy01 => Construct(0x35a11);
            public static FormLink<IGrassGetter> GroundCoverWildPlant02 => Construct(0x28f43);
            public static FormLink<IGrassGetter> GroundCoverWildPlant03 => Construct(0x28f42);
            public static FormLink<IGrassGetter> GroundCoverWildPlant04 => Construct(0x28f41);
            public static FormLink<IGrassGetter> GroundCoverWildPlant05 => Construct(0x28f40);
            public static FormLink<IGrassGetter> TestToddWeeds03B => Construct(0x28cef);
            public static FormLink<IGrassGetter> TestToddWeeds03A => Construct(0x28cee);
            public static FormLink<IGrassGetter> TestToddMediumGrass => Construct(0x28ced);
            public static FormLink<IGrassGetter> TestToddLongGrass => Construct(0x28cec);
            public static FormLink<IGrassGetter> GroundCoverPineappleWeed01 => Construct(0x2506b);
            public static FormLink<IGrassGetter> GroundCoverPineappleWeed02 => Construct(0x2506a);
            public static FormLink<IGrassGetter> GroundCoverMediumGrass01 => Construct(0x25068);
            public static FormLink<IGrassGetter> GroundCoverWildDaisy06 => Construct(0x262fc);
            public static FormLink<IGrassGetter> GroundCoverWildDaisy05 => Construct(0x262fb);
            public static FormLink<IGrassGetter> GroundCoverWildDaisy04 => Construct(0x262fa);
            public static FormLink<IGrassGetter> GroundCoverWildDaisy03 => Construct(0x262f9);
            public static FormLink<IGrassGetter> GroundCoverWildDaisy02 => Construct(0x262f8);
            public static FormLink<IGrassGetter> GroundCoverWildDaisy01 => Construct(0x262f7);
            public static FormLink<IGrassGetter> GroundCoverWildPlant01 => Construct(0x262f6);
            public static FormLink<IGrassGetter> GroundCoverLongGrass01 => Construct(0x262e9);
            public static FormLink<IGrassGetter> GroundCoverFern01 => Construct(0x262e7);
        }
    }
}
