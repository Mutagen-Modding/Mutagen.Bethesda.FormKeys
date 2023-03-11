// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class AnimatedObject
    {
        private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAnimatedObjectGetter> AnimObjectNPCBeerChug => Construct(0x4b660);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFPNukaColaCherry => Construct(0x44dac);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFPNukaColaQuantum => Construct(0x44da9);
        public static FormLink<IAnimatedObjectGetter> DLC04AnimObjectHandmadeARMagazine => Construct(0x36f6b);
        public static FormLink<IAnimatedObjectGetter> DLC04AnimObjectHandmadeARBolt => Construct(0x36f6a);
        public static FormLink<IAnimatedObjectGetter> DLC04AnimObjectHandmadeAR => Construct(0x36f69);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFish => Construct(0x341a3);
        public static FormLink<IAnimatedObjectGetter> DLC04AnimObjectBook => Construct(0x253a6);
        public static FormLink<IAnimatedObjectGetter> DLC04AnimObjectDishRag => Construct(0x21d95);
        public static FormLink<IAnimatedObjectGetter> AnimObjectDLC04SacKnife => Construct(0x20186);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFPNukaColaCap => Construct(0x1e963);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFPNukaCola => Construct(0x1e962);
        public static FormLink<IAnimatedObjectGetter> AnimObjectNukaColaEmpty => Construct(0x19518);
    }
}