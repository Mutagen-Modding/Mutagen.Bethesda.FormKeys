// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class DialogBranch
    {
        private static FormLink<IDialogBranchGetter> Construct(uint id) => new FormLink<IDialogBranchGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogBranchGetter> DLC03MQ03Branch => Construct(0x2b676);
        public static FormLink<IDialogBranchGetter> DLC03MQ04Branch => Construct(0x2e00e);
        public static FormLink<IDialogBranchGetter> DLC03MQ05_AllenTalk => Construct(0x1d271);
        public static FormLink<IDialogBranchGetter> DLC03DialogueFarHarbor_MQ05Hook => Construct(0x1d274);
        public static FormLink<IDialogBranchGetter> DLC03DialogueFarHarbor_WindFarm => Construct(0x24449);
        public static FormLink<IDialogBranchGetter> DLC03_COMOldLongfellowBranch => Construct(0x6e5d);
        public static FormLink<IDialogBranchGetter> DLC03CoA_DialogueNucleusGenericBranch => Construct(0x3a380);
        public static FormLink<IDialogBranchGetter> DLC03WorkshopRadiantOwned01Branch => Construct(0x48e8d);
        public static FormLink<IDialogBranchGetter> DLC03MQ06_WindFarmHandlingTopic => Construct(0x20427);
        public static FormLink<IDialogBranchGetter> DLC03WorkshopParentBranch => Construct(0x4402e);
        public static FormLink<IDialogBranchGetter> DLC03DialogueDiMACustomBranch => Construct(0x20de8);
        public static FormLink<IDialogBranchGetter> DLC03MQ06a_HCBranch => Construct(0x225f2);
        public static FormLink<IDialogBranchGetter> DLC03FarHarborS03_Avery => Construct(0x25fdb);
        public static FormLink<IDialogBranchGetter> DLC03WorkshopRadiantOwned03Branch => Construct(0x48e8c);
        public static FormLink<IDialogBranchGetter> DLC03WorkshopRadiantOwned05Branch => Construct(0x44030);
        public static FormLink<IDialogBranchGetter> DLC03_AO_Comment_Dialogue_Branch => Construct(0x480dc);
    }
}