using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Creature
        {
            private static FormLink<ICreatureGetter> Construct(uint id) => new FormLink<ICreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICreatureGetter> DLCFrostcragAtronachFlame => Construct(0x1254);
            public static FormLink<ICreatureGetter> CreatureClannfearRuntFC => Construct(0x214a);
            public static FormLink<ICreatureGetter> DLCFrostcragAtronachStorm => Construct(0xd27);
            public static FormLink<ICreatureGetter> DLCFrostcragAtronachFrost => Construct(0xd26);
            public static FormLink<ICreatureGetter> CreatureImpFrostCrag => Construct(0x8c40);
        }
    }
}
