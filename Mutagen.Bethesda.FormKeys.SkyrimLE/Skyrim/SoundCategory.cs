using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class SoundCategory
        {
            private static FormLink<ISoundCategoryGetter> Construct(uint id) => new FormLink<ISoundCategoryGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundCategoryGetter> AudioCategoryFSTnpc => Construct(0xf72);
            public static FormLink<ISoundCategoryGetter> AudioCategorySFXFadeDuringDialogue => Construct(0xe9e);
            public static FormLink<ISoundCategoryGetter> AudioCategorySFX => Construct(0x172a1);
            public static FormLink<ISoundCategoryGetter> AudioCategoryPausedDuringMenuLoad => Construct(0x10aa60);
            public static FormLink<ISoundCategoryGetter> AudioCategoryFST => Construct(0xf5ffc);
            public static FormLink<ISoundCategoryGetter> AudioCategoryMuteSubmerged => Construct(0xf23bb);
            public static FormLink<ISoundCategoryGetter> __AudioCategoryMaster => Construct(0xeb803);
            public static FormLink<ISoundCategoryGetter> AudioCategoryNPCKillMove => Construct(0xea51f);
            public static FormLink<ISoundCategoryGetter> AudioCategoryPausedDuringMenu => Construct(0xdddc5);
            public static FormLink<ISoundCategoryGetter> AudioCategoryMAG => Construct(0x1a0bd);
            public static FormLink<ISoundCategoryGetter> AudioCategoryPausedDuringMenuFade => Construct(0x9f254);
            public static FormLink<ISoundCategoryGetter> AudioCategoryVOCGeneral => Construct(0x876bd);
            public static FormLink<ISoundCategoryGetter> AudioCategoryNonVOC => Construct(0x876bc);
            public static FormLink<ISoundCategoryGetter> AudioCategoryVOC => Construct(0x876bb);
            public static FormLink<ISoundCategoryGetter> AudioCategoryAMB => Construct(0x7f80b);
            public static FormLink<ISoundCategoryGetter> AudioCategoryMUS => Construct(0x71e64);
            public static FormLink<ISoundCategoryGetter> AudioCategoryAMBr => Construct(0x71e63);
            public static FormLink<ISoundCategoryGetter> AudioCategoryUI => Construct(0x64451);
        }
    }
}
