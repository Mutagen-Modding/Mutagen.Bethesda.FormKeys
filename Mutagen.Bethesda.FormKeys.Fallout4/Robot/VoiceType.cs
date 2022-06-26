// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class VoiceType
    {
        private static FormLink<IVoiceTypeGetter> Construct(uint id) => new FormLink<IVoiceTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IVoiceTypeGetter> DLC01NPCMJackson => Construct(0xffc9);
        public static FormLink<IVoiceTypeGetter> DLC01_NPCMJagger => Construct(0xfe93);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionBleepC => Construct(0xf618);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionFemaleProcessed => Construct(0xb855);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionMaleProcessed => Construct(0xb854);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionBleepB => Construct(0xb211);
        public static FormLink<IVoiceTypeGetter> DLC01_NPCFAniseCiroletti => Construct(0xa5ed);
        public static FormLink<IVoiceTypeGetter> DLC01_NPCMThomasHarkin => Construct(0xa5ec);
        public static FormLink<IVoiceTypeGetter> DLC01_NPCMTonyDelano => Construct(0xa5eb);
        public static FormLink<IVoiceTypeGetter> DLC01RobotRobobrain => Construct(0x26b5);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionBleepA => Construct(0x24e1);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionFemaleDefault => Construct(0x24e0);
        public static FormLink<IVoiceTypeGetter> DLC01RobotCompanionMaleDefault => Construct(0x24df);
        public static FormLink<IVoiceTypeGetter> DLC01_Announcer_FacilityMainframeVoiceF => Construct(0x21d1);
        public static FormLink<IVoiceTypeGetter> DLC01NPCFMechanist => Construct(0x8b4);
        public static FormLink<IVoiceTypeGetter> DLC01MechanistEyebot => Construct(0x880);
    }
}
