using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class PlacedCreature
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IPlacedCreatureGetter> Construct(uint id) => new FormLink<IPlacedCreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedCreatureGetter> ND08Wraith1REF => Construct(0x120e);
            public static FormLink<IPlacedCreatureGetter> ND08Wraith2REF => Construct(0x1208);
            public static FormLink<IPlacedCreatureGetter> ND08Wraith3REF => Construct(0x1207);
            public static FormLink<IPlacedCreatureGetter> ND08Wraith4REF => Construct(0x1206);
            public static FormLink<IPlacedCreatureGetter> ND08Wraith5REF => Construct(0x1205);
            public static FormLink<IPlacedCreatureGetter> ND08Level2AuroranRef1 => Construct(0x1429);
            public static FormLink<IPlacedCreatureGetter> ND08Level1AuroranRef1 => Construct(0x1428);
            public static FormLink<IPlacedCreatureGetter> ND08Level1AuroranRef2 => Construct(0x1427);
            public static FormLink<IPlacedCreatureGetter> ND08Level1AuroranRef3 => Construct(0x1426);
            public static FormLink<IPlacedCreatureGetter> ND08Level2AuroranRef3 => Construct(0x1425);
            public static FormLink<IPlacedCreatureGetter> ND08Level3AuroranRef3 => Construct(0x1424);
            public static FormLink<IPlacedCreatureGetter> ND08Level4AuroranRef3 => Construct(0x1423);
            public static FormLink<IPlacedCreatureGetter> ND08Level5AuroranRef3 => Construct(0x1422);
            public static FormLink<IPlacedCreatureGetter> ND08Level3AuroranRef1 => Construct(0x1421);
            public static FormLink<IPlacedCreatureGetter> ND08Level4AuroranRef1 => Construct(0x1420);
            public static FormLink<IPlacedCreatureGetter> ND08Level5AuroranRef1 => Construct(0x141f);
            public static FormLink<IPlacedCreatureGetter> ND08Level2AuroranRef2 => Construct(0x141e);
            public static FormLink<IPlacedCreatureGetter> ND08Level3AuroranRef2 => Construct(0x141d);
            public static FormLink<IPlacedCreatureGetter> ND08Level4AuroranRef2 => Construct(0x141c);
            public static FormLink<IPlacedCreatureGetter> ND08Level5AuroranRef2 => Construct(0x141b);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranPlayerAttackRef => Construct(0x16f2);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL1Ref1 => Construct(0x16f1);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL2Ref1 => Construct(0x16f0);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL3Ref1 => Construct(0x16ef);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL4Ref1 => Construct(0x16ee);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL5Ref1 => Construct(0x16ed);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL1Ref2 => Construct(0x16ec);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL2Ref2 => Construct(0x16eb);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL3Ref2 => Construct(0x16ea);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL4Ref2 => Construct(0x16e9);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL5Ref2 => Construct(0x16e8);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL1Ref3 => Construct(0x16e7);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL2Ref3 => Construct(0x16e6);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL3Ref3 => Construct(0x16e5);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL4Ref3 => Construct(0x16e4);
            public static FormLink<IPlacedCreatureGetter> ND04AuroranL5Ref3 => Construct(0x16e3);
            public static FormLink<IPlacedCreatureGetter> ND03BearRef => Construct(0x2695);
            public static FormLink<IPlacedCreatureGetter> NDSirRodericsHorseREF => Construct(0x2694);
            public static FormLink<IPlacedCreatureGetter> NDLathonsHorseREF => Construct(0x2693);
            public static FormLink<IPlacedCreatureGetter> NDGukimirsHorseREF => Construct(0x267a);
            public static FormLink<IPlacedCreatureGetter> NDGeimundsHorseRef => Construct(0x2677);
        }
    }
}
