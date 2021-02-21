using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Faction
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> DLCBattlehornCastleFaction => Construct(0xb09e);
            public static FormLink<IFactionGetter> DLCBattlehornSparringFaction => Construct(0xbb21);
            public static FormLink<IFactionGetter> DLCBattlehornCastleKnightFaction => Construct(0xcf3c);
            public static FormLink<IFactionGetter> DLCBattlehornCaptainFaction => Construct(0xd43f);
        }
    }
}
