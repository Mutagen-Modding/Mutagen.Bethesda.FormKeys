using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCSpellTomes.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> DLCTomeSpellAllDamageTarget3Journeyman => Construct(0x121e);
            public static FormLink<IASpellGetter> DLCTomeSpellAllDamageTarget4Expert => Construct(0x1220);
            public static FormLink<IASpellGetter> DLCTomeSpellDrainHealth2Apprentice => Construct(0x1222);
            public static FormLink<IASpellGetter> DLCTomeSpellDrainHealth1Novice => Construct(0x1224);
            public static FormLink<IASpellGetter> DLCTomeSpellDrainHealth3Journeyman => Construct(0x1226);
            public static FormLink<IASpellGetter> DLCTomeSpellDrainHealth4Expert => Construct(0x1228);
            public static FormLink<IASpellGetter> DLCTomeSpellFireMark3Journeyman => Construct(0xcea);
            public static FormLink<IASpellGetter> DLCTomeSpellFenriksEscape3Journeyman => Construct(0x122d);
            public static FormLink<IASpellGetter> DLCTomeSpellLlivamsReversal4Expert => Construct(0x122c);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTarget2Apprentice => Construct(0x122f);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTarget4Expert => Construct(0x1231);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTouch1Novice => Construct(0x1233);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTouch3Journeyman => Construct(0x1235);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTouch1Novice => Construct(0x1237);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTouch2Apprentice => Construct(0x1239);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTouch3Journeyman => Construct(0x123b);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTouch4Expert => Construct(0x123d);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTouch1Novice => Construct(0x123f);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTouch2Apprentice => Construct(0x1241);
            public static FormLink<IASpellGetter> DLCTomeSpellThunderclap3Journeyman => Construct(0x12b2);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTouch3Journeyman => Construct(0x1243);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTouch4Expert => Construct(0x1245);
            public static FormLink<IASpellGetter> DLCTomeSpellStuntedMagicka3Journeyman => Construct(0x12b8);
            public static FormLink<IASpellGetter> DLCTomeSpellLeechVitality3Journeyman => Construct(0xce9);
            public static FormLink<IASpellGetter> DLCTomeSpellStuntedMagickaSpecial => Construct(0x179f);
            public static FormLink<IASpellGetter> DLCTomeSpellOrumsAquaticEscape3Journeyman => Construct(0x11df);
            public static FormLink<IASpellGetter> DLCTomeSpellNightForm3Journeyman => Construct(0x11e0);
            public static FormLink<IASpellGetter> DLCTomeSpellBernesAura2Apprentice => Construct(0x11e2);
            public static FormLink<IASpellGetter> DLCTomeSpellAundaesAura2Apprentice => Construct(0x11e4);
            public static FormLink<IASpellGetter> DLCTomeSpellQuarrasAura2Apprentice => Construct(0x11e6);
            public static FormLink<IASpellGetter> DLCTomeSpellKarstagsBreath4Expert => Construct(0x11e8);
            public static FormLink<IASpellGetter> DLCTomeSpellPrideOfHirstaang4Expert => Construct(0x11ea);
            public static FormLink<IASpellGetter> DLCTomeSpellMarasGrace3Journeyman => Construct(0x11ec);
            public static FormLink<IASpellGetter> DLCTomeSpellFlashOfInsight1Novice => Construct(0x11ee);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTouch2Apprentice => Construct(0x11f0);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTarget3Journeyman => Construct(0x11f2);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTarget1Novice => Construct(0x11f4);
            public static FormLink<IASpellGetter> DLCTomeSpellFireDamageTouch4Expert => Construct(0x11f6);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTarget2Apprentice => Construct(0x11f8);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTarget3Journeyman => Construct(0x11fa);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTarget1Novice => Construct(0x11fc);
            public static FormLink<IASpellGetter> DLCTomeSpellShockDamageTarget4Expert => Construct(0x11f9);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTarget2Apprentice => Construct(0x11fd);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTarget4Expert => Construct(0x1203);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTarget1Novice => Construct(0x1205);
            public static FormLink<IASpellGetter> DLCTomeSpellFrostDamageTarget3Journeyman => Construct(0x11fe);
            public static FormLink<IASpellGetter> DLCTomeSpellDamageHealthTarget4Expert => Construct(0x1204);
            public static FormLink<IASpellGetter> DLCTomeSpellDamageHealthTarget3Journeyman => Construct(0x120d);
            public static FormLink<IASpellGetter> DLCTomeSpellDamageHealthTarget2Apprentice => Construct(0x120c);
            public static FormLink<IASpellGetter> DLCTomeSpellDamageHealthTarget1Novice => Construct(0x120b);
            public static FormLink<IASpellGetter> DLCTomeSpellIlluminateTarget1Novice => Construct(0x120a);
            public static FormLink<IASpellGetter> DLCTomeSpellInvisibility1Novice => Construct(0x1212);
            public static FormLink<IASpellGetter> DLCTomeSpellResistDisease3Journeyman => Construct(0x1d89);
            public static FormLink<IASpellGetter> DLCTomeSpellResistParalysis3Journeyman => Construct(0x1d92);
            public static FormLink<IASpellGetter> DLCTomeSpellResistPoison3Journeyman => Construct(0x1d94);
            public static FormLink<IASpellGetter> DLCTomeSpellMarasFury4Expert => Construct(0x2841);
            public static FormLink<IASpellGetter> DLCTomeSpellSoulTrap1Novice => Construct(0x1214);
            public static FormLink<IASpellGetter> DLCTomeSpellFortifyHeavyArmor2Apprentice => Construct(0x1216);
            public static FormLink<IASpellGetter> DLCTomeSpellFortifyLightArmor2Apprentice => Construct(0x1218);
            public static FormLink<IASpellGetter> DLCTomeSpellAllDamageTarget1Novice => Construct(0x121a);
            public static FormLink<IASpellGetter> DLCTomeSpellAllDamageTarget2Apprentice => Construct(0x121c);
        }
    }
}
