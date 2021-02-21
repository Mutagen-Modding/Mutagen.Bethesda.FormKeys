using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Tree
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<ITreeGetter> Construct(uint id) => new FormLink<ITreeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITreeGetter> DLC2TreeFloraAshYam01 => Construct(0x206e8);
            public static FormLink<ITreeGetter> DLC2TreeFloraHangingMoss03 => Construct(0x1ff66);
            public static FormLink<ITreeGetter> DLC2TreeFloraHangingMoss02 => Construct(0x1ff65);
            public static FormLink<ITreeGetter> DLC2TreeFloraHangingMoss01 => Construct(0x1ff64);
            public static FormLink<ITreeGetter> DLC2TreePineShrubAsh02 => Construct(0x19c60);
            public static FormLink<ITreeGetter> DLC2TreePineShrubAsh03 => Construct(0x19c5f);
            public static FormLink<ITreeGetter> DLC2TreePineShrubAsh01 => Construct(0x19c5e);
            public static FormLink<ITreeGetter> DLC2TreeThicketAsh01 => Construct(0x19c5b);
            public static FormLink<ITreeGetter> DLC2TreeDeadShrubAsh => Construct(0x19b16);
            public static FormLink<ITreeGetter> DLC2TreePineForestAsh05 => Construct(0x17f76);
            public static FormLink<ITreeGetter> DLC2TreePineForestAsh04 => Construct(0x17f75);
            public static FormLink<ITreeGetter> DLC2TreePineForestAsh03 => Construct(0x17f74);
            public static FormLink<ITreeGetter> DLC2TreePineForestAsh02 => Construct(0x17f73);
            public static FormLink<ITreeGetter> DLC2TreePineForestAsh01 => Construct(0x17f72);
            public static FormLink<ITreeGetter> DLC2TreePineForestAshL05 => Construct(0x17f71);
            public static FormLink<ITreeGetter> DLC2TreePineForestAshL04 => Construct(0x17f70);
            public static FormLink<ITreeGetter> DLC2TreePineForestAshL03 => Construct(0x17f6f);
            public static FormLink<ITreeGetter> DLC2TreePineForestAshL01 => Construct(0x17f6e);
            public static FormLink<ITreeGetter> DLC2TreePineForestAshL02 => Construct(0x17f6d);
            public static FormLink<ITreeGetter> DLC2TreePineForestDeadAshL05 => Construct(0x17f62);
            public static FormLink<ITreeGetter> DLC2TreePineForestDeadAshL04 => Construct(0x17f60);
            public static FormLink<ITreeGetter> DLC2TreePineForestDeadAshL03 => Construct(0x17f5c);
            public static FormLink<ITreeGetter> DLC2TreePineForestDeadAshL02 => Construct(0x17f5b);
            public static FormLink<ITreeGetter> DLC2TreePineForestDeadAshL01 => Construct(0x17f5a);
            public static FormLink<ITreeGetter> DLC2TreeFloraScathecraw02 => Construct(0x17e94);
            public static FormLink<ITreeGetter> DLC2TreeFloraScathecraw01 => Construct(0x17e93);
            public static FormLink<ITreeGetter> DLC2TreeFloraSpikyGrassAsh02 => Construct(0x16e25);
            public static FormLink<ITreeGetter> DLC2TreeFloraSpikyGrassAsh01 => Construct(0x16e24);
        }
    }
}
