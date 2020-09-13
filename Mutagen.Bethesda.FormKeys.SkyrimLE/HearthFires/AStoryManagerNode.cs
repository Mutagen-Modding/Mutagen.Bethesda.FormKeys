namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class AStoryManagerNode
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHHouseNode => ModKey.MakeFormKey(0x10a49);
            public static FormKey BYOHHouseBanditPacifierNode => ModKey.MakeFormKey(0x8c5);
            public static FormKey BYOHHouse3BasementNode => ModKey.MakeFormKey(0x10bf7);
            public static FormKey BYOHHouse2BasementNode2 => ModKey.MakeFormKey(0x10a4b);
            public static FormKey BYOHHouseBasementNode => ModKey.MakeFormKey(0x10a4a);
            public static FormKey BYOHHouseQuestNode => ModKey.MakeFormKey(0x520c);
            public static FormKey BYOHOrphanageNode => ModKey.MakeFormKey(0x427e);
            public static FormKey BYOHAdoptionQuestNode => ModKey.MakeFormKey(0x3f7a);
            public static FormKey BYOHHouseChangeLocationNode => ModKey.MakeFormKey(0x308c);
        }
    }
}
