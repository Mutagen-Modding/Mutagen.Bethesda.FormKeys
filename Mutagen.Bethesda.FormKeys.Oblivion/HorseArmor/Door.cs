namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey DLCHorseArmorStableDoor => ModKey.MakeFormKey(0x6ab7);
        }
    }
}
