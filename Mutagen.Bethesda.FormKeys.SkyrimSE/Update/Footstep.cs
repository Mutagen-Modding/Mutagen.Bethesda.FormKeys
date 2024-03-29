// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Update
{
    public static partial class Footstep
    {
        private static FormLink<IFootstepGetter> Construct(uint id) => new FormLink<IFootstepGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFootstepGetter> NPCHorseRearUpFootstep => Construct(0x2f92);
        public static FormLink<IFootstepGetter> NPCHorseIdleTailFootstep => Construct(0x2f91);
        public static FormLink<IFootstepGetter> NPCHorseIdlePawFootstep => Construct(0x2f90);
        public static FormLink<IFootstepGetter> NPCHorseIdleHeadShakeFootstep => Construct(0x2f8f);
        public static FormLink<IFootstepGetter> NPCHorseIdleHead03Footstep => Construct(0x2f8e);
        public static FormLink<IFootstepGetter> NPCHorseIdleHead01BFootstep => Construct(0x2f8d);
        public static FormLink<IFootstepGetter> NPCHorseIdleHead01AFootstep => Construct(0x2f8c);
        public static FormLink<IFootstepGetter> NPCHorseIdleGrazeFootstep => Construct(0x2f8b);
        public static FormLink<IFootstepGetter> NPCHorseAttack2Footstep => Construct(0x2f8a);
        public static FormLink<IFootstepGetter> NPCHorseAttackFootstep => Construct(0x2f89);
        public static FormLink<IFootstepGetter> NPCWolfAggroWarningFootstep => Construct(0x2f51);
        public static FormLink<IFootstepGetter> NPCWolfHowlDistantFootstep => Construct(0x2f4e);
        public static FormLink<IFootstepGetter> NPCWolfHowlFootstep => Construct(0x2f4b);
        public static FormLink<IFootstepGetter> NPCWolfAttackPowerShortFootstep => Construct(0x2f48);
        public static FormLink<IFootstepGetter> NPCWolfAttackPowerFootstep => Construct(0x2f47);
        public static FormLink<IFootstepGetter> NPCWolfAttackBFootstep => Construct(0x2f46);
        public static FormLink<IFootstepGetter> NPCWolfAttackAFootstep => Construct(0x2f45);
    }
}
