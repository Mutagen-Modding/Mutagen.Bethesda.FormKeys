using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Keyword
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IKeywordGetter> Construct(uint id) => new FormLink<IKeywordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse07_FollowfromWait => Construct(0x3099);
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse06_Wait => Construct(0x3098);
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse05_FollowfromDismissed => Construct(0x3097);
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse04_Trade => Construct(0x3096);
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse03_GoHome => Construct(0x3095);
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse02_Wait => Construct(0x3094);
            public static FormLink<IKeywordGetter> ccBGS_ActorTypeCustomPetResponse01_Stay => Construct(0x3093);
            public static FormLink<IKeywordGetter> CommandedVoiceExcluded => Construct(0x3054);
            public static FormLink<IKeywordGetter> ccDisallowSaddleSwap => Construct(0x2f95);
            public static FormLink<IKeywordGetter> Survival_LocTypeFreeShrineUse => Construct(0x2edc);
            public static FormLink<IKeywordGetter> Survival_BodyAndHead => Construct(0x2edb);
            public static FormLink<IKeywordGetter> MagicFlameCloak => Construct(0x2eda);
            public static FormLink<IKeywordGetter> Survival_ArmorWarm => Construct(0x2ed9);
            public static FormLink<IKeywordGetter> Survival_ArmorCold => Construct(0x2ed8);
            public static FormLink<IKeywordGetter> ArmorMaterialBlades => Construct(0x9c0);
            public static FormLink<IKeywordGetter> ArmorMaterialThievesGuildLeader => Construct(0x9bf);
            public static FormLink<IKeywordGetter> ArmorMaterialBearStormcloak => Construct(0x9be);
            public static FormLink<IKeywordGetter> ArmorMaterialFalmer => Construct(0x9bd);
            public static FormLink<IKeywordGetter> ArmorMaterialThievesGuild => Construct(0x9bc);
            public static FormLink<IKeywordGetter> ArmorMaterialPenitus => Construct(0x9bb);
            public static FormLink<IKeywordGetter> ArmorMaterialMS02Forsworn => Construct(0x9ba);
            public static FormLink<IKeywordGetter> ArmorMaterialForsworn => Construct(0x9b9);
            public static FormLink<IKeywordGetter> ImmuneDragonPairedKill => Construct(0x9a2);
            public static FormLink<IKeywordGetter> WEDL06Letrush => Construct(0x99f);
            public static FormLink<IKeywordGetter> DA15WabbajackExcludedKeyword => Construct(0x997);
        }
    }
}
