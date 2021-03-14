using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Book
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DLC06ThievesDenCaptainsQtrUpgrade => Construct(0xbf4f);
            public static FormLink<IBookGetter> DLC06ThievesDenSecurityUpgrade => Construct(0x6fe1);
            public static FormLink<IBookGetter> DLC06ThievesDenFenceUpgrade => Construct(0x6fe2);
            public static FormLink<IBookGetter> DLC06ThievesDenSupplierUpgrade => Construct(0x6fe3);
            public static FormLink<IBookGetter> DLC06ThievesDenFletcherUpgrade => Construct(0x6fdf);
            public static FormLink<IBookGetter> DLC06ThievesDenBook1 => Construct(0x13dc3);
            public static FormLink<IBookGetter> DLC06ThievesDenBook2 => Construct(0x13dc4);
            public static FormLink<IBookGetter> DLC06ThievesDenBook3 => Construct(0x13dc5);
            public static FormLink<IBookGetter> DLC06ThievesDenBook4 => Construct(0x13dc6);
            public static FormLink<IBookGetter> DLC06ThievesDenStealthUpgrade => Construct(0x6fe0);
        }
    }
}
