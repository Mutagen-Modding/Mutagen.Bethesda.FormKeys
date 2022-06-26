// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class HearthFires
{
    public static class Weapon
    {
        private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWeaponGetter> BYOHWoodenSword => Construct(0x4d91);
    }
}
