using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class LoadScreen
        {
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> SE11Load04 => Construct(0x552c8);
            public static FormLink<ILoadScreenGetter> SE11Load03 => Construct(0x552c7);
            public static FormLink<ILoadScreenGetter> SE11Load02 => Construct(0x552c6);
            public static FormLink<ILoadScreenGetter> SE11Load01 => Construct(0x552c5);
            public static FormLink<ILoadScreenGetter> SE08Load02 => Construct(0x552c4);
            public static FormLink<ILoadScreenGetter> SE08Load01 => Construct(0x552c3);
            public static FormLink<ILoadScreenGetter> SE07Load03 => Construct(0x552c2);
            public static FormLink<ILoadScreenGetter> SE07Load02 => Construct(0x552c1);
            public static FormLink<ILoadScreenGetter> SE07Load01 => Construct(0x552c0);
            public static FormLink<ILoadScreenGetter> SENSPalaceLoad03 => Construct(0x552bf);
            public static FormLink<ILoadScreenGetter> SENSPalaceLoad02 => Construct(0x552be);
            public static FormLink<ILoadScreenGetter> SENewSheoth02 => Construct(0x552bd);
            public static FormLink<ILoadScreenGetter> SE03Load02 => Construct(0x552bb);
            public static FormLink<ILoadScreenGetter> SE03Load01 => Construct(0x552ba);
            public static FormLink<ILoadScreenGetter> SE09Load03 => Construct(0x552b9);
            public static FormLink<ILoadScreenGetter> SEInGameDefault13 => Construct(0x552b8);
            public static FormLink<ILoadScreenGetter> SEInGameDefault12 => Construct(0x552b7);
            public static FormLink<ILoadScreenGetter> SENSCrucibleLoad04 => Construct(0x552b6);
            public static FormLink<ILoadScreenGetter> SENSBlissLoad04 => Construct(0x552b5);
            public static FormLink<ILoadScreenGetter> SE09Load02 => Construct(0x552b4);
            public static FormLink<ILoadScreenGetter> SE09Load01 => Construct(0x552b3);
            public static FormLink<ILoadScreenGetter> SE02Load01 => Construct(0x552b2);
            public static FormLink<ILoadScreenGetter> SE10Load04 => Construct(0x525a9);
            public static FormLink<ILoadScreenGetter> SE10Load03 => Construct(0x525a8);
            public static FormLink<ILoadScreenGetter> SE10Load02 => Construct(0x525a7);
            public static FormLink<ILoadScreenGetter> SE10Load01 => Construct(0x525a6);
            public static FormLink<ILoadScreenGetter> SE04Load02 => Construct(0x525a5);
            public static FormLink<ILoadScreenGetter> SE04Load01 => Construct(0x525a4);
            public static FormLink<ILoadScreenGetter> SE12Load01 => Construct(0x525a3);
            public static FormLink<ILoadScreenGetter> SE06Load01 => Construct(0x525a2);
            public static FormLink<ILoadScreenGetter> SE32Load01 => Construct(0x525a1);
            public static FormLink<ILoadScreenGetter> SEInGameDefault11 => Construct(0x525a0);
            public static FormLink<ILoadScreenGetter> SEInGameDefault10 => Construct(0x5259f);
            public static FormLink<ILoadScreenGetter> SEInGameDefault09 => Construct(0x5259e);
            public static FormLink<ILoadScreenGetter> SEInGameDefault08 => Construct(0x5259d);
            public static FormLink<ILoadScreenGetter> SEInGameDefault07 => Construct(0x5259c);
            public static FormLink<ILoadScreenGetter> SENSBlissLoad03 => Construct(0x5259b);
            public static FormLink<ILoadScreenGetter> SENSCrucibleLoad03 => Construct(0x5259a);
            public static FormLink<ILoadScreenGetter> SEInGameDefault06 => Construct(0x52599);
            public static FormLink<ILoadScreenGetter> SEInGameDefault05 => Construct(0x52598);
            public static FormLink<ILoadScreenGetter> SEInGameDefault04 => Construct(0x52597);
            public static FormLink<ILoadScreenGetter> SENSCrucibleLoad02 => Construct(0x52596);
            public static FormLink<ILoadScreenGetter> SENSBlissLoad02 => Construct(0x52595);
            public static FormLink<ILoadScreenGetter> SESettlement06 => Construct(0x52594);
            public static FormLink<ILoadScreenGetter> SESettlement05 => Construct(0x52593);
            public static FormLink<ILoadScreenGetter> SESettlement04 => Construct(0x52592);
            public static FormLink<ILoadScreenGetter> SESettlement03 => Construct(0x52591);
            public static FormLink<ILoadScreenGetter> SESettlement02 => Construct(0x52590);
            public static FormLink<ILoadScreenGetter> SETheFringe01 => Construct(0x5258f);
            public static FormLink<ILoadScreenGetter> SESettlement01 => Construct(0x5258e);
            public static FormLink<ILoadScreenGetter> SEGatesMadness01 => Construct(0x5258d);
            public static FormLink<ILoadScreenGetter> SENSPalaceLoad01 => Construct(0x5258c);
            public static FormLink<ILoadScreenGetter> SENSBlissLoad01 => Construct(0x5258b);
            public static FormLink<ILoadScreenGetter> SENSCrucibleLoad01 => Construct(0x5258a);
            public static FormLink<ILoadScreenGetter> SENewSheoth01 => Construct(0x52589);
            public static FormLink<ILoadScreenGetter> SEInGameDefault03 => Construct(0x52588);
            public static FormLink<ILoadScreenGetter> SEInGameDefault02 => Construct(0x52587);
            public static FormLink<ILoadScreenGetter> SEInGameDefault01 => Construct(0x52586);
            public static FormLink<ILoadScreenGetter> InGameSpellVendor03 => Construct(0xc3f8);
            public static FormLink<ILoadScreenGetter> InGameSpellVendor02 => Construct(0xc3f7);
            public static FormLink<ILoadScreenGetter> InGameSpellVendor01 => Construct(0xc3f6);
            public static FormLink<ILoadScreenGetter> MagesGuild04 => Construct(0xc3f5);
            public static FormLink<ILoadScreenGetter> InGameCombat20 => Construct(0xcb620);
            public static FormLink<ILoadScreenGetter> InGameSkingrad05 => Construct(0xcad15);
            public static FormLink<ILoadScreenGetter> InGameSkingrad04 => Construct(0xcad14);
            public static FormLink<ILoadScreenGetter> InGameLeyawiin05 => Construct(0xcad13);
            public static FormLink<ILoadScreenGetter> InGameLeyawiin04 => Construct(0xcad12);
            public static FormLink<ILoadScreenGetter> InGameImperialCity08 => Construct(0xcad11);
            public static FormLink<ILoadScreenGetter> InGameImperialCity07 => Construct(0xcad10);
            public static FormLink<ILoadScreenGetter> InGameChorrol07 => Construct(0xcad0f);
            public static FormLink<ILoadScreenGetter> InGameChorrol06 => Construct(0xcad0e);
            public static FormLink<ILoadScreenGetter> InGameCheydinhal06 => Construct(0xcad0d);
            public static FormLink<ILoadScreenGetter> InGameCheydinhal05 => Construct(0xcad0c);
            public static FormLink<ILoadScreenGetter> InGameBruma07 => Construct(0xcad0b);
            public static FormLink<ILoadScreenGetter> InGameBruma06 => Construct(0xcad0a);
            public static FormLink<ILoadScreenGetter> InGameBravil07 => Construct(0xcad09);
            public static FormLink<ILoadScreenGetter> InGameBravil06 => Construct(0xcad08);
            public static FormLink<ILoadScreenGetter> InGameAnvil07 => Construct(0xcad07);
            public static FormLink<ILoadScreenGetter> InGameAnvil06 => Construct(0xcad06);
            public static FormLink<ILoadScreenGetter> Chapels05 => Construct(0xcad05);
            public static FormLink<ILoadScreenGetter> Chapels04 => Construct(0xcad04);
            public static FormLink<ILoadScreenGetter> InGameSkingrad03 => Construct(0xcad03);
            public static FormLink<ILoadScreenGetter> InGameSkingrad02 => Construct(0xcad02);
            public static FormLink<ILoadScreenGetter> InGameLeyawiin03 => Construct(0xcad01);
            public static FormLink<ILoadScreenGetter> InGameLeyawiin02 => Construct(0xcad00);
            public static FormLink<ILoadScreenGetter> InGameChorrol05 => Construct(0xcacff);
            public static FormLink<ILoadScreenGetter> InGameChorrol04 => Construct(0xcacfe);
            public static FormLink<ILoadScreenGetter> InGameCheydinhal04 => Construct(0xcacfd);
            public static FormLink<ILoadScreenGetter> InGameCheydinhal03 => Construct(0xcacfc);
            public static FormLink<ILoadScreenGetter> InGameBruma05 => Construct(0xcacfb);
            public static FormLink<ILoadScreenGetter> InGameBruma04 => Construct(0xcacfa);
            public static FormLink<ILoadScreenGetter> InGameBravil05 => Construct(0xcacf9);
            public static FormLink<ILoadScreenGetter> InGameBravil04 => Construct(0xcacf8);
            public static FormLink<ILoadScreenGetter> InGameAnvil05 => Construct(0xcacf7);
            public static FormLink<ILoadScreenGetter> InGameAnvil04 => Construct(0xcacf6);
            public static FormLink<ILoadScreenGetter> InGameMagic06 => Construct(0xca0f7);
            public static FormLink<ILoadScreenGetter> InGameBruma03 => Construct(0xca089);
            public static FormLink<ILoadScreenGetter> InGameBruma02 => Construct(0xca088);
            public static FormLink<ILoadScreenGetter> InGameBravil03 => Construct(0xca087);
            public static FormLink<ILoadScreenGetter> Chapels03 => Construct(0xca072);
            public static FormLink<ILoadScreenGetter> Chapels02 => Construct(0xca071);
            public static FormLink<ILoadScreenGetter> Chapels01 => Construct(0xca070);
            public static FormLink<ILoadScreenGetter> VampireDungeonLoad01 => Construct(0xc9e76);
            public static FormLink<ILoadScreenGetter> InGameStealth09 => Construct(0xc8bc8);
            public static FormLink<ILoadScreenGetter> InGameMagic05 => Construct(0xc8973);
            public static FormLink<ILoadScreenGetter> InGameDefault20 => Construct(0xc853f);
            public static FormLink<ILoadScreenGetter> InGameSpellsDestruction06 => Construct(0xc75b6);
            public static FormLink<ILoadScreenGetter> InGameSpellsAlteration05 => Construct(0xc75b5);
            public static FormLink<ILoadScreenGetter> InGameSpellsConjuration04 => Construct(0xc75b4);
            public static FormLink<ILoadScreenGetter> InGameSpellsMysticism06 => Construct(0xc75b3);
            public static FormLink<ILoadScreenGetter> InGameSpellsConjuration03 => Construct(0xc75b2);
            public static FormLink<ILoadScreenGetter> InGameSpellsConjuration02 => Construct(0xc75b1);
            public static FormLink<ILoadScreenGetter> InGameSpellsMysticism05 => Construct(0xc75b0);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion09 => Construct(0xc75af);
            public static FormLink<ILoadScreenGetter> InGameSpellsAlteration04 => Construct(0xc75ae);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration07 => Construct(0xc75ad);
            public static FormLink<ILoadScreenGetter> InGameSpellsMysticism04 => Construct(0xc75ac);
            public static FormLink<ILoadScreenGetter> InGameSpellsMysticism03 => Construct(0xc75ab);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration06 => Construct(0xc75aa);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion08 => Construct(0xc75a9);
            public static FormLink<ILoadScreenGetter> InGameSpellsAlteration03 => Construct(0xc75a8);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion07 => Construct(0xc75a7);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion06 => Construct(0xc75a6);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration05 => Construct(0xc75a5);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration04 => Construct(0xc75a4);
            public static FormLink<ILoadScreenGetter> InGameSpellsAlteration02 => Construct(0xc75a3);
            public static FormLink<ILoadScreenGetter> InGameSpellsDestruction05 => Construct(0xc75a2);
            public static FormLink<ILoadScreenGetter> InGameSpellsMysticism02 => Construct(0xc75a1);
            public static FormLink<ILoadScreenGetter> InGameSpellsMysticism01 => Construct(0xc75a0);
            public static FormLink<ILoadScreenGetter> InGameSpellsDestruction04 => Construct(0xc759f);
            public static FormLink<ILoadScreenGetter> InGameSpellsDestruction03 => Construct(0xc759e);
            public static FormLink<ILoadScreenGetter> InGameSpellsDestruction02 => Construct(0xc759d);
            public static FormLink<ILoadScreenGetter> InGameSpellsDestruction01 => Construct(0xc759c);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion05 => Construct(0xc759b);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration03 => Construct(0xc759a);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion04 => Construct(0xc7599);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion03 => Construct(0xc7598);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion02 => Construct(0xc7597);
            public static FormLink<ILoadScreenGetter> InGameSpellsIllusion01 => Construct(0xc7596);
            public static FormLink<ILoadScreenGetter> InGameSpellsAlteration01 => Construct(0xc7595);
            public static FormLink<ILoadScreenGetter> InGameSpellsConjuration01 => Construct(0xc7594);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration02 => Construct(0xc7593);
            public static FormLink<ILoadScreenGetter> InGameSpellsRestoration01 => Construct(0xc7592);
            public static FormLink<ILoadScreenGetter> MS05Dreamworld02 => Construct(0x8c831);
            public static FormLink<ILoadScreenGetter> MS05Dreamworld01 => Construct(0x8c82f);
            public static FormLink<ILoadScreenGetter> MS02BenirusManor => Construct(0x88ffc);
            public static FormLink<ILoadScreenGetter> MS12PalePassRuins02 => Construct(0x7be5b);
            public static FormLink<ILoadScreenGetter> MS12PalePassRuins => Construct(0x7be5a);
            public static FormLink<ILoadScreenGetter> MS12PalePass => Construct(0x7be59);
            public static FormLink<ILoadScreenGetter> InGameStealth08 => Construct(0x7b477);
            public static FormLink<ILoadScreenGetter> InGameStealth07 => Construct(0x7b476);
            public static FormLink<ILoadScreenGetter> InGameStealth06 => Construct(0x7b475);
            public static FormLink<ILoadScreenGetter> InGamePerksSneak05 => Construct(0x7b474);
            public static FormLink<ILoadScreenGetter> MQ16BattleSpacesLoad => Construct(0x795e0);
            public static FormLink<ILoadScreenGetter> MQ16TempleOfTheOne => Construct(0x795df);
            public static FormLink<ILoadScreenGetter> InGameImperialCity06 => Construct(0x6fddd);
            public static FormLink<ILoadScreenGetter> InGameCheydinhal02 => Construct(0x6fddc);
            public static FormLink<ILoadScreenGetter> InGameBravil02 => Construct(0x6fddb);
            public static FormLink<ILoadScreenGetter> InGameDialogue08 => Construct(0x6ab36);
            public static FormLink<ILoadScreenGetter> InGameDialogue07 => Construct(0x6ab35);
            public static FormLink<ILoadScreenGetter> InGameDialogue06 => Construct(0x6ab34);
            public static FormLink<ILoadScreenGetter> InGameDialogue04 => Construct(0x6ab32);
            public static FormLink<ILoadScreenGetter> InGameDialogue03 => Construct(0x6ab31);
            public static FormLink<ILoadScreenGetter> InGameDialogue02 => Construct(0x6ab30);
            public static FormLink<ILoadScreenGetter> InGameDialogue01 => Construct(0x6ab2f);
            public static FormLink<ILoadScreenGetter> InGameCreatures01 => Construct(0x6ab2e);
            public static FormLink<ILoadScreenGetter> InGameBirthsign13 => Construct(0x6ab2d);
            public static FormLink<ILoadScreenGetter> InGameBirthsign12 => Construct(0x6ab2c);
            public static FormLink<ILoadScreenGetter> InGameBirthsign11 => Construct(0x6ab2b);
            public static FormLink<ILoadScreenGetter> InGameBirthsign10 => Construct(0x6ab2a);
            public static FormLink<ILoadScreenGetter> InGameBirthsign09 => Construct(0x6ab29);
            public static FormLink<ILoadScreenGetter> InGameBirthsign08 => Construct(0x6ab28);
            public static FormLink<ILoadScreenGetter> InGameBirthsign07 => Construct(0x6ab27);
            public static FormLink<ILoadScreenGetter> InGameBirthsign06 => Construct(0x6ab26);
            public static FormLink<ILoadScreenGetter> InGameBirthsign05 => Construct(0x6ab25);
            public static FormLink<ILoadScreenGetter> InGameBirthsign04 => Construct(0x6ab24);
            public static FormLink<ILoadScreenGetter> InGameBirthsign03 => Construct(0x6ab23);
            public static FormLink<ILoadScreenGetter> InGameBirthsign02 => Construct(0x6ab22);
            public static FormLink<ILoadScreenGetter> InGameBirthsign01 => Construct(0x6ab21);
            public static FormLink<ILoadScreenGetter> InGamePerksLight05 => Construct(0x6ab20);
            public static FormLink<ILoadScreenGetter> InGamePerksLight04 => Construct(0x6ab1f);
            public static FormLink<ILoadScreenGetter> InGamePerksLight03 => Construct(0x6ab1e);
            public static FormLink<ILoadScreenGetter> InGamePerksLight02 => Construct(0x6ab1d);
            public static FormLink<ILoadScreenGetter> InGamePerksLight01 => Construct(0x6ab1c);
            public static FormLink<ILoadScreenGetter> InGamePerksMercantile04 => Construct(0x6ab1b);
            public static FormLink<ILoadScreenGetter> InGamePerksMercantile03 => Construct(0x6ab1a);
            public static FormLink<ILoadScreenGetter> InGamePerksMercantile02 => Construct(0x6ab19);
            public static FormLink<ILoadScreenGetter> InGamePerksMercantile01 => Construct(0x6ab18);
            public static FormLink<ILoadScreenGetter> InGamePerksMarksman05 => Construct(0x6ab17);
            public static FormLink<ILoadScreenGetter> InGamePerksMarksman04 => Construct(0x6ab16);
            public static FormLink<ILoadScreenGetter> InGamePerksMarksman03 => Construct(0x6ab15);
            public static FormLink<ILoadScreenGetter> InGamePerksMarksman02 => Construct(0x6ab14);
            public static FormLink<ILoadScreenGetter> InGamePerksMarksman01 => Construct(0x6ab13);
            public static FormLink<ILoadScreenGetter> InGamePerksAcrobatics04 => Construct(0x6ab12);
            public static FormLink<ILoadScreenGetter> InGamePerksAcrobatics03 => Construct(0x6ab11);
            public static FormLink<ILoadScreenGetter> InGamePerksAcrobatics02 => Construct(0x6ab10);
            public static FormLink<ILoadScreenGetter> InGamePerksAcrobatics01 => Construct(0x6ab0f);
            public static FormLink<ILoadScreenGetter> InGamePerksSneak04 => Construct(0x6ab0e);
            public static FormLink<ILoadScreenGetter> InGamePerksSneak03 => Construct(0x6ab0d);
            public static FormLink<ILoadScreenGetter> InGamePerksSneak02 => Construct(0x6ab0c);
            public static FormLink<ILoadScreenGetter> InGamePerksSneak01 => Construct(0x6ab0b);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat11 => Construct(0x6ab0a);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat10 => Construct(0x6ab09);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat09 => Construct(0x6ab08);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat08 => Construct(0x6ab07);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat07 => Construct(0x6ab06);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat06 => Construct(0x6ab05);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat05 => Construct(0x6ab04);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat04 => Construct(0x6ab03);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat03 => Construct(0x6ab02);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat02 => Construct(0x6ab01);
            public static FormLink<ILoadScreenGetter> InGamePerksCombat01 => Construct(0x6ab00);
            public static FormLink<ILoadScreenGetter> InGamePerksAthletics03 => Construct(0x6aaff);
            public static FormLink<ILoadScreenGetter> InGamePerksAthletics02 => Construct(0x6aafe);
            public static FormLink<ILoadScreenGetter> InGamePerksAthletics01 => Construct(0x6aafd);
            public static FormLink<ILoadScreenGetter> InGamePerksHeavy05 => Construct(0x6aafc);
            public static FormLink<ILoadScreenGetter> InGamePerksHeavy04 => Construct(0x6aafb);
            public static FormLink<ILoadScreenGetter> InGamePerksHeavy03 => Construct(0x6aafa);
            public static FormLink<ILoadScreenGetter> InGamePerksHeavy02 => Construct(0x6aaf9);
            public static FormLink<ILoadScreenGetter> InGamePerksArmorer05 => Construct(0x6aaf7);
            public static FormLink<ILoadScreenGetter> InGamePerksArmorer04 => Construct(0x6aaf6);
            public static FormLink<ILoadScreenGetter> InGamePerksArmorer03 => Construct(0x6aaf5);
            public static FormLink<ILoadScreenGetter> InGamePerksArmorer02 => Construct(0x6aaf4);
            public static FormLink<ILoadScreenGetter> InGamePerksBlock04 => Construct(0x6aaf2);
            public static FormLink<ILoadScreenGetter> InGamePerksBlock03 => Construct(0x6aaf1);
            public static FormLink<ILoadScreenGetter> InGamePerksBlock02 => Construct(0x6aaf0);
            public static FormLink<ILoadScreenGetter> InGamePerksBlock01 => Construct(0x6aaef);
            public static FormLink<ILoadScreenGetter> InGamePerks02 => Construct(0x6aaee);
            public static FormLink<ILoadScreenGetter> InGamePerks01 => Construct(0x6aaed);
            public static FormLink<ILoadScreenGetter> InGameSkills13 => Construct(0x6aaec);
            public static FormLink<ILoadScreenGetter> InGameSkills12 => Construct(0x6aaeb);
            public static FormLink<ILoadScreenGetter> InGameSkills11 => Construct(0x6aaea);
            public static FormLink<ILoadScreenGetter> InGameSkills10 => Construct(0x6aae9);
            public static FormLink<ILoadScreenGetter> InGameSkills09 => Construct(0x6aae8);
            public static FormLink<ILoadScreenGetter> InGameSkills08 => Construct(0x6aae7);
            public static FormLink<ILoadScreenGetter> InGameSkills07 => Construct(0x6aae6);
            public static FormLink<ILoadScreenGetter> InGameSkills05 => Construct(0x6aae5);
            public static FormLink<ILoadScreenGetter> InGameSkills04 => Construct(0x6aae4);
            public static FormLink<ILoadScreenGetter> InGameSkills03 => Construct(0x6aae3);
            public static FormLink<ILoadScreenGetter> InGameSkills02 => Construct(0x6aae2);
            public static FormLink<ILoadScreenGetter> InGameSkills01 => Construct(0x6aae1);
            public static FormLink<ILoadScreenGetter> InGameRace11 => Construct(0x6aae0);
            public static FormLink<ILoadScreenGetter> InGameRace10 => Construct(0x6aadf);
            public static FormLink<ILoadScreenGetter> InGameRace09 => Construct(0x6aade);
            public static FormLink<ILoadScreenGetter> InGameRace08 => Construct(0x6aadd);
            public static FormLink<ILoadScreenGetter> InGameRace07 => Construct(0x6aadc);
            public static FormLink<ILoadScreenGetter> InGameRace06 => Construct(0x6aadb);
            public static FormLink<ILoadScreenGetter> InGameRace05 => Construct(0x6aada);
            public static FormLink<ILoadScreenGetter> InGameRace04 => Construct(0x6aad9);
            public static FormLink<ILoadScreenGetter> InGameRace03 => Construct(0x6aad8);
            public static FormLink<ILoadScreenGetter> InGameRace02 => Construct(0x6aad7);
            public static FormLink<ILoadScreenGetter> InGameRace01 => Construct(0x6aad6);
            public static FormLink<ILoadScreenGetter> InGameStealth04 => Construct(0x6aad5);
            public static FormLink<ILoadScreenGetter> InGameStealth03 => Construct(0x6aad4);
            public static FormLink<ILoadScreenGetter> InGameStealth02 => Construct(0x6aad3);
            public static FormLink<ILoadScreenGetter> InGameStealth01 => Construct(0x6aad2);
            public static FormLink<ILoadScreenGetter> InGameMagic04 => Construct(0x6aad1);
            public static FormLink<ILoadScreenGetter> InGameMagic03 => Construct(0x6aad0);
            public static FormLink<ILoadScreenGetter> InGameMagic02 => Construct(0x6aacf);
            public static FormLink<ILoadScreenGetter> InGameMagic01 => Construct(0x6aace);
            public static FormLink<ILoadScreenGetter> InGameCombat16 => Construct(0x6aacd);
            public static FormLink<ILoadScreenGetter> InGameCombat19 => Construct(0x6aacc);
            public static FormLink<ILoadScreenGetter> InGameCombat18 => Construct(0x6aacb);
            public static FormLink<ILoadScreenGetter> InGameCombat17 => Construct(0x6aaca);
            public static FormLink<ILoadScreenGetter> InGameStealth05 => Construct(0x6aac9);
            public static FormLink<ILoadScreenGetter> InGameCombat15 => Construct(0x6aac8);
            public static FormLink<ILoadScreenGetter> InGameCombat14 => Construct(0x6aac7);
            public static FormLink<ILoadScreenGetter> InGameCombat13 => Construct(0x6aac6);
            public static FormLink<ILoadScreenGetter> InGameCombat12 => Construct(0x6aac5);
            public static FormLink<ILoadScreenGetter> InGameCombat11 => Construct(0x6aac4);
            public static FormLink<ILoadScreenGetter> InGameCombat10 => Construct(0x6aac3);
            public static FormLink<ILoadScreenGetter> InGameCombat09 => Construct(0x6aac2);
            public static FormLink<ILoadScreenGetter> InGameCombat08 => Construct(0x6aac1);
            public static FormLink<ILoadScreenGetter> InGameCombat07 => Construct(0x6aac0);
            public static FormLink<ILoadScreenGetter> InGameCombat06 => Construct(0x6aabf);
            public static FormLink<ILoadScreenGetter> InGameCombat05 => Construct(0x6aabe);
            public static FormLink<ILoadScreenGetter> InGameCombat04 => Construct(0x6aabd);
            public static FormLink<ILoadScreenGetter> InGameCombat03 => Construct(0x6aabc);
            public static FormLink<ILoadScreenGetter> InGameCombat02 => Construct(0x6aabb);
            public static FormLink<ILoadScreenGetter> InGameCombat01 => Construct(0x6aaba);
            public static FormLink<ILoadScreenGetter> Charactergen02 => Construct(0x651d9);
            public static FormLink<ILoadScreenGetter> Charactergen03 => Construct(0x651d8);
            public static FormLink<ILoadScreenGetter> Charactergen01 => Construct(0x64443);
            public static FormLink<ILoadScreenGetter> InGameImperialCity05 => Construct(0x62d00);
            public static FormLink<ILoadScreenGetter> InGameImperialCity04 => Construct(0x62cff);
            public static FormLink<ILoadScreenGetter> InGameImperialCity03 => Construct(0x62cfe);
            public static FormLink<ILoadScreenGetter> SancreTorLoad02 => Construct(0x62cfb);
            public static FormLink<ILoadScreenGetter> InGameOblivionGate04 => Construct(0x62cf9);
            public static FormLink<ILoadScreenGetter> ArenaLoad3 => Construct(0x627d5);
            public static FormLink<ILoadScreenGetter> ArenaLoad2 => Construct(0x627d4);
            public static FormLink<ILoadScreenGetter> ArenaLoad1 => Construct(0x627d3);
            public static FormLink<ILoadScreenGetter> DBSanctuary03 => Construct(0x627d2);
            public static FormLink<ILoadScreenGetter> DBSanctuary02 => Construct(0x627d1);
            public static FormLink<ILoadScreenGetter> MagesGuild03 => Construct(0x6210f);
            public static FormLink<ILoadScreenGetter> MagesGuild02 => Construct(0x6210e);
            public static FormLink<ILoadScreenGetter> MagesGuild01 => Construct(0x6210d);
            public static FormLink<ILoadScreenGetter> FightersGuild03 => Construct(0x6210c);
            public static FormLink<ILoadScreenGetter> FightersGuild02 => Construct(0x6210b);
            public static FormLink<ILoadScreenGetter> FightersGuild01 => Construct(0x6210a);
            public static FormLink<ILoadScreenGetter> InGameImperialCity02 => Construct(0x62109);
            public static FormLink<ILoadScreenGetter> InGameOblivionGate03 => Construct(0x62108);
            public static FormLink<ILoadScreenGetter> InGameOblivionGate02 => Construct(0x62107);
            public static FormLink<ILoadScreenGetter> InGameOblivionGate01 => Construct(0x62106);
            public static FormLink<ILoadScreenGetter> InGameDefault19 => Construct(0x62105);
            public static FormLink<ILoadScreenGetter> InGameDefault18 => Construct(0x62104);
            public static FormLink<ILoadScreenGetter> InGameBruma01 => Construct(0x62103);
            public static FormLink<ILoadScreenGetter> InGameSkingrad01 => Construct(0x62102);
            public static FormLink<ILoadScreenGetter> InGameLeyawiin01 => Construct(0x62101);
            public static FormLink<ILoadScreenGetter> InGameKvatch01 => Construct(0x62100);
            public static FormLink<ILoadScreenGetter> InGameImperialCity01 => Construct(0x620ff);
            public static FormLink<ILoadScreenGetter> InGameCheydinhal01 => Construct(0x620fe);
            public static FormLink<ILoadScreenGetter> InGameBravil01 => Construct(0x620fd);
            public static FormLink<ILoadScreenGetter> InGameDefault17 => Construct(0x18ae82);
            public static FormLink<ILoadScreenGetter> InGameAnvil03 => Construct(0x18ad29);
            public static FormLink<ILoadScreenGetter> InGameAnvil02 => Construct(0x18ad28);
            public static FormLink<ILoadScreenGetter> InGameAnvil01 => Construct(0x18ad27);
            public static FormLink<ILoadScreenGetter> InGameDefault16 => Construct(0x18ad26);
            public static FormLink<ILoadScreenGetter> InGameDefault15 => Construct(0x18ad25);
            public static FormLink<ILoadScreenGetter> InGameDefault14 => Construct(0x18ad24);
            public static FormLink<ILoadScreenGetter> InGameDefault13 => Construct(0x18ad23);
            public static FormLink<ILoadScreenGetter> DBSanctuary01 => Construct(0x187b3a);
            public static FormLink<ILoadScreenGetter> Widescreen1ElvenArmor => Construct(0x8ff65);
            public static FormLink<ILoadScreenGetter> InGameDefault09 => Construct(0x3a82d);
            public static FormLink<ILoadScreenGetter> InGameDefault07 => Construct(0x3365a);
            public static FormLink<ILoadScreenGetter> InGameDefault08 => Construct(0x33659);
            public static FormLink<ILoadScreenGetter> InGameDefault06 => Construct(0x2278c);
            public static FormLink<ILoadScreenGetter> InGameDefault04 => Construct(0x2278a);
            public static FormLink<ILoadScreenGetter> InGameDefault12 => Construct(0x22784);
            public static FormLink<ILoadScreenGetter> InGameDefault11 => Construct(0x2277c);
            public static FormLink<ILoadScreenGetter> InGameDefault05 => Construct(0x2277b);
            public static FormLink<ILoadScreenGetter> InGameChorrol03 => Construct(0x1fc4c);
            public static FormLink<ILoadScreenGetter> InGameChorrol02 => Construct(0x1fc4b);
            public static FormLink<ILoadScreenGetter> InGameDefault03 => Construct(0x1e771);
            public static FormLink<ILoadScreenGetter> InGameDefault02 => Construct(0x1e770);
            public static FormLink<ILoadScreenGetter> InGameDefault01 => Construct(0x1e76f);
            public static FormLink<ILoadScreenGetter> InGameDefault10 => Construct(0x1e65a);
            public static FormLink<ILoadScreenGetter> InGameChorrol01 => Construct(0x1e656);
        }
    }
}
