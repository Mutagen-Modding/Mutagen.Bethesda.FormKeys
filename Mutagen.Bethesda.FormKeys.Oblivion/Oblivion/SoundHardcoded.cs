using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Oblivion
{
    public static partial class Sound
    {
        public static FormLink<ISoundGetter> MagicEnchantDrawSoundAlteration => Construct(0x138);
        public static FormLink<ISoundGetter> MagicEnchantDrawSoundConjuration => Construct(0x139);
        public static FormLink<ISoundGetter> MagicEnchantDrawSoundDestruction => Construct(0x13A);
        public static FormLink<ISoundGetter> MagicEnchantDrawSoundIllusion => Construct(0x13B);
        public static FormLink<ISoundGetter> MagicEnchantDrawSoundMysticism => Construct(0x13C);
        public static FormLink<ISoundGetter> MagicEnchantDrawSoundRestoration => Construct(0x13D);
        public static FormLink<ISoundGetter> MagicEnchantHitSoundAlteration => Construct(0x13E);
        public static FormLink<ISoundGetter> MagicEnchantHitSoundConjuration => Construct(0x13F);
        public static FormLink<ISoundGetter> MagicEnchantHitSoundDestruction => Construct(0x140);
        public static FormLink<ISoundGetter> MagicEnchantHitSoundIllusion => Construct(0x141);
        public static FormLink<ISoundGetter> MagicEnchantHitSoundMysticism => Construct(0x142);
        public static FormLink<ISoundGetter> MagicEnchantHitSoundRestoration => Construct(0x143);
    }
}