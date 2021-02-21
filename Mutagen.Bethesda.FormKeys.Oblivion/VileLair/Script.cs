using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IScriptGetter> Construct(uint id) => new FormLink<IScriptGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScriptGetter> DLCDeepscornScript => Construct(0x46ab);
            public static FormLink<IScriptGetter> LairVilePoolofPurificationSCRIPT => Construct(0x1375);
            public static FormLink<IScriptGetter> DeepscornHollowJournalScript => Construct(0x65ac);
            public static FormLink<IScriptGetter> LairVileShrineBlessingSCRIPT => Construct(0x137a);
            public static FormLink<IScriptGetter> LairVileMinionScript => Construct(0x7977);
            public static FormLink<IScriptGetter> LairVileChokeberryEffectScript => Construct(0x9c02);
            public static FormLink<IScriptGetter> LairVilePrisonerScript => Construct(0xa0e9);
            public static FormLink<IScriptGetter> LairVileExitLadderScript => Construct(0x120c1);
        }
    }
}
