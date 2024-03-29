// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class DialogTopic
    {
        private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogTopicGetter> DLC03MQ04TakeDataTopic => Construct(0x2dfda);
        public static FormLink<IDialogTopicGetter> DLC03MQ04StartCombatTopic => Construct(0x31668);
        public static FormLink<IDialogTopicGetter> COMOldLongfellowIdle => Construct(0xf11e);
        public static FormLink<IDialogTopicGetter> DLC03WorkshopParentAssignSceneA => Construct(0x4d3cb);
        public static FormLink<IDialogTopicGetter> DIMA_NeutralButton => Construct(0x20dc4);
        public static FormLink<IDialogTopicGetter> DIMA_QuestionButton => Construct(0x20dc5);
        public static FormLink<IDialogTopicGetter> DIMA_PositiveButton => Construct(0x22ced);
    }
}
