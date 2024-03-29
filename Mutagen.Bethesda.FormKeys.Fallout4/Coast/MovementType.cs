// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class MovementType
    {
        private static FormLink<IMovementTypeGetter> Construct(uint id) => new FormLink<IMovementTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMovementTypeGetter> DLC03RadChicken_Default_MT => Construct(0x43328);
        public static FormLink<IMovementTypeGetter> DLC03RadRabbit_Default_MT => Construct(0x43327);
        public static FormLink<IMovementTypeGetter> DLC03RoboBrain_Crippled_MT => Construct(0x42526);
        public static FormLink<IMovementTypeGetter> DLC03RoboBrain_Default_MT => Construct(0x3db70);
        public static FormLink<IMovementTypeGetter> DLC03Angler_Default_MT => Construct(0x2016b);
        public static FormLink<IMovementTypeGetter> DLC03HermitCrab_Default_MT => Construct(0x180a5);
        public static FormLink<IMovementTypeGetter> DLC03FogCrawler_Default_MT => Construct(0x1536b);
    }
}
