namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey fPathMinimalUseDoorPenalty => ModKey.MakeFormKey(0xa468);
        }
    }
}
