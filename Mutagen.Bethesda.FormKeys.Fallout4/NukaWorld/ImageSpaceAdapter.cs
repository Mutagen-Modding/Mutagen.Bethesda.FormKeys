// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class ImageSpaceAdapter
    {
        private static FormLink<IImageSpaceAdapterGetter> Construct(uint id) => new FormLink<IImageSpaceAdapterGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImageSpaceAdapterGetter> DLC04MisterImodHit => Construct(0x50279);
        public static FormLink<IImageSpaceAdapterGetter> DLC04ExplosionNukaCherryImod => Construct(0x4bf1f);
        public static FormLink<IImageSpaceAdapterGetter> DLC04PackScentGrenadeImageSpace => Construct(0x3db49);
        public static FormLink<IImageSpaceAdapterGetter> DLC04ExplosionNukaQuantumImod => Construct(0x36f6e);
        public static FormLink<IImageSpaceAdapterGetter> DLC04Gauntlet_GasHazardImod => Construct(0x2d827);
        public static FormLink<IImageSpaceAdapterGetter> DLC04_FadeToBlackImod => Construct(0x2ab6a);
        public static FormLink<IImageSpaceAdapterGetter> DLC04ExplosionNukaNukeImod => Construct(0x1a290);
    }
}
