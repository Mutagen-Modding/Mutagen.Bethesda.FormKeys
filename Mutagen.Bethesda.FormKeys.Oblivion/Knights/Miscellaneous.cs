using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Miscellaneous
        {
            private static FormLink<IMiscellaneousGetter> Construct(uint id) => new FormLink<IMiscellaneousGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscellaneousGetter> ND05MiscStone => Construct(0xf03);
            public static FormLink<IMiscellaneousGetter> ND05MiscGem => Construct(0xf04);
            public static FormLink<IMiscellaneousGetter> ND05MiscSkull => Construct(0xf05);
            public static FormLink<IMiscellaneousGetter> ND05MiscHammer => Construct(0xf06);
            public static FormLink<IMiscellaneousGetter> ND05MiscBook => Construct(0xf07);
            public static FormLink<IMiscellaneousGetter> ND05MiscGoblet => Construct(0xf08);
            public static FormLink<IMiscellaneousGetter> ND05MiscHelm => Construct(0xf09);
            public static FormLink<IMiscellaneousGetter> ND05MiscSword => Construct(0xf0a);
        }
    }
}
