namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MovementType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey BenthicLurkerCombatRun_MT => ModKey.MakeFormKey(0x35e11);
            public static FormKey DwarvenBallista_Default_MT => ModKey.MakeFormKey(0x2b015);
            public static FormKey BenthicLurkerDefault_MT => ModKey.MakeFormKey(0x248b5);
            public static FormKey DLC2Netch_Sprinting_MT => ModKey.MakeFormKey(0x209ad);
            public static FormKey DLC2Netch_Default_MT => ModKey.MakeFormKey(0x209a3);
            public static FormKey ScribDefault_MT => ModKey.MakeFormKey(0x1fedc);
            public static FormKey HMDaedraDefault_MT => ModKey.MakeFormKey(0x1dcbb);
            public static FormKey DLC2Riekling_Default_MT => ModKey.MakeFormKey(0x17f4d);
            public static FormKey Boar_Default_MT => ModKey.MakeFormKey(0x179d6);
        }
    }
}
