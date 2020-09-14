namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class CombatStyle
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            public static FormKey DLCBattlehornLichCombatStyle => ModKey.MakeFormKey(0xe823);
        }
    }
}
