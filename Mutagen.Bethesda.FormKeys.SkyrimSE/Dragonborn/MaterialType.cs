using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MaterialType
        {
            private static FormLink<IMaterialTypeGetter> Construct(uint id) => new FormLink<IMaterialTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMaterialTypeGetter> MaterialAsh => Construct(0x18c9c);
        }
    }
}
