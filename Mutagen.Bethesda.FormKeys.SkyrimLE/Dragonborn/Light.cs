using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Light
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightGetter> DLC2BulwarkCaveLight02 => Construct(0x3d4ab);
            public static FormLink<ILightGetter> DLC2BulwarkCaveLight => Construct(0x3d4a8);
            public static FormLink<ILightGetter> DLC2RedoranShadowLight02 => Construct(0x3cf1e);
            public static FormLink<ILightGetter> DLC2SpiderEggLight => Construct(0x3ac61);
            public static FormLink<ILightGetter> DLC2ApoMagicLight02 => Construct(0x39007);
            public static FormLink<ILightGetter> DLC2ApoMagicLight01 => Construct(0x39006);
            public static FormLink<ILightGetter> DLC2FXLightElectricBlueGlowDUPLICATE001 => Construct(0x38839);
            public static FormLink<ILightGetter> DLC2FXLightElectricBlueGlow => Construct(0x3770b);
            public static FormLink<ILightGetter> DefaultCandleLight01_DesatFXExtraDark => Construct(0x35c9e);
            public static FormLink<ILightGetter> DLC2RedoranShadowLight01 => Construct(0x3523f);
            public static FormLink<ILightGetter> DLC2RRLightForgeFire01 => Construct(0x33970);
            public static FormLink<ILightGetter> DLC2RedoranLight01 => Construct(0x336e8);
            public static FormLink<ILightGetter> DLC2RedoranFireLight01 => Construct(0x336e7);
            public static FormLink<ILightGetter> DLC2MagicSmallLightFireInHand => Construct(0x3280c);
            public static FormLink<ILightGetter> DLC2ApoMagicLight02NS => Construct(0x327bf);
            public static FormLink<ILightGetter> DLC2ApoMagicLight01NS => Construct(0x327af);
            public static FormLink<ILightGetter> DLC2HighPointGlowLight => Construct(0x32691);
            public static FormLink<ILightGetter> DLC2APOMovingLightShadowNOSCRIPT => Construct(0x325d9);
            public static FormLink<ILightGetter> DLC2APOMovingLightNoShadowNOSCRIPT => Construct(0x325d8);
            public static FormLink<ILightGetter> DLC2DwarvenOmniLight_Desat => Construct(0x30ce9);
            public static FormLink<ILightGetter> DLC2IceCaveBlueDesatShad => Construct(0x2bca5);
            public static FormLink<ILightGetter> DLC2IceCaveBlueDesat => Construct(0x2bca4);
            public static FormLink<ILightGetter> DLC2CZLightTorch01 => Construct(0x2b5fd);
            public static FormLink<ILightGetter> DLC2CZLightTorchShadow01 => Construct(0x2b5fb);
            public static FormLink<ILightGetter> DLC2CZLightCampFireShadow01 => Construct(0x2acf6);
            public static FormLink<ILightGetter> DLC2ExpSpiderGlowingLight => Construct(0x27484);
            public static FormLink<ILightGetter> DLC2APOMovingLightNoShadow => Construct(0x1ea7d);
            public static FormLink<ILightGetter> DLC2APOMovingLightShadow => Construct(0x1ea79);
            public static FormLink<ILightGetter> DLC2dunKolbjornRitualLight => Construct(0x1dbc2);
        }
    }
}
