// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static partial class Package
    {
        private static FormLink<IPackageGetter> Construct(uint id) => new FormLink<IPackageGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPackageGetter> DLC02CageSitPackage => Construct(0xcb1);
        public static FormLink<IPackageGetter> DLC02SitFoundRef => Construct(0xbd7);
        public static FormLink<IPackageGetter> DLC02WorkshopSummonedToRelaxObserveCombatOverride => Construct(0x867);
        public static FormLink<IPackageGetter> DLC02WorkshopSummonedToRelaxPackage => Construct(0x842);
        public static FormLink<IPackageGetter> DLC02WorkshopCatSandbox => Construct(0x81c);
    }
}
