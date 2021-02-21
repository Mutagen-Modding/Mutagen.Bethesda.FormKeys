using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Subspace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<ISubspaceGetter> Construct(uint id) => new FormLink<ISubspaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISubspaceGetter> SubSpace800x500x200 => Construct(0x8e83f);
            public static FormLink<ISubspaceGetter> SubSpace800x600x200 => Construct(0x8e82a);
            public static FormLink<ISubspaceGetter> SECrucible900x300x300 => Construct(0x698d4);
            public static FormLink<ISubspaceGetter> SECrucible600x350x300 => Construct(0x698d3);
            public static FormLink<ISubspaceGetter> SEBliss750x200x250 => Construct(0x698c5);
            public static FormLink<ISubspaceGetter> SEBliss2400x3000x384 => Construct(0x698c2);
            public static FormLink<ISubspaceGetter> SubSpace1000x1000x1000 => Construct(0x59b56);
            public static FormLink<ISubspaceGetter> SubSpaceSmallDoor => Construct(0x9652);
            public static FormLink<ISubspaceGetter> SubSpaceMq14OblivionSpace => Construct(0xc449);
            public static FormLink<ISubspaceGetter> SubSpace700x200x250 => Construct(0xab16);
            public static FormLink<ISubspaceGetter> SubSpace1100x200x250 => Construct(0xab12);
            public static FormLink<ISubspaceGetter> SubSpace250x250x500 => Construct(0x9a9c);
            public static FormLink<ISubspaceGetter> SubSpace300x300x100 => Construct(0x54ed);
            public static FormLink<ISubspaceGetter> SubSpace200x200x50 => Construct(0x54ea);
            public static FormLink<ISubspaceGetter> SubSpace1000x1000x1500 => Construct(0x54e2);
            public static FormLink<ISubspaceGetter> SubSpace15000x11000x2000 => Construct(0xc792d);
            public static FormLink<ISubspaceGetter> SubSpace1500x1500x300 => Construct(0x8b6dc);
            public static FormLink<ISubspaceGetter> SubSpace1000x1000x300 => Construct(0x6dc50);
            public static FormLink<ISubspaceGetter> SubSpace1000x2000x500 => Construct(0x6dc4e);
            public static FormLink<ISubspaceGetter> SeigePath => Construct(0x18ad7a);
            public static FormLink<ISubspaceGetter> SubSpace1700x600x600 => Construct(0x86de6);
            public static FormLink<ISubspaceGetter> SubSpace600x600x600 => Construct(0x86de4);
            public static FormLink<ISubspaceGetter> SubSpace300x600x100 => Construct(0x9c25a);
            public static FormLink<ISubspaceGetter> SubSpace400x400x400 => Construct(0x93f0b);
            public static FormLink<ISubspaceGetter> SubSpace4500x350x200 => Construct(0x92aa8);
            public static FormLink<ISubspaceGetter> SubSpace400x200x200 => Construct(0x90c4d);
            public static FormLink<ISubspaceGetter> SubSpace750x500x200 => Construct(0x90c4a);
            public static FormLink<ISubspaceGetter> SubSpace1700x300x250 => Construct(0x90747);
            public static FormLink<ISubspaceGetter> SubSpace400x100x200 => Construct(0x8305d);
            public static FormLink<ISubspaceGetter> SubSpace400x400x100 => Construct(0x4f615);
            public static FormLink<ISubspaceGetter> SubSpace400x200x100 => Construct(0x3e919);
            public static FormLink<ISubspaceGetter> SubSpace400x100x100 => Construct(0x3e918);
            public static FormLink<ISubspaceGetter> SubSpace200x200x100 => Construct(0x3e917);
        }
    }
}
