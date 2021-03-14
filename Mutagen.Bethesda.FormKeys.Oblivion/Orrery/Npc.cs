using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> DLCOrreryBandit3 => Construct(0x11c3d5);
            public static FormLink<INpcGetter> DLCOrreyBandit4 => Construct(0x11c3d7);
            public static FormLink<INpcGetter> DLCOrreryBandit5 => Construct(0x11c3d8);
            public static FormLink<INpcGetter> DLCOrreyBandit1 => Construct(0x11c3d1);
            public static FormLink<INpcGetter> DLCOrreyBandit2 => Construct(0x11c3d4);
        }
    }
}
