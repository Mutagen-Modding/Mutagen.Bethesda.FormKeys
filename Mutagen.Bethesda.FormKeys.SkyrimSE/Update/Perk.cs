using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Perk
        {
            private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPerkGetter> PetFramework_PetStealth => Construct(0x2f1e);
            public static FormLink<IPerkGetter> MS04AncientKnowledge => Construct(0x9d4);
        }
    }
}
