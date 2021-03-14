using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Quest
        {
            private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> BYOHHouseGiantAttack => Construct(0xc3e);
            public static FormLink<IQuestGetter> BYOHHouseWolfAttack => Construct(0xc39);
            public static FormLink<IQuestGetter> BYOHHouseBanditPacifier => Construct(0x8c3);
            public static FormLink<IQuestGetter> BYOHHouseBanditAttack2 => Construct(0x8a8);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptableOrphanageCL => Construct(0xe29a);
            public static FormLink<IQuestGetter> BYOHHouseDialogueHousecarl => Construct(0x15d5a);
            public static FormLink<IQuestGetter> BYOHHousePale => Construct(0x10bee);
            public static FormLink<IQuestGetter> BYOHHouseSkeeverInfestation => Construct(0x10a44);
            public static FormLink<IQuestGetter> BYOHHouseHjaalmarch => Construct(0xbe09);
            public static FormLink<IQuestGetter> BYOHHouseBanditAttack => Construct(0x5207);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoption => Construct(0x42b4);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptable => Construct(0x4291);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptableOrphanage => Construct(0x4286);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptableUrchins => Construct(0x4100);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptionScheduler => Construct(0x401c);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptionCWSiegeHandler => Construct(0x3f7e);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptableStewardCourier => Construct(0x3f7b);
            public static FormLink<IQuestGetter> BYOHRelationshipAdoptionNewAdoptionHandler => Construct(0x3f6e);
            public static FormLink<IQuestGetter> BYOHHouseStewardOffer => Construct(0x308b);
            public static FormLink<IQuestGetter> BYOHHouseFalkreath => Construct(0x305e);
            public static FormLink<IQuestGetter> BYOHHouseBuilding => Construct(0x305d);
        }
    }
}
