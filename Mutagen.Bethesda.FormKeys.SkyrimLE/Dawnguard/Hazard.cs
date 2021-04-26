// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
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
