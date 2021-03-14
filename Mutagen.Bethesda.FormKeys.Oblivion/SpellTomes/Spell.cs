using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> DLCTomeSpellAllDamageTarget3Journeyman => Construct(0x121e);
            public static FormLink<ISpellGetter> DLCTomeSpellAllDamageTarget4Expert => Construct(0x1220);
            public static FormLink<ISpellGetter> DLCTomeSpellDrainHealth2Apprentice => Construct(0x1222);
            public static FormLink<ISpellGetter> DLCTomeSpellDrainHealth1Novice => Construct(0x1224);
            public static FormLink<ISpellGetter> DLCTomeSpellDrainHealth3Journeyman => Construct(0x1226);
            public static FormLink<ISpellGetter> DLCTomeSpellDrainHealth4Expert => Construct(0x1228);
            public static FormLink<ISpellGetter> DLCTomeSpellFireMark3Journeyman => Construct(0xcea);
            public static FormLink<ISpellGetter> DLCTomeSpellFenriksEscape3Journeyman => Construct(0x122d);
            public static FormLink<ISpellGetter> DLCTomeSpellLlivamsReversal4Expert => Construct(0x122c);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTarget2Apprentice => Construct(0x122f);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTarget4Expert => Construct(0x1231);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTouch1Novice => Construct(0x1233);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTouch3Journeyman => Construct(0x1235);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTouch1Novice => Construct(0x1237);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTouch2Apprentice => Construct(0x1239);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTouch3Journeyman => Construct(0x123b);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTouch4Expert => Construct(0x123d);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTouch1Novice => Construct(0x123f);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTouch2Apprentice => Construct(0x1241);
            public static FormLink<ISpellGetter> DLCTomeSpellThunderclap3Journeyman => Construct(0x12b2);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTouch3Journeyman => Construct(0x1243);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTouch4Expert => Construct(0x1245);
            public static FormLink<ISpellGetter> DLCTomeSpellStuntedMagicka3Journeyman => Construct(0x12b8);
            public static FormLink<ISpellGetter> DLCTomeSpellLeechVitality3Journeyman => Construct(0xce9);
            public static FormLink<ISpellGetter> DLCTomeSpellStuntedMagickaSpecial => Construct(0x179f);
            public static FormLink<ISpellGetter> DLCTomeSpellOrumsAquaticEscape3Journeyman => Construct(0x11df);
            public static FormLink<ISpellGetter> DLCTomeSpellNightForm3Journeyman => Construct(0x11e0);
            public static FormLink<ISpellGetter> DLCTomeSpellBernesAura2Apprentice => Construct(0x11e2);
            public static FormLink<ISpellGetter> DLCTomeSpellAundaesAura2Apprentice => Construct(0x11e4);
            public static FormLink<ISpellGetter> DLCTomeSpellQuarrasAura2Apprentice => Construct(0x11e6);
            public static FormLink<ISpellGetter> DLCTomeSpellKarstagsBreath4Expert => Construct(0x11e8);
            public static FormLink<ISpellGetter> DLCTomeSpellPrideOfHirstaang4Expert => Construct(0x11ea);
            public static FormLink<ISpellGetter> DLCTomeSpellMarasGrace3Journeyman => Construct(0x11ec);
            public static FormLink<ISpellGetter> DLCTomeSpellFlashOfInsight1Novice => Construct(0x11ee);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTouch2Apprentice => Construct(0x11f0);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTarget3Journeyman => Construct(0x11f2);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTarget1Novice => Construct(0x11f4);
            public static FormLink<ISpellGetter> DLCTomeSpellFireDamageTouch4Expert => Construct(0x11f6);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTarget2Apprentice => Construct(0x11f8);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTarget3Journeyman => Construct(0x11fa);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTarget1Novice => Construct(0x11fc);
            public static FormLink<ISpellGetter> DLCTomeSpellShockDamageTarget4Expert => Construct(0x11f9);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTarget2Apprentice => Construct(0x11fd);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTarget4Expert => Construct(0x1203);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTarget1Novice => Construct(0x1205);
            public static FormLink<ISpellGetter> DLCTomeSpellFrostDamageTarget3Journeyman => Construct(0x11fe);
            public static FormLink<ISpellGetter> DLCTomeSpellDamageHealthTarget4Expert => Construct(0x1204);
            public static FormLink<ISpellGetter> DLCTomeSpellDamageHealthTarget3Journeyman => Construct(0x120d);
            public static FormLink<ISpellGetter> DLCTomeSpellDamageHealthTarget2Apprentice => Construct(0x120c);
            public static FormLink<ISpellGetter> DLCTomeSpellDamageHealthTarget1Novice => Construct(0x120b);
            public static FormLink<ISpellGetter> DLCTomeSpellIlluminateTarget1Novice => Construct(0x120a);
            public static FormLink<ISpellGetter> DLCTomeSpellInvisibility1Novice => Construct(0x1212);
            public static FormLink<ISpellGetter> DLCTomeSpellResistDisease3Journeyman => Construct(0x1d89);
            public static FormLink<ISpellGetter> DLCTomeSpellResistParalysis3Journeyman => Construct(0x1d92);
            public static FormLink<ISpellGetter> DLCTomeSpellResistPoison3Journeyman => Construct(0x1d94);
            public static FormLink<ISpellGetter> DLCTomeSpellMarasFury4Expert => Construct(0x2841);
            public static FormLink<ISpellGetter> DLCTomeSpellSoulTrap1Novice => Construct(0x1214);
            public static FormLink<ISpellGetter> DLCTomeSpellFortifyHeavyArmor2Apprentice => Construct(0x1216);
            public static FormLink<ISpellGetter> DLCTomeSpellFortifyLightArmor2Apprentice => Construct(0x1218);
            public static FormLink<ISpellGetter> DLCTomeSpellAllDamageTarget1Novice => Construct(0x121a);
            public static FormLink<ISpellGetter> DLCTomeSpellAllDamageTarget2Apprentice => Construct(0x121c);
        }
    }
}