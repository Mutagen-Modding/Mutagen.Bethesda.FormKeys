using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Furniture
        {
            private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFurnitureGetter> LairVileCoffinBed => Construct(0x1360);
        }
    }
}
