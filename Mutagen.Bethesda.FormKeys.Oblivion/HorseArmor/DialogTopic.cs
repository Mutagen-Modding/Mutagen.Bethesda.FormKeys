namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class DialogTopic
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            public static FormKey DLCHorseArmorTopic => ModKey.MakeFormKey(0xcef);
            public static FormKey DLCHorseArmorTopicBuy => ModKey.MakeFormKey(0x16c5);
            public static FormKey DLCHorseArmorTopicSteel => ModKey.MakeFormKey(0x260f);
            public static FormKey DLCHorseArmorTopicElven => ModKey.MakeFormKey(0x2610);
            public static FormKey DLCHorseArmorTopicTooMuch => ModKey.MakeFormKey(0x2afb);
            public static FormKey DLCHorseArmorTopicNoHorse => ModKey.MakeFormKey(0x34c7);
            public static FormKey DLCHorseArmorNoHorse1 => ModKey.MakeFormKey(0x6aaf);
            public static FormKey DLCHorseArmorPersuade1 => ModKey.MakeFormKey(0x6ab0);
            public static FormKey DLCHorseArmorPersuade2 => ModKey.MakeFormKey(0x6ab1);
            public static FormKey DLCHorseArmorPersuade3 => ModKey.MakeFormKey(0x6ab2);
        }
    }
}
