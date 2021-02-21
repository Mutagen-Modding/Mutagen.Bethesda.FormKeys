using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> ccBGS_RootClusterLarge02 => Construct(0x30a5);
            public static FormLink<IStaticGetter> ccBGS_RootClusterLarge01 => Construct(0x30a4);
            public static FormLink<IStaticGetter> ccBGS_RootCluster02 => Construct(0x3092);
            public static FormLink<IStaticGetter> ccBGS_RootCluster01 => Construct(0x3091);
            public static FormLink<IStaticGetter> ccBGS_GiantRoot04 => Construct(0x3088);
            public static FormLink<IStaticGetter> ccBGS_GiantRoot03 => Construct(0x3087);
            public static FormLink<IStaticGetter> ccBGS_GiantRoot02 => Construct(0x3086);
            public static FormLink<IStaticGetter> ccBGS_GiantRoot01 => Construct(0x3085);
            public static FormLink<IStaticGetter> ccBGS_RootHallShift02 => Construct(0x3084);
            public static FormLink<IStaticGetter> ccBGS_RootHallShift01 => Construct(0x3083);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTree01 => Construct(0x3082);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTreeCluster03 => Construct(0x3081);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTreeCluster02 => Construct(0x3080);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTreeCluster01 => Construct(0x307f);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTree06 => Construct(0x307e);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTree05 => Construct(0x307d);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTree04 => Construct(0x307c);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTree03 => Construct(0x307b);
            public static FormLink<IStaticGetter> ccBGS_ThinMushroomTree02 => Construct(0x307a);
            public static FormLink<IStaticGetter> ccBGS_RootWeeds01 => Construct(0x3078);
            public static FormLink<IStaticGetter> ccBGS_RootMoundRound01 => Construct(0x3077);
            public static FormLink<IStaticGetter> ccBGS_FireStalkBud => Construct(0x3076);
            public static FormLink<IStaticGetter> ccBGS_RootHall2way => Construct(0x3075);
            public static FormLink<IStaticGetter> ccBGS_RootHallTurn => Construct(0x3074);
            public static FormLink<IStaticGetter> ccBGS_RootHallRamp01 => Construct(0x3073);
            public static FormLink<IStaticGetter> ccBGS_RootHallEndcap => Construct(0x3072);
            public static FormLink<IStaticGetter> ccBGS_RootHall4way => Construct(0x3071);
            public static FormLink<IStaticGetter> ccBGS_RootHall3way => Construct(0x3070);
            public static FormLink<IStaticGetter> TundraStreamBend01ReachMoss01ReachDirt01 => Construct(0x2f5c);
            public static FormLink<IStaticGetter> TundraStreamBend01ReachMoss01 => Construct(0x2f5b);
        }
    }
}
