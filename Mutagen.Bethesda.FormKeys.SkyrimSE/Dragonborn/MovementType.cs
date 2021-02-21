using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MovementType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMovementTypeGetter> Construct(uint id) => new FormLink<IMovementTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMovementTypeGetter> BenthicLurkerCombatRun_MT => Construct(0x35e11);
            public static FormLink<IMovementTypeGetter> DwarvenBallista_Default_MT => Construct(0x2b015);
            public static FormLink<IMovementTypeGetter> BenthicLurkerDefault_MT => Construct(0x248b5);
            public static FormLink<IMovementTypeGetter> DLC2Netch_Sprinting_MT => Construct(0x209ad);
            public static FormLink<IMovementTypeGetter> DLC2Netch_Default_MT => Construct(0x209a3);
            public static FormLink<IMovementTypeGetter> ScribDefault_MT => Construct(0x1fedc);
            public static FormLink<IMovementTypeGetter> HMDaedraDefault_MT => Construct(0x1dcbb);
            public static FormLink<IMovementTypeGetter> DLC2Riekling_Default_MT => Construct(0x17f4d);
            public static FormLink<IMovementTypeGetter> Boar_Default_MT => Construct(0x179d6);
        }
    }
}
