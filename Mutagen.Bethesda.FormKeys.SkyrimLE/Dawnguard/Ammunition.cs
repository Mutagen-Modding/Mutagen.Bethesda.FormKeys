namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Ammunition
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1SoulCairnKeeperArrow => ModKey.MakeFormKey(0xff03);
            public static FormKey DLC1ElderScrollBack => ModKey.MakeFormKey(0x1a958);
            public static FormKey DLC1DragonboneArrow => ModKey.MakeFormKey(0x176f4);
            public static FormKey DLC1BoltSteelExplodingShock => ModKey.MakeFormKey(0xf1bc);
            public static FormKey DLC1BoltSteelExplodingIce => ModKey.MakeFormKey(0xf1bb);
            public static FormKey DLC1BoltDwarvenExplodingShock => ModKey.MakeFormKey(0xf1b9);
            public static FormKey DLC1BoltDwarvenExplodingIce => ModKey.MakeFormKey(0xf1b7);
            public static FormKey DLC1BoltDwarvenExplodingFire => ModKey.MakeFormKey(0xf1b1);
            public static FormKey DLC1BoltSteelExplodingFire => ModKey.MakeFormKey(0xf1a0);
            public static FormKey DLC1BoltDwarven => ModKey.MakeFormKey(0xd099);
            public static FormKey DLC1ElvenArrowBlessed => ModKey.MakeFormKey(0x98a1);
            public static FormKey DLC1ElvenArrowBlood => ModKey.MakeFormKey(0x98a0);
            public static FormKey TestDLC1Bolt => ModKey.MakeFormKey(0x590c);
            public static FormKey DLC1BoltSteel => ModKey.MakeFormKey(0xbb3);
        }
    }
}
