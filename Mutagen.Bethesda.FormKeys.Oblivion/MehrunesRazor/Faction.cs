namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            public static FormKey DL9MoragTongFaction => ModKey.MakeFormKey(0x252f);
            public static FormKey DL9CommanderFaction => ModKey.MakeFormKey(0x2530);
            public static FormKey DL9DrothermiFaction => ModKey.MakeFormKey(0x14e9);
        }
    }
}
