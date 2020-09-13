namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class ArmorAddon
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey ChildTorso05AA => ModKey.MakeFormKey(0xc741);
            public static FormKey ChildTorso04AA => ModKey.MakeFormKey(0xc73f);
        }
    }
}
