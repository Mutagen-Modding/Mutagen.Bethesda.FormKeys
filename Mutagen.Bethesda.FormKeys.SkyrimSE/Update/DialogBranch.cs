using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class DialogBranch
        {
            private static FormLink<IDialogBranchGetter> Construct(uint id) => new FormLink<IDialogBranchGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogBranchGetter> PetFramework_BranchWaitResume => Construct(0x2f2d);
            public static FormLink<IDialogBranchGetter> PetFramework_BranchDismiss_CurrLoc => Construct(0x2f2c);
            public static FormLink<IDialogBranchGetter> PetFramework_BranchInventory => Construct(0x2f2a);
            public static FormLink<IDialogBranchGetter> PetFramework_BranchWait => Construct(0x2f25);
            public static FormLink<IDialogBranchGetter> PetFramework_BranchDismiss_Home => Construct(0x2f23);
            public static FormLink<IDialogBranchGetter> PetFramework_BranchDismiss_Hold => Construct(0x2f22);
            public static FormLink<IDialogBranchGetter> PetFramework_BranchRecruit => Construct(0x2f21);
        }
    }
}
