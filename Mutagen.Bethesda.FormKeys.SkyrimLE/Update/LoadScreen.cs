namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class LoadScreen
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey CharacterSkillILegendary => ModKey.MakeFormKey(0x9da);
        }
    }
}
