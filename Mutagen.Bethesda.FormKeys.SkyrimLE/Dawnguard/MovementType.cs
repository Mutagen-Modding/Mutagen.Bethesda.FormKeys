namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MovementType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey GargoyleDefault_MT => ModKey.MakeFormKey(0xd036);
            public static FormKey GargoyleCombatRun_MT => ModKey.MakeFormKey(0xd035);
            public static FormKey GargoyleCombatWalk_MT => ModKey.MakeFormKey(0xa2ca);
            public static FormKey ChaurusFlyer_Default_MT => ModKey.MakeFormKey(0x51fc);
            public static FormKey VampireLordSprint_MT => ModKey.MakeFormKey(0x240d);
            public static FormKey VampireLordDefault_MT => ModKey.MakeFormKey(0x240c);
        }
    }
}
