using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Message
        {
            private static FormLink<IMessageGetter> Construct(uint id) => new FormLink<IMessageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMessageGetter> BYOHVampireSleepMsg => Construct(0xc33);
            public static FormLink<IMessageGetter> BYOHFishHatcheryOnlyOneItemMESSAGE => Construct(0xa09);
            public static FormLink<IMessageGetter> BYOHFishHatcherySuccessMESSAGE => Construct(0xa08);
            public static FormLink<IMessageGetter> BYOHHouseBanditAttack2BossName => Construct(0x8af);
            public static FormLink<IMessageGetter> PlanterItemPlantedMESSAGE => Construct(0x19955);
            public static FormLink<IMessageGetter> BYOHHouseLogPileName => Construct(0x13eb5);
            public static FormLink<IMessageGetter> BYOHStoneDepletedMessage => Construct(0xd17d);
            public static FormLink<IMessageGetter> BYOHClayDepletedMessage => Construct(0xd17c);
            public static FormLink<IMessageGetter> PlanterOnlyOneItemMESSAGE => Construct(0x8245);
            public static FormLink<IMessageGetter> PlanterNotPlantableMESSAGE => Construct(0x8244);
            public static FormLink<IMessageGetter> PlanterPreviousItemRemovedMESSAGE => Construct(0x8243);
            public static FormLink<IMessageGetter> planterClearMessage => Construct(0x8242);
            public static FormLink<IMessageGetter> BYOHAdoptionRestedMessageMale => Construct(0x2f55);
            public static FormLink<IMessageGetter> BYOHAdoptionRestedMessageFemale => Construct(0x4293);
        }
    }
}
