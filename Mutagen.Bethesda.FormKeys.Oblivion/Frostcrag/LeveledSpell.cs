// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Frostcrag
{
    public static partial class LeveledSpell
    {
        private static FormLink<ILeveledSpellGetter> Construct(uint id) => new FormLink<ILeveledSpellGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILeveledSpellGetter> FrostcragAtronachShockBoltLvl => Construct(0x1771);
        public static FormLink<ILeveledSpellGetter> FrostcragAtronachShockTouchLvl => Construct(0x1772);
        public static FormLink<ILeveledSpellGetter> FrostcragAtronachFireballLvl => Construct(0x1773);
        public static FormLink<ILeveledSpellGetter> FrostcragAtronachFireTouchLvl => Construct(0x1774);
        public static FormLink<ILeveledSpellGetter> FrostcragAtronachFrostBoltLvl => Construct(0x176f);
        public static FormLink<ILeveledSpellGetter> FrostcragAtronachFrostTouchLvl => Construct(0x1770);
    }
}
