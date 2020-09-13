namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class GameSetting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey sLegendaryResetConfirm => ModKey.MakeFormKey(0x9d9);
            public static FormKey sLegendaryResetSecondConfirm => ModKey.MakeFormKey(0x9d8);
            public static FormKey fDiffMultHPToPCL => ModKey.MakeFormKey(0x9d5);
            public static FormKey fMountedMaxLookingDown => ModKey.MakeFormKey(0x953);
            public static FormKey sKinectNotCalibrated => ModKey.MakeFormKey(0x951);
            public static FormKey sKinectCantInit => ModKey.MakeFormKey(0x950);
            public static FormKey sKinectAllyTooFarToTrade => ModKey.MakeFormKey(0x94f);
            public static FormKey fTemperingSkillUseItemValConst => ModKey.MakeFormKey(0x949);
            public static FormKey fTemperingSkillUseItemValExp => ModKey.MakeFormKey(0x948);
            public static FormKey fTemperingSkillUseItemValMult => ModKey.MakeFormKey(0x947);
            public static FormKey iUpdateESMVersion => ModKey.MakeFormKey(0x945);
            public static FormKey fConstructibleSkillUseConst => ModKey.MakeFormKey(0x943);
            public static FormKey fConstructibleSkilluseExp => ModKey.MakeFormKey(0x942);
            public static FormKey fConstructibleSkillUseMult => ModKey.MakeFormKey(0x941);
            public static FormKey sInvalidTagString => ModKey.MakeFormKey(0x83e);
        }
    }
}
