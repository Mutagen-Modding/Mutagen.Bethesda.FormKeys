// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dragonborn
{
    public static partial class LightingTemplate
    {
        private static FormLink<ILightingTemplateGetter> Construct(uint id) => new FormLink<ILightingTemplateGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILightingTemplateGetter> DarklightTowerTemplateFar => Construct(0x3d563);
        public static FormLink<ILightingTemplateGetter> DLC2SkallVillageLT => Construct(0x35560);
        public static FormLink<ILightingTemplateGetter> DLC2TelMithrynLT => Construct(0x34f4b);
        public static FormLink<ILightingTemplateGetter> DLC2ApocryphaWorldLightingTemplate => Construct(0x34ce1);
        public static FormLink<ILightingTemplateGetter> DLC2ApocryphaDarkTemplate => Construct(0x34ce0);
        public static FormLink<ILightingTemplateGetter> DLC2ApocryphaNewLightingTemplate => Construct(0x34c19);
        public static FormLink<ILightingTemplateGetter> DLC2DwarvenLightingFar => Construct(0x31d29);
        public static FormLink<ILightingTemplateGetter> DLC2CastleKarstaagIceCaveLTFar => Construct(0x2bca3);
        public static FormLink<ILightingTemplateGetter> DLC2CastleKarstaagIceCaveLTClose => Construct(0x2bca2);
        public static FormLink<ILightingTemplateGetter> DLC2ApocryphaLightingTemplate => Construct(0x19a81);
    }
}
