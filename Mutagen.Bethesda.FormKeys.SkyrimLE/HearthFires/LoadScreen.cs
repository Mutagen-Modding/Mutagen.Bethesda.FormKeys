namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class LoadScreen
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHAdoption03 => ModKey.MakeFormKey(0x15fba);
            public static FormKey BYOHAdoption02 => ModKey.MakeFormKey(0x15fb9);
            public static FormKey BYOHAdoption01 => ModKey.MakeFormKey(0xf838);
            public static FormKey BYOHBuildYourOwnHouse => ModKey.MakeFormKey(0xf837);
        }
    }
}
