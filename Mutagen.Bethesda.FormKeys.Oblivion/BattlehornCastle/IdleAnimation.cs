namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class IdleAnimation
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey DLCBattlehornOpenGate => ModKey.MakeFormKey(0x13918);
        }
    }
}
