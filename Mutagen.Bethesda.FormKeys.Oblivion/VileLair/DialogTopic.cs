using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class DialogTopic
        {
            private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogTopicGetter> DeepscornSlay => Construct(0x7973);
            public static FormLink<IDialogTopicGetter> DeepscornDone => Construct(0x7975);
            public static FormLink<IDialogTopicGetter> DeepscornNm => Construct(0xefc1);
        }
    }
}
