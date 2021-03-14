using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Static
        {
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> DL9BravilWall => Construct(0x142f);
            public static FormLink<IStaticGetter> DL9StaticCellDoor => Construct(0x1ab6);
            public static FormLink<IStaticGetter> DL9StaticShovel => Construct(0x2ce7);
        }
    }
}
