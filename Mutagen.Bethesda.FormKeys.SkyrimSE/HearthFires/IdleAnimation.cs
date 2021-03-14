using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class IdleAnimation
        {
            private static FormLink<IIdleAnimationGetter> Construct(uint id) => new FormLink<IIdleAnimationGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleAnimationGetter> IdleChildCryingEnd => Construct(0x18300);
            public static FormLink<IIdleAnimationGetter> IdleChildCryingStart => Construct(0x182ff);
            public static FormLink<IIdleAnimationGetter> IdleHammerCarpenterTableExit => Construct(0x14357);
            public static FormLink<IIdleAnimationGetter> IdleHammerCarpenterTableEnter => Construct(0x14356);
            public static FormLink<IIdleAnimationGetter> IdleHammerCarpenterTableEnterInstant => Construct(0x14355);
            public static FormLink<IIdleAnimationGetter> HammerCarpenterTableRoot => Construct(0x14354);
            public static FormLink<IIdleAnimationGetter> ChildSitOnKnees => Construct(0xed58);
            public static FormLink<IIdleAnimationGetter> ChildSitOnKneesEnterInstant => Construct(0xed57);
            public static FormLink<IIdleAnimationGetter> ChildSitOnKneesEnter => Construct(0xed56);
            public static FormLink<IIdleAnimationGetter> ChildSitOnKneesExit => Construct(0xed55);
            public static FormLink<IIdleAnimationGetter> ChildLayOnFloor => Construct(0xed54);
            public static FormLink<IIdleAnimationGetter> ChildLayOnFloorEnterInstant => Construct(0xed53);
            public static FormLink<IIdleAnimationGetter> ChildLayOnFloorEnter => Construct(0xed52);
            public static FormLink<IIdleAnimationGetter> ChildLayOnFloorExit => Construct(0xed51);
            public static FormLink<IIdleAnimationGetter> ChildSittingIdleRoot => Construct(0xed50);
            public static FormLink<IIdleAnimationGetter> IdleChildLegsOut => Construct(0xed4f);
            public static FormLink<IIdleAnimationGetter> IdleChildPlayDoll => Construct(0xba60);
            public static FormLink<IIdleAnimationGetter> IdleChildPlayDirt => Construct(0xba5e);
            public static FormLink<IIdleAnimationGetter> IdleChildFidget => Construct(0xba5d);
            public static FormLink<IIdleAnimationGetter> IdleChildWhineKick => Construct(0xba5c);
            public static FormLink<IIdleAnimationGetter> IdleChildWhineStomp => Construct(0xba5b);
            public static FormLink<IIdleAnimationGetter> IdleChildApologize => Construct(0xba5a);
            public static FormLink<IIdleAnimationGetter> IdleChildTaunt4 => Construct(0xba59);
            public static FormLink<IIdleAnimationGetter> IdleChildTaunt3 => Construct(0xba58);
            public static FormLink<IIdleAnimationGetter> IdleChildTaunt2 => Construct(0xba57);
            public static FormLink<IIdleAnimationGetter> IdleChildTaunt1 => Construct(0xba56);
            public static FormLink<IIdleAnimationGetter> IdleChildShy => Construct(0xba55);
            public static FormLink<IIdleAnimationGetter> IdleOvenExit => Construct(0x2847);
            public static FormLink<IIdleAnimationGetter> IdleOvenEnter => Construct(0x2846);
            public static FormLink<IIdleAnimationGetter> IdleOvenEnterInstant => Construct(0x2845);
            public static FormLink<IIdleAnimationGetter> CraftingOven => Construct(0x2844);
        }
    }
}
