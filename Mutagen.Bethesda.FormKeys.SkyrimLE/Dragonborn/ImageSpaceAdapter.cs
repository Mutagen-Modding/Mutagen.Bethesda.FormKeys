using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class ImageSpaceAdapter
        {
            private static FormLink<IImageSpaceAdapterGetter> Construct(uint id) => new FormLink<IImageSpaceAdapterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImageSpaceAdapterGetter> DLC2ConstellationExplosionImod => Construct(0x3d5cf);
            public static FormLink<IImageSpaceAdapterGetter> DLC2ApocryphaBookExitMQ02 => Construct(0x3d573);
            public static FormLink<IImageSpaceAdapterGetter> DLC2MAGBanishApocryphaImod => Construct(0x3d3ba);
            public static FormLink<IImageSpaceAdapterGetter> DLC2MorasGraspCastImod => Construct(0x3a29a);
            public static FormLink<IImageSpaceAdapterGetter> DLC2BendWillImod => Construct(0x39e44);
            public static FormLink<IImageSpaceAdapterGetter> DLC2dunKarstaagMAGBlizzardForceExplosionImod => Construct(0x38abb);
            public static FormLink<IImageSpaceAdapterGetter> DLC2dunKarstaagMAGFrostExpImod => Construct(0x38ab9);
            public static FormLink<IImageSpaceAdapterGetter> DLC2ApocryphaRewardBookEnter => Construct(0x38060);
            public static FormLink<IImageSpaceAdapterGetter> DLC2ApocryphaRewardBookExit => Construct(0x3805f);
            public static FormLink<IImageSpaceAdapterGetter> DLC2ApocryphaBookExit => Construct(0x3805e);
            public static FormLink<IImageSpaceAdapterGetter> DLC2ApocryphaBookEnter => Construct(0x366aa);
            public static FormLink<IImageSpaceAdapterGetter> DLC2StandingStoneCageExplosionImod => Construct(0x31d27);
            public static FormLink<IImageSpaceAdapterGetter> DLC2StandingStoneReleaseImod => Construct(0x31d26);
            public static FormLink<IImageSpaceAdapterGetter> DLC2MiraakTeleportIMODStatic => Construct(0x317d8);
            public static FormLink<IImageSpaceAdapterGetter> DLC2HMDaedraExpImod02 => Construct(0x24fbc);
            public static FormLink<IImageSpaceAdapterGetter> DLC2HMDaedraExpImod => Construct(0x23f86);
            public static FormLink<IImageSpaceAdapterGetter> DLC2DBBookLevelIod => Construct(0x1eb05);
        }
    }
}
