namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class DialogBranch
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_BranchWaitResume => ModKey.MakeFormKey(0x2f2d);
            public static FormKey PetFramework_BranchDismiss_CurrLoc => ModKey.MakeFormKey(0x2f2c);
            public static FormKey PetFramework_BranchInventory => ModKey.MakeFormKey(0x2f2a);
            public static FormKey PetFramework_BranchWait => ModKey.MakeFormKey(0x2f25);
            public static FormKey PetFramework_BranchDismiss_Home => ModKey.MakeFormKey(0x2f23);
            public static FormKey PetFramework_BranchDismiss_Hold => ModKey.MakeFormKey(0x2f22);
            public static FormKey PetFramework_BranchRecruit => ModKey.MakeFormKey(0x2f21);
        }
    }
}
