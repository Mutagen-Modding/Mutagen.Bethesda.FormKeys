namespace Mutagen.Bethesda.FormKeys.SkyrimSE
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
