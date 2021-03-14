using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Activator
        {
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> DL9RazorSwapTrigger => Construct(0x5fe4);
            public static FormLink<IActivatorGetter> DL9TrigSceneSetup => Construct(0x2d1e);
            public static FormLink<IActivatorGetter> DL9UnlockRearDoorTrig => Construct(0x5096);
            public static FormLink<IActivatorGetter> DL9BezoarPedestal01 => Construct(0x2037);
            public static FormLink<IActivatorGetter> DL9QuestStage20Trigger => Construct(0x13b8);
            public static FormLink<IActivatorGetter> DL9VillageReinforementsTrig => Construct(0x133d);
            public static FormLink<IActivatorGetter> DL9GenericFireDamage01 => Construct(0x20f8);
            public static FormLink<IActivatorGetter> DL9ForgeAmbushTrig => Construct(0x21d8);
            public static FormLink<IActivatorGetter> DL9RedCrystalActivator => Construct(0x3537);
            public static FormLink<IActivatorGetter> DL9BezoarPedestal02 => Construct(0x253f);
            public static FormLink<IActivatorGetter> DL9RazorGate => Construct(0x1b1c);
            public static FormLink<IActivatorGetter> DL9ComplexityTrigger => Construct(0x5c72);
            public static FormLink<IActivatorGetter> DL9Stage15TriggerActivator => Construct(0x4afc);
            public static FormLink<IActivatorGetter> DL9BezoarSafetyNet => Construct(0xa190);
            public static FormLink<IActivatorGetter> DL9BezoarDummy01 => Construct(0x2523);
            public static FormLink<IActivatorGetter> DL9MoragTongInvisTrig => Construct(0xa681);
            public static FormLink<IActivatorGetter> DL9MehrunesRazorFake => Construct(0x5fc0);
            public static FormLink<IActivatorGetter> DL9pcbBox => Construct(0xa688);
            public static FormLink<IActivatorGetter> DL9TrigActorsKill => Construct(0x2d1d);
            public static FormLink<IActivatorGetter> DL9AutoSave => Construct(0xa68d);
        }
    }
}
