namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey DLC06DunbarrowPirateFaction => ModKey.MakeFormKey(0x3edb);
            public static FormKey DLC06DunbarrowFaction => ModKey.MakeFormKey(0x3edc);
        }
    }
}
