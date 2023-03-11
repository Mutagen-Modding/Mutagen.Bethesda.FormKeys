// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static class Spell
    {
        private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISpellGetter> DLC05RadStormFastTransitionSpell => Construct(0xf2b);
    }
}