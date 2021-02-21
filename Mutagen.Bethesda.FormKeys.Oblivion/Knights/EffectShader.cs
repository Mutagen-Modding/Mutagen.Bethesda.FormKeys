using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IEffectShaderGetter> Construct(uint id) => new FormLink<IEffectShaderGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEffectShaderGetter> ND05PlateEffect => Construct(0x2e64);
            public static FormLink<IEffectShaderGetter> NDSpiritEffect => Construct(0x2e65);
            public static FormLink<IEffectShaderGetter> ND05ItemEffect => Construct(0x2e66);
            public static FormLink<IEffectShaderGetter> NDGhostEffect => Construct(0x2e63);
        }
    }
}
