// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class EquipType
    {
        private static FormLink<IEquipTypeGetter> Construct(uint id) => new FormLink<IEquipTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IEquipTypeGetter> LeftHandOther => Construct(0x23e486);
        public static FormLink<IEquipTypeGetter> BothHandsMiddle => Construct(0x22b642);
        public static FormLink<IEquipTypeGetter> AltAttackSlot3 => Construct(0x136257);
        public static FormLink<IEquipTypeGetter> AltAttackSlot2 => Construct(0x136256);
        public static FormLink<IEquipTypeGetter> AltAttackSlot1 => Construct(0x136255);
        public static FormLink<IEquipTypeGetter> MiddleHandBothLegs => Construct(0x12fb50);
        public static FormLink<IEquipTypeGetter> BothHandsMiddleOptional => Construct(0x12fb4f);
        public static FormLink<IEquipTypeGetter> BothHandsAltOptional => Construct(0x10fffc);
        public static FormLink<IEquipTypeGetter> RightHandAlt => Construct(0x10fffb);
        public static FormLink<IEquipTypeGetter> LeftHandAlt => Construct(0x10fffa);
        public static FormLink<IEquipTypeGetter> LeftHandBothLegs => Construct(0xa2710);
        public static FormLink<IEquipTypeGetter> BlockSlot => Construct(0x986c9);
        public static FormLink<IEquipTypeGetter> PowerArmorBatterySlot => Construct(0x66991);
        public static FormLink<IEquipTypeGetter> HandyMiddleHandRLOptional => Construct(0x47323);
        public static FormLink<IEquipTypeGetter> HandyLeftHandRMOptional => Construct(0x47321);
        public static FormLink<IEquipTypeGetter> HandyRightHandLMOptional => Construct(0x471a2);
        public static FormLink<IEquipTypeGetter> HandyLMOptional => Construct(0x4718e);
        public static FormLink<IEquipTypeGetter> HandyRMOptional => Construct(0x4716d);
        public static FormLink<IEquipTypeGetter> HandyRLOptional => Construct(0x47149);
        public static FormLink<IEquipTypeGetter> GrenadeSlot => Construct(0x46aac);
        public static FormLink<IEquipTypeGetter> MiddleHand => Construct(0x1a02f);
        public static FormLink<IEquipTypeGetter> BothHandsBothLegs => Construct(0x49be7);
        public static FormLink<IEquipTypeGetter> RightHandBothLegs => Construct(0x49be6);
        public static FormLink<IEquipTypeGetter> BothLegs => Construct(0x49be4);
        public static FormLink<IEquipTypeGetter> LeftLeg => Construct(0x49be2);
        public static FormLink<IEquipTypeGetter> RightLeg => Construct(0x49be1);
        public static FormLink<IEquipTypeGetter> BothHandsOtherOptional => Construct(0x43350);
        public static FormLink<IEquipTypeGetter> OTHER => Construct(0x4334f);
        public static FormLink<IEquipTypeGetter> LeftHandOptional => Construct(0x4334e);
        public static FormLink<IEquipTypeGetter> BothHandsLeftOptional => Construct(0x4334d);
        public static FormLink<IEquipTypeGetter> BothHandsOptional => Construct(0x4334c);
        public static FormLink<IEquipTypeGetter> RightHand => Construct(0x13f42);
        public static FormLink<IEquipTypeGetter> BothHands => Construct(0x13f45);
        public static FormLink<IEquipTypeGetter> EitherHand => Construct(0x13f44);
        public static FormLink<IEquipTypeGetter> LeftHand => Construct(0x13f43);
        public static FormLink<IEquipTypeGetter> Shield => Construct(0x141e8);
        public static FormLink<IEquipTypeGetter> Voice => Construct(0x25bee);
        public static FormLink<IEquipTypeGetter> Potion => Construct(0x35698);
    }
}
