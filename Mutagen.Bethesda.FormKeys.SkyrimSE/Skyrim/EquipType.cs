namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class EquipType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey Potion => ModKey.MakeFormKey(0x35698);
            public static FormKey Voice => ModKey.MakeFormKey(0x25bee);
            public static FormKey Shield => ModKey.MakeFormKey(0x141e8);
            public static FormKey BothHands => ModKey.MakeFormKey(0x13f45);
            public static FormKey EitherHand => ModKey.MakeFormKey(0x13f44);
            public static FormKey LeftHand => ModKey.MakeFormKey(0x13f43);
            public static FormKey RightHand => ModKey.MakeFormKey(0x13f42);
        }
    }
}
