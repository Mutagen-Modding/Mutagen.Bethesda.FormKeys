// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class Transform
    {
        private static FormLink<ITransformGetter> Construct(uint id) => new FormLink<ITransformGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ITransformGetter> DLC01_LSWeaponTeslaRifle => Construct(0x128e);
        public static FormLink<ITransformGetter> LSDLC01ArmorRobot01 => Construct(0x115c);
        public static FormLink<ITransformGetter> LSDLC01CreatureRustDevil01 => Construct(0x115a);
        public static FormLink<ITransformGetter> LSDLC01CreatureRobobrain01 => Construct(0x1158);
        public static FormLink<ITransformGetter> DLC01workshop_WorkbenchRobot_LS => Construct(0xeb8);
        public static FormLink<ITransformGetter> DLC01LSChemrepairkit => Construct(0xeb5);
        public static FormLink<ITransformGetter> DLC01workshop_ResourceScanner => Construct(0x10c9c);
        public static FormLink<ITransformGetter> ArmorHelmetEyebot => Construct(0x10ba0);
        public static FormLink<ITransformGetter> DLC01workshop_TurretSpotlightWall => Construct(0xffd7);
        public static FormLink<ITransformGetter> Misc_DLC01RobotPart00 => Construct(0xf480);
        public static FormLink<ITransformGetter> DLC01workshop_WorkbenchRobot => Construct(0xca9b);
        public static FormLink<ITransformGetter> DLC01Mq02Schematics_Transform => Construct(0x363e);
        public static FormLink<ITransformGetter> Misc_DLC01RobotPart02 => Construct(0x2639);
        public static FormLink<ITransformGetter> Misc_DLC01RobotPart01 => Construct(0x2637);
        public static FormLink<ITransformGetter> Misc_DLC01Transmitter => Construct(0x2636);
    }
}
