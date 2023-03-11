// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class AudioEffectChain
    {
        private static FormLink<IAudioEffectChainGetter> Construct(uint id) => new FormLink<IAudioEffectChainGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAudioEffectChainGetter> DLC04AudioEffectChainPAOswald => Construct(0x56eaf);
        public static FormLink<IAudioEffectChainGetter> DLC04AudioEffectChainInWorldRadioRedEye => Construct(0x5618f);
        public static FormLink<IAudioEffectChainGetter> DLC04AudioEffectChainMonorailSpeakerDelay => Construct(0x4a8e6);
        public static FormLink<IAudioEffectChainGetter> DLC04AudioEffectChainGauntletSpeakerSystemDelay => Construct(0x36658);
    }
}