using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> DL9MoragTongFaction => Construct(0x252f);
            public static FormLink<IFactionGetter> DL9CommanderFaction => Construct(0x2530);
            public static FormLink<IFactionGetter> DL9DrothermiFaction => Construct(0x14e9);
        }
    }
}
