using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Static
        {
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> NDBarrierSmallCrypt => Construct(0xf0b);
            public static FormLink<IStaticGetter> NDCryptEntrance01 => Construct(0xf0c);
            public static FormLink<IStaticGetter> NDCathedralExtWin01 => Construct(0xf0d);
            public static FormLink<IStaticGetter> ND10orbOfSmitting => Construct(0xf0e);
            public static FormLink<IStaticGetter> NDBlastRing => Construct(0xf0f);
            public static FormLink<IStaticGetter> NDRFDchestLargeJulianos => Construct(0xf10);
            public static FormLink<IStaticGetter> NDCathedralCryptAlcove01 => Construct(0xf11);
            public static FormLink<IStaticGetter> NDCathedralCryptCorner01 => Construct(0xf12);
            public static FormLink<IStaticGetter> NDPriory01 => Construct(0xf13);
            public static FormLink<IStaticGetter> NDPrioryStairs01 => Construct(0xf14);
            public static FormLink<IStaticGetter> NDCathedralCryptWin01 => Construct(0xf15);
            public static FormLink<IStaticGetter> NDCathedralCryptStraight01 => Construct(0xf16);
            public static FormLink<IStaticGetter> NDBlood01 => Construct(0xf17);
            public static FormLink<IStaticGetter> NDBarrier => Construct(0xf18);
            public static FormLink<IStaticGetter> NDKnightTomb => Construct(0xf19);
            public static FormLink<IStaticGetter> NDSwordsNine => Construct(0xf1a);
            public static FormLink<IStaticGetter> NdRug => Construct(0xf1b);
            public static FormLink<IStaticGetter> ND10CloudCollision => Construct(0xf1c);
            public static FormLink<IStaticGetter> NDCloudLayer => Construct(0xf1d);
            public static FormLink<IStaticGetter> ND10Clouds => Construct(0xf1e);
            public static FormLink<IStaticGetter> NDTapestry => Construct(0xf1f);
        }
    }
}
