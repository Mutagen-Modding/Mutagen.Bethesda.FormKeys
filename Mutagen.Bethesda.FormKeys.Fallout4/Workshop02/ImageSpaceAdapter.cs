// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class ImageSpaceAdapter
    {
        private static FormLink<IImageSpaceAdapterGetter> Construct(uint id) => new FormLink<IImageSpaceAdapterGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImageSpaceAdapterGetter> DLC05ExplosionWeatherRainImod => Construct(0xf2e);
        public static FormLink<IImageSpaceAdapterGetter> DLC05ExplosionWeatherRadImod => Construct(0xf2d);
        public static FormLink<IImageSpaceAdapterGetter> DLC05ExplosionWeatherClearImod => Construct(0xf2c);
    }
}
