// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static class AudioEffectChain
    {
        private static FormLink<IAudioEffectChainGetter> Construct(uint id) => new FormLink<IAudioEffectChainGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAudioEffectChainGetter> DLC06AudioEffectChainVaultPA => Construct(0x563c);
    }
}