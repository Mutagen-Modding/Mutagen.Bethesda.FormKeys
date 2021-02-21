using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class ImpactDataSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IImpactDataSetGetter> Construct(uint id) => new FormLink<IImpactDataSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactDataSetGetter> WPNzBlade1HandWoodSwordImpactSet => Construct(0x8993);
        }
    }
}
