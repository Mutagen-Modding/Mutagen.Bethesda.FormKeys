using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Furniture
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFurnitureGetter> BYOHVampireCoffinVert01 => Construct(0x801);
            public static FormLink<IFurnitureGetter> ChildSitOnKneesMarker => Construct(0xed5c);
            public static FormLink<IFurnitureGetter> ChildLayOnFloorMarker => Construct(0xed5a);
            public static FormLink<IFurnitureGetter> BYOHHouseTrophyBase2 => Construct(0xa31e);
            public static FormLink<IFurnitureGetter> BYOHHouseTrophyBase1 => Construct(0xa31a);
            public static FormLink<IFurnitureGetter> BYOHBedrollGroundChild => Construct(0x695d);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom02_bedrooms => Construct(0x5a9f);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom02_back => Construct(0x5a9e);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom12 => Construct(0x3b01);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom11 => Construct(0x3b00);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom10 => Construct(0x3aff);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom09 => Construct(0x3afe);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom08 => Construct(0x3afd);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom07 => Construct(0x3afc);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom06 => Construct(0x3afb);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom05 => Construct(0x3afa);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom04 => Construct(0x3af9);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom03 => Construct(0x3aee);
            public static FormLink<IFurnitureGetter> BYOHLayDownMarkerChild => Construct(0x402a);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom01B => Construct(0x3129);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom02_main => Construct(0x30f2);
            public static FormLink<IFurnitureGetter> BYOHHouseInteriorWorkbenchRoom01A => Construct(0x30da);
            public static FormLink<IFurnitureGetter> BYOHHouseCarpentersWorkbench => Construct(0x3065);
            public static FormLink<IFurnitureGetter> BYOHDraftingTable => Construct(0x305b);
            public static FormLink<IFurnitureGetter> CraftingOvenMarker => Construct(0x283f);
        }
    }
}
