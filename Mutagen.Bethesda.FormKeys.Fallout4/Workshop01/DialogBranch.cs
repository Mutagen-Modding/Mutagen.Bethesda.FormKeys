// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static partial class DialogBranch
    {
        private static FormLink<IDialogBranchGetter> Construct(uint id) => new FormLink<IDialogBranchGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogBranchGetter> DLC02WorkshopSummonedToRelaxBranch => Construct(0xa9a);
    }
}
