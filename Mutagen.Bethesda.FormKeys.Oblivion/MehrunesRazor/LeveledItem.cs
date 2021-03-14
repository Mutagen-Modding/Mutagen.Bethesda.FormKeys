using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class LeveledItem
        {
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> DL9MTongGreavesList => Construct(0x20ab);
            public static FormLink<ILeveledItemGetter> DL9Torch30 => Construct(0x1b32);
            public static FormLink<ILeveledItemGetter> DL9ForgeAmulets => Construct(0x2747);
            public static FormLink<ILeveledItemGetter> DL9ForgeSmocks => Construct(0x2748);
            public static FormLink<ILeveledItemGetter> DL9ChampAxeList => Construct(0x2737);
            public static FormLink<ILeveledItemGetter> DL9MTongHoodList => Construct(0x20a7);
            public static FormLink<ILeveledItemGetter> DL9MehrunesRazor => Construct(0x5fbf);
            public static FormLink<ILeveledItemGetter> DL9MTongCuirassList => Construct(0x20a8);
            public static FormLink<ILeveledItemGetter> DL9LaborerWeapons75 => Construct(0x274c);
            public static FormLink<ILeveledItemGetter> DL9DrothanRobeList => Construct(0x5fe1);
            public static FormLink<ILeveledItemGetter> DL9DrothanHoodList => Construct(0x5fe2);
            public static FormLink<ILeveledItemGetter> DL9MTongGlovesList => Construct(0x20a9);
            public static FormLink<ILeveledItemGetter> DL9MTongBootsList => Construct(0x20aa);
        }
    }
}