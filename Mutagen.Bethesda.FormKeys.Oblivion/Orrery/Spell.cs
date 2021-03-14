using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> DLCOrreryPower7 => Construct(0x11dc6a);
            public static FormLink<ISpellGetter> DLCOrreryPower8 => Construct(0x11dc6c);
            public static FormLink<ISpellGetter> DLCOrreryPower1 => Construct(0x11dc5f);
            public static FormLink<ISpellGetter> DLCOrreryPower2 => Construct(0x11dc60);
            public static FormLink<ISpellGetter> DLCOrreryPower3 => Construct(0x11dc62);
            public static FormLink<ISpellGetter> DLCOrreryPower4 => Construct(0x11dc64);
            public static FormLink<ISpellGetter> DLCOrreryPower5 => Construct(0x11dc66);
            public static FormLink<ISpellGetter> DLCOrreryPower6 => Construct(0x11dc68);
        }
    }
}
