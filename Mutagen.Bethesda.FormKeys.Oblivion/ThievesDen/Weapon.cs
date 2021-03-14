using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Weapon
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeaponGetter> WeapSteelCutlassMaster => Construct(0x11ae1);
            public static FormLink<IWeaponGetter> WeapSteelCutlassSuperb => Construct(0x11ae2);
            public static FormLink<IWeaponGetter> DLC06WeapTest => Construct(0x83a9);
        }
    }
}
