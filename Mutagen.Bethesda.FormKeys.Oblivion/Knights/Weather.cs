using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Weather
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeatherGetter> NDSkyBattleWeatherNEW => Construct(0xfd3);
            public static FormLink<IWeatherGetter> NDSkyBattleWeatherOLD => Construct(0xfd4);
            public static FormLink<IWeatherGetter> ND08Fog => Construct(0xfd5);
        }
    }
}
