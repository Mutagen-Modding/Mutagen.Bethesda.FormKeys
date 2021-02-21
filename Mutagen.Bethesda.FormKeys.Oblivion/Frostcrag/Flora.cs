using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFloraGetter> HarradaUpRightAttackPLANTDomesticated => Construct(0x8525);
            public static FormLink<IFloraGetter> SpiddalStickPLANTDomesticated => Construct(0x8518);
            public static FormLink<IFloraGetter> HarradaGroundAttackPLANTDomesticated => Construct(0x8520);
        }
    }
}
