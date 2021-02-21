using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Weapon
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeaponGetter> BYOHWoodenSword => Construct(0x4d91);
        }
    }
}
