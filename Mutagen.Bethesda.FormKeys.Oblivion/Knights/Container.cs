namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey TestQAKnights => ModKey.MakeFormKey(0xee0);
            public static FormKey NDChestVendorBooks => ModKey.MakeFormKey(0xee1);
            public static FormKey NDPrioryUndercroftBossChest => ModKey.MakeFormKey(0xee2);
            public static FormKey NDPrioryUndercroftChest01 => ModKey.MakeFormKey(0xee3);
            public static FormKey ND05MainTestChestNew => ModKey.MakeFormKey(0xee4);
            public static FormKey NDPrioryArmoryChest => ModKey.MakeFormKey(0xee5);
            public static FormKey ND05MainTestChestKurt => ModKey.MakeFormKey(0xee6);
            public static FormKey ND08Tomb => ModKey.MakeFormKey(0xee7);
            public static FormKey ND05StoneChest => ModKey.MakeFormKey(0xee8);
            public static FormKey ND05GemChest => ModKey.MakeFormKey(0xee9);
            public static FormKey ND05HammerChest => ModKey.MakeFormKey(0xeea);
            public static FormKey ND05GobletChest => ModKey.MakeFormKey(0xeeb);
            public static FormKey ND05BookChest => ModKey.MakeFormKey(0xeec);
            public static FormKey ND05SkullChest => ModKey.MakeFormKey(0xeed);
            public static FormKey ND05HelmChest => ModKey.MakeFormKey(0xeee);
            public static FormKey ND05SwordChest => ModKey.MakeFormKey(0xeef);
            public static FormKey ND05MainTestChest => ModKey.MakeFormKey(0xef0);
        }
    }
}
