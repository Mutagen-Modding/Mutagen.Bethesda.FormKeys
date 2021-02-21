using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IANpcSpawnGetter> Construct(uint id) => new FormLink<IANpcSpawnGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IANpcSpawnGetter> Aurelinwae => Construct(0x1246);
            public static FormLink<IANpcSpawnGetter> DLCFrostcragAtronachFlame => Construct(0x1254);
            public static FormLink<IANpcSpawnGetter> CreatureClannfearRuntFC => Construct(0x214a);
            public static FormLink<IANpcSpawnGetter> DLCFrostcragAtronachStorm => Construct(0xd27);
            public static FormLink<IANpcSpawnGetter> DLCFrostcragAtronachFrost => Construct(0xd26);
            public static FormLink<IANpcSpawnGetter> CreatureImpFrostCrag => Construct(0x8c40);
        }
    }
}
