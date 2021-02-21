using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class ReverbParameters
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IReverbParametersGetter> Construct(uint id) => new FormLink<IReverbParametersGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IReverbParametersGetter> IntRoomStoneLargeReverb_Vyrthur => Construct(0x14cb4);
        }
    }
}
