using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ReverbParameters
        {
            private static FormLink<IReverbParametersGetter> Construct(uint id) => new FormLink<IReverbParametersGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IReverbParametersGetter> IntRoomStoneLargeReverb_Vyrthur => Construct(0x14cb4);
        }
    }
}
