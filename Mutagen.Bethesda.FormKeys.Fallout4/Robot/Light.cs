// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class Light
    {
        private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILightGetter> DLC01LightHemiGoboNS => Construct(0x2d54);
        public static FormLink<ILightGetter> RandomSpot01GRNS => Construct(0x2359);
        public static FormLink<ILightGetter> MuseumSpotWarmFlickerNS => Construct(0x2358);
        public static FormLink<ILightGetter> DefaultLightWarm01SpotNSLF => Construct(0x2357);
        public static FormLink<ILightGetter> DLC01LightAmbGreen02 => Construct(0x1dbe);
        public static FormLink<ILightGetter> DLC01LightWhite01SpotNSGobo => Construct(0x12f8);
        public static FormLink<ILightGetter> DLC01LightIndCat01CoolNSGobo => Construct(0x12f7);
        public static FormLink<ILightGetter> DLC01LightMechanistDialogRedSpotNS => Construct(0x11392);
        public static FormLink<ILightGetter> DLC01LightMechanistDialogRedNSNonSpec => Construct(0x11391);
        public static FormLink<ILightGetter> DLC01MechDoorControl01GreenLight => Construct(0x1132e);
        public static FormLink<ILightGetter> DLC01MechDoorControl01RedLight => Construct(0x1132d);
        public static FormLink<ILightGetter> DLC01LightIndCat01NSGobo => Construct(0x10c1a);
        public static FormLink<ILightGetter> DLC01LightFireNSGoboBounce => Construct(0x10c19);
        public static FormLink<ILightGetter> DLC01LightAmbGreen => Construct(0x10c18);
        public static FormLink<ILightGetter> DefaultGreenOmni01NS => Construct(0x10b80);
        public static FormLink<ILightGetter> DefaultRedOmni01NSCOPY0000 => Construct(0x10b7f);
        public static FormLink<ILightGetter> DLC01WorkshopTurretSpotlightLightLong01 => Construct(0x10a5c);
        public static FormLink<ILightGetter> DLC01TrackSystem_ArmRobotLight => Construct(0x1089b);
        public static FormLink<ILightGetter> DLC01FXjarsBlack => Construct(0x10860);
        public static FormLink<ILightGetter> DLC01FXjarsCOPY0000 => Construct(0x1085f);
        public static FormLink<ILightGetter> DLC01FXjars => Construct(0x1085e);
        public static FormLink<ILightGetter> DLCOilLampLight01NSFlickerGobo => Construct(0x1027a);
        public static FormLink<ILightGetter> defaultLightFire01NSGoboBounce01Flicker => Construct(0x10278);
        public static FormLink<ILightGetter> DLCOilLampLight01NSFlickerLF => Construct(0xeaab);
        public static FormLink<ILightGetter> defaultLightWarm01NSGobo05Grating => Construct(0xcf5e);
        public static FormLink<ILightGetter> defaultLightCool03NSGoboBounce04x => Construct(0xcf5d);
        public static FormLink<ILightGetter> defaultLightCool03NSGoboBounce04 => Construct(0xcf5c);
        public static FormLink<ILightGetter> defaultLightCool01SpotGRNS => Construct(0xb9fa);
        public static FormLink<ILightGetter> DefaultLightWhite01SpotGRNS => Construct(0xb9f9);
        public static FormLink<ILightGetter> DLC01Lair_TempSpotlights => Construct(0xb80f);
        public static FormLink<ILightGetter> DLC01RobobrainFaceLight => Construct(0x4975);
        public static FormLink<ILightGetter> DLC01WeapLightMezmatron => Construct(0x4177);
    }
}