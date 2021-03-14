using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class FootstepSet
        {
            private static FormLink<IFootstepSetGetter> Construct(uint id) => new FormLink<IFootstepSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFootstepSetGetter> NPCDragonPaarthurnaxFootWalkFootstepSet => Construct(0x172ab);
            public static FormLink<IFootstepSetGetter> NPCFoxFootWalkFootstepSet => Construct(0x10f896);
            public static FormLink<IFootstepSetGetter> NPCWerewolfFootstepSet => Construct(0xf23e6);
            public static FormLink<IFootstepSetGetter> NPCHareFootWalkFootstepSet => Construct(0xd3ad8);
            public static FormLink<IFootstepSetGetter> NPCHagravenFootWalkFootstepSet => Construct(0xc0d36);
            public static FormLink<IFootstepSetGetter> NPCSkeletonFootWalkFootstepSet => Construct(0xbfb28);
            public static FormLink<IFootstepSetGetter> NPCHorkerFootFootstepSet => Construct(0x42abe);
            public static FormLink<IFootstepSetGetter> NPCWolfFootWalkFootstepSet => Construct(0xdce9d);
            public static FormLink<IFootstepSetGetter> NPCGoatFootFootstepSet => Construct(0x5e3d3);
            public static FormLink<IFootstepSetGetter> NPCSpiderFrostbiteGiantFootWalkFootstepSet => Construct(0x2e2f5);
            public static FormLink<IFootstepSetGetter> NPCMudcrabFootWalkFootstepSet => Construct(0xb97cc);
            public static FormLink<IFootstepSetGetter> NPCSprigganFootFootstepSet => Construct(0xa9208);
            public static FormLink<IFootstepSetGetter> NPCBearFootFootstepSet => Construct(0x8ad5a);
            public static FormLink<IFootstepSetGetter> NPCMammothFootFootstepSet => Construct(0x87597);
            public static FormLink<IFootstepSetGetter> NPCDwarvenCenturionFootWalkFootstepSet => Construct(0x86ef7);
            public static FormLink<IFootstepSetGetter> NPCDwarvenSpiderFootWalkFootstepSet => Construct(0x7a73f);
            public static FormLink<IFootstepSetGetter> NPCElkFootFootstepSet => Construct(0x78f17);
            public static FormLink<IFootstepSetGetter> NPCHorseFootFootstepSet => Construct(0x5f720);
            public static FormLink<IFootstepSetGetter> NPCCharusFootWalkFootstepSet => Construct(0x4401a);
            public static FormLink<IFootstepSetGetter> NPCFalmerFootWalkFootstepSet => Construct(0x4400b);
            public static FormLink<IFootstepSetGetter> NPCIceWraithFootWalkFootstepSet => Construct(0x5de22);
            public static FormLink<IFootstepSetGetter> NPCAtronachFrostFootFootstepSet => Construct(0x5dd87);
            public static FormLink<IFootstepSetGetter> NPCDogFootWalkFootstepSet => Construct(0x4e86e);
            public static FormLink<IFootstepSetGetter> NPCCowFootWalkFootstepSet => Construct(0x4e20f);
            public static FormLink<IFootstepSetGetter> NPCTrollFootWalkFootstepSet => Construct(0x17cb1);
            public static FormLink<IFootstepSetGetter> NPCSpiderFrostbiteFootWalkFootstepSet => Construct(0x15482);
            public static FormLink<IFootstepSetGetter> NPCGiantFootWalkFootstepSet => Construct(0x2ee32);
            public static FormLink<IFootstepSetGetter> NPCDragonFootWalkFootstepSet => Construct(0x1cb28);
            public static FormLink<IFootstepSetGetter> NPCDraugrFootWalkFootstepSet => Construct(0x1aebd);
            public static FormLink<IFootstepSetGetter> FSTArmorHeavyFootstepSet => Construct(0x21487);
            public static FormLink<IFootstepSetGetter> FSTArmorLightFootstepSet => Construct(0x21486);
            public static FormLink<IFootstepSetGetter> FSTBarefootFootstepSet => Construct(0x21468);
            public static FormLink<IFootstepSetGetter> NPCSabreCatFootWalkFootstepSet => Construct(0x1f26f);
            public static FormLink<IFootstepSetGetter> NPCSkeeverFootWalkFootstepSet => Construct(0x1f26b);
            public static FormLink<IFootstepSetGetter> DefaultFootstepSet => Construct(0x12f16);
        }
    }
}
