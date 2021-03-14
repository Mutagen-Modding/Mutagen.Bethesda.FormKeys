using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Potion
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IPotionGetter> Construct(uint id) => new FormLink<IPotionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPotionGetter> DrinkArgonianBloodwine => Construct(0xa6a8);
            public static FormLink<IPotionGetter> DrinkNumbskinMead => Construct(0xa6a9);
            public static FormLink<IPotionGetter> DrinkJulianosFirebelly => Construct(0xa6ab);
            public static FormLink<IPotionGetter> DrinkSparklingHoneydew => Construct(0xa6ad);
            public static FormLink<IPotionGetter> DrinkStumblefootsReserve => Construct(0xa6af);
            public static FormLink<IPotionGetter> DrinkFrostdewBlanc => Construct(0xa6a2);
            public static FormLink<IPotionGetter> DrinkColovianBattleCry => Construct(0xa6a5);
        }
    }
}
