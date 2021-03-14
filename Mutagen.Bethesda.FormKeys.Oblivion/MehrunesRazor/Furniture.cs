using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Furniture
        {
            private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFurnitureGetter> DL9Stool01 => Construct(0x92ce);
        }
    }
}
