using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostTouchGrand => Construct(0x174d);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockTouchGrand => Construct(0x174f);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockTouchGreater => Construct(0x1751);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockTouchMajor => Construct(0x1753);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockTouchMinor => Construct(0x1755);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockBoltGrand => Construct(0x1757);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockBoltGreater => Construct(0x1759);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockBoltMajor => Construct(0x175b);
            public static FormLink<ISpellGetter> FrostcragLpAtronachShockBoltMinor => Construct(0x175d);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFireballGreater => Construct(0x1761);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFireballMajor => Construct(0x1763);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFireballMinor => Construct(0x1765);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFireTouchGreater => Construct(0x1769);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFireTouchMajor => Construct(0x176b);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFireTouchMinor => Construct(0x176d);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostBoltMinor => Construct(0x173f);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostBoltMajor => Construct(0x1741);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostTouchMajor => Construct(0x1743);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostTouchMinor => Construct(0x1745);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostBoltGreater => Construct(0x1747);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostBoltGrand => Construct(0x1749);
            public static FormLink<ISpellGetter> AbFrostcragSpireAlchemyBuff => Construct(0x13131);
            public static FormLink<ISpellGetter> DLCFrostcragSpireTomb => Construct(0x13feb);
            public static FormLink<ISpellGetter> FrostcragLpAtronachFrostTouchGreater => Construct(0x174b);
        }
    }
}