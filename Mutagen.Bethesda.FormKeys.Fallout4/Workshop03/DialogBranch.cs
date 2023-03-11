// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static class DialogBranch
    {
        private static FormLink<IDialogBranchGetter> Construct(uint id) => new FormLink<IDialogBranchGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogBranchGetter> DLC06WorkshopParentBranch => Construct(0x24c7);
        public static FormLink<IDialogBranchGetter> DLC06E01Branch => Construct(0x1089);
    }
}