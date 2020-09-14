namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey HorsePCOldNagScript => ModKey.MakeFormKey(0x3e9b);
            public static FormKey DLCHorseArmorScriptSnakGraBura => ModKey.MakeFormKey(0x4382);
            public static FormKey DLCHorseArmorDoorScript => ModKey.MakeFormKey(0x6ab8);
            public static FormKey DLCHorseArmorScript => ModKey.MakeFormKey(0xced);
        }
    }
}
