using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class WordOfPower
        {
            private static FormLink<IWordOfPowerGetter> Construct(uint id) => new FormLink<IWordOfPowerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWordOfPowerGetter> DLC2MKMiraakMaskShoutWord => Construct(0x39d29);
            public static FormLink<IWordOfPowerGetter> DLC2BattleFuryWord3 => Construct(0x200e6);
            public static FormLink<IWordOfPowerGetter> DLC2BattleFuryWord2 => Construct(0x200e5);
            public static FormLink<IWordOfPowerGetter> DLC2BattleFuryWord1 => Construct(0x200e4);
            public static FormLink<IWordOfPowerGetter> DLC2CycloneWord3 => Construct(0x200c4);
            public static FormLink<IWordOfPowerGetter> DLC2CycloneWord2 => Construct(0x200c3);
            public static FormLink<IWordOfPowerGetter> DLC2CycloneWord1 => Construct(0x200c2);
            public static FormLink<IWordOfPowerGetter> DLC2DragonAspectWord3 => Construct(0x1df95);
            public static FormLink<IWordOfPowerGetter> DLC2DragonAspectWord2 => Construct(0x1df94);
            public static FormLink<IWordOfPowerGetter> DLC2DragonAspectWord1 => Construct(0x1df93);
            public static FormLink<IWordOfPowerGetter> dlc2DBWordRageOfAncients => Construct(0x1bff2);
            public static FormLink<IWordOfPowerGetter> DLC2BendToWillWord3 => Construct(0x179db);
            public static FormLink<IWordOfPowerGetter> DLC2BendToWillWord2 => Construct(0x179da);
            public static FormLink<IWordOfPowerGetter> DLC2BendToWillWord1 => Construct(0x179d9);
        }
    }
}
