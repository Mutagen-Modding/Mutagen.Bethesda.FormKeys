using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class LandscapeTexture
        {
            private static FormLink<ILandscapeTextureGetter> Construct(uint id) => new FormLink<ILandscapeTextureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshTundra04 => Construct(0x1eecd);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshTundra03 => Construct(0x1bd21);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshTundra02 => Construct(0x1bd20);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshTundra01 => Construct(0x1bd1f);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshGrass01_NoGrass => Construct(0x17ea6);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAsh03 => Construct(0x17ea4);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshRocks01_NoRocks => Construct(0x17ea1);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshRocks01 => Construct(0x1771d);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAshGrass01 => Construct(0x1771b);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAsh02 => Construct(0x16e08);
            public static FormLink<ILandscapeTextureGetter> LVolcanicAsh01 => Construct(0x16e04);
        }
    }
}
