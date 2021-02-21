using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Keyword
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IKeywordGetter> Construct(uint id) => new FormLink<IKeywordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeywordGetter> DLC2DremoraButlerKeyword => Construct(0x1e1ae);
            public static FormLink<IKeywordGetter> DLC2MorasGraspExcludedKeyword => Construct(0x3d2f9);
            public static FormLink<IKeywordGetter> DLC2FreaSorrow => Construct(0x3d2bb);
            public static FormLink<IKeywordGetter> isDLC02MiraakDeath => Construct(0x3d244);
            public static FormLink<IKeywordGetter> DLC2LinkBlackBookSound => Construct(0x3d222);
            public static FormLink<IKeywordGetter> DLC2ActorTypeMiraak => Construct(0x3ca98);
            public static FormLink<IKeywordGetter> isTowerFloatDown => Construct(0x3a640);
            public static FormLink<IKeywordGetter> DLC2IsPickaxeWall => Construct(0x3a490);
            public static FormLink<IKeywordGetter> DLC2IsPickaxeTable => Construct(0x3a48f);
            public static FormLink<IKeywordGetter> DLC2IsPickaxeFloor => Construct(0x3a48e);
            public static FormLink<IKeywordGetter> DLC2LinkBlackBookEnabled => Construct(0x3a3de);
            public static FormLink<IKeywordGetter> DLC2NordicPickaxe => Construct(0x3a335);
            public static FormLink<IKeywordGetter> DLC2MagicAshSpawn => Construct(0x3a32d);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialMoragTong => Construct(0x3a328);
            public static FormLink<IKeywordGetter> DLC2RieklingMountedKeyword => Construct(0x3a159);
            public static FormLink<IKeywordGetter> DLC2RieklingKeyword => Construct(0x3a158);
            public static FormLink<IKeywordGetter> DLC2NetchKeyword => Construct(0x3a157);
            public static FormLink<IKeywordGetter> isTowerFloatUp => Construct(0x39cb8);
            public static FormLink<IKeywordGetter> isDLC02TentacleWordBurn => Construct(0x39ba8);
            public static FormLink<IKeywordGetter> MagicIgnite => Construct(0x38ab8);
            public static FormLink<IKeywordGetter> DLC2LinkAshSpawnAttackHoldPosition => Construct(0x3843a);
            public static FormLink<IKeywordGetter> DLC2dunHaknirScimitar02Keyword => Construct(0x38052);
            public static FormLink<IKeywordGetter> DLC2dunHaknirScimitar01Keyword => Construct(0x38050);
            public static FormLink<IKeywordGetter> DLC2TTR5SpecialSpell => Construct(0x36a68);
            public static FormLink<IKeywordGetter> DLC2WerebearKeyword => Construct(0x34fb7);
            public static FormLink<IKeywordGetter> StonePickUp => Construct(0x34ef6);
            public static FormLink<IKeywordGetter> DLC2MagicMorasAgony => Construct(0x339a0);
            public static FormLink<IKeywordGetter> DLC2MH02ThirskRieklingForceGreeter => Construct(0x337e3);
            public static FormLink<IKeywordGetter> isRieklingDance => Construct(0x33266);
            public static FormLink<IKeywordGetter> isRieklingPray => Construct(0x32726);
            public static FormLink<IKeywordGetter> DLC2StandingStoneFXLink => Construct(0x31c3c);
            public static FormLink<IKeywordGetter> isRieklingChisel => Construct(0x31b0f);
            public static FormLink<IKeywordGetter> isRieklingThrone => Construct(0x31b0e);
            public static FormLink<IKeywordGetter> DLC2_isChildLayOnFloor => Construct(0x31440);
            public static FormLink<IKeywordGetter> DLC2_isChildSitOnKnees => Construct(0x3143e);
            public static FormLink<IKeywordGetter> LocTypeWerebearLair => Construct(0x2c96a);
            public static FormLink<IKeywordGetter> DLC2LocTypeAshSpawn => Construct(0x2c969);
            public static FormLink<IKeywordGetter> DLC2LinkPillarMonster => Construct(0x2bab3);
            public static FormLink<IKeywordGetter> DLC2CraftingSmithingSkaalForge => Construct(0x2b073);
            public static FormLink<IKeywordGetter> DLC2BenthicLurkerSpray => Construct(0x2a8df);
            public static FormLink<IKeywordGetter> isKneelingChisel => Construct(0x2a6d2);
            public static FormLink<IKeywordGetter> isStandingChisel => Construct(0x29d2e);
            public static FormLink<IKeywordGetter> DLC2LocTypeRieklingCamp => Construct(0x2972e);
            public static FormLink<IKeywordGetter> DLC2AshSpawnKeyword => Construct(0x28fde);
            public static FormLink<IKeywordGetter> DLC2LinkPillarStandingStone => Construct(0x2866a);
            public static FormLink<IKeywordGetter> DLC2LinkPillarMonsterSpawn => Construct(0x28669);
            public static FormLink<IKeywordGetter> DLC2PillarDestroyedStart => Construct(0x28665);
            public static FormLink<IKeywordGetter> DLC2SV02AncarionMerchantKeyword => Construct(0x27e14);
            public static FormLink<IKeywordGetter> DLC2dunKolbjornAhzidalItem => Construct(0x270e7);
            public static FormLink<IKeywordGetter> DLC2WeaponMaterialNordic => Construct(0x26230);
            public static FormLink<IKeywordGetter> DLC2WeaponMaterialStalhrim => Construct(0x2622f);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialStalhrimLight => Construct(0x24107);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialStalhrimHeavy => Construct(0x24106);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialNordicHeavy => Construct(0x24105);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialNordicLight => Construct(0x24104);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialChitinHeavy => Construct(0x24103);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialChitinLight => Construct(0x24102);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialBonemoldHeavy => Construct(0x24101);
            public static FormLink<IKeywordGetter> DLC2ArmorMaterialBonemoldLight => Construct(0x24100);
            public static FormLink<IKeywordGetter> DLC2dunHaknirArmor => Construct(0x24022);
            public static FormLink<IKeywordGetter> DLC2LocTypePillar => Construct(0x1debd);
            public static FormLink<IKeywordGetter> DLC2LinkPillarToggle => Construct(0x1debb);
            public static FormLink<IKeywordGetter> DLC2ApocryphaBookLink => Construct(0x1bd81);
            public static FormLink<IKeywordGetter> DLC2DragonMountKeyword => Construct(0x1bd7d);
            public static FormLink<IKeywordGetter> DLC2WEStart => Construct(0x1aa2b);
            public static FormLink<IKeywordGetter> DLC2WERoadStart => Construct(0x1aa2a);
            public static FormLink<IKeywordGetter> DLC2TT2HeartStoneKeyword => Construct(0x1961f);
            public static FormLink<IKeywordGetter> testPhilCraftingBreakItDowner => Construct(0x18cb1);
            public static FormLink<IKeywordGetter> DLC2StaffEnchanter => Construct(0x17738);
        }
    }
}
