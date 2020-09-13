namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class AddonNode
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1MPSVampDrainTrail01 => ModKey.MakeFormKey(0x1a3f9);
            public static FormKey DLC01SoulRendTrailMPS => ModKey.MakeFormKey(0x7cbe);
        }
    }
}
