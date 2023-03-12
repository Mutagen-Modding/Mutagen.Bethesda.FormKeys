using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Oblivion
{
    public static partial class Spell
    {
        public static FormLink<ISpellGetter> DefaultMarksmanParalyzeSpell => Construct(0x137);
    }
}