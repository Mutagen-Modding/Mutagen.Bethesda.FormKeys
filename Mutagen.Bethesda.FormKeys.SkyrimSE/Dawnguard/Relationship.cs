using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Relationship
        {
            private static FormLink<IRelationshipGetter> Construct(uint id) => new FormLink<IRelationshipGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRelationshipGetter> DLC1DurnehviirPlayer => Construct(0xc71b);
        }
    }
}
