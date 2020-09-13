namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class CombatStyle
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey csAdoptedChildren => ModKey.MakeFormKey(0x7b73);
        }
    }
}
