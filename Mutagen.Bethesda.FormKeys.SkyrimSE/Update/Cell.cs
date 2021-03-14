using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Cell
        {
            private static FormLink<ICellGetter> Construct(uint id) => new FormLink<ICellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICellGetter> ccPlaceholder02Interior01 => Construct(0x2fd0);
            public static FormLink<ICellGetter> ccPlaceholder03Interior01 => Construct(0x2fd1);
            public static FormLink<ICellGetter> ccPlaceholder04Interior01 => Construct(0x2fd2);
            public static FormLink<ICellGetter> ccPlaceholder05Interior01 => Construct(0x2fd3);
            public static FormLink<ICellGetter> ccPlaceholder06Interior01 => Construct(0x2fd4);
            public static FormLink<ICellGetter> ccEEJSSE003_Interior01 => Construct(0x2f98);
            public static FormLink<ICellGetter> ccPlaceholder07Interior01 => Construct(0x2fd5);
            public static FormLink<ICellGetter> ccMDRSSE001_Interior01 => Construct(0x2f99);
            public static FormLink<ICellGetter> ccPlaceholder08Interior01 => Construct(0x2fd6);
            public static FormLink<ICellGetter> ccBGSSSE016Interior02 => Construct(0x2f9a);
            public static FormLink<ICellGetter> ccPlaceholder09Interior01 => Construct(0x2fd7);
            public static FormLink<ICellGetter> ccBGSSSE016Interior01 => Construct(0x2f9b);
            public static FormLink<ICellGetter> ccPlaceholder10Interior01 => Construct(0x2fd8);
            public static FormLink<ICellGetter> ccBGSSSE043_Interior01 => Construct(0x2f9c);
            public static FormLink<ICellGetter> ccPlaceholder01Interior01 => Construct(0x2fcf);
            public static FormLink<ICellGetter> ccEEJSSE004_Interior01 => Construct(0x2fd9);
            public static FormLink<ICellGetter> Snow => Construct(0x297c);
        }
    }
}
