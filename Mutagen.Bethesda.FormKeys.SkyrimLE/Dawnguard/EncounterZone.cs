// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dawnguard
{
    public static partial class EncounterZone
    {
        private static FormLink<IEncounterZoneGetter> Construct(uint id) => new FormLink<IEncounterZoneGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IEncounterZoneGetter> DLC1FalmerValleyTempleZone => Construct(0x1379d);
        public static FormLink<IEncounterZoneGetter> DLC1FalmerValleyZone => Construct(0x12f42);
        public static FormLink<IEncounterZoneGetter> DLC1_SoulCairnZone => Construct(0x643c);
        public static FormLink<IEncounterZoneGetter> DLC1MolderingRuinsZone => Construct(0x3cfc);
        public static FormLink<IEncounterZoneGetter> DLC1zFalmerValley03Zone => Construct(0x162b5);
        public static FormLink<IEncounterZoneGetter> DLC1zFalmerValley02Zone => Construct(0x162b3);
        public static FormLink<IEncounterZoneGetter> DLC1zFalmerValley01Zone => Construct(0x162b1);
        public static FormLink<IEncounterZoneGetter> DLC1GlacialCreviceZone => Construct(0x162ae);
        public static FormLink<IEncounterZoneGetter> DLC1DarkfallPassageZone => Construct(0x162ad);
        public static FormLink<IEncounterZoneGetter> DLC1DarkfallCaveZone => Construct(0xa879);
        public static FormLink<IEncounterZoneGetter> DLC1RuunvaldZone => Construct(0x7b22);
        public static FormLink<IEncounterZoneGetter> DLC1RedwaterDenZone => Construct(0x7779);
        public static FormLink<IEncounterZoneGetter> DLC1LDBthalftAetheriumForgeZone => Construct(0x5825);
        public static FormLink<IEncounterZoneGetter> DLC1ArkngthamzZone => Construct(0x5824);
        public static FormLink<IEncounterZoneGetter> DLC1DimhollowCryptZone => Construct(0x4ee7);
        public static FormLink<IEncounterZoneGetter> DLC1_AncestorsGladeZone => Construct(0x3582);
        public static FormLink<IEncounterZoneGetter> DLC1ForebearsHoldoutZone => Construct(0x3581);
        public static FormLink<IEncounterZoneGetter> DLC1_VCDungeonZone => Construct(0x3580);
    }
}
