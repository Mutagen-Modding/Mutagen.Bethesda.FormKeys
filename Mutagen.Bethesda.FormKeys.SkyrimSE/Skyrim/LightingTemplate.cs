using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class LightingTemplate
        {
            private static FormLink<ILightingTemplateGetter> Construct(uint id) => new FormLink<ILightingTemplateGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightingTemplateGetter> GreenCaveCloseDark => Construct(0x10acd3);
            public static FormLink<ILightingTemplateGetter> GreenCaveSuperFarDark => Construct(0x10acd2);
            public static FormLink<ILightingTemplateGetter> ThalmorInterior => Construct(0xfedb4);
            public static FormLink<ILightingTemplateGetter> KagrenzelFalmerTemplateFar => Construct(0xf9b2b);
            public static FormLink<ILightingTemplateGetter> CaveSuperFarFog => Construct(0xef2c5);
            public static FormLink<ILightingTemplateGetter> WaterCaveTemplateFar => Construct(0xef2c3);
            public static FormLink<ILightingTemplateGetter> DraugrPriestCloser => Construct(0xedb13);
            public static FormLink<ILightingTemplateGetter> DraugrPriestMedium => Construct(0xeda92);
            public static FormLink<ILightingTemplateGetter> DraugrPriestClose => Construct(0xeda91);
            public static FormLink<ILightingTemplateGetter> WaterCaveTemplate => Construct(0xed010);
            public static FormLink<ILightingTemplateGetter> SovngardeLightingTemplateTest => Construct(0xe9d91);
            public static FormLink<ILightingTemplateGetter> DwarvenLightingCloseWarm => Construct(0xc684a);
            public static FormLink<ILightingTemplateGetter> DwarvenLightingFarSkyhole => Construct(0xc6528);
            public static FormLink<ILightingTemplateGetter> FalmerTemplateFar => Construct(0xc1301);
            public static FormLink<ILightingTemplateGetter> FalmerTemplateMedium => Construct(0xc1300);
            public static FormLink<ILightingTemplateGetter> EastEmpireTemplate => Construct(0x8a8c9);
            public static FormLink<ILightingTemplateGetter> ElderGleamTemplateAlt => Construct(0x4c9b1);
            public static FormLink<ILightingTemplateGetter> FrostmereCryptWolrdspaceTemplate => Construct(0x1560d);
            public static FormLink<ILightingTemplateGetter> MineTemplateFar => Construct(0xe7c5f);
            public static FormLink<ILightingTemplateGetter> MineTemplateMedium => Construct(0xe7c5e);
            public static FormLink<ILightingTemplateGetter> MineTemplateClose => Construct(0xe7c5d);
            public static FormLink<ILightingTemplateGetter> ElderGleamTemplate => Construct(0xe6598);
            public static FormLink<ILightingTemplateGetter> SolitudeInteriorsNEW => Construct(0xe301f);
            public static FormLink<ILightingTemplateGetter> AzurasStarTemplate => Construct(0xe2167);
            public static FormLink<ILightingTemplateGetter> ShadowGreenTemplate => Construct(0xe20f6);
            public static FormLink<ILightingTemplateGetter> GreenCaveSuperFar => Construct(0xe2022);
            public static FormLink<ILightingTemplateGetter> RannveigsFarTemplate => Construct(0xe2016);
            public static FormLink<ILightingTemplateGetter> RannveigsMediumTemplate => Construct(0xe2015);
            public static FormLink<ILightingTemplateGetter> RannveigsCloseTemplate => Construct(0xe2014);
            public static FormLink<ILightingTemplateGetter> MarkarthLightingTemplate => Construct(0xd7b14);
            public static FormLink<ILightingTemplateGetter> SovngardeLightingTemplate => Construct(0xcabc9);
            public static FormLink<ILightingTemplateGetter> IceCaveOutside => Construct(0xc5cd5);
            public static FormLink<ILightingTemplateGetter> WindhelmInteriorTemplate03 => Construct(0xc3d39);
            public static FormLink<ILightingTemplateGetter> BlindCliffTemplate => Construct(0xc1cba);
            public static FormLink<ILightingTemplateGetter> WindhelmInteriorTemplate02 => Construct(0xc0c76);
            public static FormLink<ILightingTemplateGetter> WindhelmInteriorTemplate => Construct(0xc0c75);
            public static FormLink<ILightingTemplateGetter> NightCallerDreamTemplate => Construct(0xa2682);
            public static FormLink<ILightingTemplateGetter> NightCallerTemplate => Construct(0xa2680);
            public static FormLink<ILightingTemplateGetter> EastEmpireCaveFar => Construct(0x231d0);
            public static FormLink<ILightingTemplateGetter> IceCaveClose => Construct(0x195d3);
            public static FormLink<ILightingTemplateGetter> IceCaveFar => Construct(0x195d2);
            public static FormLink<ILightingTemplateGetter> IceCaveMedium => Construct(0x1952f);
            public static FormLink<ILightingTemplateGetter> GreenCaveClose => Construct(0x345a4);
            public static FormLink<ILightingTemplateGetter> GreenCaveFar => Construct(0x345a2);
            public static FormLink<ILightingTemplateGetter> GreenCaveMedium => Construct(0x34566);
            public static FormLink<ILightingTemplateGetter> UstengravLargeTest => Construct(0x7545e);
            public static FormLink<ILightingTemplateGetter> ImperialFortCloseTemplate => Construct(0x6909b);
            public static FormLink<ILightingTemplateGetter> BorderWallTransTemplate => Construct(0x68ec9);
            public static FormLink<ILightingTemplateGetter> BorderWallFarDarkTemplate => Construct(0x68ec8);
            public static FormLink<ILightingTemplateGetter> DarklightTowerTemplate => Construct(0x68b3e);
            public static FormLink<ILightingTemplateGetter> WhiteRunIntMedLightingTemplate => Construct(0x660a3);
            public static FormLink<ILightingTemplateGetter> KarthspireSuperFarTemplate => Construct(0x5eae9);
            public static FormLink<ILightingTemplateGetter> KarthspireMediumTemplate => Construct(0x5eae8);
            public static FormLink<ILightingTemplateGetter> KarthspireFarTemplate => Construct(0x5ead5);
            public static FormLink<ILightingTemplateGetter> RiftenRatwayMed => Construct(0x5c735);
            public static FormLink<ILightingTemplateGetter> RiftenRatwayClose => Construct(0x5c734);
            public static FormLink<ILightingTemplateGetter> BlackreachTemplate => Construct(0x487e6);
            public static FormLink<ILightingTemplateGetter> UstengravLarge => Construct(0x361ec);
            public static FormLink<ILightingTemplateGetter> UstengravHalls => Construct(0x359cc);
            public static FormLink<ILightingTemplateGetter> UstengravEntrance => Construct(0x3534d);
            public static FormLink<ILightingTemplateGetter> NchuandZelMedium => Construct(0x1fb68);
            public static FormLink<ILightingTemplateGetter> NchuandZelTrans => Construct(0x1f933);
            public static FormLink<ILightingTemplateGetter> NchuandZelFar => Construct(0x1f932);
            public static FormLink<ILightingTemplateGetter> NchuandZelClose => Construct(0x1ee51);
            public static FormLink<ILightingTemplateGetter> FalmerTemplateDesat => Construct(0xb9f59);
            public static FormLink<ILightingTemplateGetter> FalmerTemplateInitial => Construct(0xb9ef5);
            public static FormLink<ILightingTemplateGetter> FalmerTemplateClose => Construct(0xb9e23);
            public static FormLink<ILightingTemplateGetter> HelgenKeepSunlightTemplate => Construct(0xb7db8);
            public static FormLink<ILightingTemplateGetter> HelgenKeepClose => Construct(0xb6bc7);
            public static FormLink<ILightingTemplateGetter> Korvanjund => Construct(0xb6468);
            public static FormLink<ILightingTemplateGetter> SolitudeInteriorFarms => Construct(0xb37b0);
            public static FormLink<ILightingTemplateGetter> RiftenInteriors => Construct(0xb2157);
            public static FormLink<ILightingTemplateGetter> FarmLightingTemplate => Construct(0xa1196);
            public static FormLink<ILightingTemplateGetter> HHFar => Construct(0xa0f40);
            public static FormLink<ILightingTemplateGetter> MarkarthLightingClose => Construct(0x9f281);
            public static FormLink<ILightingTemplateGetter> CidhnaMine_LightingTemplateClose => Construct(0x98b91);
            public static FormLink<ILightingTemplateGetter> AlikrBaseLightingTemplateNear => Construct(0x98853);
            public static FormLink<ILightingTemplateGetter> AlikrBaseLightingTemplate => Construct(0x94e50);
            public static FormLink<ILightingTemplateGetter> CidhnaMine_LightingTemplate => Construct(0x91937);
            public static FormLink<ILightingTemplateGetter> IlinaltasDeep_LightingTemplateNear => Construct(0x91931);
            public static FormLink<ILightingTemplateGetter> IlinaltasDeep_LightingTemplateFar => Construct(0x91930);
            public static FormLink<ILightingTemplateGetter> IceCave_HobsFall_LightingTemplateFar => Construct(0x906cd);
            public static FormLink<ILightingTemplateGetter> IceCave_HobsFall_LightingTemplateNear => Construct(0x906cc);
            public static FormLink<ILightingTemplateGetter> IceCave_HobsFall_LightingTemplate => Construct(0x8e78e);
            public static FormLink<ILightingTemplateGetter> IlinaltasDeep_LightingTemplate => Construct(0x8cdda);
            public static FormLink<ILightingTemplateGetter> DwarvenLightingClose => Construct(0x8810c);
            public static FormLink<ILightingTemplateGetter> DwarvenLightingFar => Construct(0x8810b);
            public static FormLink<ILightingTemplateGetter> DwarvenLightingMedium => Construct(0x8810a);
            public static FormLink<ILightingTemplateGetter> DwarvenLightingTemplate => Construct(0x87999);
            public static FormLink<ILightingTemplateGetter> WindhelmLightingTemplate => Construct(0x7ba87);
            public static FormLink<ILightingTemplateGetter> SolitudeInteriors => Construct(0x6ab01);
            public static FormLink<ILightingTemplateGetter> SolitudeInteriorShops => Construct(0x6256a);
            public static FormLink<ILightingTemplateGetter> WhiteRunIntLightingTemplate => Construct(0x6175d);
            public static FormLink<ILightingTemplateGetter> BleakFallsBarrowFar => Construct(0x3128d);
            public static FormLink<ILightingTemplateGetter> BleakFallsBarrowMedium => Construct(0x3128c);
            public static FormLink<ILightingTemplateGetter> BleakFallsBarrowClose => Construct(0x3128b);
            public static FormLink<ILightingTemplateGetter> DefaultLightingTemplate => Construct(0x300e2);
        }
    }
}
