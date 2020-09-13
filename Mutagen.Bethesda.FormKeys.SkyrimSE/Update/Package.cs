namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Package
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_PetFollowPlayer => ModKey.MakeFormKey(0x2f1a);
        }
    }
}
