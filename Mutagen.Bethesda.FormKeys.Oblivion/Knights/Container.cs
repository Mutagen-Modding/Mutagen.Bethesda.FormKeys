// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Knights
{
    public static partial class Container
    {
        private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IContainerGetter> TestQAKnights => Construct(0xee0);
        public static FormLink<IContainerGetter> NDChestVendorBooks => Construct(0xee1);
        public static FormLink<IContainerGetter> NDPrioryUndercroftBossChest => Construct(0xee2);
        public static FormLink<IContainerGetter> NDPrioryUndercroftChest01 => Construct(0xee3);
        public static FormLink<IContainerGetter> ND05MainTestChestNew => Construct(0xee4);
        public static FormLink<IContainerGetter> NDPrioryArmoryChest => Construct(0xee5);
        public static FormLink<IContainerGetter> ND05MainTestChestKurt => Construct(0xee6);
        public static FormLink<IContainerGetter> ND08Tomb => Construct(0xee7);
        public static FormLink<IContainerGetter> ND05StoneChest => Construct(0xee8);
        public static FormLink<IContainerGetter> ND05GemChest => Construct(0xee9);
        public static FormLink<IContainerGetter> ND05HammerChest => Construct(0xeea);
        public static FormLink<IContainerGetter> ND05GobletChest => Construct(0xeeb);
        public static FormLink<IContainerGetter> ND05BookChest => Construct(0xeec);
        public static FormLink<IContainerGetter> ND05SkullChest => Construct(0xeed);
        public static FormLink<IContainerGetter> ND05HelmChest => Construct(0xeee);
        public static FormLink<IContainerGetter> ND05SwordChest => Construct(0xeef);
        public static FormLink<IContainerGetter> ND05MainTestChest => Construct(0xef0);
    }
}
