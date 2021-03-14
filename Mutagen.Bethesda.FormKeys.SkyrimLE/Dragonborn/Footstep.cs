using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Footstep
        {
            private static FormLink<IFootstepGetter> Construct(uint id) => new FormLink<IFootstepGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFootstepGetter> FSTSprintArmorSkaalRFootstep => Construct(0x3d376);
            public static FormLink<IFootstepGetter> FSTSprintArmorSkaalLFootstep => Construct(0x3d375);
            public static FormLink<IFootstepGetter> NPCDwarvenBallistaFootWalkRFootstep => Construct(0x3cf91);
            public static FormLink<IFootstepGetter> NPCDwarvenBallistaFootWalkLFootstep => Construct(0x3cf90);
            public static FormLink<IFootstepGetter> NPCRieklingBristlebackAttackStandingFootstep => Construct(0x337e1);
            public static FormLink<IFootstepGetter> NPCRieklingFootWalkRFootstep => Construct(0x28b90);
            public static FormLink<IFootstepGetter> NPCRieklingFootRunRFootstep => Construct(0x28b8f);
            public static FormLink<IFootstepGetter> NPCRieklingFootRunLFootstep => Construct(0x28b8e);
            public static FormLink<IFootstepGetter> NPCRieklingFootWalkLFootstep => Construct(0x28b8d);
            public static FormLink<IFootstepGetter> NPCSpiderHandFootWalkRFootstep => Construct(0x28b5e);
            public static FormLink<IFootstepGetter> NPCSpiderHandFootWalkLFootstep => Construct(0x28b5d);
            public static FormLink<IFootstepGetter> NPCNetchFootFootstep => Construct(0x2858f);
            public static FormLink<IFootstepGetter> NPCBristlebackFootRunBackFootstep => Construct(0x25c72);
            public static FormLink<IFootstepGetter> NPCBristlebackFootRunFrontFootstep => Construct(0x25c6e);
            public static FormLink<IFootstepGetter> NPCBristlebackFootWalkFrontFootstep => Construct(0x25c68);
            public static FormLink<IFootstepGetter> NPCBristlebackFootWalkBackFootstep => Construct(0x25c67);
            public static FormLink<IFootstepGetter> NPCAshGhoulFootWalkRFootstep => Construct(0x23f90);
            public static FormLink<IFootstepGetter> NPCAshGhoulFootWalkLFootstep => Construct(0x23f8f);
            public static FormLink<IFootstepGetter> NPCScribFootWalkRFootstep => Construct(0x1f175);
            public static FormLink<IFootstepGetter> NPCScribFootWalkLFootstep => Construct(0x1f174);
            public static FormLink<IFootstepGetter> NPCFishmanFootWalkRFootstep => Construct(0x1f14b);
            public static FormLink<IFootstepGetter> NPCFishmanFootWalkLFootstep => Construct(0x1f14a);
        }
    }
}
