using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class ImageSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IImageSpaceGetter> Construct(uint id) => new FormLink<IImageSpaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAsh01NIGHT_A => Construct(0x374bb);
            public static FormLink<IImageSpaceGetter> DLC2ISApocryphaWorld => Construct(0x34cfa);
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAshStorm01DAY => Construct(0x32339);
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAsh02DAY => Construct(0x31ac2);
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAsh02DAWN => Construct(0x31ac1);
            public static FormLink<IImageSpaceGetter> DLC2ISApocrypha => Construct(0x1c48c);
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAsh01NIGHT => Construct(0x18ed3);
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAsh01DAWN => Construct(0x18680);
            public static FormLink<IImageSpaceGetter> DLC02VolcanicAsh01DAY => Construct(0x1867f);
        }
    }
}
