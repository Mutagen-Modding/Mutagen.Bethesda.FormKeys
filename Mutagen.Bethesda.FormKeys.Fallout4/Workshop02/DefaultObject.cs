// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static class DefaultObject
    {
        private static FormLink<IDefaultObjectGetter> Construct(uint id) => new FormLink<IDefaultObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDefaultObjectGetter> WorkshopArmorRackKeyword_DO => Construct(0xf35);
    }
}