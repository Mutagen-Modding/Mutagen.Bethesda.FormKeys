namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Class
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1EncClassDeathhound => ModKey.MakeFormKey(0x145dc);
            public static FormKey DLC1CClassVyrthur => ModKey.MakeFormKey(0x126b3);
            public static FormKey DLC1EncClassGargoyle => ModKey.MakeFormKey(0xd6f6);
            public static FormKey DLC1_EncClassChaurusFlyer => ModKey.MakeFormKey(0x5206);
            public static FormKey DLC1EncClassKatria => ModKey.MakeFormKey(0x4d0e);
        }
    }
}
