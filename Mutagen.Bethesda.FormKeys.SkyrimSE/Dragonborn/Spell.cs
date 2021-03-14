using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Spell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> DLC2AshGuardianPowerAttackExplosion => Construct(0x1e2a6);
            public static FormLink<ISpellGetter> DLC2crAshGuadianMeleeAttack => Construct(0x1e2a4);
            public static FormLink<ISpellGetter> DLC2MiraakEtherealFXSpell => Construct(0x1e0c7);
            public static FormLink<ISpellGetter> DLC2WhirlwindCloakLeftHand => Construct(0x1dbe8);
            public static FormLink<ISpellGetter> DLC2LightningStormRightHand_Miraak => Construct(0x3d5c2);
            public static FormLink<ISpellGetter> DLC2DragonAspectMiraak => Construct(0x3d5b2);
            public static FormLink<ISpellGetter> DLC2dunIldariCandlelight => Construct(0x3d5ac);
            public static FormLink<ISpellGetter> DLC2SacredStoneSpell => Construct(0x3d582);
            public static FormLink<ISpellGetter> DLC2ConjureAshGuardianLeftHand => Construct(0x3d473);
            public static FormLink<ISpellGetter> DLC2crFireWrymMeleeAttack => Construct(0x3d472);
            public static FormLink<ISpellGetter> DLC2AbWerebear => Construct(0x3d471);
            public static FormLink<ISpellGetter> DLC2ApoFontStamina => Construct(0x3d43f);
            public static FormLink<ISpellGetter> DLC2ApoFontMagicka => Construct(0x3d43c);
            public static FormLink<ISpellGetter> DLC2TTR4aCheckWater => Construct(0x3d382);
            public static FormLink<ISpellGetter> DLC2TTR4aNelothHealthSpell => Construct(0x3d304);
            public static FormLink<ISpellGetter> DLC2MQ02SeekerRightHandSpell => Construct(0x3d2f2);
            public static FormLink<ISpellGetter> DLC2VoiceMiraakCyclone03 => Construct(0x3d2ad);
            public static FormLink<ISpellGetter> DLC2abAshSpawn03FlameCloak => Construct(0x3cfee);
            public static FormLink<ISpellGetter> DLC2abRiekling => Construct(0x3cfed);
            public static FormLink<ISpellGetter> DLC2VoiceElementalFury1 => Construct(0x3cf31);
            public static FormLink<ISpellGetter> DLC2VoiceElementalFury2 => Construct(0x3cf30);
            public static FormLink<ISpellGetter> DLC2LurkerStomp => Construct(0x3cef5);
            public static FormLink<ISpellGetter> DLC2MiraakSprintFXSpell => Construct(0x3cef1);
            public static FormLink<ISpellGetter> DLC2VoiceElementalFury3 => Construct(0x3cecf);
            public static FormLink<ISpellGetter> DLC2TameDragonWoundedNoFly => Construct(0x3cd63);
            public static FormLink<ISpellGetter> DLC2MQ02SeekerMouthSpell2 => Construct(0x3ca8b);
            public static FormLink<ISpellGetter> DLC2MQ02SeekerMouthSpell => Construct(0x3ca89);
            public static FormLink<ISpellGetter> DLC2abLurker => Construct(0x3ca72);
            public static FormLink<ISpellGetter> DLC2abForitifySneak => Construct(0x3c470);
            public static FormLink<ISpellGetter> DLC2AltarMephalaSpell => Construct(0x3bcfd);
            public static FormLink<ISpellGetter> DLC2AltarBoethiahSpell => Construct(0x3bcfc);
            public static FormLink<ISpellGetter> DLC2AltarAzuraSpell => Construct(0x3bcfb);
            public static FormLink<ISpellGetter> DLC2dunHaknirSetAbility => Construct(0x3b563);
            public static FormLink<ISpellGetter> DLC2MKMorasCloakdmgSpell => Construct(0x3b548);
            public static FormLink<ISpellGetter> dlc2MKMorasCloakSpell => Construct(0x3b546);
            public static FormLink<ISpellGetter> DLC2dunFahlbtharzSteamBreathPower => Construct(0x3b00d);
            public static FormLink<ISpellGetter> DLC2TelMithrynTeleportSpell01 => Construct(0x39fb8);
            public static FormLink<ISpellGetter> dlc2MKMiraakMaskShoutSpell => Construct(0x39d27);
            public static FormLink<ISpellGetter> DLC2AbFireWyrm => Construct(0x39b8d);
            public static FormLink<ISpellGetter> dlc2MKMiraakRobeAbilitySpell => Construct(0x39152);
            public static FormLink<ISpellGetter> DLC2AbAcolyteDragonPriest => Construct(0x3911b);
            public static FormLink<ISpellGetter> DLC2dunFahlbtharzSteamBreath => Construct(0x38adc);
            public static FormLink<ISpellGetter> DLC2AshSpawnDeathFX01 => Construct(0x387fc);
            public static FormLink<ISpellGetter> DLC2dunHaknirForitifySneak => Construct(0x3804c);
            public static FormLink<ISpellGetter> DLC2dunHaknirBuff => Construct(0x37fd8);
            public static FormLink<ISpellGetter> DLC2abApoWaterDamageActual => Construct(0x3784e);
            public static FormLink<ISpellGetter> DLC2ExpSpiderShockEnemyEFFECTdmg => Construct(0x36daa);
            public static FormLink<ISpellGetter> DLC2ExpSpiderPoisonEnemyEFFECTdmg => Construct(0x36da7);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFrostEnemyEFFECTdmg => Construct(0x36da4);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireEnemyEFFECTdmg => Construct(0x36da1);
            public static FormLink<ISpellGetter> DLC2VoiceDragonFireBall06 => Construct(0x36130);
            public static FormLink<ISpellGetter> DLC2VoiceDragonFire06 => Construct(0x3612f);
            public static FormLink<ISpellGetter> DLC2VoiceDragonFrostBall06 => Construct(0x3612d);
            public static FormLink<ISpellGetter> DLC2VoiceDragonFrost06 => Construct(0x3612a);
            public static FormLink<ISpellGetter> DLC2crLurkerSpit04 => Construct(0x35bf2);
            public static FormLink<ISpellGetter> DLC2crLurkerSpit03 => Construct(0x35bf1);
            public static FormLink<ISpellGetter> DLC2crLurkerSpit02 => Construct(0x35bf0);
            public static FormLink<ISpellGetter> DLC2dunFrostmoonRingHuntRegen => Construct(0x35b1e);
            public static FormLink<ISpellGetter> DLC2dunFrostmoonRingInstinctSlowTime => Construct(0x35b1b);
            public static FormLink<ISpellGetter> DLC2TTF1ConjureAshGuardianRight => Construct(0x3553d);
            public static FormLink<ISpellGetter> DLC2KillMiraakSpell => Construct(0x354c3);
            public static FormLink<ISpellGetter> DLC2dunKarstaagConjureIceWraithSummoned => Construct(0x34b57);
            public static FormLink<ISpellGetter> DLC2BlackBookSeekerStealthSpell => Construct(0x34838);
            public static FormLink<ISpellGetter> DLC2BlackBookSeekerMagicSpell => Construct(0x34837);
            public static FormLink<ISpellGetter> DLC2BlackBookSeekerCombatSpell => Construct(0x34834);
            public static FormLink<ISpellGetter> DLC2MiraakFakeShoutSpell => Construct(0x34813);
            public static FormLink<ISpellGetter> DLC2ConjureSeeker => Construct(0x33c66);
            public static FormLink<ISpellGetter> DLC2BloodskalBladeSpellVert => Construct(0x33a27);
            public static FormLink<ISpellGetter> DLC2ExpSpiderShockResistAb => Construct(0x32794);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFrostResistAb => Construct(0x32793);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireResistAb => Construct(0x32792);
            public static FormLink<ISpellGetter> DLC2ConjureWerebear => Construct(0x322b2);
            public static FormLink<ISpellGetter> DLC2ExpSpiderShockFriendSpit => Construct(0x3229d);
            public static FormLink<ISpellGetter> DLC2ExpSpiderPoisonFriendSpit => Construct(0x3229a);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFrostFriendSpit => Construct(0x32297);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireFriendSpit => Construct(0x32294);
            public static FormLink<ISpellGetter> DLC2crFireWyrmMeleeAttack => Construct(0x31db9);
            public static FormLink<ISpellGetter> dlc2DBConjureAncientsCastBodySpell => Construct(0x31855);
            public static FormLink<ISpellGetter> dlc2DBConjureAncientsSpell => Construct(0x31853);
            public static FormLink<ISpellGetter> DLC2MQ02MiraakSpell => Construct(0x31852);
            public static FormLink<ISpellGetter> DLC2MorasGrasp => Construct(0x31844);
            public static FormLink<ISpellGetter> DLC2MorasAgony => Construct(0x31842);
            public static FormLink<ISpellGetter> DLC2MorasAgonyHazardSpell => Construct(0x3183d);
            public static FormLink<ISpellGetter> DLC2FrostStreamRightHand => Construct(0x30ce8);
            public static FormLink<ISpellGetter> DLC2FireStreamRightHand => Construct(0x30ce6);
            public static FormLink<ISpellGetter> DLC2LightningStormRightHand => Construct(0x30ce4);
            public static FormLink<ISpellGetter> DLC2ConjureSeekerHighLeftHand => Construct(0x30ce0);
            public static FormLink<ISpellGetter> DLC2ConjureSeekerLeftHand => Construct(0x30cd0);
            public static FormLink<ISpellGetter> DLC2ReflectAttackStagger => Construct(0x30ccd);
            public static FormLink<ISpellGetter> DLC2AshSpawnSelfFX01 => Construct(0x2c29e);
            public static FormLink<ISpellGetter> DLC2BardInstrumentalBuffSpell => Construct(0x2bd26);
            public static FormLink<ISpellGetter> DLC2ExpSpiderAlbinoPoisonBite => Construct(0x2af84);
            public static FormLink<ISpellGetter> DLC2VoiceBattleFury03 => Construct(0x2ad0b);
            public static FormLink<ISpellGetter> DLC2VoiceBattleFury02 => Construct(0x2ad0a);
            public static FormLink<ISpellGetter> DLC2LurkerSpray => Construct(0x2aa10);
            public static FormLink<ISpellGetter> dlc2DBDragonBreathCastBodySpell => Construct(0x2a758);
            public static FormLink<ISpellGetter> DLC2SprigganBurntFireDeath => Construct(0x2a6d5);
            public static FormLink<ISpellGetter> DLC2abApoWaterDamage => Construct(0x2a6cb);
            public static FormLink<ISpellGetter> DLC2dunKarstaagGiantClubSlam => Construct(0x2a1b7);
            public static FormLink<ISpellGetter> DLC2ConjureBardInstruments => Construct(0x29f12);
            public static FormLink<ISpellGetter> DLC2dunKarstaagAbIceWraithFX => Construct(0x29ee6);
            public static FormLink<ISpellGetter> DLC2dunKarstaagConjureIceWraith => Construct(0x29ee2);
            public static FormLink<ISpellGetter> DLC2ApocryphaRewardSpell => Construct(0x29a26);
            public static FormLink<ISpellGetter> DLC2dunSummonKarstaag1Left => Construct(0x2970a);
            public static FormLink<ISpellGetter> DLC2dunSummonKarstaag2Left => Construct(0x29709);
            public static FormLink<ISpellGetter> DLC2dunHighpointAshGuardianSpell => Construct(0x296ba);
            public static FormLink<ISpellGetter> DLC2dunInstrumentsAb => Construct(0x2969a);
            public static FormLink<ISpellGetter> DLC2crLurkerSpit01 => Construct(0x28e8a);
            public static FormLink<ISpellGetter> DLC2Seeker03RightHandSpell => Construct(0x28e85);
            public static FormLink<ISpellGetter> DLC2Seeker03MouthSpell => Construct(0x28e84);
            public static FormLink<ISpellGetter> DLC2Seeker01RightHandSpell => Construct(0x28e81);
            public static FormLink<ISpellGetter> DLC2Seeker01MouthSpell => Construct(0x28e80);
            public static FormLink<ISpellGetter> DLC2abSeekerAbilities => Construct(0x28e7e);
            public static FormLink<ISpellGetter> DLC2AbFXLurker => Construct(0x28e7c);
            public static FormLink<ISpellGetter> DLC2MiraakTeleportReturnSpell01 => Construct(0x28b37);
            public static FormLink<ISpellGetter> DLC2DiseaseDroops => Construct(0x285c1);
            public static FormLink<ISpellGetter> DLC2StormFlow => Construct(0x2858a);
            public static FormLink<ISpellGetter> DLC2FrostFlow => Construct(0x28589);
            public static FormLink<ISpellGetter> DLC2FireFlow => Construct(0x28587);
            public static FormLink<ISpellGetter> DLC2NetchCalfShockTouch => Construct(0x28582);
            public static FormLink<ISpellGetter> DLC2dunKarstaagBlizzard => Construct(0x28245);
            public static FormLink<ISpellGetter> DLC2dunKarstaagFrostCloakFreeze => Construct(0x28236);
            public static FormLink<ISpellGetter> DLC2dunKarstaagFrostDamageBoost2 => Construct(0x2822c);
            public static FormLink<ISpellGetter> DLC2dunKarstaagFrostDamageBoost1 => Construct(0x2822b);
            public static FormLink<ISpellGetter> DLC2dunKarstaagFrostCloak => Construct(0x2821d);
            public static FormLink<ISpellGetter> DLC2crAshGuardianAttack => Construct(0x27f89);
            public static FormLink<ISpellGetter> DLC2AbAshGuardian => Construct(0x27bfb);
            public static FormLink<ISpellGetter> DLC2ThunderboltLeftHand => Construct(0x279e9);
            public static FormLink<ISpellGetter> DLC2FakeDivination => Construct(0x279e8);
            public static FormLink<ISpellGetter> DLC2ExpSpiderGlowingAb => Construct(0x2747f);
            public static FormLink<ISpellGetter> DLC2dunKolbjornSetAbility => Construct(0x27332);
            public static FormLink<ISpellGetter> DLC2Freeze => Construct(0x2732d);
            public static FormLink<ISpellGetter> DLC2Ignite => Construct(0x2732b);
            public static FormLink<ISpellGetter> DLC2dunKolbjornRingNecromancyAbility => Construct(0x27329);
            public static FormLink<ISpellGetter> DLC2dunKolbjornArmorParalyze => Construct(0x27325);
            public static FormLink<ISpellGetter> DLC2dunKolbjornArmorAbility => Construct(0x27322);
            public static FormLink<ISpellGetter> DLC2NetchShockTouch => Construct(0x271fb);
            public static FormLink<ISpellGetter> DLC2abNetch => Construct(0x271f9);
            public static FormLink<ISpellGetter> DLC2ExpSpiderShockSpit => Construct(0x26d90);
            public static FormLink<ISpellGetter> DLC2ExpSpiderShockCloakDmg => Construct(0x26d68);
            public static FormLink<ISpellGetter> DLC2ExpSpiderShockCloakAb => Construct(0x26d66);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFrostSpit => Construct(0x26d53);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFrostCloakDmg => Construct(0x26d4f);
            public static FormLink<ISpellGetter> DLC2FakeProtection => Construct(0x26c8c);
            public static FormLink<ISpellGetter> DLC2KagrumezResistFire => Construct(0x2663a);
            public static FormLink<ISpellGetter> DLC2KagrumezResistShock => Construct(0x26639);
            public static FormLink<ISpellGetter> dlc2DBAncientDragonbornAggroCloakDMG => Construct(0x265ad);
            public static FormLink<ISpellGetter> dlc2DBAncientDragonbornAggroCloak => Construct(0x265ab);
            public static FormLink<ISpellGetter> dlc2DBDragonStormSpell => Construct(0x265a8);
            public static FormLink<ISpellGetter> dlc2DBDragonStormCastBodySpell => Construct(0x265a5);
            public static FormLink<ISpellGetter> dlc2DBDragonBreathSpell => Construct(0x265a3);
            public static FormLink<ISpellGetter> dlc2DBConjureSpectralDragon => Construct(0x265a0);
            public static FormLink<ISpellGetter> DLC2BlackBookDragonbornFrostSpell => Construct(0x2647e);
            public static FormLink<ISpellGetter> DLC2BlackBookDragonbornFlameSpell => Construct(0x2647d);
            public static FormLink<ISpellGetter> DLC2BlackBookDragonbornForceSpell => Construct(0x2647b);
            public static FormLink<ISpellGetter> DLC2crLurkerStomp => Construct(0x2622e);
            public static FormLink<ISpellGetter> DLC2crLurkerMagicResistance => Construct(0x2622d);
            public static FormLink<ISpellGetter> DLC2MiraakTeleportSpell01 => Construct(0x25e10);
            public static FormLink<ISpellGetter> DLC2Seeker02RightHandSpell => Construct(0x24fc7);
            public static FormLink<ISpellGetter> DLC2Seeker02MouthSpell => Construct(0x24fc5);
            public static FormLink<ISpellGetter> crKarstaagResistances => Construct(0x24816);
            public static FormLink<ISpellGetter> DLC2dunSummonKarstaag3Left => Construct(0x24812);
            public static FormLink<ISpellGetter> DLC2AbFXHMDaedraSpell => Construct(0x23f82);
            public static FormLink<ISpellGetter> DLC2crAshSPawnUnarmedDamage03 => Construct(0x20f08);
            public static FormLink<ISpellGetter> DLC2crAshSpawnFireboltLeftHand03 => Construct(0x20f07);
            public static FormLink<ISpellGetter> DLC2crAshSpawnFireboltLeftHand02 => Construct(0x20f06);
            public static FormLink<ISpellGetter> DLC2crAshSPawnUnarmedDamage02 => Construct(0x20f05);
            public static FormLink<ISpellGetter> DLC2crAshSPawnUnarmedDamage01 => Construct(0x20f04);
            public static FormLink<ISpellGetter> DLC2crAshSpawnFireboltLeftHand01 => Construct(0x20f03);
            public static FormLink<ISpellGetter> DLC2AshBreath1 => Construct(0x20f01);
            public static FormLink<ISpellGetter> DLC2BlackBookFireStorm => Construct(0x20ea3);
            public static FormLink<ISpellGetter> DLC2BlackBookFlameCloakDmg => Construct(0x20ea0);
            public static FormLink<ISpellGetter> DLC2BlackBookFlameCloak => Construct(0x20e9d);
            public static FormLink<ISpellGetter> DLC2crScribPoisonBite => Construct(0x20e92);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFrostCloakAb => Construct(0x206e0);
            public static FormLink<ISpellGetter> DLC2AbAshHopper => Construct(0x2068f);
            public static FormLink<ISpellGetter> DLC2abCalmDragon => Construct(0x202cc);
            public static FormLink<ISpellGetter> DLC2TestCalm => Construct(0x202c9);
            public static FormLink<ISpellGetter> DLC2TameDragonNoFlyAbility => Construct(0x200eb);
            public static FormLink<ISpellGetter> DLC2VoiceBattleFury01 => Construct(0x200c6);
            public static FormLink<ISpellGetter> DLC2VoiceCyclone03 => Construct(0x200c1);
            public static FormLink<ISpellGetter> DLC2VoiceCyclone02 => Construct(0x200be);
            public static FormLink<ISpellGetter> DLC2VoiceCyclone01 => Construct(0x200bc);
            public static FormLink<ISpellGetter> DLC2AshRightHand => Construct(0x1ff31);
            public static FormLink<ISpellGetter> DLC2AbSprigganBurnt => Construct(0x1ff2f);
            public static FormLink<ISpellGetter> DLC2DiseaseBlackHeartBlight => Construct(0x1ff2e);
            public static FormLink<ISpellGetter> DLC2crSprigganBurntFlames => Construct(0x1ff2d);
            public static FormLink<ISpellGetter> DLC2abDremoraCarryWeight => Construct(0x1ff26);
            public static FormLink<ISpellGetter> DLC2ConjureDremoraButler => Construct(0x1ff21);
            public static FormLink<ISpellGetter> DLC2VoiceBendWill2 => Construct(0x1ff1e);
            public static FormLink<ISpellGetter> DLC2dunFrostmoonWerewolfChangeFX => Construct(0x1f9c1);
            public static FormLink<ISpellGetter> dlc2SpectralDragonSummonSpell => Construct(0x1f997);
            public static FormLink<ISpellGetter> dlc2SpectralDragonShout => Construct(0x1f994);
            public static FormLink<ISpellGetter> DLC2ConjureDremoraMerchant => Construct(0x1eec6);
            public static FormLink<ISpellGetter> dlc2BBUnlimitedMagickaSpell => Construct(0x1eda2);
            public static FormLink<ISpellGetter> dlc2BBUnlimitedStaminaSpell => Construct(0x1eda0);
            public static FormLink<ISpellGetter> dlc2BBWrithingWallSpell => Construct(0x1ed9c);
            public static FormLink<ISpellGetter> dlc2BBStopRuneSpell => Construct(0x1ed9a);
            public static FormLink<ISpellGetter> DLC2BlackBookNoFallingDamageSpell => Construct(0x1e803);
            public static FormLink<ISpellGetter> DLC2BlackBookHalfDamageSpell => Construct(0x1e800);
            public static FormLink<ISpellGetter> DLC2BlackBookNoMagickaSpell => Construct(0x1e7fd);
            public static FormLink<ISpellGetter> DLC2BlackBookNoStaminaSpell => Construct(0x1e7fa);
            public static FormLink<ISpellGetter> DLC2BlackBookHealSpell => Construct(0x1e7f7);
            public static FormLink<ISpellGetter> DLC2BlackBookCompanionsSafeSpell => Construct(0x1e7f5);
            public static FormLink<ISpellGetter> DLC2BlackBookHagglingSpell => Construct(0x1e7f3);
            public static FormLink<ISpellGetter> DLC2BlackBookSkillBookSpell => Construct(0x1e7ef);
            public static FormLink<ISpellGetter> DLC2WerebearChangeFX => Construct(0x1e178);
            public static FormLink<ISpellGetter> DLC2StandingStoneTreeSpell => Construct(0x1dfab);
            public static FormLink<ISpellGetter> DLC2StandingStoneWaterSpell => Construct(0x1dfa7);
            public static FormLink<ISpellGetter> DLC2StandingStoneWindSpell => Construct(0x1dfa5);
            public static FormLink<ISpellGetter> DLC2StandingStoneBeastSpell => Construct(0x1dfa4);
            public static FormLink<ISpellGetter> DLC2StandingStoneEarthSpell => Construct(0x1df9f);
            public static FormLink<ISpellGetter> DLC2StandingStoneSunSpell => Construct(0x1df9c);
            public static FormLink<ISpellGetter> DLC2DragonAspectHeadSpell => Construct(0x1df99);
            public static FormLink<ISpellGetter> DLC2DragonAspectBodySpell => Construct(0x1df96);
            public static FormLink<ISpellGetter> DLC2DragonAspectArmsSpell => Construct(0x1df91);
            public static FormLink<ISpellGetter> DLC2dunKolbjornRalisRitualSpell => Construct(0x1dbd7);
            public static FormLink<ISpellGetter> DLC2dunKolbjornRalisKnockback => Construct(0x1dbd2);
            public static FormLink<ISpellGetter> WallOfFlamesLeftHand => Construct(0x1dbd1);
            public static FormLink<ISpellGetter> DLC2PoisonRune => Construct(0x1d74b);
            public static FormLink<ISpellGetter> DLC2BoundDagger => Construct(0x1ce06);
            public static FormLink<ISpellGetter> DLC2ConjureAshSpawn => Construct(0x1cdf6);
            public static FormLink<ISpellGetter> DLC2TTR4bNelothsSpell => Construct(0x1cde5);
            public static FormLink<ISpellGetter> DLC2ExpSpiderPoisonCloakDmg => Construct(0x1cab9);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireCloakDmg => Construct(0x1cab6);
            public static FormLink<ISpellGetter> DLC2ExpSpiderPoisonCloakAb => Construct(0x1caac);
            public static FormLink<ISpellGetter> DLC2NelothsHealthRemoved => Construct(0x1c075);
            public static FormLink<ISpellGetter> DLC2NelothsHealth => Construct(0x1c073);
            public static FormLink<ISpellGetter> DLC2TTR5MemoryReturned => Construct(0x1c067);
            public static FormLink<ISpellGetter> DLC2TTR5MemoryStored => Construct(0x1c066);
            public static FormLink<ISpellGetter> dlc2DBRageOfAncientsSpell => Construct(0x1bff5);
            public static FormLink<ISpellGetter> dlc2MerchBowOfTheStagBlessing => Construct(0x1bfec);
            public static FormLink<ISpellGetter> DLC2TTR4aFortifyHealth => Construct(0x1bd0a);
            public static FormLink<ISpellGetter> DLC2AbAshSpawn => Construct(0x1b638);
            public static FormLink<ISpellGetter> DLC2BloodskalBladeSpellHoriz => Construct(0x1aeae);
            public static FormLink<ISpellGetter> DLC2HazardLurkerSlimeSpell => Construct(0x1ae9e);
            public static FormLink<ISpellGetter> DLC2LurkerSlime => Construct(0x1ae98);
            public static FormLink<ISpellGetter> DLC2crAshSpawnCyclone03RightHand => Construct(0x1aaae);
            public static FormLink<ISpellGetter> DLC2DetectAshSourceSpell => Construct(0x1961a);
            public static FormLink<ISpellGetter> testPhilMoth => Construct(0x18cea);
            public static FormLink<ISpellGetter> testPhilWhale => Construct(0x18ce8);
            public static FormLink<ISpellGetter> testPhilFoxInvisibility => Construct(0x18cdb);
            public static FormLink<ISpellGetter> testPhilFox => Construct(0x18cd8);
            public static FormLink<ISpellGetter> DLC2VoiceBendWill3 => Construct(0x179e1);
            public static FormLink<ISpellGetter> DLC2VoiceBendWill1 => Construct(0x179dc);
            public static FormLink<ISpellGetter> DLC2ExpSpiderZombieAb => Construct(0x1795d);
            public static FormLink<ISpellGetter> DLC2FrenzyRune => Construct(0x177b7);
            public static FormLink<ISpellGetter> DLC2AshRune => Construct(0x177af);
            public static FormLink<ISpellGetter> DLC2AshGuardianRune => Construct(0x17782);
            public static FormLink<ISpellGetter> DLC2PerkMagickaRecovery2NPC => Construct(0x17741);
            public static FormLink<ISpellGetter> DLC2WhirlwindCloakConc => Construct(0x17735);
            public static FormLink<ISpellGetter> DLC2WhirlwindCloakDmgConc => Construct(0x17734);
            public static FormLink<ISpellGetter> DLC2AshShell => Construct(0x17731);
            public static FormLink<ISpellGetter> DLC2WhirlwindCloakDmg => Construct(0x1772f);
            public static FormLink<ISpellGetter> DLC2WhirlwindCloak => Construct(0x1772d);
            public static FormLink<ISpellGetter> DLC2Fling => Construct(0x1772c);
            public static FormLink<ISpellGetter> DLC2AbWaterwalking => Construct(0x173c2);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireCloakAb => Construct(0x17075);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireSpit => Construct(0x14484);
            public static FormLink<ISpellGetter> DLC2ExpSpiderFireHazardSpell => Construct(0x1447e);
            public static FormLink<ISpellGetter> DLC2ExpSpiderPoisonHazardSpell => Construct(0x1445c);
            public static FormLink<ISpellGetter> DLC2ExpSpiderPoisonSpit => Construct(0x1444e);
        }
    }
}
