namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Perk
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey BYOHRestedAdoptionPerk => ModKey.MakeFormKey(0x4295);
        }
    }
}
