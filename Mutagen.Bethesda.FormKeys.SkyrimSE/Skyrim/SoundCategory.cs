namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class SoundCategory
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey AudioCategoryFSTnpc => ModKey.MakeFormKey(0xf72);
            public static FormKey AudioCategorySFXFadeDuringDialogue => ModKey.MakeFormKey(0xe9e);
            public static FormKey AudioCategorySFX => ModKey.MakeFormKey(0x172a1);
            public static FormKey AudioCategoryPausedDuringMenuLoad => ModKey.MakeFormKey(0x10aa60);
            public static FormKey AudioCategoryFST => ModKey.MakeFormKey(0xf5ffc);
            public static FormKey AudioCategoryMuteSubmerged => ModKey.MakeFormKey(0xf23bb);
            public static FormKey __AudioCategoryMaster => ModKey.MakeFormKey(0xeb803);
            public static FormKey AudioCategoryNPCKillMove => ModKey.MakeFormKey(0xea51f);
            public static FormKey AudioCategoryPausedDuringMenu => ModKey.MakeFormKey(0xdddc5);
            public static FormKey AudioCategoryMAG => ModKey.MakeFormKey(0x1a0bd);
            public static FormKey AudioCategoryPausedDuringMenuFade => ModKey.MakeFormKey(0x9f254);
            public static FormKey AudioCategoryVOCGeneral => ModKey.MakeFormKey(0x876bd);
            public static FormKey AudioCategoryNonVOC => ModKey.MakeFormKey(0x876bc);
            public static FormKey AudioCategoryVOC => ModKey.MakeFormKey(0x876bb);
            public static FormKey AudioCategoryAMB => ModKey.MakeFormKey(0x7f80b);
            public static FormKey AudioCategoryMUS => ModKey.MakeFormKey(0x71e64);
            public static FormKey AudioCategoryAMBr => ModKey.MakeFormKey(0x71e63);
            public static FormKey AudioCategoryUI => ModKey.MakeFormKey(0x64451);
        }
    }
}
