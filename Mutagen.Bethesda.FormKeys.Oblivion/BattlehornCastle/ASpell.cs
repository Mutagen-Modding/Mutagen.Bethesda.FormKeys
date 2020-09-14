namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey DLCBattlehornDragonswordPower2 => ModKey.MakeFormKey(0x147da);
            public static FormKey AbBattlehornArmorerBuff => ModKey.MakeFormKey(0xc512);
            public static FormKey DLCBattlehornDragonswordPower3 => ModKey.MakeFormKey(0x147d8);
            public static FormKey DLCBattlehornDragonswordPower1 => ModKey.MakeFormKey(0x147dd);
        }
    }
}
