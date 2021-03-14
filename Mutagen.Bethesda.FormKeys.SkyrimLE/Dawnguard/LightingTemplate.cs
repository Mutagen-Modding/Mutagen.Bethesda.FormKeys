using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class LightingTemplate
        {
            private static FormLink<ILightingTemplateGetter> Construct(uint id) => new FormLink<ILightingTemplateGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightingTemplateGetter> DLC1VCCourtyardLightingTemplate => Construct(0x14646);
            public static FormLink<ILightingTemplateGetter> RuunvaldLightingTemplateDarkClose => Construct(0x14517);
            public static FormLink<ILightingTemplateGetter> RuunvaldLightingTemplateDark => Construct(0x14516);
            public static FormLink<ILightingTemplateGetter> DLC1AncestorGladeCaveLightingTemplate => Construct(0x144f3);
            public static FormLink<ILightingTemplateGetter> DLC1ArkngthamzMed => Construct(0x14110);
            public static FormLink<ILightingTemplateGetter> DLC1ArkngthamzFar => Construct(0x13f90);
            public static FormLink<ILightingTemplateGetter> DLC1BthalftForgeLT => Construct(0x12ff6);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonFarWater => Construct(0xe6c6);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonFarDarkfallEnd => Construct(0xe66e);
            public static FormLink<ILightingTemplateGetter> DLC1AncestorGladeLightingTemplate => Construct(0xd99e);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonMediumShrineAmbient => Construct(0xd6fc);
            public static FormLink<ILightingTemplateGetter> ForebearsHideoutFar => Construct(0x2fde);
            public static FormLink<ILightingTemplateGetter> DLC1VolkhairCastleCloseDarkLT => Construct(0x19c6c);
            public static FormLink<ILightingTemplateGetter> DLC1VolkhairCastleCloseLT => Construct(0x17940);
            public static FormLink<ILightingTemplateGetter> DLC1VolkhairCastleBlueLT => Construct(0x1793f);
            public static FormLink<ILightingTemplateGetter> DLC1VolkhairCastleLT => Construct(0x17776);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonCloseBrighterAmbient => Construct(0x16075);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonMediumBrighterAmbient => Construct(0x16073);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonMedium => Construct(0x6aea);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonFar => Construct(0x6ae9);
            public static FormLink<ILightingTemplateGetter> DLC1DarkDungeonClose => Construct(0x6ae8);
            public static FormLink<ILightingTemplateGetter> IceCaveDarkFar => Construct(0x4eea);
            public static FormLink<ILightingTemplateGetter> IceCaveDark => Construct(0x2f7e);
        }
    }
}
