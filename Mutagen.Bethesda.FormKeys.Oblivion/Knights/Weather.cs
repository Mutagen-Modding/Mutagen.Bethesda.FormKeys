// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Knights
{
    public static class Weather
    {
        private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWeatherGetter> NDSkyBattleWeatherNEW => Construct(0xfd3);
        public static FormLink<IWeatherGetter> NDSkyBattleWeatherOLD => Construct(0xfd4);
        public static FormLink<IWeatherGetter> ND08Fog => Construct(0xfd5);
    }
}
