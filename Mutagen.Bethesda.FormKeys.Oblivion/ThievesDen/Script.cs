using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Script
        {
            private static FormLink<IScriptGetter> Construct(uint id) => new FormLink<IScriptGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScriptGetter> DLC06SecurityChestScript => Construct(0x34a4);
            public static FormLink<IScriptGetter> DLC06ThievesDenQuestScript => Construct(0x3e85);
            public static FormLink<IScriptGetter> DLCWeakenLockScript => Construct(0x83a3);
            public static FormLink<IScriptGetter> DLC06PirateScript => Construct(0xbf79);
            public static FormLink<IScriptGetter> DLC06UndeadPirateScript => Construct(0x11ae3);
            public static FormLink<IScriptGetter> DLC06ThievesDenCaptainsQtrUpgradeScript => Construct(0x12ef2);
            public static FormLink<IScriptGetter> DLC06ThievesDenSupplierUpgradeScript => Construct(0x12ef3);
            public static FormLink<IScriptGetter> DLC06ThievesDenStealthUpgradeScript => Construct(0x12ef4);
            public static FormLink<IScriptGetter> DLC06ThievesDenSecurityUpgradeScript => Construct(0x12ef5);
            public static FormLink<IScriptGetter> DLC06ThievesDenFletcherUpgradeScript => Construct(0x12ef6);
            public static FormLink<IScriptGetter> DLC06ThievesDenFenceUpgradeScript => Construct(0x12ef7);
            public static FormLink<IScriptGetter> DLC06FletcherScript => Construct(0x12ef8);
            public static FormLink<IScriptGetter> DLC06PirateScript2 => Construct(0x13dcc);
        }
    }
}
