using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Hazard
        {
            private static FormLink<IHazardGetter> Construct(uint id) => new FormLink<IHazardGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IHazardGetter> Test2LightHazard => Construct(0x15413);
        }
    }
}
