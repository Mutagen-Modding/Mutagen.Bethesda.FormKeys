using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class EquipType
        {
            private static FormLink<IEquipTypeGetter> Construct(uint id) => new FormLink<IEquipTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEquipTypeGetter> Potion => Construct(0x35698);
            public static FormLink<IEquipTypeGetter> Voice => Construct(0x25bee);
            public static FormLink<IEquipTypeGetter> Shield => Construct(0x141e8);
            public static FormLink<IEquipTypeGetter> BothHands => Construct(0x13f45);
            public static FormLink<IEquipTypeGetter> EitherHand => Construct(0x13f44);
            public static FormLink<IEquipTypeGetter> LeftHand => Construct(0x13f43);
            public static FormLink<IEquipTypeGetter> RightHand => Construct(0x13f42);
        }
    }
}
