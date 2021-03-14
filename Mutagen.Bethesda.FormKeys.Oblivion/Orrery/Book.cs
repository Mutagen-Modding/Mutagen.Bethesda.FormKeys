using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Book
        {
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DLCOrreryBanditNote => Construct(0x11c3d2);
            public static FormLink<IBookGetter> DLCOrreryNote => Construct(0x11b9fd);
        }
    }
}
