using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class PlacedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> TGCrown15MoveToMarker => Construct(0x811);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolA1 => Construct(0x9b7);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolB3 => Construct(0x9b6);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolB1 => Construct(0x9b5);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolB003 => Construct(0x9b4);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp2PatrolA3 => Construct(0x9b3);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolA3 => Construct(0x9b2);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolA2 => Construct(0x9b1);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolA1 => Construct(0x9b0);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolB3 => Construct(0x9af);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolB1 => Construct(0x9ae);
            public static FormLink<IPlacedObjectGetter> WindhelmPalaceUp1PatrolB2 => Construct(0x9ad);
        }
    }
}
