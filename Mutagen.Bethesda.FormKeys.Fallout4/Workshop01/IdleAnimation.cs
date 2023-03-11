// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static class IdleAnimation
    {
        private static FormLink<IIdleAnimationGetter> Construct(uint id) => new FormLink<IIdleAnimationGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IIdleAnimationGetter> DLC02HandyPatrol => Construct(0xce0);
        public static FormLink<IIdleAnimationGetter> DLC02HandyPatrolIdle => Construct(0xcdf);
        public static FormLink<IIdleAnimationGetter> DLC02CreateABotPatrolIdle => Construct(0xcde);
        public static FormLink<IIdleAnimationGetter> PoseA_IdleOneHandsUp => Construct(0xa97);
        public static FormLink<IIdleAnimationGetter> DLC02IdleArenaCheer => Construct(0xa8f);
        public static FormLink<IIdleAnimationGetter> DLC02ArenaPlatformMeleeIdle => Construct(0xcd3);
        public static FormLink<IIdleAnimationGetter> DLC02ArenaPlatformGunIdle => Construct(0xcd2);
    }
}