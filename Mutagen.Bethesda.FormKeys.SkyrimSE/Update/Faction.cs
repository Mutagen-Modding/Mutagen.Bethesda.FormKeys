using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Faction
        {
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> PetFramework_PetFollowingFaction => Construct(0x2f1d);
            public static FormLink<IFactionGetter> PetFramework_PetFaction => Construct(0x2f1b);
            public static FormLink<IFactionGetter> CR08ExclusionFaction => Construct(0x944);
        }
    }
}
