using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class ActionRecord
        {
            private static FormLink<IActionRecordGetter> Construct(uint id) => new FormLink<IActionRecordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActionRecordGetter> ActionRagdollInstant => Construct(0x9bb4e);
            public static FormLink<IActionRecordGetter> ActionIdleStopInstant => Construct(0x7f8e3);
            public static FormLink<IActionRecordGetter> ActionSheath => Construct(0x46baf);
            public static FormLink<IActionRecordGetter> ActionResetGraph => Construct(0xd1fde);
            public static FormLink<IActionRecordGetter> ActionGetUp => Construct(0xd1fdd);
            public static FormLink<IActionRecordGetter> ActionKnockDown => Construct(0xd1fdc);
            public static FormLink<IActionRecordGetter> ActionShieldChange => Construct(0x94065);
            public static FormLink<IActionRecordGetter> ActionMoveRight => Construct(0x5edce);
            public static FormLink<IActionRecordGetter> ActionMoveLeft => Construct(0x5edcd);
            public static FormLink<IActionRecordGetter> ActionMoveBackward => Construct(0x5edcc);
            public static FormLink<IActionRecordGetter> ActionMoveForward => Construct(0x5edc9);
            public static FormLink<IActionRecordGetter> ActionDualPowerAttack => Construct(0x2e2f7);
            public static FormLink<IActionRecordGetter> ActionLeftPowerAttack => Construct(0x2e2f6);
            public static FormLink<IActionRecordGetter> ActionIdleWarn => Construct(0x98886);
            public static FormLink<IActionRecordGetter> ActionTurnStop => Construct(0x959fe);
            public static FormLink<IActionRecordGetter> ActionTurnLeft => Construct(0x959fd);
            public static FormLink<IActionRecordGetter> ActionTurnRight => Construct(0x959fc);
            public static FormLink<IActionRecordGetter> ActionMoveStop => Construct(0x959f9);
            public static FormLink<IActionRecordGetter> ActionMoveStart => Construct(0x959f8);
            public static FormLink<IActionRecordGetter> ActionLand => Construct(0x937f5);
            public static FormLink<IActionRecordGetter> ActionFall => Construct(0x937f4);
            public static FormLink<IActionRecordGetter> ActionLargeMovementDelta => Construct(0x2e444);
            public static FormLink<IActionRecordGetter> ActionDeathWait => Construct(0x5dd59);
            public static FormLink<IActionRecordGetter> ActionDualRelease => Construct(0x50c97);
            public static FormLink<IActionRecordGetter> ActionDualAttack => Construct(0x50c96);
            public static FormLink<IActionRecordGetter> ActionStopEffect => Construct(0x20941);
            public static FormLink<IActionRecordGetter> ActionListen => Construct(0x489f2);
            public static FormLink<IActionRecordGetter> ActionTalking => Construct(0x489f1);
            public static FormLink<IActionRecordGetter> ActionDeath => Construct(0x489ed);
            public static FormLink<IActionRecordGetter> ActionSummonedStart => Construct(0x45b5b);
            public static FormLink<IActionRecordGetter> ActionBumpedInto => Construct(0x3de4d);
            public static FormLink<IActionRecordGetter> ActionHoverStop => Construct(0x3b4e6);
            public static FormLink<IActionRecordGetter> ActionHoverStart => Construct(0x3b4e5);
            public static FormLink<IActionRecordGetter> ActionFlyStop => Construct(0x3b4e4);
            public static FormLink<IActionRecordGetter> ActionFlyStart => Construct(0x3b4e3);
            public static FormLink<IActionRecordGetter> ActionSprintStart => Construct(0x3b4a7);
            public static FormLink<IActionRecordGetter> ActionPathEnd => Construct(0x2edb9);
            public static FormLink<IActionRecordGetter> ActionPathStart => Construct(0x2edb8);
            public static FormLink<IActionRecordGetter> ActionForceEquip => Construct(0x2adf1);
            public static FormLink<IActionRecordGetter> ActionWardHit => Construct(0x24b3a);
            public static FormLink<IActionRecordGetter> ActionBlockAnticipate => Construct(0x193ce);
            public static FormLink<IActionRecordGetter> ActionIdleStop => Construct(0x18ba8);
            public static FormLink<IActionRecordGetter> ActionBleedoutStop => Construct(0x13eca);
            public static FormLink<IActionRecordGetter> ActionBleedoutStart => Construct(0x13ec9);
            public static FormLink<IActionRecordGetter> ActionRecoilLarge => Construct(0x13ec8);
            public static FormLink<IActionRecordGetter> ActionRecoil => Construct(0x13af5);
            public static FormLink<IActionRecordGetter> ActionBlockHit => Construct(0x13af4);
            public static FormLink<IActionRecordGetter> ActionStaggerStart => Construct(0x138d2);
            public static FormLink<IActionRecordGetter> ActionVoiceInterrupt => Construct(0x13459);
            public static FormLink<IActionRecordGetter> ActionVoiceReady => Construct(0x13458);
            public static FormLink<IActionRecordGetter> ActionVoiceRelease => Construct(0x13457);
            public static FormLink<IActionRecordGetter> ActionRightInterrupt => Construct(0x13456);
            public static FormLink<IActionRecordGetter> ActionRightReady => Construct(0x13455);
            public static FormLink<IActionRecordGetter> ActionRightRelease => Construct(0x13454);
            public static FormLink<IActionRecordGetter> ActionLeftInterrupt => Construct(0x13453);
            public static FormLink<IActionRecordGetter> ActionLeftReady => Construct(0x13452);
            public static FormLink<IActionRecordGetter> ActionLeftRelease => Construct(0x13451);
            public static FormLink<IActionRecordGetter> ActionRightPowerAttack => Construct(0x13383);
            public static FormLink<IActionRecordGetter> ActionDraw => Construct(0x132af);
            public static FormLink<IActionRecordGetter> ActionSprintStop => Construct(0x13219);
            public static FormLink<IActionRecordGetter> ActionLook => Construct(0x1300a);
            public static FormLink<IActionRecordGetter> ActionActivate => Construct(0x13009);
            public static FormLink<IActionRecordGetter> ActionVoice => Construct(0x13008);
            public static FormLink<IActionRecordGetter> ActionSneak => Construct(0x13007);
            public static FormLink<IActionRecordGetter> ActionJump => Construct(0x13006);
            public static FormLink<IActionRecordGetter> ActionRightAttack => Construct(0x13005);
            public static FormLink<IActionRecordGetter> ActionLeftAttack => Construct(0x13004);
            public static FormLink<IActionRecordGetter> ActionSwimStateChange => Construct(0x13003);
            public static FormLink<IActionRecordGetter> ActionIdle => Construct(0x13002);
        }
    }
}
