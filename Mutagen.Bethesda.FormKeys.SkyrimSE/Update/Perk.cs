namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Perk
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_PetStealth => ModKey.MakeFormKey(0x2f1e);
            public static FormKey MS04AncientKnowledge => ModKey.MakeFormKey(0x9d4);
        }
    }
}
