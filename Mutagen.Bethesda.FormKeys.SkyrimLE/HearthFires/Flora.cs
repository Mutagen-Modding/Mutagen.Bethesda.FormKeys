using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFloraGetter> BYOHButterChurn => Construct(0xbc0);
            public static FormLink<IFloraGetter> BYOHMeadBarrel => Construct(0xf39b);
            public static FormLink<IFloraGetter> BYOHHawkNest => Construct(0xf1ce);
        }
    }
}
