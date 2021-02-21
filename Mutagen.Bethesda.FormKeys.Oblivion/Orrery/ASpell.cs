using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> DLCOrreryPower7 => Construct(0x11dc6a);
            public static FormLink<IASpellGetter> DLCOrreryPower8 => Construct(0x11dc6c);
            public static FormLink<IASpellGetter> DLCOrreryPower1 => Construct(0x11dc5f);
            public static FormLink<IASpellGetter> DLCOrreryPower2 => Construct(0x11dc60);
            public static FormLink<IASpellGetter> DLCOrreryPower3 => Construct(0x11dc62);
            public static FormLink<IASpellGetter> DLCOrreryPower4 => Construct(0x11dc64);
            public static FormLink<IASpellGetter> DLCOrreryPower5 => Construct(0x11dc66);
            public static FormLink<IASpellGetter> DLCOrreryPower6 => Construct(0x11dc68);
        }
    }
}
