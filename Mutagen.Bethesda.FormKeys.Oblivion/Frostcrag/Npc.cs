using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> Aurelinwae => Construct(0x1246);
        }
    }
}