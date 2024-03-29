// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class ArtObject
    {
        private static FormLink<IArtObjectGetter> Construct(uint id) => new FormLink<IArtObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultUtilityIcon => Construct(0x2552);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultDomesticIcon => Construct(0x251e);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultDecorationsPostersIcon => Construct(0x1639);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultPowerIcon => Construct(0x11bb);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultDecorationsIcon => Construct(0x11ae);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultFurnitureIcon => Construct(0x49f1);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultRoomsIcon => Construct(0x42eb);
        public static FormLink<IArtObjectGetter> DLC06WorkshopVaultIcon => Construct(0x42e9);
    }
}
