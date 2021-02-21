using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Armor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorGetter> ClothesChild05 => Construct(0xc740);
            public static FormLink<IArmorGetter> ClothesChild04 => Construct(0xc73e);
        }
    }
}
