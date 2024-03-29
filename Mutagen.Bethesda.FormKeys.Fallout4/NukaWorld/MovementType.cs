// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class MovementType
    {
        private static FormLink<IMovementTypeGetter> Construct(uint id) => new FormLink<IMovementTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMovementTypeGetter> DLC04_Swarm_Default_MT => Construct(0x12335);
        public static FormLink<IMovementTypeGetter> DLC04_CaveCricket_Default_MT => Construct(0xdc15);
        public static FormLink<IMovementTypeGetter> DLC04_Bloodworm_Default_MT => Construct(0xdc14);
    }
}
