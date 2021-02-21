using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ImageSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IImageSpaceGetter> Construct(uint id) => new FormLink<IImageSpaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImageSpaceGetter> DLC1_ISSkyrimCloudyNIGHT_FV_A => Construct(0x10e0c);
            public static FormLink<IImageSpaceGetter> DLC1_UnderwaterImageSpace => Construct(0xf675);
            public static FormLink<IImageSpaceGetter> DLC1AncestorGladeImageSpace => Construct(0xd99f);
            public static FormLink<IImageSpaceGetter> CastleVampireIS => Construct(0x19964);
            public static FormLink<IImageSpaceGetter> DLC01UnderLava01 => Construct(0x181c4);
            public static FormLink<IImageSpaceGetter> DLC1EclipseISNight => Construct(0x8941);
            public static FormLink<IImageSpaceGetter> ISDLC01SoulCairn => Construct(0x7ad7);
            public static FormLink<IImageSpaceGetter> DLC1EclipseIS => Construct(0x6aed);
            public static FormLink<IImageSpaceGetter> IceDarkImagespace => Construct(0x2f7f);
        }
    }
}
