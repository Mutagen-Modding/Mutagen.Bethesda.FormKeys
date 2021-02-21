using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class ArmorAddon
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IArmorAddonGetter> Construct(uint id) => new FormLink<IArmorAddonGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorAddonGetter> ChildTorso05AA => Construct(0xc741);
            public static FormLink<IArmorAddonGetter> ChildTorso04AA => Construct(0xc73f);
        }
    }
}
