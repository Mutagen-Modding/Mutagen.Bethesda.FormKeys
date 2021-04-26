// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Weather
        {
            private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeatherGetter> DLC02VolcanicAshTundra01_A => Construct(0x374ba);
            public static FormLink<IWeatherGetter> DLC02VolcanicAsh02_A => Construct(0x374b9);
            public static FormLink<IWeatherGetter> DLC02VolcanicAsh01_A => Construct(0x374b8);
            public static FormLink<IWeatherGetter> DLC2ApocryphaWeatherNew => Construct(0x34cfb);
            public static FormLink<IWeatherGetter> DLC02VolcanicAshStorm01 => Construct(0x32336);
            public static FormLink<IWeatherGetter> DLC02VolcanicAsh02 => Construct(0x31ac0);
            public static FormLink<IWeatherGetter> DLC2ApocryphaWeather => Construct(0x1dff5);
            public static FormLink<IWeatherGetter> DLC02VolcanicAshTundra01 => Construct(0x1d760);
            public static FormLink<IWeatherGetter> DLC02VolcanicAsh01 => Construct(0x18471);
        }
    }
}
