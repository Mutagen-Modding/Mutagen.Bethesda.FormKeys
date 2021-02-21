using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class ObjectEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IObjectEffectGetter> Construct(uint id) => new FormLink<IObjectEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IObjectEffectGetter> BYOHHousePart187ShrineBaseEnch => Construct(0xf3cf);
            public static FormLink<IObjectEffectGetter> BYOHHousePartEnchantingTableEnch => Construct(0xf3c0);
            public static FormLink<IObjectEffectGetter> BYOHHousePart068Room11Ench => Construct(0x7ad6);
            public static FormLink<IObjectEffectGetter> BYOHHousePart067Room10Ench => Construct(0x7ad5);
            public static FormLink<IObjectEffectGetter> BYOHHousePart066Room9Ench => Construct(0x7ad4);
            public static FormLink<IObjectEffectGetter> BYOHHousePart065Room8Ench => Construct(0x7ad3);
            public static FormLink<IObjectEffectGetter> BYOHHousePart064Room7Ench => Construct(0x7ad2);
            public static FormLink<IObjectEffectGetter> BYOHHousePart063Room6Ench => Construct(0x7ad1);
            public static FormLink<IObjectEffectGetter> BYOHHousePart062Room5Ench => Construct(0x7ad0);
            public static FormLink<IObjectEffectGetter> BYOHHousePart061Room4Ench => Construct(0x7acf);
            public static FormLink<IObjectEffectGetter> BYOHHousePart060Room3Ench => Construct(0x7ace);
            public static FormLink<IObjectEffectGetter> BYOHHousePart190CellarEnch => Construct(0x7ac4);
            public static FormLink<IObjectEffectGetter> BYOHHousePart219Room12WorkbenchEnch => Construct(0x7ac2);
            public static FormLink<IObjectEffectGetter> BYOHHousePart218Room12WorkbenchEnch => Construct(0x7ac1);
            public static FormLink<IObjectEffectGetter> BYOHHousePart217Room11WorkbenchEnch => Construct(0x7ac0);
            public static FormLink<IObjectEffectGetter> BYOHHousePart216Room11WorkbenchEnch => Construct(0x7abf);
            public static FormLink<IObjectEffectGetter> BYOHHousePart215Room10WorkbenchEnch => Construct(0x7abe);
            public static FormLink<IObjectEffectGetter> BYOHHousePart214Room10WorkbenchEnch => Construct(0x7abd);
            public static FormLink<IObjectEffectGetter> BYOHHousePart213Room9WorkbenchEnch => Construct(0x7abc);
            public static FormLink<IObjectEffectGetter> BYOHHousePart212Room9WorkbenchEnch => Construct(0x7abb);
            public static FormLink<IObjectEffectGetter> BYOHHousePart211Room8WorkbenchEnch => Construct(0x7aba);
            public static FormLink<IObjectEffectGetter> BYOHHousePart210Room8WorkbenchEnch => Construct(0x7ab9);
            public static FormLink<IObjectEffectGetter> BYOHHousePart209Room7WorkbenchEnch => Construct(0x7ab8);
            public static FormLink<IObjectEffectGetter> BYOHHousePart208Room7WorkbenchEnch => Construct(0x7ab7);
            public static FormLink<IObjectEffectGetter> BYOHHousePart207Room6WorkbenchEnch => Construct(0x7ab6);
            public static FormLink<IObjectEffectGetter> BYOHHousePart206Room6WorkbenchEnch => Construct(0x7ab5);
            public static FormLink<IObjectEffectGetter> BYOHHousePart205Room5WorkbenchEnch => Construct(0x7ab4);
            public static FormLink<IObjectEffectGetter> BYOHHousePart204Room5WorkbenchEnch => Construct(0x7ab3);
            public static FormLink<IObjectEffectGetter> BYOHHousePart203Room4WorkbenchEnch => Construct(0x7ab2);
            public static FormLink<IObjectEffectGetter> BYOHHousePart202Room4WorkbenchEnch => Construct(0x7ab1);
            public static FormLink<IObjectEffectGetter> BYOHHousePart201Room3WorkbenchEnch => Construct(0x7ab0);
            public static FormLink<IObjectEffectGetter> BYOHHousePart200Room3WorkbenchEnch => Construct(0x7aaf);
            public static FormLink<IObjectEffectGetter> BYOHHousePart035Room1BWorkbenchEnch => Construct(0x7aae);
            public static FormLink<IObjectEffectGetter> BYOHHousePart034Room1BWorkbenchEnch => Construct(0x7aad);
            public static FormLink<IObjectEffectGetter> BYOHHousePart033Room2WorkbenchEnch => Construct(0x7aac);
            public static FormLink<IObjectEffectGetter> BYOHHousePart032Room2WorkbenchEnch => Construct(0x7aab);
            public static FormLink<IObjectEffectGetter> BYOHHousePart031Room1WorkbenchEnch => Construct(0x7aaa);
            public static FormLink<IObjectEffectGetter> BYOHHousePart030Room1WorkbenchEnch => Construct(0x7aa9);
            public static FormLink<IObjectEffectGetter> BYOHHousePartRoom1RemodelAEnch => Construct(0x3126);
            public static FormLink<IObjectEffectGetter> BYOHHousePart012Room2LayoutCEnch => Construct(0x30a9);
            public static FormLink<IObjectEffectGetter> BYOHHousePart011Room2LayoutBEnch => Construct(0x30a8);
            public static FormLink<IObjectEffectGetter> BYOHHousePart010Room2LayoutAEnch => Construct(0x30a4);
            public static FormLink<IObjectEffectGetter> BYOHHousePart001Room1LayoutEnch => Construct(0x30a3);
        }
    }
}
