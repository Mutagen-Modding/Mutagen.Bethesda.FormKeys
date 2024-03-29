// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class DefaultObject
    {
        private static FormLink<IDefaultObjectGetter> Construct(uint id) => new FormLink<IDefaultObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDefaultObjectGetter> WorkshopAcousticSpace_DO => Construct(0x139f);
        public static FormLink<IDefaultObjectGetter> WorkshopAcousticSpaceKeyword_DO => Construct(0x139e);
        public static FormLink<IDefaultObjectGetter> WorkshopAcousticSpaceAV_DO => Construct(0x139d);
    }
}
