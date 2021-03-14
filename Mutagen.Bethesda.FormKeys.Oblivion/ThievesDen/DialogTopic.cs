using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class DialogTopic
        {
            private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogTopicGetter> DLC06FletcherTopic01 => Construct(0x6fd9);
            public static FormLink<IDialogTopicGetter> DLC06PirateTopic01 => Construct(0x6fda);
            public static FormLink<IDialogTopicGetter> DLC06SecurityTopic01 => Construct(0x6fdd);
            public static FormLink<IDialogTopicGetter> DLC06FenceTopic01 => Construct(0x79b7);
            public static FormLink<IDialogTopicGetter> DLC06SupplierTopic01 => Construct(0x79b8);
            public static FormLink<IDialogTopicGetter> DLC06StealthTopic01 => Construct(0x79b9);
            public static FormLink<IDialogTopicGetter> DLC06FenceTopic02 => Construct(0x889e);
            public static FormLink<IDialogTopicGetter> DLC06FenceTopic03 => Construct(0x889f);
            public static FormLink<IDialogTopicGetter> DLC06PirateTopic02 => Construct(0x12ef9);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicFence => Construct(0x16019);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicFletcher => Construct(0x1601a);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicSecurity => Construct(0x1601b);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicStealth => Construct(0x1601c);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicQuarters => Construct(0x1601d);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicSupplier => Construct(0x1601e);
            public static FormLink<IDialogTopicGetter> DLC06DahliaUpgradeTopic => Construct(0x1602b);
            public static FormLink<IDialogTopicGetter> DLC06DahliaTopicNo => Construct(0x178b9);
        }
    }
}
