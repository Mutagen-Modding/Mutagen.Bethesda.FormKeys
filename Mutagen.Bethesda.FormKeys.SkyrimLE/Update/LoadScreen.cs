using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class LoadScreen
        {
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> CharacterSkillILegendary => Construct(0x9da);
        }
    }
}
