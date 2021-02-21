using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Hazard
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IHazardGetter> Construct(uint id) => new FormLink<IHazardGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IHazardGetter> DLC2MorasGraspHazardLargeDrop => Construct(0x3d54c);
            public static FormLink<IHazardGetter> DLC2MorasGraspHazardDrop => Construct(0x3a3d1);
            public static FormLink<IHazardGetter> DLC2MorasGraspHazard => Construct(0x3183e);
            public static FormLink<IHazardGetter> DLC2BenthicLurkerGooHazardDrop => Construct(0x1ae9d);
            public static FormLink<IHazardGetter> DLC2ExpSpiderFireHazard => Construct(0x1447d);
            public static FormLink<IHazardGetter> DLC2ExpSpiderPoisonHazard => Construct(0x1445a);
        }
    }
}
