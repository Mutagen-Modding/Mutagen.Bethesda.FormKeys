namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class SoundOutputModel
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey SOMDialogue3D6500_Vyrthur_verb => ModKey.MakeFormKey(0x14cb3);
            public static FormKey SOMStereoRad08000 => ModKey.MakeFormKey(0x14bcb);
            public static FormKey SOMMono12000 => ModKey.MakeFormKey(0x14bc7);
            public static FormKey SOMStereoRad15000 => ModKey.MakeFormKey(0x14bc5);
            public static FormKey SOMStereoRad04000_verb => ModKey.MakeFormKey(0x1333c);
            public static FormKey SOMStereoRad01400_verb => ModKey.MakeFormKey(0x1686b);
        }
    }
}
