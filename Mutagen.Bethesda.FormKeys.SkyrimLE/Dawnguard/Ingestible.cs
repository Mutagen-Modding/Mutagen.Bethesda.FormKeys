using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Ingestible
        {
            private static FormLink<IIngestibleGetter> Construct(uint id) => new FormLink<IIngestibleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngestibleGetter> DLC1BloodPotion => Construct(0x18ef3);
            public static FormLink<IIngestibleGetter> DLC1FoodSoulHuskExtract => Construct(0x15a1e);
            public static FormLink<IIngestibleGetter> DLC1FoodSoulHusk => Construct(0x14dc4);
            public static FormLink<IIngestibleGetter> DLC1RedwaterDenSkooma => Construct(0x1391d);
        }
    }
}
