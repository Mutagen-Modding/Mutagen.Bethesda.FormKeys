using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Climate
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<IClimateGetter> Construct(uint id) => new FormLink<IClimateGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClimateGetter> SEWaitingRoomClimate => Construct(0x7d13a);
            public static FormLink<IClimateGetter> SEOrderedFringeClimate => Construct(0x68f45);
            public static FormLink<IClimateGetter> SEWorldClimate => Construct(0x44f57);
            public static FormLink<IClimateGetter> ClimateSigil => Construct(0xc099a);
            public static FormLink<IClimateGetter> MQTempleWeather => Construct(0x94041);
            public static FormLink<IClimateGetter> MQ16Oblivionclimate => Construct(0x6bc8c);
            public static FormLink<IClimateGetter> MQ14OblivionClimate => Construct(0x6a9a1);
            public static FormLink<IClimateGetter> TamrielClimate => Construct(0x688e2);
            public static FormLink<IClimateGetter> OblivionMountains => Construct(0x671a0);
            public static FormLink<IClimateGetter> MS14Climate => Construct(0x18bcd0);
            public static FormLink<IClimateGetter> TestOblivionStorm2 => Construct(0x836d6);
            public static FormLink<IClimateGetter> OblivionTESTclimate => Construct(0x9c453);
            public static FormLink<IClimateGetter> ThunderstormClimate => Construct(0x97f8e);
            public static FormLink<IClimateGetter> ClearClimate => Construct(0x97c60);
            public static FormLink<IClimateGetter> PalePassWorldClimate => Construct(0x836da);
            public static FormLink<IClimateGetter> AllWeather => Construct(0x473f9);
            public static FormLink<IClimateGetter> DefaultClimate => Construct(0x15f);
            public static FormLink<IClimateGetter> CamoranClimate => Construct(0x370cf);
            public static FormLink<IClimateGetter> Obliviondefaultclimate => Construct(0x32e16);
        }
    }
}
