namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHButterChurn => ModKey.MakeFormKey(0xbc0);
            public static FormKey BYOHMeadBarrel => ModKey.MakeFormKey(0xf39b);
            public static FormKey BYOHHawkNest => ModKey.MakeFormKey(0xf1ce);
        }
    }
}
