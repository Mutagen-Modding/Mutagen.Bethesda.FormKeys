using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Light
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightGetter> DL9ForgeFire384Pulse => Construct(0x45c5);
            public static FormLink<ILightGetter> DL9DaedricAmb => Construct(0x1aed);
            public static FormLink<ILightGetter> DL9Lectern => Construct(0x1980);
        }
    }
}
