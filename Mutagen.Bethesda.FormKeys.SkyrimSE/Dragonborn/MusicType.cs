namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MusicType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2MUSExploreMountain => ModKey.MakeFormKey(0x3d4a4);
            public static FormKey DLC2MUSExploreSnow => ModKey.MakeFormKey(0x3d4a3);
            public static FormKey MUSDLC2BoatArrival => ModKey.MakeFormKey(0x3a4d9);
            public static FormKey DLC2MUSCombatBoss => ModKey.MakeFormKey(0x39ba5);
            public static FormKey DLC2MUSDungeonApocrypha => ModKey.MakeFormKey(0x34281);
            public static FormKey DLC2MUSExploreSolstheimGeneral => ModKey.MakeFormKey(0x33917);
            public static FormKey DLC2MUSCombatKarstaag => ModKey.MakeFormKey(0x28215);
        }
    }
}
