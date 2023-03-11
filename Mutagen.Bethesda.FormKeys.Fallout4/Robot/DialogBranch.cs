// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class DialogBranch
    {
        private static FormLink<IDialogBranchGetter> Construct(uint id) => new FormLink<IDialogBranchGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogBranchGetter> DLC01MQ02_ToCodsworthStage400 => Construct(0x254d);
        public static FormLink<IDialogBranchGetter> DLC01MQ02_ToCodsworthStage600 => Construct(0x254f);
        public static FormLink<IDialogBranchGetter> DLC01MQ00Branch => Construct(0x892);
        public static FormLink<IDialogBranchGetter> DLC01COMRobotCompanionBranch => Construct(0x14ed);
        public static FormLink<IDialogBranchGetter> DLC01MQ04Branch => Construct(0x2885);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantAssault01Branch => Construct(0x3ef0);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantParentBranch => Construct(0x3eea);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantScene01Branch => Construct(0x3ef1);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantTravel01Branch => Construct(0x3ef2);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantTravel02Branch => Construct(0xd625);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantAssault04_InstBranch => Construct(0xd623);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantAssault02Branch => Construct(0xaf72);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantAssault03_MinBranch => Construct(0xaf73);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantAssault05_BOSBranch => Construct(0xd624);
        public static FormLink<IDialogBranchGetter> DLC01MQPostQuestRadiantScene02Branch => Construct(0xd628);
        public static FormLink<IDialogBranchGetter> DLC01WorkshopParentBranch => Construct(0xf47d);
        public static FormLink<IDialogBranchGetter> DLC01COMRobotCompanionCommandDialogue => Construct(0xebaa);
    }
}