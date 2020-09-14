namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey DLC06SecurityChestScript => ModKey.MakeFormKey(0x34a4);
            public static FormKey DLC06ThievesDenQuestScript => ModKey.MakeFormKey(0x3e85);
            public static FormKey DLCWeakenLockScript => ModKey.MakeFormKey(0x83a3);
            public static FormKey DLC06PirateScript => ModKey.MakeFormKey(0xbf79);
            public static FormKey DLC06UndeadPirateScript => ModKey.MakeFormKey(0x11ae3);
            public static FormKey DLC06ThievesDenCaptainsQtrUpgradeScript => ModKey.MakeFormKey(0x12ef2);
            public static FormKey DLC06ThievesDenSupplierUpgradeScript => ModKey.MakeFormKey(0x12ef3);
            public static FormKey DLC06ThievesDenStealthUpgradeScript => ModKey.MakeFormKey(0x12ef4);
            public static FormKey DLC06ThievesDenSecurityUpgradeScript => ModKey.MakeFormKey(0x12ef5);
            public static FormKey DLC06ThievesDenFletcherUpgradeScript => ModKey.MakeFormKey(0x12ef6);
            public static FormKey DLC06ThievesDenFenceUpgradeScript => ModKey.MakeFormKey(0x12ef7);
            public static FormKey DLC06FletcherScript => ModKey.MakeFormKey(0x12ef8);
            public static FormKey DLC06PirateScript2 => ModKey.MakeFormKey(0x13dcc);
        }
    }
}
