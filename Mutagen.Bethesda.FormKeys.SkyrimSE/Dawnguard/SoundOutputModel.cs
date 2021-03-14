using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class SoundOutputModel
        {
            private static FormLink<ISoundOutputModelGetter> Construct(uint id) => new FormLink<ISoundOutputModelGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D6500_Vyrthur_verb => Construct(0x14cb3);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad08000 => Construct(0x14bcb);
            public static FormLink<ISoundOutputModelGetter> SOMMono12000 => Construct(0x14bc7);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad15000 => Construct(0x14bc5);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad04000_verb => Construct(0x1333c);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad01400_verb => Construct(0x1686b);
        }
    }
}
