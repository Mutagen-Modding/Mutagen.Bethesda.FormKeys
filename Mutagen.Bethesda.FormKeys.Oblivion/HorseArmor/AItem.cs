namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey DLCHorseArmorNote => ModKey.MakeFormKey(0x5235);
            public static FormKey DLCHorseArmorPlans => ModKey.MakeFormKey(0x16c6);
        }
    }
}
