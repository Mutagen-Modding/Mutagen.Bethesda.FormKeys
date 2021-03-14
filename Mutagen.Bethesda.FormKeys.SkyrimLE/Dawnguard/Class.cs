using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Class
        {
            private static FormLink<IClassGetter> Construct(uint id) => new FormLink<IClassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClassGetter> DLC1EncClassDeathhound => Construct(0x145dc);
            public static FormLink<IClassGetter> DLC1CClassVyrthur => Construct(0x126b3);
            public static FormLink<IClassGetter> DLC1EncClassGargoyle => Construct(0xd6f6);
            public static FormLink<IClassGetter> DLC1_EncClassChaurusFlyer => Construct(0x5206);
            public static FormLink<IClassGetter> DLC1EncClassKatria => Construct(0x4d0e);
        }
    }
}
