using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class AnimatedObject
        {
            private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectPickAxeWall => Construct(0x3a330);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectBoat => Construct(0x39ba6);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectStone => Construct(0x3663a);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectChiselHammerRiekling => Construct(0x2b10b);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectChiselRiekling => Construct(0x2b10a);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectChiselHammer => Construct(0x29d29);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectChisel => Construct(0x29d28);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSeekerBook => Construct(0x261e3);
            public static FormLink<IAnimatedObjectGetter> DLC02AnimObjectHeart => Construct(0x24fcb);
        }
    }
}
