// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class Furniture
    {
        private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFurnitureGetter> DLC01_PowerArmorFurnitureTesla => Construct(0xc579);
        public static FormLink<IFurnitureGetter> DLC01EyeBotPod => Construct(0x9afc);
        public static FormLink<IFurnitureGetter> DLC01MechanistReveal => Construct(0x8785);
        public static FormLink<IFurnitureGetter> DLC01RobotInspection => Construct(0x8783);
        public static FormLink<IFurnitureGetter> DLC01AmbushEyeBotPipe1024 => Construct(0x80a3);
        public static FormLink<IFurnitureGetter> DLC01AmbushEyeBotPipe512 => Construct(0x809f);
        public static FormLink<IFurnitureGetter> DLC01AmbushAssaultronFromBackSlow => Construct(0x4e09);
        public static FormLink<IFurnitureGetter> DLC01AmbushSentryBotGetUp => Construct(0x4e04);
        public static FormLink<IFurnitureGetter> DLC01AmbushEyeBotPipe => Construct(0x4e03);
        public static FormLink<IFurnitureGetter> DLC01AmbushAssaultronFromBack => Construct(0x4e02);
        public static FormLink<IFurnitureGetter> WorkbenchRobot => Construct(0x1f16);
    }
}
