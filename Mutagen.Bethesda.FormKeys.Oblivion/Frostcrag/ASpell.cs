using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostTouchGrand => Construct(0x174d);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockTouchGrand => Construct(0x174f);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockTouchGreater => Construct(0x1751);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockTouchMajor => Construct(0x1753);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockTouchMinor => Construct(0x1755);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockBoltGrand => Construct(0x1757);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockBoltGreater => Construct(0x1759);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockBoltMajor => Construct(0x175b);
            public static FormLink<IASpellGetter> FrostcragLpAtronachShockBoltMinor => Construct(0x175d);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFireballGreater => Construct(0x1761);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFireballMajor => Construct(0x1763);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFireballMinor => Construct(0x1765);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFireTouchGreater => Construct(0x1769);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFireTouchMajor => Construct(0x176b);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFireTouchMinor => Construct(0x176d);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostBoltMinor => Construct(0x173f);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostBoltMajor => Construct(0x1741);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostTouchMajor => Construct(0x1743);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostTouchMinor => Construct(0x1745);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostBoltGreater => Construct(0x1747);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostBoltGrand => Construct(0x1749);
            public static FormLink<IASpellGetter> AbFrostcragSpireAlchemyBuff => Construct(0x13131);
            public static FormLink<IASpellGetter> DLCFrostcragSpireTomb => Construct(0x13feb);
            public static FormLink<IASpellGetter> FrostcragLpAtronachFrostTouchGreater => Construct(0x174b);
            public static FormLink<IASpellGetter> FrostcragAtronachShockBoltLvl => Construct(0x1771);
            public static FormLink<IASpellGetter> FrostcragAtronachShockTouchLvl => Construct(0x1772);
            public static FormLink<IASpellGetter> FrostcragAtronachFireballLvl => Construct(0x1773);
            public static FormLink<IASpellGetter> FrostcragAtronachFireTouchLvl => Construct(0x1774);
            public static FormLink<IASpellGetter> FrostcragAtronachFrostBoltLvl => Construct(0x176f);
            public static FormLink<IASpellGetter> FrostcragAtronachFrostTouchLvl => Construct(0x1770);
        }
    }
}
