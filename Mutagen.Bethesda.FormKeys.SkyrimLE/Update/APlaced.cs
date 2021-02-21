using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class APlaced
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IAPlacedGetter> Construct(uint id) => new FormLink<IAPlacedGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAPlacedGetter> TGCrown15MoveToMarker => Construct(0x811);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolA1 => Construct(0x9b7);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolB3 => Construct(0x9b6);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolB1 => Construct(0x9b5);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolB003 => Construct(0x9b4);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp2PatrolA3 => Construct(0x9b3);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolA3 => Construct(0x9b2);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolA2 => Construct(0x9b1);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolA1 => Construct(0x9b0);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolB3 => Construct(0x9af);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolB1 => Construct(0x9ae);
            public static FormLink<IAPlacedGetter> WindhelmPalaceUp1PatrolB2 => Construct(0x9ad);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1SonsA => Construct(0x9ac);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1SonsB => Construct(0x9ab);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2SonsA => Construct(0x9aa);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2SonsB => Construct(0x9a9);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1ImperialA => Construct(0x9a8);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp1ImperialB => Construct(0x9a7);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2ImperialA => Construct(0x9a6);
            public static FormLink<IAPlacedGetter> GuardWindhelmPalaceUp2ImperialB => Construct(0x9a5);
        }
    }
}
