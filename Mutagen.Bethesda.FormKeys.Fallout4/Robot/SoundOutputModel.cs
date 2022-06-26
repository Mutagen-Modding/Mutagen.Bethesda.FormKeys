// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static class SoundOutputModel
    {
        private static FormLink<ISoundOutputModelGetter> Construct(uint id) => new FormLink<ISoundOutputModelGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundOutputModelGetter> DLC01SOMMonoWorldRadio_Eyebot_03000 => Construct(0x10a61);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystemSpot_Mono_B_00001x01800 => Construct(0xd317);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystemSpot_Mono_A_00000x00750 => Construct(0xd316);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystem_Stereo_C_01200x02500 => Construct(0xcace);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystem_Stereo_B_00001x01200 => Construct(0xcacd);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystem_Mono_C_00900x02500 => Construct(0xcacc);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystem_Mono_B_00001x01400 => Construct(0xcacb);
        public static FormLink<ISoundOutputModelGetter> SOMCompound_DLC01OBJTrackSystem_Mono_A_00000x00500 => Construct(0xcaca);
        public static FormLink<ISoundOutputModelGetter> DLC01SOMMono_MechanistInControlCenter => Construct(0x2877);
    }
}
