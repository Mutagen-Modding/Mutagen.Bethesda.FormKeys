using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Door
        {
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> NDRF1xDoorRight => Construct(0xef1);
            public static FormLink<IDoorGetter> NDRF1xDoorLeft => Construct(0xef2);
            public static FormLink<IDoorGetter> ND10Door => Construct(0xef3);
            public static FormLink<IDoorGetter> NDPrioryUndercroftGate01 => Construct(0xef4);
            public static FormLink<IDoorGetter> ND02Door => Construct(0xef5);
            public static FormLink<IDoorGetter> ND02PrioryDoorTEMP => Construct(0xef6);
            public static FormLink<IDoorGetter> ND03StoneDoor => Construct(0xef7);
            public static FormLink<IDoorGetter> ND02PrioryTrapdoor => Construct(0xef8);
        }
    }
}
