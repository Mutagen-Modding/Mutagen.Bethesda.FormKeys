namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class PlacedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey DLCHorseArmorMoveToMarker => ModKey.MakeFormKey(0xaf52);
            public static FormKey DLCHorseCellMarker => ModKey.MakeFormKey(0x3e9c);
            public static FormKey DLCHorseArmorMarker => ModKey.MakeFormKey(0x1c28);
            public static FormKey DLCHorseArmorChorrolMarker => ModKey.MakeFormKey(0xcf1);
        }
    }
}
