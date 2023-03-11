// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static class Weather
    {
        private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWeatherGetter> DLC05CommonwealthGSRadstormFastTransition => Construct(0xa4f);
        public static FormLink<IWeatherGetter> DLC05CommonwealthRainFastTransition => Construct(0xa4e);
        public static FormLink<IWeatherGetter> DLC05CommonwealthClearFastTransition => Construct(0xa4d);
    }
}