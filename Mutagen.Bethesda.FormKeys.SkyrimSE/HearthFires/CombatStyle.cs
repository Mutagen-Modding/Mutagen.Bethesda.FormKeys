using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class CombatStyle
        {
            private static FormLink<ICombatStyleGetter> Construct(uint id) => new FormLink<ICombatStyleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICombatStyleGetter> csAdoptedChildren => Construct(0x7b73);
        }
    }
}
