namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class ReverbParameters
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey IntRoomStoneLargeExtraReverb => ModKey.MakeFormKey(0x1079e9);
            public static FormKey IntRoomAzurasStarInterior => ModKey.MakeFormKey(0xfd92a);
            public static FormKey IntRoomStoneLargeReverb => ModKey.MakeFormKey(0xe3246);
            public static FormKey IntRoomStoneNarrow => ModKey.MakeFormKey(0xe322e);
            public static FormKey IntRoomWoodShipReverb => ModKey.MakeFormKey(0xd78b2);
            public static FormKey Underwater => ModKey.MakeFormKey(0x97608);
            public static FormKey IntRoomWoodLargeReverb => ModKey.MakeFormKey(0xc5d09);
            public static FormKey DefaultReverb => ModKey.MakeFormKey(0xc5b6e);
            public static FormKey IntRoomStoneMediumReverb => ModKey.MakeFormKey(0xc5b6c);
            public static FormKey IntRoomWoodMediumReverb => ModKey.MakeFormKey(0xc5b6a);
        }
    }
}
