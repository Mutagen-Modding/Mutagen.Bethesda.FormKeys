// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class LandscapeTexture
    {
        private static FormLink<ILandscapeTextureGetter> Construct(uint id) => new FormLink<ILandscapeTextureGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILandscapeTextureGetter> LDLC04HillGrass01NoGrass => Construct(0xd371);
        public static FormLink<ILandscapeTextureGetter> LDLC04HillPath01 => Construct(0xb900);
        public static FormLink<ILandscapeTextureGetter> LDLC04HillGrass01Shrubs01 => Construct(0xb8fd);
        public static FormLink<ILandscapeTextureGetter> LDLC04ValleyGrass01Shrubs01 => Construct(0xab06);
        public static FormLink<ILandscapeTextureGetter> LDLC04HillDirt01Grass01 => Construct(0xa6d9);
        public static FormLink<ILandscapeTextureGetter> LDLC04ValleyDirt01Grass02 => Construct(0xa6ce);
        public static FormLink<ILandscapeTextureGetter> LDLC04ValleyDirt01Grass01 => Construct(0xa6cd);
        public static FormLink<ILandscapeTextureGetter> LDLC04HillGrass01 => Construct(0xa4b2);
        public static FormLink<ILandscapeTextureGetter> LDLC04HillDirt01 => Construct(0xa4ad);
        public static FormLink<ILandscapeTextureGetter> LDLC04WetMud01 => Construct(0x9a33);
        public static FormLink<ILandscapeTextureGetter> LDLC04ValleyGrass01NoGrass => Construct(0x9a2b);
        public static FormLink<ILandscapeTextureGetter> LDLC04ValleyGrass01 => Construct(0x9a2a);
        public static FormLink<ILandscapeTextureGetter> LDLC04ValleyDirt01 => Construct(0x9a24);
        public static FormLink<ILandscapeTextureGetter> LDLC04CrackedMud01NoGrass => Construct(0x87aa);
        public static FormLink<ILandscapeTextureGetter> LDLC04CrackedMud01 => Construct(0x87a9);
    }
}
