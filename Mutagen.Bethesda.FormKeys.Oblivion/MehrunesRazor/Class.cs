using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Class
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IClassGetter> Construct(uint id) => new FormLink<IClassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClassGetter> DL9ForgeMasterClass => Construct(0x272d);
        }
    }
}
