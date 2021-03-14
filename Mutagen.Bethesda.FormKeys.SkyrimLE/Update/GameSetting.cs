using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class GameSetting
        {
            private static FormLink<IGameSettingGetter> Construct(uint id) => new FormLink<IGameSettingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> sLegendaryResetConfirm => Construct(0x9d9);
            public static FormLink<IGameSettingGetter> sLegendaryResetSecondConfirm => Construct(0x9d8);
            public static FormLink<IGameSettingGetter> fDiffMultHPToPCL => Construct(0x9d5);
            public static FormLink<IGameSettingGetter> fMountedMaxLookingDown => Construct(0x953);
            public static FormLink<IGameSettingGetter> sKinectNotCalibrated => Construct(0x951);
            public static FormLink<IGameSettingGetter> sKinectCantInit => Construct(0x950);
            public static FormLink<IGameSettingGetter> sKinectAllyTooFarToTrade => Construct(0x94f);
            public static FormLink<IGameSettingGetter> fTemperingSkillUseItemValConst => Construct(0x949);
            public static FormLink<IGameSettingGetter> fTemperingSkillUseItemValExp => Construct(0x948);
            public static FormLink<IGameSettingGetter> fTemperingSkillUseItemValMult => Construct(0x947);
            public static FormLink<IGameSettingGetter> iUpdateESMVersion => Construct(0x945);
            public static FormLink<IGameSettingGetter> fConstructibleSkillUseConst => Construct(0x943);
            public static FormLink<IGameSettingGetter> fConstructibleSkilluseExp => Construct(0x942);
            public static FormLink<IGameSettingGetter> fConstructibleSkillUseMult => Construct(0x941);
            public static FormLink<IGameSettingGetter> sInvalidTagString => Construct(0x83e);
        }
    }
}
