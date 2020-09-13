namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Climate
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey SoulCairnClimate => ModKey.MakeFormKey(0x1409);
        }
    }
}
