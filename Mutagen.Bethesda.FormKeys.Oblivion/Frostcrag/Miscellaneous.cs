using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Miscellaneous
        {
            private static FormLink<IMiscellaneousGetter> Construct(uint id) => new FormLink<IMiscellaneousGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscellaneousGetter> FrostcragMagetallowCandle => Construct(0xd44);
        }
    }
}