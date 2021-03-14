using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class GameSetting
        {
            private static FormLink<IGameSettingGetter> Construct(uint id) => new FormLink<IGameSettingGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGameSettingGetter> sConfirmNewMods_Orbis => Construct(0x2ece);
            public static FormLink<IGameSettingGetter> sConfirmNewMods => Construct(0x2ecd);
            public static FormLink<IGameSettingGetter> sModdedString => Construct(0x2eca);
            public static FormLink<IGameSettingGetter> sReportModCat_Slander => Construct(0x2ec9);
            public static FormLink<IGameSettingGetter> sReportModCat_Religious => Construct(0x2ec8);
            public static FormLink<IGameSettingGetter> sReportModCat_Racial => Construct(0x2ec7);
            public static FormLink<IGameSettingGetter> sReportModCat_Profanity => Construct(0x2ec6);
            public static FormLink<IGameSettingGetter> sReportModCat_PrivateInfo => Construct(0x2ec5);
            public static FormLink<IGameSettingGetter> sReportModCat_Impersonation => Construct(0x2ec4);
            public static FormLink<IGameSettingGetter> sReportModCat_Harassment => Construct(0x2ec3);
            public static FormLink<IGameSettingGetter> sReportModCat_General => Construct(0x2ec2);
            public static FormLink<IGameSettingGetter> sReportModCat_Explicit => Construct(0x2ec1);
            public static FormLink<IGameSettingGetter> sReportModConfirm => Construct(0x2ec0);
            public static FormLink<IGameSettingGetter> sReportModChooseCategory => Construct(0x2ebf);
            public static FormLink<IGameSettingGetter> sCantInstallModInvalid => Construct(0x2ebe);
            public static FormLink<IGameSettingGetter> sCantInstallModDependency => Construct(0x2ebd);
            public static FormLink<IGameSettingGetter> sLoadVanillaSaveWithMods_Orbis => Construct(0x2ebc);
            public static FormLink<IGameSettingGetter> sLoadVanillaSaveWithMods => Construct(0x2ebb);
            public static FormLink<IGameSettingGetter> sResultsFor => Construct(0x2eba);
            public static FormLink<IGameSettingGetter> sCloseModManager_Confirm => Construct(0x2eb9);
            public static FormLink<IGameSettingGetter> sChangedModsResetConfirm => Construct(0x2eb8);
            public static FormLink<IGameSettingGetter> sDeleteLibraryModConfirm => Construct(0x2eb7);
            public static FormLink<IGameSettingGetter> sDeleteModConfirm => Construct(0x2eb6);
            public static FormLink<IGameSettingGetter> sDeleteAllModsConfirm => Construct(0x2eb5);
            public static FormLink<IGameSettingGetter> sReportModCat_Spam => Construct(0x2eb4);
            public static FormLink<IGameSettingGetter> sGamepadDisconnectedTitle => Construct(0x2df7);
            public static FormLink<IGameSettingGetter> sGamepadDisconnectedMessage => Construct(0x2df6);
            public static FormLink<IGameSettingGetter> sCantLoadSettings => Construct(0x2a7d);
            public static FormLink<IGameSettingGetter> sCantLoadControls => Construct(0x2a7c);
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
