using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp1SonsA => Construct(0x9ac);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp1SonsB => Construct(0x9ab);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp2SonsA => Construct(0x9aa);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp2SonsB => Construct(0x9a9);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp1ImperialA => Construct(0x9a8);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp1ImperialB => Construct(0x9a7);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp2ImperialA => Construct(0x9a6);
            public static FormLink<IPlacedNpcGetter> GuardWindhelmPalaceUp2ImperialB => Construct(0x9a5);
        }
    }
}
