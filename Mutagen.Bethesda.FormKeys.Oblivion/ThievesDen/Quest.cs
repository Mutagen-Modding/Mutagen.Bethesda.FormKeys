// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class ThievesDen
{
    public static partial class Quest
    {
        private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IQuestGetter> DLC06ThievesDen => Construct(0x3e84);
    }
}
