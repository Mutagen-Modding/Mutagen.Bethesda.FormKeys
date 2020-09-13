namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Message
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHVampireSleepMsg => ModKey.MakeFormKey(0xc33);
            public static FormKey BYOHFishHatcheryOnlyOneItemMESSAGE => ModKey.MakeFormKey(0xa09);
            public static FormKey BYOHFishHatcherySuccessMESSAGE => ModKey.MakeFormKey(0xa08);
            public static FormKey BYOHHouseBanditAttack2BossName => ModKey.MakeFormKey(0x8af);
            public static FormKey PlanterItemPlantedMESSAGE => ModKey.MakeFormKey(0x19955);
            public static FormKey BYOHHouseLogPileName => ModKey.MakeFormKey(0x13eb5);
            public static FormKey BYOHStoneDepletedMessage => ModKey.MakeFormKey(0xd17d);
            public static FormKey BYOHClayDepletedMessage => ModKey.MakeFormKey(0xd17c);
            public static FormKey PlanterOnlyOneItemMESSAGE => ModKey.MakeFormKey(0x8245);
            public static FormKey PlanterNotPlantableMESSAGE => ModKey.MakeFormKey(0x8244);
            public static FormKey PlanterPreviousItemRemovedMESSAGE => ModKey.MakeFormKey(0x8243);
            public static FormKey planterClearMessage => ModKey.MakeFormKey(0x8242);
            public static FormKey BYOHAdoptionRestedMessageMale => ModKey.MakeFormKey(0x2f55);
            public static FormKey BYOHAdoptionRestedMessageFemale => ModKey.MakeFormKey(0x4293);
        }
    }
}
