// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static class Weather
    {
        private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWeatherGetter> VRWorkshopShared_CommonwealthGSOvercastNoHazard => Construct(0x24a3c1);
        public static FormLink<IWeatherGetter> VRWorkshopShared_CommonwealthGSRadstormNoHazard => Construct(0x24a3c0);
        public static FormLink<IWeatherGetter> CommonwealthOvercast_VBFog => Construct(0x2486a5);
        public static FormLink<IWeatherGetter> CommonwealthClear_VBFog => Construct(0x2486a4);
        public static FormLink<IWeatherGetter> CommonwealthClearBackup2 => Construct(0x23ab9c);
        public static FormLink<IWeatherGetter> CommonwealthSanctuaryClearBackup => Construct(0x2392a6);
        public static FormLink<IWeatherGetter> CommonwealthMistyBackup => Construct(0x2392a5);
        public static FormLink<IWeatherGetter> CommonwealthGSFoggyBackup => Construct(0x2392a4);
        public static FormLink<IWeatherGetter> CommonwealthGSRadstormBackup => Construct(0x2392a3);
        public static FormLink<IWeatherGetter> CommonwealthFoggyBackup => Construct(0x2392a2);
        public static FormLink<IWeatherGetter> CommonwealthClear2 => Construct(0x2385fd);
        public static FormLink<IWeatherGetter> CommonwealthDarkSkies2 => Construct(0x2385fb);
        public static FormLink<IWeatherGetter> CommonwealthDarkSkies3 => Construct(0x226448);
        public static FormLink<IWeatherGetter> CommonwealthSanctuaryClearNoAttach => Construct(0x225922);
        public static FormLink<IWeatherGetter> CommonwealthRainBackup => Construct(0x22239a);
        public static FormLink<IWeatherGetter> CommonwealthGSRadstormOld => Construct(0x222394);
        public static FormLink<IWeatherGetter> CommonwealthClearTrailer2 => Construct(0x21a564);
        public static FormLink<IWeatherGetter> CommonwealthClearTrailer1 => Construct(0x21a563);
        public static FormLink<IWeatherGetter> CommonwealthClearBackup => Construct(0x216a98);
        public static FormLink<IWeatherGetter> CommonwealthMistyRainyBackup => Construct(0x2115d7);
        public static FormLink<IWeatherGetter> VideoVaultExit => Construct(0x211221);
        public static FormLink<IWeatherGetter> CommonwealthOvercastBackup => Construct(0x20f46c);
        public static FormLink<IWeatherGetter> CGPrewarNukeFXWeather => Construct(0x1f61fd);
        public static FormLink<IWeatherGetter> CommonwealthDusty => Construct(0x1f61a1);
        public static FormLink<IWeatherGetter> CommOvercastTest2 => Construct(0x1f2529);
        public static FormLink<IWeatherGetter> CommonwealthPolluted => Construct(0x1eb2ff);
        public static FormLink<IWeatherGetter> CommonwealthDarkSkies => Construct(0x1e5e60);
        public static FormLink<IWeatherGetter> CommonwealthClearestSkies => Construct(0x1d670e);
        public static FormLink<IWeatherGetter> FXWthrSunlightOffAtNightBlack => Construct(0x1d1cec);
        public static FormLink<IWeatherGetter> CommonwealthMistyRainy => Construct(0x1cd096);
        public static FormLink<IWeatherGetter> CommonwealthMisty => Construct(0x1cc186);
        public static FormLink<IWeatherGetter> CommonwealthRain => Construct(0x1ca7e4);
        public static FormLink<IWeatherGetter> CommonwealthOvercast => Construct(0x1c8556);
        public static FormLink<IWeatherGetter> CommonwealthGSRadstorm => Construct(0x1c3d5e);
        public static FormLink<IWeatherGetter> CommonwealthFoggy => Construct(0x1c3473);
        public static FormLink<IWeatherGetter> CommonwealthGSFoggy => Construct(0x1bd481);
        public static FormLink<IWeatherGetter> FXWthrSunlightOffAtNightGlass => Construct(0x171636);
        public static FormLink<IWeatherGetter> DefaultInteriorWeatherNoLUT => Construct(0x171621);
        public static FormLink<IWeatherGetter> CommonwealthSanctuaryClearNukeFog => Construct(0x1a6994);
        public static FormLink<IWeatherGetter> DefaultInteriorWeather => Construct(0x1a65f0);
        public static FormLink<IWeatherGetter> ConcMuseumWeather => Construct(0x1a65e5);
        public static FormLink<IWeatherGetter> FXWthrInvertDayNightGS => Construct(0x191647);
        public static FormLink<IWeatherGetter> FXWthrSunlightWhiteBounce => Construct(0x141ab4);
        public static FormLink<IWeatherGetter> CommonwealthSanctuaryClear => Construct(0x12a18e);
        public static FormLink<IWeatherGetter> FXNukeWeather => Construct(0x1256fb);
        public static FormLink<IWeatherGetter> NeutralOvercast => Construct(0x1209af);
        public static FormLink<IWeatherGetter> GoodneighborWeatherBase => Construct(0x115c64);
        public static FormLink<IWeatherGetter> TCommonwealthMarshOvercast => Construct(0x10f781);
        public static FormLink<IWeatherGetter> FXInstituteDayNightCycleKey => Construct(0x10d573);
        public static FormLink<IWeatherGetter> FXInstituteDayNightCycle => Construct(0x108640);
        public static FormLink<IWeatherGetter> PrewarPlayerHouseInteriorWeather => Construct(0xff98f);
        public static FormLink<IWeatherGetter> MQ203Weather => Construct(0xdb2a1);
        public static FormLink<IWeatherGetter> CommonwealthGSOvercast => Construct(0xf1033);
        public static FormLink<IWeatherGetter> NeutralWeather => Construct(0xa1588);
        public static FormLink<IWeatherGetter> CommonwealthClear => Construct(0x2b52a);
        public static FormLink<IWeatherGetter> FXWthrMorningOnly => Construct(0x96c61);
        public static FormLink<IWeatherGetter> FXWthrMoonlightOnly => Construct(0x88c57);
        public static FormLink<IWeatherGetter> FXConcord01OffatNight => Construct(0x76a58);
        public static FormLink<IWeatherGetter> FXConcord01 => Construct(0x747c8);
        public static FormLink<IWeatherGetter> FXWthrSunlightWhite => Construct(0x75491);
        public static FormLink<IWeatherGetter> FXWthrSunlight => Construct(0x7548f);
        public static FormLink<IWeatherGetter> WorldMapWeather => Construct(0xa6858);
        public static FormLink<IWeatherGetter> FXWthrInvertDayNighWarm => Construct(0x777cf);
        public static FormLink<IWeatherGetter> FXWthrInvertDayNight => Construct(0x6ed5a);
        public static FormLink<IWeatherGetter> DefaultWeather => Construct(0x15e);
        public static FormLink<IWeatherGetter> EditorCloudPreview => Construct(0x10e3d4);
        public static FormLink<IWeatherGetter> IstWeather => Construct(0x16ec);
        public static FormLink<IWeatherGetter> DiamondWeatherPastel => Construct(0x116e);
        public static FormLink<IWeatherGetter> DiamondWeather => Construct(0x116d);
        public static FormLink<IWeatherGetter> FXDiamondSunlightBounce => Construct(0x116b);
        public static FormLink<IWeatherGetter> FXWthrSunlightOffAtNight => Construct(0x29bb8);
    }
}