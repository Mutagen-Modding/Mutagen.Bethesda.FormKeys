using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Package
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IPackageGetter> Construct(uint id) => new FormLink<IPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPackageGetter> PetFramework_PetFollowPlayer => Construct(0x2f1a);
        }
    }
}
