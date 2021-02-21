using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IEffectShaderGetter> Construct(uint id) => new FormLink<IEffectShaderGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEffectShaderGetter> DL9ChampShader => Construct(0x1a22);
            public static FormLink<IEffectShaderGetter> DL9ChampDeathFX => Construct(0x2716);
        }
    }
}
