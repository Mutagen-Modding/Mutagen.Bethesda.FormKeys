using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class AStoryManagerNode
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IAStoryManagerNodeGetter> Construct(uint id) => new FormLink<IAStoryManagerNodeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRMineNode => Construct(0x3332d);
            public static FormLink<IAStoryManagerNodeGetter> DLC2SkaalVillageScenes => Construct(0x2075c);
            public static FormLink<IAStoryManagerNodeGetter> DLC2TelMithrynBranchNode => Construct(0x20686);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RegionGlacierNode => Construct(0x1e7e0);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WERegionNorthNode => Construct(0x1e7df);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WERegionAshlandNode => Construct(0x1e7de);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WENode => Construct(0x1e7d9);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RavenRockScenes => Construct(0x19952);
            public static FormLink<IAStoryManagerNodeGetter> DLC2 => Construct(0x19951);
            public static FormLink<IAStoryManagerNodeGetter> DLC2AshSpawnAttackNode => Construct(0x3842c);
            public static FormLink<IAStoryManagerNodeGetter> DLC2CultistAmbushNode => Construct(0x35472);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RR03Node => Construct(0x3332e);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WEPriorityQuests => Construct(0x331c1);
            public static FormLink<IAStoryManagerNodeGetter> DLC2EbonyWarriorNode => Construct(0x2c49f);
            public static FormLink<IAStoryManagerNodeGetter> DLC2PillarDestroyedNode => Construct(0x28667);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WaterStoneSailAwayNode => Construct(0x27827);
            public static FormLink<IAStoryManagerNodeGetter> DLC2ThirskReclaimedScenes => Construct(0x251fb);
            public static FormLink<IAStoryManagerNodeGetter> DLC2dunKarstaagNode => Construct(0x24809);
            public static FormLink<IAStoryManagerNodeGetter> DLC2dunHaknirTreasureNodeSHARES => Construct(0x24003);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WETemplateNodeONLY => Construct(0x20fbf);
            public static FormLink<IAStoryManagerNodeGetter> DLC2FavorSkaalVillage => Construct(0x20955);
            public static FormLink<IAStoryManagerNodeGetter> DLC2ThirskRieklingSpawnerNode => Construct(0x208cd);
            public static FormLink<IAStoryManagerNodeGetter> DLC2SVEdlasHouseConversations => Construct(0x2075f);
            public static FormLink<IAStoryManagerNodeGetter> DLC2SVGreathallConversations => Construct(0x2075e);
            public static FormLink<IAStoryManagerNodeGetter> DLC2SVAnyLocConversations => Construct(0x2075d);
            public static FormLink<IAStoryManagerNodeGetter> DLC2BlackBookQuestNode => Construct(0x20689);
            public static FormLink<IAStoryManagerNodeGetter> DLC2ElyneaQuestNode => Construct(0x20688);
            public static FormLink<IAStoryManagerNodeGetter> DLC2NelothQuestNode => Construct(0x20687);
            public static FormLink<IAStoryManagerNodeGetter> DLC2dunFrostmoonCragNode => Construct(0x1f9e9);
            public static FormLink<IAStoryManagerNodeGetter> DLC2TelMithrynScenes => Construct(0x1f908);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WERegionAshlandQuestNode => Construct(0x1e7e3);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RegionGlacierQuestNode => Construct(0x1e7e2);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WERegionNorthQuestNode => Construct(0x1e7e1);
            public static FormLink<IAStoryManagerNodeGetter> DLC2WEDragonQuests => Construct(0x1e7da);
            public static FormLink<IAStoryManagerNodeGetter> DLC2dunNchardakNode => Construct(0x1d4b4);
            public static FormLink<IAStoryManagerNodeGetter> DLC2NelothRadiantQuests => Construct(0x1b65e);
            public static FormLink<IAStoryManagerNodeGetter> DLC2ThirskRetreatScenes => Construct(0x1a547);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRBeggarConversations => Construct(0x19c50);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRAnyLocConversations => Construct(0x19c4a);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRTempleConversations => Construct(0x19959);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRSwingScoopConversations => Construct(0x19958);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRSeverinManorConversations => Construct(0x19957);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRNetchConversations => Construct(0x19956);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRMorvaynManorConversations => Construct(0x19955);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRIenthFarmConversations => Construct(0x19954);
            public static FormLink<IAStoryManagerNodeGetter> DLC2RRCresciusHouseConversations => Construct(0x19953);
            public static FormLink<IAStoryManagerNodeGetter> DLC2dunKolbjornNode => Construct(0x182b6);
        }
    }
}
