using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Faction
        {
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> DLC06DunbarrowPirateFaction => Construct(0x3edb);
            public static FormLink<IFactionGetter> DLC06DunbarrowFaction => Construct(0x3edc);
        }
    }
}
