// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class MehrunesRazor
{
    public static class EffectShader
    {
        private static FormLink<IEffectShaderGetter> Construct(uint id) => new FormLink<IEffectShaderGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IEffectShaderGetter> DL9ChampShader => Construct(0x1a22);
        public static FormLink<IEffectShaderGetter> DL9ChampDeathFX => Construct(0x2716);
    }
}
