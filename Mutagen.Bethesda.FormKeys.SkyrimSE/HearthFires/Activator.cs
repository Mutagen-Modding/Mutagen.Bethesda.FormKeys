using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Activator
        {
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> BYOHMineClay01RiverMud01 => Construct(0xa14);
            public static FormLink<IActivatorGetter> BYOHMineClay01ReachDirt01 => Construct(0x9f3);
            public static FormLink<IActivatorGetter> BYOHMineClay01FallForestDirt01 => Construct(0x9f2);
            public static FormLink<IActivatorGetter> BYOHFishHatchery01 => Construct(0x8ce);
            public static FormLink<IActivatorGetter> BYOHRelationshipAdoptionPetDoorTrig => Construct(0x18b79);
            public static FormLink<IActivatorGetter> BYOHHouseLogPileActivator => Construct(0xed27);
            public static FormLink<IActivatorGetter> BYOHMineClay01Dirt01 => Construct(0xa511);
            public static FormLink<IActivatorGetter> BYOHCraftingButterChurn => Construct(0x8848);
            public static FormLink<IActivatorGetter> BYOHPlanterSoil => Construct(0x8240);
            public static FormLink<IActivatorGetter> BYOHMineClay01Dirt02 => Construct(0x310b);
            public static FormLink<IActivatorGetter> BYOHHouseCraftingTrigger => Construct(0x30b0);
            public static FormLink<IActivatorGetter> BYOHInteriorSwapTrigger => Construct(0x309c);
            public static FormLink<IActivatorGetter> BYOHMineStone01 => Construct(0x306b);
        }
    }
}
