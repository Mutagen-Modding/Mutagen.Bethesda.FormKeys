namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Sound
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey NPCHorseFootArmor => ModKey.MakeFormKey(0x91ec);
        }
    }
}
