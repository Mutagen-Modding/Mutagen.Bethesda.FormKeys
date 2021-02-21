using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Water
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<IWaterGetter> Construct(uint id) => new FormLink<IWaterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWaterGetter> SEBrellachWater => Construct(0x8fa32);
            public static FormLink<IWaterGetter> SEPinnacleRockWater => Construct(0x8fa31);
            public static FormLink<IWaterGetter> SERuinDungeonWaterNoSwim => Construct(0x8f519);
            public static FormLink<IWaterGetter> SErootDungeonWaterDeepNasty => Construct(0x8f518);
            public static FormLink<IWaterGetter> SErootDungeonWaterShallow => Construct(0x8f516);
            public static FormLink<IWaterGetter> XPBlood => Construct(0x81a37);
            public static FormLink<IWaterGetter> SEDefaultUnderwater => Construct(0x7b3a4);
            public static FormLink<IWaterGetter> SEDefaultWaterNight => Construct(0x7b3a3);
            public static FormLink<IWaterGetter> SEDefaultWater => Construct(0x7b3a2);
            public static FormLink<IWaterGetter> DungeonWaterBrightFog01 => Construct(0xa9fb);
            public static FormLink<IWaterGetter> DefaultUnderwater => Construct(0x84d1);
            public static FormLink<IWaterGetter> DefaultWaterNight => Construct(0x84d0);
            public static FormLink<IWaterGetter> OblivionCitadelLavaPlane => Construct(0xcd4ea);
            public static FormLink<IWaterGetter> SwampWater => Construct(0xbe52f);
            public static FormLink<IWaterGetter> DungeonWater01 => Construct(0x6ee2f);
            public static FormLink<IWaterGetter> MS31Water => Construct(0x6dec7);
            public static FormLink<IWaterGetter> SewerWater => Construct(0x6af23);
            public static FormLink<IWaterGetter> Blood => Construct(0x90ddc);
            public static FormLink<IWaterGetter> CamoranLava02 => Construct(0x3afd4);
            public static FormLink<IWaterGetter> CamoranLava => Construct(0x3afd3);
            public static FormLink<IWaterGetter> OblivionOil01 => Construct(0x3ab07);
            public static FormLink<IWaterGetter> DefaultWater => Construct(0x18);
            public static FormLink<IWaterGetter> OblivionLavaTest01 => Construct(0x39d98);
        }
    }
}
