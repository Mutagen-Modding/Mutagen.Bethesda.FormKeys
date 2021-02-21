using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Tree
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ITreeGetter> Construct(uint id) => new FormLink<ITreeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITreeGetter> TreeSoulCairnShrubGroup02 => Construct(0x11d55);
            public static FormLink<ITreeGetter> TreeSoulCairnShrubGroup01 => Construct(0x11d54);
            public static FormLink<ITreeGetter> DLC1TreeFloraMountainFlower02Yellow => Construct(0x2a77);
            public static FormLink<ITreeGetter> DLC1TreeFloraMountainFlower01Yellow => Construct(0x2a76);
            public static FormLink<ITreeGetter> DLC1PPVineWall03NoCol => Construct(0x165a1);
            public static FormLink<ITreeGetter> DLC1PPVineWall03 => Construct(0x165a0);
            public static FormLink<ITreeGetter> DLC1PPVineWall02NoCol => Construct(0x1659f);
            public static FormLink<ITreeGetter> DLC1PPVineWall02 => Construct(0x1659e);
            public static FormLink<ITreeGetter> DLC1PPVineWall01NoCol => Construct(0x1659d);
            public static FormLink<ITreeGetter> DLC1PPVineWall01 => Construct(0x1659c);
            public static FormLink<ITreeGetter> DLC1PPVineCeiling01NoCol1 => Construct(0x1659b);
            public static FormLink<ITreeGetter> DLC1PPVineFloor01 => Construct(0x1659a);
            public static FormLink<ITreeGetter> DLC1PPVineFloor01NoCol1 => Construct(0x16599);
            public static FormLink<ITreeGetter> DLC1PPVineFloor02NoCol => Construct(0x16598);
            public static FormLink<ITreeGetter> TreeSoulCairnTreeGroup => Construct(0xddb5);
            public static FormLink<ITreeGetter> DLC1TreePineForestSnowHeavy02 => Construct(0xb55f);
            public static FormLink<ITreeGetter> DLC1FallenBranchSnowH01 => Construct(0xb55e);
            public static FormLink<ITreeGetter> DLC1BushDeadSnowH01 => Construct(0xb55d);
            public static FormLink<ITreeGetter> DLC01AncestorsGladeTree => Construct(0xb4ec);
            public static FormLink<ITreeGetter> DLC01Gleamblossom01old => Construct(0xa24d);
            public static FormLink<ITreeGetter> DLC1TreePineForestSnowHeavy01 => Construct(0x9670);
            public static FormLink<ITreeGetter> TreeSoulCairnShrub03 => Construct(0x3bdb);
            public static FormLink<ITreeGetter> TreeSoulCairnShrub02 => Construct(0x3bda);
            public static FormLink<ITreeGetter> TreeSoulCairnShrub01 => Construct(0x3bd9);
            public static FormLink<ITreeGetter> TreeWinterAspen06 => Construct(0x3acf);
            public static FormLink<ITreeGetter> TreeWinterAspen05 => Construct(0x3acc);
            public static FormLink<ITreeGetter> TreeWinterAspen04 => Construct(0x3acb);
            public static FormLink<ITreeGetter> TreeWinterAspen03 => Construct(0x3aca);
            public static FormLink<ITreeGetter> TreeWinterAspen02 => Construct(0x3ac9);
            public static FormLink<ITreeGetter> SnowGrassMound03 => Construct(0x3ac8);
            public static FormLink<ITreeGetter> SnowGrassMound02 => Construct(0x3ac7);
            public static FormLink<ITreeGetter> SnowGrassMound01 => Construct(0x3ac6);
            public static FormLink<ITreeGetter> TreeWinterAspen01 => Construct(0x3ac5);
            public static FormLink<ITreeGetter> TreeSoulCairnTree03 => Construct(0x4334);
            public static FormLink<ITreeGetter> TreeSoulCairnTree02 => Construct(0x4333);
            public static FormLink<ITreeGetter> TreeSoulCairnTree01 => Construct(0x4332);
            public static FormLink<ITreeGetter> TreeDeadVineLongAsh => Construct(0x4322);
            public static FormLink<ITreeGetter> TreeDeadVineHallwayAsh => Construct(0x4321);
            public static FormLink<ITreeGetter> TreeDeadVinePatchAsh => Construct(0x4320);
            public static FormLink<ITreeGetter> TreeDeadVinePatch => Construct(0x431f);
            public static FormLink<ITreeGetter> TreeDeadVineLong => Construct(0x431e);
            public static FormLink<ITreeGetter> TreeDeadVineHallway => Construct(0x431d);
            public static FormLink<ITreeGetter> TreeIceVinePatchSnow => Construct(0x42ea);
            public static FormLink<ITreeGetter> TreeIceVineLongSnow => Construct(0x42e9);
            public static FormLink<ITreeGetter> TreeIceVineHallwaySnow => Construct(0x42e8);
            public static FormLink<ITreeGetter> TreeIceVineHallway => Construct(0x42e3);
            public static FormLink<ITreeGetter> TreeIceVinePatch => Construct(0x42e2);
            public static FormLink<ITreeGetter> TreeIceVineLong => Construct(0x42e1);
        }
    }
}
