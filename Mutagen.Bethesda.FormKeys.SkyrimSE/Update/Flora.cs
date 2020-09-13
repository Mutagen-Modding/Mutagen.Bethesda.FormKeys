namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccBGS_FlameStalk02 => ModKey.MakeFormKey(0x308a);
            public static FormKey ccBGS_FlameStalk01 => ModKey.MakeFormKey(0x3089);
            public static FormKey ccBGS_RootThornHook => ModKey.MakeFormKey(0x306c);
            public static FormKey ccBGS_RootRotScale => ModKey.MakeFormKey(0x306b);
            public static FormKey ccBGS_RootScreamingMaw => ModKey.MakeFormKey(0x306a);
        }
    }
}
