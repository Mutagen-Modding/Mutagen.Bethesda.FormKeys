using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class LoadScreen
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> CharacterSkillILegendary => Construct(0x9da);
        }
    }
}
