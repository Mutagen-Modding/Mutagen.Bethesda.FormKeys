// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class Weather
    {
        private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWeatherGetter> DLC04NukaWorldClearDustyOLD => Construct(0x4f57b);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClearBackup2 => Construct(0x4f57a);
        public static FormLink<IWeatherGetter> DLC04NukaWorldEndGameDark => Construct(0x43b70);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClear_Trailer => Construct(0x396a3);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClear_Trailer2 => Construct(0x396a2);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClearDusty => Construct(0x367ca);
        public static FormLink<IWeatherGetter> DLC04NukaWorldDust => Construct(0x30ace);
        public static FormLink<IWeatherGetter> DLC04NukaWorldRain => Construct(0x30acd);
        public static FormLink<IWeatherGetter> DLC04NukaWorldRainBackup2 => Construct(0x30acc);
        public static FormLink<IWeatherGetter> DLC04NukaWorldDustBackup2 => Construct(0x30acb);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClearBackup => Construct(0x30aca);
        public static FormLink<IWeatherGetter> DLC04NukaWorldRainBackup => Construct(0x30ac8);
        public static FormLink<IWeatherGetter> DLC04NukaWorldDustBackup => Construct(0x30ac7);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClearMarkT => Construct(0x30ac6);
        public static FormLink<IWeatherGetter> DLC04NukaWorldDustMarkT => Construct(0x1fab4);
        public static FormLink<IWeatherGetter> DLC04NukaWorldRainMarkT => Construct(0xc60b);
        public static FormLink<IWeatherGetter> DLC04NukaWorldClear => Construct(0x7e3b);
    }
}
