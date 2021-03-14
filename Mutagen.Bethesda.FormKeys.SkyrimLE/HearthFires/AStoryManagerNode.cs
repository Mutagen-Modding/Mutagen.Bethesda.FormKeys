using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class AStoryManagerNode
        {
            private static FormLink<IAStoryManagerNodeGetter> Construct(uint id) => new FormLink<IAStoryManagerNodeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouseNode => Construct(0x10a49);
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouseBanditPacifierNode => Construct(0x8c5);
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouse3BasementNode => Construct(0x10bf7);
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouse2BasementNode2 => Construct(0x10a4b);
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouseBasementNode => Construct(0x10a4a);
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouseQuestNode => Construct(0x520c);
            public static FormLink<IAStoryManagerNodeGetter> BYOHOrphanageNode => Construct(0x427e);
            public static FormLink<IAStoryManagerNodeGetter> BYOHAdoptionQuestNode => Construct(0x3f7a);
            public static FormLink<IAStoryManagerNodeGetter> BYOHHouseChangeLocationNode => Construct(0x308c);
        }
    }
}
