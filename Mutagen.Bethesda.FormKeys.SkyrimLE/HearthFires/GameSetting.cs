using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class GameSetting
        {
            private static FormLink<IGameSettingGetter> Construct(uint id) => new FormLink<IGameSettingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName10 => Construct(0x8bd4);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName09 => Construct(0x8bd3);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName08 => Construct(0x8bd2);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName07 => Construct(0x8ac9);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName06 => Construct(0x8ac8);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName05 => Construct(0x8ac7);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName04 => Construct(0x8ac6);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName03 => Construct(0x8ac5);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName02 => Construct(0x8ac4);
            public static FormLink<IGameSettingGetter> sGenericCraftKeywordName01 => Construct(0x8a9c);
        }
    }
}
