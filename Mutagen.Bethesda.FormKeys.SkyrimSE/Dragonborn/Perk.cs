using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Perk
        {
            private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPerkGetter> DLC2MQ06MiraakExtraDamageDragonsPerk => Construct(0x3d5cd);
            public static FormLink<IPerkGetter> DLC2MQ06DragonNerfDamageMiraakPerk => Construct(0x3d5b4);
            public static FormLink<IPerkGetter> DLC2dunTT2IldariPerk => Construct(0x3d597);
            public static FormLink<IPerkGetter> DLC2EbonyWarriorPickPocketMod => Construct(0x3d291);
            public static FormLink<IPerkGetter> DLC2ArrowDefense => Construct(0x3ca73);
            public static FormLink<IPerkGetter> DLC2CriticalHit => Construct(0x3bd06);
            public static FormLink<IPerkGetter> DLC2Summoner => Construct(0x3a32e);
            public static FormLink<IPerkGetter> DLC2dunHaknirScimitar02Perk => Construct(0x38057);
            public static FormLink<IPerkGetter> DLC2dunHaknirScimitar01Perk => Construct(0x38055);
            public static FormLink<IPerkGetter> DLC2dunFrostmoonRingBloodlustBloodlust => Construct(0x35b17);
            public static FormLink<IPerkGetter> DLC2dunFrostmoonRingMoonMagnifyHowls => Construct(0x35b16);
            public static FormLink<IPerkGetter> DLC2BlackBookSeekerPerks => Construct(0x3399f);
            public static FormLink<IPerkGetter> DLC2dunKarstaagModifySummonCountPerk => Construct(0x29ee4);
            public static FormLink<IPerkGetter> DLC2dunKolbjornGauntletsPerk => Construct(0x27330);
            public static FormLink<IPerkGetter> DLC2dunKolbjornRingNecromancyPerk => Construct(0x27328);
            public static FormLink<IPerkGetter> DLC2dunKolbjornArmorPerk => Construct(0x27324);
            public static FormLink<IPerkGetter> DLC2dunKolbjornHelmPerk => Construct(0x270e9);
            public static FormLink<IPerkGetter> DLC2HorksbanePerk => Construct(0x2648f);
            public static FormLink<IPerkGetter> DLC2StalhrimEnchanting => Construct(0x26233);
            public static FormLink<IPerkGetter> DLC2AcolyteMaskAugmentShock => Construct(0x250e9);
            public static FormLink<IPerkGetter> DLC2AcolyteMaskAugmentFrost => Construct(0x250e8);
            public static FormLink<IPerkGetter> DLC2AcolyteMaskAugmentFire => Construct(0x250e7);
            public static FormLink<IPerkGetter> DLC2MatchingSetHeavy => Construct(0x2410a);
            public static FormLink<IPerkGetter> DLC2MatchingSet => Construct(0x24109);
            public static FormLink<IPerkGetter> DLC2Smithing => Construct(0x24108);
            public static FormLink<IPerkGetter> DLC2DremoraPrices => Construct(0x1eec7);
            public static FormLink<IPerkGetter> dlc2BBDrunkenMaster => Construct(0x1ed99);
            public static FormLink<IPerkGetter> DLC2BlackBookNoFallingDamagePerk => Construct(0x1e801);
            public static FormLink<IPerkGetter> DLC2BlackBookHalfDamagePerk => Construct(0x1e7fe);
            public static FormLink<IPerkGetter> DLC2BlackBookNoMagickaPerk => Construct(0x1e7fb);
            public static FormLink<IPerkGetter> DLC2BlackBookNoStaminaPerk => Construct(0x1e7f8);
            public static FormLink<IPerkGetter> DLC2BlackBookFoodPerk => Construct(0x1e7f6);
            public static FormLink<IPerkGetter> DLC2BlackBookHagglingPerk => Construct(0x1e7f1);
            public static FormLink<IPerkGetter> DLC2BlackBookCompanionsSafePerk => Construct(0x1e7f0);
            public static FormLink<IPerkGetter> DLC2BlackBookSkillBookPerk => Construct(0x1e7ed);
            public static FormLink<IPerkGetter> DLC2StandingStoneTreePerk => Construct(0x1dfa9);
            public static FormLink<IPerkGetter> DLC2StandingStoneEarthPerk => Construct(0x1df9e);
            public static FormLink<IPerkGetter> DLC2DragonAspectHeadPerk => Construct(0x1df9b);
            public static FormLink<IPerkGetter> DLC2DragonAspectArmsPerk => Construct(0x1df8f);
            public static FormLink<IPerkGetter> DLC2TTR3aAshExtractionPerk => Construct(0x1cdf0);
            public static FormLink<IPerkGetter> DLC2TTR4bBlockActivation => Construct(0x1cde7);
            public static FormLink<IPerkGetter> DLC2TameDragonActivatePerk => Construct(0x1caea);
            public static FormLink<IPerkGetter> DLC2TTR5BriarheartHarvestPerk => Construct(0x1c05b);
            public static FormLink<IPerkGetter> DLC2AshShellDmgPerk => Construct(0x177b4);
            public static FormLink<IPerkGetter> DLC2MageArmor30NPC => Construct(0x17745);
            public static FormLink<IPerkGetter> DLC2MageArmor70NPC => Construct(0x17744);
            public static FormLink<IPerkGetter> DLC2MageArmor50NPC => Construct(0x17743);
            public static FormLink<IPerkGetter> DLC2Recovery50NPC => Construct(0x17742);
            public static FormLink<IPerkGetter> DLC2wardAbsorbNPC => Construct(0x17740);
            public static FormLink<IPerkGetter> DLC2NecromageNPC => Construct(0x1773f);
            public static FormLink<IPerkGetter> DLC2Summoner70NPC => Construct(0x1773e);
            public static FormLink<IPerkGetter> DLC2AugmentedShock60NPC => Construct(0x1773d);
            public static FormLink<IPerkGetter> DLC2AugmentedFrost60NPC => Construct(0x1773c);
            public static FormLink<IPerkGetter> DLC2StaffEnchantingMult => Construct(0x17739);
        }
    }
}
