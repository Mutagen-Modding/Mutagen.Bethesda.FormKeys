using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Perk
        {
            private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPerkGetter> BYOHRestedAdoptionPerk => Construct(0x4295);
        }
    }
}
