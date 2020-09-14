namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey DLCHorseArmorDummyCell => ModKey.MakeFormKey(0x1bb0);
        }
    }
}
