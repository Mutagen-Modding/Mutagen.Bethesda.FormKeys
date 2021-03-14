using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Creature
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<ICreatureGetter> Construct(uint id) => new FormLink<ICreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICreatureGetter> DogBattlehorn => Construct(0xc513);
            public static FormLink<ICreatureGetter> DLCBattlehornSkeleton => Construct(0xe824);
            public static FormLink<ICreatureGetter> DLCBattlehornLich => Construct(0xe337);
        }
    }
}
