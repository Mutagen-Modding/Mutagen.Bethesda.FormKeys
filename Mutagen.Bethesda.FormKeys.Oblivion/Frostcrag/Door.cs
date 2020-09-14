namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey FrostcragSpireTelepadTower => ModKey.MakeFormKey(0xae35);
            public static FormKey FrostcragSpireTelepadBruma => ModKey.MakeFormKey(0xbd27);
            public static FormKey FrostCragDisplayCase01 => ModKey.MakeFormKey(0x3f05);
            public static FormKey TeleportTest01DOOR => ModKey.MakeFormKey(0x43ef);
            public static FormKey FrostCragSpireDoor01 => ModKey.MakeFormKey(0x3ef2);
            public static FormKey FrostcragSpireTelepad => ModKey.MakeFormKey(0xcff);
            public static FormKey FrostcragSpireTelepadKVATCH01 => ModKey.MakeFormKey(0x8012);
        }
    }
}
