namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            public static FormKey NDRF1xDoorRight => ModKey.MakeFormKey(0xef1);
            public static FormKey NDRF1xDoorLeft => ModKey.MakeFormKey(0xef2);
            public static FormKey ND10Door => ModKey.MakeFormKey(0xef3);
            public static FormKey NDPrioryUndercroftGate01 => ModKey.MakeFormKey(0xef4);
            public static FormKey ND02Door => ModKey.MakeFormKey(0xef5);
            public static FormKey ND02PrioryDoorTEMP => ModKey.MakeFormKey(0xef6);
            public static FormKey ND03StoneDoor => ModKey.MakeFormKey(0xef7);
            public static FormKey ND02PrioryTrapdoor => ModKey.MakeFormKey(0xef8);
        }
    }
}
