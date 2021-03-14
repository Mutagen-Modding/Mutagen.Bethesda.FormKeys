using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Grass
        {
            private static FormLink<IGrassGetter> Construct(uint id) => new FormLink<IGrassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGrassGetter> DLC02VolcanicAshGrass02 => Construct(0x1e341);
            public static FormLink<IGrassGetter> DLC02VolcanicAshGrass01 => Construct(0x17ea2);
            public static FormLink<IGrassGetter> DLC02VolcanicAshRocks01 => Construct(0x1771e);
        }
    }
}
