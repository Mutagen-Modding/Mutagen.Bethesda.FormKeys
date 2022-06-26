// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Skyrim
{
    public static class MovementType
    {
        private static FormLink<IMovementTypeGetter> Construct(uint id) => new FormLink<IMovementTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMovementTypeGetter> Falmer_1HM_Run => Construct(0x103273);
        public static FormLink<IMovementTypeGetter> Falmer_1HM_Walk => Construct(0x103272);
        public static FormLink<IMovementTypeGetter> AIControlledNPC_Sprinting_MT => Construct(0xf3469);
        public static FormLink<IMovementTypeGetter> Hagraven_Magic_MT => Construct(0xf0e9f);
        public static FormLink<IMovementTypeGetter> NPC_BowDrawn_QuickShot_MT => Construct(0xef542);
        public static FormLink<IMovementTypeGetter> NPC_Blocking_ShieldCharge_MT => Construct(0xef541);
        public static FormLink<IMovementTypeGetter> SabreCat_Run_MT => Construct(0xea64c);
        public static FormLink<IMovementTypeGetter> Wolf_Run_MT => Construct(0xea64b);
        public static FormLink<IMovementTypeGetter> Dog_Run_MT => Construct(0xea64a);
        public static FormLink<IMovementTypeGetter> FalmerBowDrawn_MT => Construct(0xd82f5);
        public static FormLink<IMovementTypeGetter> Horse_Swim_MT => Construct(0xc2ee2);
        public static FormLink<IMovementTypeGetter> Deer_DefaultRun_MT => Construct(0xb8f2e);
        public static FormLink<IMovementTypeGetter> Chicken_Default_MT => Construct(0xb0b90);
        public static FormLink<IMovementTypeGetter> GiantCombatRun_MT => Construct(0xa5cb2);
        public static FormLink<IMovementTypeGetter> Horse_Fall_MT => Construct(0x78722);
        public static FormLink<IMovementTypeGetter> Hare_Default_MT => Construct(0x6e27a);
        public static FormLink<IMovementTypeGetter> Bear_Swimming_MT => Construct(0x54b36);
        public static FormLink<IMovementTypeGetter> SlaughterfishSwim_MT => Construct(0xd8c5e);
        public static FormLink<IMovementTypeGetter> NPC_Drunk_MT => Construct(0xcefcf);
        public static FormLink<IMovementTypeGetter> NPC_Attacking2H_MT => Construct(0xcedfc);
        public static FormLink<IMovementTypeGetter> WerewolfBeastSprint_MT => Construct(0xcdd98);
        public static FormLink<IMovementTypeGetter> WerewolfBeastDefault_MT => Construct(0xcdd8b);
        public static FormLink<IMovementTypeGetter> CowSwimDefault_MT => Construct(0xc9edb);
        public static FormLink<IMovementTypeGetter> HorkerSwimming_MT => Construct(0xc9eda);
        public static FormLink<IMovementTypeGetter> NPC_PowerAttacking_MT => Construct(0xbff7f);
        public static FormLink<IMovementTypeGetter> NPC_Attacking_MT => Construct(0xa0bc2);
        public static FormLink<IMovementTypeGetter> Spriggan_Combat => Construct(0x2bb09);
        public static FormLink<IMovementTypeGetter> MCrab_Default_MT => Construct(0xba555);
        public static FormLink<IMovementTypeGetter> DraugrShieldBlocking_MT => Construct(0xb7306);
        public static FormLink<IMovementTypeGetter> Spriggan_Default => Construct(0x973ba);
        public static FormLink<IMovementTypeGetter> Hagraven_Default_MT => Construct(0x97241);
        public static FormLink<IMovementTypeGetter> GiantCombatWalk_MT => Construct(0x95568);
        public static FormLink<IMovementTypeGetter> Wisp_Default_MT => Construct(0x4252a);
        public static FormLink<IMovementTypeGetter> Draugr2HMBlocking_MT => Construct(0x23ef3);
        public static FormLink<IMovementTypeGetter> Draugr2GSBlocking_MT => Construct(0x21a46);
        public static FormLink<IMovementTypeGetter> AtronachFlame_Default => Construct(0x884a4);
        public static FormLink<IMovementTypeGetter> DwarvenSpider_Default_MT => Construct(0x872af);
        public static FormLink<IMovementTypeGetter> Witchlight_Default_MT => Construct(0x86f47);
        public static FormLink<IMovementTypeGetter> SteamCombat_MT => Construct(0x800ee);
        public static FormLink<IMovementTypeGetter> SteamDefault_MT => Construct(0x800ed);
        public static FormLink<IMovementTypeGetter> SphereRanged_MT => Construct(0x78750);
        public static FormLink<IMovementTypeGetter> SphereCombat_MT => Construct(0x7874f);
        public static FormLink<IMovementTypeGetter> SphereDefault_MT => Construct(0x7874e);
        public static FormLink<IMovementTypeGetter> IceWraith_Default_MT => Construct(0x2f585);
        public static FormLink<IMovementTypeGetter> DraugrH2H_MT => Construct(0x745ad);
        public static FormLink<IMovementTypeGetter> DraugrGreatSword_MT => Construct(0x745ac);
        public static FormLink<IMovementTypeGetter> DraugrBow_MT => Construct(0x745ab);
        public static FormLink<IMovementTypeGetter> DraugrBattleAxe_MT => Construct(0x745aa);
        public static FormLink<IMovementTypeGetter> Draugr1HM_MT => Construct(0x745a9);
        public static FormLink<IMovementTypeGetter> DraugrBowDrawn_MT => Construct(0x745a8);
        public static FormLink<IMovementTypeGetter> DraugrRanged_MT => Construct(0x71bef);
        public static FormLink<IMovementTypeGetter> AtronachStorm_Default => Construct(0x6b7c8);
        public static FormLink<IMovementTypeGetter> NPC_Horse_MT => Construct(0x69f74);
        public static FormLink<IMovementTypeGetter> NPC_MagicCasting_MT => Construct(0x69cdc);
        public static FormLink<IMovementTypeGetter> NPC_Magic_MT => Construct(0x69cdb);
        public static FormLink<IMovementTypeGetter> NPC_Bow_MT => Construct(0x69cda);
        public static FormLink<IMovementTypeGetter> NPC_2HM_MT => Construct(0x69cd9);
        public static FormLink<IMovementTypeGetter> NPC_1HM_MT => Construct(0x69cd8);
        public static FormLink<IMovementTypeGetter> DraugrBlocking_MT => Construct(0x6773a);
        public static FormLink<IMovementTypeGetter> Dragon_Perching_MT => Construct(0x65aa2);
        public static FormLink<IMovementTypeGetter> ChaurusDefault_MT => Construct(0x64113);
        public static FormLink<IMovementTypeGetter> Falmer_Default_MT => Construct(0x63856);
        public static FormLink<IMovementTypeGetter> DragonPriest_Default_MT => Construct(0x60788);
        public static FormLink<IMovementTypeGetter> TrollDefault_MT => Construct(0x5f5c9);
        public static FormLink<IMovementTypeGetter> DraugrDefault_MT => Construct(0x5f5c8);
        public static FormLink<IMovementTypeGetter> AtronachFrost_Default_MT => Construct(0x59662);
        public static FormLink<IMovementTypeGetter> AtronachFrost_Blocking_MT => Construct(0x59661);
        public static FormLink<IMovementTypeGetter> Mammoth_Default_MT => Construct(0x5965b);
        public static FormLink<IMovementTypeGetter> Horker_Default_MT => Construct(0x5965a);
        public static FormLink<IMovementTypeGetter> Goat_Default_MT => Construct(0x59659);
        public static FormLink<IMovementTypeGetter> Deer_Default_MT => Construct(0x59658);
        public static FormLink<IMovementTypeGetter> SabreCat_Default_MT => Construct(0x59657);
        public static FormLink<IMovementTypeGetter> Bear_Default_MT => Construct(0x59656);
        public static FormLink<IMovementTypeGetter> Cow_Default_MT => Construct(0x59655);
        public static FormLink<IMovementTypeGetter> Horse_Sprint_MT => Construct(0x4408d);
        public static FormLink<IMovementTypeGetter> Horse_Default_MT => Construct(0x1cf24);
        public static FormLink<IMovementTypeGetter> Wolf_Default_MT => Construct(0x55d28);
        public static FormLink<IMovementTypeGetter> Dog_Default_MT => Construct(0x4e5e0);
        public static FormLink<IMovementTypeGetter> Skeever_Default_MT => Construct(0x4ced0);
        public static FormLink<IMovementTypeGetter> Skeever_AttackLunge_MT => Construct(0x4cecf);
        public static FormLink<IMovementTypeGetter> GiantDefault_MT => Construct(0x3c59d);
        public static FormLink<IMovementTypeGetter> Dragon_Hovering_MT => Construct(0x1bcfb);
        public static FormLink<IMovementTypeGetter> Dragon_Flying_MT => Construct(0x1bcfa);
        public static FormLink<IMovementTypeGetter> Dragon_Default_MT => Construct(0x1bcf9);
        public static FormLink<IMovementTypeGetter> SpiderDefault_MT => Construct(0x45c4e);
        public static FormLink<IMovementTypeGetter> NPC_Swimming_MT => Construct(0x36d42);
        public static FormLink<IMovementTypeGetter> NPC_Bleedout_MT => Construct(0x36d41);
        public static FormLink<IMovementTypeGetter> NPC_Blocking_MT => Construct(0x35b4c);
        public static FormLink<IMovementTypeGetter> NPC_Default_MT => Construct(0x3580d);
        public static FormLink<IMovementTypeGetter> NPC_BowDrawn_MT => Construct(0x3580c);
        public static FormLink<IMovementTypeGetter> NPC_Sneaking_MT => Construct(0x3580b);
        public static FormLink<IMovementTypeGetter> NPC_Sprinting_MT => Construct(0x34d9c);
    }
}
