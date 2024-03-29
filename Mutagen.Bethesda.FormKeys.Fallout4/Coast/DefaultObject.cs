// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class DefaultObject
    {
        private static FormLink<IDefaultObjectGetter> Construct(uint id) => new FormLink<IDefaultObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDefaultObjectGetter> NoPathFailureWarping_DO => Construct(0x5d898);
        public static FormLink<IDefaultObjectGetter> WorldSpaceDLC03_DO => Construct(0x57762);
        public static FormLink<IDefaultObjectGetter> ActorTypeCreatureDLC03_DO => Construct(0x57761);
        public static FormLink<IDefaultObjectGetter> CraftedItemDLC03_DO => Construct(0x5775f);
    }
}
