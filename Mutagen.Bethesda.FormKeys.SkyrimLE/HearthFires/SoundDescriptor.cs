// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class HearthFires
{
    public static partial class SoundDescriptor
    {
        private static FormLink<ISoundDescriptorGetter> Construct(uint id) => new FormLink<ISoundDescriptorGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundDescriptorGetter> OBJMineClaySD => Construct(0xba3);
        public static FormLink<ISoundDescriptorGetter> NPCHumanWorkbenchHammerDistant => Construct(0x17ecc);
        public static FormLink<ISoundDescriptorGetter> NPCHumanWorkbenchHammer => Construct(0x17ecb);
        public static FormLink<ISoundDescriptorGetter> WPNWoodSwordDrawSD => Construct(0x14c2b);
        public static FormLink<ISoundDescriptorGetter> WPNImpact1HandWoodSwordBluntGeneric => Construct(0x14c2a);
        public static FormLink<ISoundDescriptorGetter> WPNWoodSwordSheatheSD => Construct(0x8991);
        public static FormLink<ISoundDescriptorGetter> WPNSwing1HandWoodSwordSD => Construct(0x8990);
        public static FormLink<ISoundDescriptorGetter> WPNImpact1HandWoodSwordvsDummy => Construct(0x898f);
    }
}
