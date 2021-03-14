using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class DialogTopic
        {
            private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogTopicGetter> DLCHorseArmorTopic => Construct(0xcef);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorTopicBuy => Construct(0x16c5);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorTopicSteel => Construct(0x260f);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorTopicElven => Construct(0x2610);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorTopicTooMuch => Construct(0x2afb);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorTopicNoHorse => Construct(0x34c7);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorNoHorse1 => Construct(0x6aaf);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorPersuade1 => Construct(0x6ab0);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorPersuade2 => Construct(0x6ab1);
            public static FormLink<IDialogTopicGetter> DLCHorseArmorPersuade3 => Construct(0x6ab2);
        }
    }
}
