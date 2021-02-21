using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class BodyPartData
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IBodyPartDataGetter> Construct(uint id) => new FormLink<IBodyPartDataGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBodyPartDataGetter> GargoyleBodyPartData => Construct(0xa2c7);
            public static FormLink<IBodyPartDataGetter> ChaurusFlyerBodyPartData => Construct(0x5205);
        }
    }
}
