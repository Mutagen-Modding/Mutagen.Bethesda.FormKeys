namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Global
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey PCInfamy => ModKey.MakeFormKey(0xce7);
        }
    }
}
