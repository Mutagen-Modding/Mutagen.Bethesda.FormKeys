using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class ReverbParameters
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IReverbParametersGetter> Construct(uint id) => new FormLink<IReverbParametersGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IReverbParametersGetter> IntRoomStoneLargeExtraReverb => Construct(0x1079e9);
            public static FormLink<IReverbParametersGetter> IntRoomAzurasStarInterior => Construct(0xfd92a);
            public static FormLink<IReverbParametersGetter> IntRoomStoneLargeReverb => Construct(0xe3246);
            public static FormLink<IReverbParametersGetter> IntRoomStoneNarrow => Construct(0xe322e);
            public static FormLink<IReverbParametersGetter> IntRoomWoodShipReverb => Construct(0xd78b2);
            public static FormLink<IReverbParametersGetter> Underwater => Construct(0x97608);
            public static FormLink<IReverbParametersGetter> IntRoomWoodLargeReverb => Construct(0xc5d09);
            public static FormLink<IReverbParametersGetter> DefaultReverb => Construct(0xc5b6e);
            public static FormLink<IReverbParametersGetter> IntRoomStoneMediumReverb => Construct(0xc5b6c);
            public static FormLink<IReverbParametersGetter> IntRoomWoodMediumReverb => Construct(0xc5b6a);
        }
    }
}
