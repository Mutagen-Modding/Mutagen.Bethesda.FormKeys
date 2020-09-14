namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey DLCBattlehornCastle => ModKey.MakeFormKey(0xb089);
        }
    }
}
