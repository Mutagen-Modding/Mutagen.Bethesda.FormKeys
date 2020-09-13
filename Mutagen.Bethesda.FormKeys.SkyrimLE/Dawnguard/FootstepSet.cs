namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class FootstepSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey NPCVampireLordFootstepSet => ModKey.MakeFormKey(0x1377c);
            public static FormKey NPCDogHuskyFootWalkFootstepSet => ModKey.MakeFormKey(0x117fd);
            public static FormKey NPCDogDeathHoundFootWalkFootstepSet => ModKey.MakeFormKey(0x115cd);
            public static FormKey NPCArmoredTrollFootWalkFootstepSet => ModKey.MakeFormKey(0x39a7);
            public static FormKey NPCGargoyleFootWalkFootstepSet => ModKey.MakeFormKey(0xf8ad);
            public static FormKey NPCHorseSkeletonFootFootstepSet => ModKey.MakeFormKey(0xefb2);
        }
    }
}
