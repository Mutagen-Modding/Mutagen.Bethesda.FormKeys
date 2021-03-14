using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class IdleAnimation
        {
            private static FormLink<IIdleAnimationGetter> Construct(uint id) => new FormLink<IIdleAnimationGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleAnimationGetter> MC_NoForceEquip => Construct(0x996);
            public static FormLink<IIdleAnimationGetter> Mounted_NoDraw => Construct(0x995);
            public static FormLink<IIdleAnimationGetter> RightPowerAttack => Construct(0x994);
            public static FormLink<IIdleAnimationGetter> NonMountedForceEquip => Construct(0x993);
            public static FormLink<IIdleAnimationGetter> NonMountedDraw => Construct(0x992);
            public static FormLink<IIdleAnimationGetter> NonMountedCombatRightPower => Construct(0x991);
            public static FormLink<IIdleAnimationGetter> NonMountedCombatRight => Construct(0x990);
            public static FormLink<IIdleAnimationGetter> NonMountedCombatLeftPower => Construct(0x98f);
            public static FormLink<IIdleAnimationGetter> NonMountedCombatLeft => Construct(0x98e);
            public static FormLink<IIdleAnimationGetter> MountedForceEquip => Construct(0x98d);
            public static FormLink<IIdleAnimationGetter> MountedDrawWeapon => Construct(0x98c);
            public static FormLink<IIdleAnimationGetter> MountedDraw => Construct(0x98b);
            public static FormLink<IIdleAnimationGetter> MountedCombatRightPower => Construct(0x98a);
            public static FormLink<IIdleAnimationGetter> MountedCombatRight => Construct(0x989);
            public static FormLink<IIdleAnimationGetter> MountedCombatLeftPower => Construct(0x988);
            public static FormLink<IIdleAnimationGetter> MountedCombatLeft => Construct(0x987);
            public static FormLink<IIdleAnimationGetter> MountedBowZoom => Construct(0x986);
            public static FormLink<IIdleAnimationGetter> MC_WeaponRightHandEquip => Construct(0x985);
            public static FormLink<IIdleAnimationGetter> LeftPowerAttack => Construct(0x984);
            public static FormLink<IIdleAnimationGetter> LeftAttackRelease => Construct(0x983);
            public static FormLink<IIdleAnimationGetter> BowAttackRight => Construct(0x982);
            public static FormLink<IIdleAnimationGetter> AttackRightSide => Construct(0x981);
            public static FormLink<IIdleAnimationGetter> AttackLeftSide => Construct(0x980);
            public static FormLink<IIdleAnimationGetter> MC_ForceSheathe => Construct(0x952);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveShieldBashAttack00 => Construct(0x83d);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveStabUpFace00 => Construct(0x83c);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveStabDownChest00 => Construct(0x83b);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveRepeatStabDowns00 => Construct(0x83a);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveGrappleStab00 => Construct(0x839);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveShieldBashAttack => Construct(0x838);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveStabUpFace => Construct(0x837);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveStabDownChest => Construct(0x836);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveRepeatStabDowns => Construct(0x835);
            public static FormLink<IIdleAnimationGetter> _1HMKillMoveGrappleStab => Construct(0x834);
            public static FormLink<IIdleAnimationGetter> KillMoveShieldBashSlash00 => Construct(0x833);
            public static FormLink<IIdleAnimationGetter> KillMoveShieldBashSlash => Construct(0x832);
            public static FormLink<IIdleAnimationGetter> KillMoveDualWieldDualSlashCOPY0000 => Construct(0x831);
            public static FormLink<IIdleAnimationGetter> KillMoveDualWieldXSlashCOPY0000 => Construct(0x830);
            public static FormLink<IIdleAnimationGetter> KillMoveDualWieldXSlash => Construct(0x82f);
            public static FormLink<IIdleAnimationGetter> KillMoveDualWieldDualSlash => Construct(0x82e);
            public static FormLink<IIdleAnimationGetter> KillMove2HMSlash00 => Construct(0x82d);
            public static FormLink<IIdleAnimationGetter> KillMove2HM3Slash00 => Construct(0x82c);
            public static FormLink<IIdleAnimationGetter> KillMove2HMUnderSwingLeg00 => Construct(0x82b);
            public static FormLink<IIdleAnimationGetter> KillMove2HMUnderSwingLeg => Construct(0x82a);
            public static FormLink<IIdleAnimationGetter> KillMove2HMSlash => Construct(0x829);
            public static FormLink<IIdleAnimationGetter> KillMove2HM3Slash => Construct(0x828);
            public static FormLink<IIdleAnimationGetter> KillMove2HWChopKick00 => Construct(0x827);
            public static FormLink<IIdleAnimationGetter> KillMove2HWHeadButt00 => Construct(0x826);
            public static FormLink<IIdleAnimationGetter> KillMove2HWHeadButt => Construct(0x825);
            public static FormLink<IIdleAnimationGetter> KillMove2HWChopKick => Construct(0x824);
            public static FormLink<IIdleAnimationGetter> H2HKillMoveKneeThrow00 => Construct(0x823);
            public static FormLink<IIdleAnimationGetter> H2HKillMoveBodySlam00 => Construct(0x822);
            public static FormLink<IIdleAnimationGetter> H2HKillMoveKneeThrow => Construct(0x821);
            public static FormLink<IIdleAnimationGetter> H2HKillMoveBodySlam => Construct(0x820);
            public static FormLink<IIdleAnimationGetter> KillMove2HMStabFromBehind00 => Construct(0x81f);
            public static FormLink<IIdleAnimationGetter> KillMove2HMStabFromBehind => Construct(0x81e);
            public static FormLink<IIdleAnimationGetter> KillMove2HWHackFromBehind => Construct(0x81d);
            public static FormLink<IIdleAnimationGetter> KillMove2HWHackFromBehind00 => Construct(0x81c);
            public static FormLink<IIdleAnimationGetter> KillMoveH2HSuplex => Construct(0x81b);
            public static FormLink<IIdleAnimationGetter> KillMoveH2HSuplex00 => Construct(0x81a);
            public static FormLink<IIdleAnimationGetter> KillMoveSneakH2H => Construct(0x819);
            public static FormLink<IIdleAnimationGetter> KillMoveSneakH2H00 => Construct(0x818);
            public static FormLink<IIdleAnimationGetter> KillMoveSneakH2HSleeper00 => Construct(0x817);
            public static FormLink<IIdleAnimationGetter> KillMoveSneakH2HSleeper => Construct(0x816);
            public static FormLink<IIdleAnimationGetter> KillMoveSneakH2HNeckBreak => Construct(0x815);
            public static FormLink<IIdleAnimationGetter> KillMoveSneakH2HNeckBreak00 => Construct(0x814);
            public static FormLink<IIdleAnimationGetter> KillMoveSneak1HMThroatSlit => Construct(0x813);
            public static FormLink<IIdleAnimationGetter> KillMoveSneak1HMThroatSlit00 => Construct(0x812);
        }
    }
}
