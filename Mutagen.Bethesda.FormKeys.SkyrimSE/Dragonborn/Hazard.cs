namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Hazard
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2MorasGraspHazardLargeDrop => ModKey.MakeFormKey(0x3d54c);
            public static FormKey DLC2MorasGraspHazardDrop => ModKey.MakeFormKey(0x3a3d1);
            public static FormKey DLC2MorasGraspHazard => ModKey.MakeFormKey(0x3183e);
            public static FormKey DLC2BenthicLurkerGooHazardDrop => ModKey.MakeFormKey(0x1ae9d);
            public static FormKey DLC2ExpSpiderFireHazard => ModKey.MakeFormKey(0x1447d);
            public static FormKey DLC2ExpSpiderPoisonHazard => ModKey.MakeFormKey(0x1445a);
        }
    }
}
