// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class AnimatedObject
    {
        private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAnimatedObjectGetter> AnimObjectDLC06PryBar => Construct(0x1122);
        public static FormLink<IAnimatedObjectGetter> AO_SodaStationCupC => Construct(0x58a2);
        public static FormLink<IAnimatedObjectGetter> AO_SodaStationCupB => Construct(0x58a1);
        public static FormLink<IAnimatedObjectGetter> AO_SodaStationCupA => Construct(0x58a0);
    }
}
