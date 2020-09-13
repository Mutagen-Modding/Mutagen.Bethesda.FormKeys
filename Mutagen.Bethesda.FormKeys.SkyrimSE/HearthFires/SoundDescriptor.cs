namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class SoundDescriptor
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey OBJMineClaySD => ModKey.MakeFormKey(0xba3);
            public static FormKey NPCHumanWorkbenchHammerDistant => ModKey.MakeFormKey(0x17ecc);
            public static FormKey NPCHumanWorkbenchHammer => ModKey.MakeFormKey(0x17ecb);
            public static FormKey WPNWoodSwordDrawSD => ModKey.MakeFormKey(0x14c2b);
            public static FormKey WPNImpact1HandWoodSwordBluntGeneric => ModKey.MakeFormKey(0x14c2a);
            public static FormKey WPNWoodSwordSheatheSD => ModKey.MakeFormKey(0x8991);
            public static FormKey WPNSwing1HandWoodSwordSD => ModKey.MakeFormKey(0x8990);
            public static FormKey WPNImpact1HandWoodSwordvsDummy => ModKey.MakeFormKey(0x898f);
        }
    }
}
