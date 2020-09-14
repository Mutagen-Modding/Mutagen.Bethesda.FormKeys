namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Weather
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey NDSkyBattleWeatherNEW => ModKey.MakeFormKey(0xfd3);
            public static FormKey NDSkyBattleWeatherOLD => ModKey.MakeFormKey(0xfd4);
            public static FormKey ND08Fog => ModKey.MakeFormKey(0xfd5);
        }
    }
}
