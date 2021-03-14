using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Key
        {
            private static FormLink<IKeyGetter> Construct(uint id) => new FormLink<IKeyGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeyGetter> FrostcragSpireKey => Construct(0xd50);
        }
    }
}