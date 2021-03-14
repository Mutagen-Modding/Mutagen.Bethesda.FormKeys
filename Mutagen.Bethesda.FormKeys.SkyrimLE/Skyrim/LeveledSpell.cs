using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class LeveledSpell
        {
            private static FormLink<ILeveledSpellGetter> Construct(uint id) => new FormLink<ILeveledSpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledSpellGetter> LSpellDragonFrostBreath => Construct(0x10fe1c);
            public static FormLink<ILeveledSpellGetter> TrapLSpellDiseases => Construct(0x10a249);
            public static FormLink<ILeveledSpellGetter> LSpellCloak50 => Construct(0x109ae0);
            public static FormLink<ILeveledSpellGetter> LSpellDestructionArea => Construct(0x109adf);
            public static FormLink<ILeveledSpellGetter> LSpellWalls => Construct(0x109ade);
            public static FormLink<ILeveledSpellGetter> LSpellWEConjurerRighHand => Construct(0x10554d);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageStormLeftHand => Construct(0x105104);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageIceLeftHand => Construct(0x105103);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageWardLeftHand => Construct(0x105102);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageFireLeftHand => Construct(0x105101);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageStormRightHand => Construct(0x105100);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageIceRightHand => Construct(0x1050ff);
            public static FormLink<ILeveledSpellGetter> LSpellWEBattlemageFireRightHand => Construct(0x1050fe);
            public static FormLink<ILeveledSpellGetter> LSpellBandit05FireFrostShock => Construct(0x100e74);
            public static FormLink<ILeveledSpellGetter> LSpellDragonPriestDestruction => Construct(0x20259);
            public static FormLink<ILeveledSpellGetter> LSpellDragonPriestShock => Construct(0x20258);
            public static FormLink<ILeveledSpellGetter> LSpellDragonPriestFire => Construct(0x20257);
            public static FormLink<ILeveledSpellGetter> LSpellDraugr05Ebony => Construct(0x44c5a);
            public static FormLink<ILeveledSpellGetter> LSpellDraugr05 => Construct(0x44c59);
            public static FormLink<ILeveledSpellGetter> LSpellBandit03FireFrostShock => Construct(0x39d40);
            public static FormLink<ILeveledSpellGetter> LSpellBandit01FireFrostShock => Construct(0x39d3f);
            public static FormLink<ILeveledSpellGetter> LSpellDragonPriestFrost => Construct(0x2430c);
            public static FormLink<ILeveledSpellGetter> LSpellDraugr04 => Construct(0x2430b);
            public static FormLink<ILeveledSpellGetter> LSpellDraugr03 => Construct(0x24309);
        }
    }
}
