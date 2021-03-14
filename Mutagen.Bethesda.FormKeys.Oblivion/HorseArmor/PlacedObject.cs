using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class PlacedObject
        {
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> DLCHorseArmorMoveToMarker => Construct(0xaf52);
            public static FormLink<IPlacedObjectGetter> DLCHorseCellMarker => Construct(0x3e9c);
            public static FormLink<IPlacedObjectGetter> DLCHorseArmorMarker => Construct(0x1c28);
            public static FormLink<IPlacedObjectGetter> DLCHorseArmorChorrolMarker => Construct(0xcf1);
        }
    }
}
