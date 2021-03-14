using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class PlacedNpc
        {
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> DL9QuickDeath01REF => Construct(0x27ee);
            public static FormLink<IPlacedNpcGetter> DL9DeadGuy01REF => Construct(0x27e6);
            public static FormLink<IPlacedNpcGetter> DL9Champion1REF => Construct(0x1983);
            public static FormLink<IPlacedNpcGetter> DL9MoragTongAssassinREF => Construct(0x1aae);
            public static FormLink<IPlacedNpcGetter> DL9BossCommanderREF => Construct(0x1a08);
            public static FormLink<IPlacedNpcGetter> DL9ForgeMasterREF => Construct(0x154e);
            public static FormLink<IPlacedNpcGetter> DL9Actor01REF => Construct(0x2d10);
            public static FormLink<IPlacedNpcGetter> DL9Actor03REF => Construct(0x2d14);
            public static FormLink<IPlacedNpcGetter> DL9Actor02REF => Construct(0x2d15);
        }
    }
}
