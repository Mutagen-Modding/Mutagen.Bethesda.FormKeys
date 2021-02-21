using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MovementType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IMovementTypeGetter> Construct(uint id) => new FormLink<IMovementTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMovementTypeGetter> GargoyleDefault_MT => Construct(0xd036);
            public static FormLink<IMovementTypeGetter> GargoyleCombatRun_MT => Construct(0xd035);
            public static FormLink<IMovementTypeGetter> GargoyleCombatWalk_MT => Construct(0xa2ca);
            public static FormLink<IMovementTypeGetter> ChaurusFlyer_Default_MT => Construct(0x51fc);
            public static FormLink<IMovementTypeGetter> VampireLordSprint_MT => Construct(0x240d);
            public static FormLink<IMovementTypeGetter> VampireLordDefault_MT => Construct(0x240c);
        }
    }
}
