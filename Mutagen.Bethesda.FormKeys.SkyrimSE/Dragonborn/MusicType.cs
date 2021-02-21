using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MusicType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMusicTypeGetter> Construct(uint id) => new FormLink<IMusicTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTypeGetter> DLC2MUSExploreMountain => Construct(0x3d4a4);
            public static FormLink<IMusicTypeGetter> DLC2MUSExploreSnow => Construct(0x3d4a3);
            public static FormLink<IMusicTypeGetter> MUSDLC2BoatArrival => Construct(0x3a4d9);
            public static FormLink<IMusicTypeGetter> DLC2MUSCombatBoss => Construct(0x39ba5);
            public static FormLink<IMusicTypeGetter> DLC2MUSDungeonApocrypha => Construct(0x34281);
            public static FormLink<IMusicTypeGetter> DLC2MUSExploreSolstheimGeneral => Construct(0x33917);
            public static FormLink<IMusicTypeGetter> DLC2MUSCombatKarstaag => Construct(0x28215);
        }
    }
}
