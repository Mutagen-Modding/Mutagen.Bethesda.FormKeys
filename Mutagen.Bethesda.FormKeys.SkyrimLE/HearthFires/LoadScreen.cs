using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class LoadScreen
        {
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> BYOHAdoption03 => Construct(0x15fba);
            public static FormLink<ILoadScreenGetter> BYOHAdoption02 => Construct(0x15fb9);
            public static FormLink<ILoadScreenGetter> BYOHAdoption01 => Construct(0xf838);
            public static FormLink<ILoadScreenGetter> BYOHBuildYourOwnHouse => Construct(0xf837);
        }
    }
}
