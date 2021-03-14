using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Furniture
        {
            private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFurnitureGetter> DLC2MQ02Meditate => Construct(0x3d5dc);
            public static FormLink<IFurnitureGetter> DLC2FreaCrouchedMarker => Construct(0x3d2bc);
            public static FormLink<IFurnitureGetter> DLC2MiraakDeathMarker => Construct(0x3d245);
            public static FormLink<IFurnitureGetter> BedrollHay01GlacierR => Construct(0x3d132);
            public static FormLink<IFurnitureGetter> BedrollHay01GlacierL => Construct(0x3d131);
            public static FormLink<IFurnitureGetter> DLC2CraftingBlackSmithForge => Construct(0x3cf6e);
            public static FormLink<IFurnitureGetter> DLC2MQ06TentacleWordBurnMarker => Construct(0x3ca99);
            public static FormLink<IFurnitureGetter> PickaxeMiningTableMarker_IgnoredBySandbox => Construct(0x3c71a);
            public static FormLink<IFurnitureGetter> DLC2TelvanniTowerFloatDown => Construct(0x3a641);
            public static FormLink<IFurnitureGetter> DLC2PickaxeMiningWallMarker_Stalhrim => Construct(0x3a493);
            public static FormLink<IFurnitureGetter> DLC2PickaxeMiningTableMarker_Stalhrim => Construct(0x3a492);
            public static FormLink<IFurnitureGetter> DLC2PickaxeMiningFloorMarker_Stalhrim => Construct(0x3a491);
            public static FormLink<IFurnitureGetter> DLC2dunKarstaagThroneMarker => Construct(0x39e40);
            public static FormLink<IFurnitureGetter> DLC2TelvanniTowerFloatUp => Construct(0x39cb9);
            public static FormLink<IFurnitureGetter> DLC2TentacleWordBurnMarker => Construct(0x39ba7);
            public static FormLink<IFurnitureGetter> DLC2WoodChoppingBlockAsh => Construct(0x3828b);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBedDouble01L => Construct(0x36797);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBedDouble01R => Construct(0x36796);
            public static FormLink<IFurnitureGetter> DLC2DarkElfChair01F => Construct(0x36795);
            public static FormLink<IFurnitureGetter> DLC2DarkElfChair01R => Construct(0x36794);
            public static FormLink<IFurnitureGetter> DLC2DarkElfChair01L => Construct(0x36793);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBed01L => Construct(0x35038);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBed01R => Construct(0x35037);
            public static FormLink<IFurnitureGetter> DLC1GroundAmbush01 => Construct(0x34f98);
            public static FormLink<IFurnitureGetter> DLC2StonePile => Construct(0x34ef5);
            public static FormLink<IFurnitureGetter> DLC2BallistaGroundAmbush01 => Construct(0x33650);
            public static FormLink<IFurnitureGetter> DLC2RieklingDance => Construct(0x33265);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBedDouble01 => Construct(0x32802);
            public static FormLink<IFurnitureGetter> DLC2RieklingPray => Construct(0x32725);
            public static FormLink<IFurnitureGetter> DLC2RieklingThroneMarker => Construct(0x31b0d);
            public static FormLink<IFurnitureGetter> DLC2_ChildLayOnFloorMarker => Construct(0x31441);
            public static FormLink<IFurnitureGetter> DLC2_ChildSitOnKneesMarker => Construct(0x3143f);
            public static FormLink<IFurnitureGetter> DLC2dunNchardakControlConsoleFurniture => Construct(0x30e92);
            public static FormLink<IFurnitureGetter> BedrollHay01LDirtPath01R => Construct(0x2c0b4);
            public static FormLink<IFurnitureGetter> BedrollHay01LDirtPath01F => Construct(0x2c0b3);
            public static FormLink<IFurnitureGetter> BedrollHay01LDirtPath01L => Construct(0x2c0b2);
            public static FormLink<IFurnitureGetter> DLC2ChiselStanding_Riekling => Construct(0x2b10c);
            public static FormLink<IFurnitureGetter> DLC2DarkElfThrone01 => Construct(0x2b086);
            public static FormLink<IFurnitureGetter> DLC2CraftingBlackSmithSkaalForge => Construct(0x2b074);
            public static FormLink<IFurnitureGetter> DLC2BenthicLurkerAmbushFurniture => Construct(0x2a8dd);
            public static FormLink<IFurnitureGetter> DLC2ChiselKneeling => Construct(0x2a6d3);
            public static FormLink<IFurnitureGetter> DLC2ChiselStanding => Construct(0x29ec4);
            public static FormLink<IFurnitureGetter> DLC2ApocryphaFountain => Construct(0x29d13);
            public static FormLink<IFurnitureGetter> BedrollHay01L_Ash => Construct(0x28aa9);
            public static FormLink<IFurnitureGetter> BedrollHay01R_Ash => Construct(0x28a68);
            public static FormLink<IFurnitureGetter> BedrollHay01IceR => Construct(0x25e52);
            public static FormLink<IFurnitureGetter> BedrollHay01IceL => Construct(0x25e51);
            public static FormLink<IFurnitureGetter> DLC2ScribGroundAmbush01 => Construct(0x24fb9);
            public static FormLink<IFurnitureGetter> DLC2DarkElfChair01 => Construct(0x2174b);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBench01 => Construct(0x2174a);
            public static FormLink<IFurnitureGetter> DLC2DarkElfBed01 => Construct(0x21749);
            public static FormLink<IFurnitureGetter> BedrollHay01LDirtSnowPath => Construct(0x1ee28);
            public static FormLink<IFurnitureGetter> DLC2InvRieklingTreeAmbush => Construct(0x1e8b5);
            public static FormLink<IFurnitureGetter> DLC2InvRieklingGroundAmbush => Construct(0x1d8c7);
            public static FormLink<IFurnitureGetter> DLC2InvRieklingBushAmbush => Construct(0x1d8c6);
            public static FormLink<IFurnitureGetter> testPhilCraftingSmelterMarker1 => Construct(0x18cae);
            public static FormLink<IFurnitureGetter> BedrollHay01LDirtSnowPath01R => Construct(0x18618);
            public static FormLink<IFurnitureGetter> BedrollHay01LDirtSnowPath01F => Construct(0x18617);
            public static FormLink<IFurnitureGetter> DLC2CraftingStaffWorkbench => Construct(0x17736);
        }
    }
}
