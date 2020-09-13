namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Global
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey OghmaInfiniumBookHasBeenRead => ModKey.MakeFormKey(0x9de);
            public static FormKey RiftenUngrienGlobal => ModKey.MakeFormKey(0x9db);
            public static FormKey WEDL06LetrushKilled => ModKey.MakeFormKey(0x99c);
        }
    }
}
