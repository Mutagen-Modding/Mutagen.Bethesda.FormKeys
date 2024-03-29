// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class DialogTopic
    {
        private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogTopicGetter> DLC01COMRTalkGreetings => Construct(0x908);
        public static FormLink<IDialogTopicGetter> DLC01MasterQuestShared => Construct(0xb1b7);
        public static FormLink<IDialogTopicGetter> DLC01COMRWaitingForInput => Construct(0xbef);
        public static FormLink<IDialogTopicGetter> DLC01COMRShared => Construct(0xbf0);
        public static FormLink<IDialogTopicGetter> DLC01COMRIdles => Construct(0xbf1);
        public static FormLink<IDialogTopicGetter> DLC01COMRHellos => Construct(0xbf2);
        public static FormLink<IDialogTopicGetter> DLC01COMRGreetings => Construct(0xbf3);
        public static FormLink<IDialogTopicGetter> DLC01ComRobotRumors => Construct(0x10110);
        public static FormLink<IDialogTopicGetter> DLC01MQ04RadiantOutro => Construct(0x287f);
        public static FormLink<IDialogTopicGetter> DLC01MQ04RadiantIntro => Construct(0xffb5);
        public static FormLink<IDialogTopicGetter> DLC01MQPostQuestRadiantRumors => Construct(0x3ea8);
        public static FormLink<IDialogTopicGetter> DLC01MQPostQuestRadiantIntro => Construct(0x3ea9);
        public static FormLink<IDialogTopicGetter> DLC01COMRBleepWaiting => Construct(0xb195);
        public static FormLink<IDialogTopicGetter> DLC01COMRBleepIdles => Construct(0xb196);
        public static FormLink<IDialogTopicGetter> DLC01COMRBleepHellos => Construct(0xb197);
        public static FormLink<IDialogTopicGetter> DLC01COMRBleepGreets => Construct(0xb1a4);
        public static FormLink<IDialogTopicGetter> DLC01COMRobotCompanionOtherShared => Construct(0xf5b0);
        public static FormLink<IDialogTopicGetter> DLC01COMRobotCompanionOtherGreets => Construct(0xf5b9);
        public static FormLink<IDialogTopicGetter> DLC01COMRobotCompanionBeepTalkGreets => Construct(0xf67d);
        public static FormLink<IDialogTopicGetter> DLC01COMRobotCompanionOtherTalkGreets => Construct(0xf68e);
        public static FormLink<IDialogTopicGetter> DLC01MQ04PostGreets => Construct(0xf8eb);
    }
}
