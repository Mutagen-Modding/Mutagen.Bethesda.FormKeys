namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey DLCDeepscornScript => ModKey.MakeFormKey(0x46ab);
            public static FormKey LairVilePoolofPurificationSCRIPT => ModKey.MakeFormKey(0x1375);
            public static FormKey DeepscornHollowJournalScript => ModKey.MakeFormKey(0x65ac);
            public static FormKey LairVileShrineBlessingSCRIPT => ModKey.MakeFormKey(0x137a);
            public static FormKey LairVileMinionScript => ModKey.MakeFormKey(0x7977);
            public static FormKey LairVileChokeberryEffectScript => ModKey.MakeFormKey(0x9c02);
            public static FormKey LairVilePrisonerScript => ModKey.MakeFormKey(0xa0e9);
            public static FormKey LairVileExitLadderScript => ModKey.MakeFormKey(0x120c1);
        }
    }
}
