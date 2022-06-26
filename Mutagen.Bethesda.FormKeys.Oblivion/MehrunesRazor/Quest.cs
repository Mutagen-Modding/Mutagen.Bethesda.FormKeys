// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class MehrunesRazor
{
    public static class Quest
    {
        private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IQuestGetter> DL9MehrunesQuest => Construct(0xed9);
    }
}
