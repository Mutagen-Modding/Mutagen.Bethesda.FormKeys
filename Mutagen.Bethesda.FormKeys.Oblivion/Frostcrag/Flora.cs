namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey HarradaUpRightAttackPLANTDomesticated => ModKey.MakeFormKey(0x8525);
            public static FormKey SpiddalStickPLANTDomesticated => ModKey.MakeFormKey(0x8518);
            public static FormKey HarradaGroundAttackPLANTDomesticated => ModKey.MakeFormKey(0x8520);
        }
    }
}
