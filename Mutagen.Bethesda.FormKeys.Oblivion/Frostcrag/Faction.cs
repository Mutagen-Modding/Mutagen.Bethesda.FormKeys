namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey FrostcragSpireAtronachFaction => ModKey.MakeFormKey(0x173e);
            public static FormKey ICMysticEmporiumFaction => ModKey.MakeFormKey(0x1250);
        }
    }
}
