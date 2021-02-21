using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class IdleAnimation
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IIdleAnimationGetter> Construct(uint id) => new FormLink<IIdleAnimationGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleAnimationGetter> DLCBattlehornOpenGate => Construct(0x13918);
        }
    }
}
