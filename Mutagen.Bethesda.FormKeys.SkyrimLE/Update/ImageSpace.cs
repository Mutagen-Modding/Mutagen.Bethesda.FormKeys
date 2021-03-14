using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class ImageSpace
        {
            private static FormLink<IImageSpaceGetter> Construct(uint id) => new FormLink<IImageSpaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImageSpaceGetter> UnderwaterImageSpace => Construct(0x946);
        }
    }
}
