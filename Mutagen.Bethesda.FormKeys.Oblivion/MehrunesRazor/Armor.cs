using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Armor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IArmorGetter> Construct(uint id) => new FormLink<IArmorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArmorGetter> DL9MTongBoots01 => Construct(0x1b8c);
            public static FormLink<IArmorGetter> DL9MTongCuirass02 => Construct(0x2085);
            public static FormLink<IArmorGetter> DL9MTongGloves02 => Construct(0x2086);
            public static FormLink<IArmorGetter> DL9MTongGreaves02 => Construct(0x2087);
            public static FormLink<IArmorGetter> DL9MTongBoots02 => Construct(0x2088);
            public static FormLink<IArmorGetter> DL9MTongBoots03 => Construct(0x208f);
            public static FormLink<IArmorGetter> DL9MTongCuirass03 => Construct(0x2090);
            public static FormLink<IArmorGetter> DL9MTongGloves03 => Construct(0x2091);
            public static FormLink<IArmorGetter> DL9MTongGreaves03 => Construct(0x2092);
            public static FormLink<IArmorGetter> DL9MTongBoots04 => Construct(0x2099);
            public static FormLink<IArmorGetter> DL9MTongCuirass04 => Construct(0x209a);
            public static FormLink<IArmorGetter> DL9MTongGloves04 => Construct(0x209b);
            public static FormLink<IArmorGetter> DL9MTongGreaves04 => Construct(0x209c);
            public static FormLink<IArmorGetter> DL9MTongBoots05 => Construct(0x20a3);
            public static FormLink<IArmorGetter> DL9MTongCuirass05 => Construct(0x20a4);
            public static FormLink<IArmorGetter> DL9MTongGloves05 => Construct(0x20a5);
            public static FormLink<IArmorGetter> DL9MTongGreaves05 => Construct(0x20a6);
            public static FormLink<IArmorGetter> DL9MTongCuirass01 => Construct(0x1b89);
            public static FormLink<IArmorGetter> DL9MTongGloves01 => Construct(0x1b8a);
            public static FormLink<IArmorGetter> DL9MTongGreaves01 => Construct(0x1b8b);
        }
    }
}
