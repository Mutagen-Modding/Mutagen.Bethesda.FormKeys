// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class DialogTopic
    {
        private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDialogTopicGetter> DLC06WorkshopParentVendorTrade => Construct(0x54c1);
        public static FormLink<IDialogTopicGetter> DLC06WorkshopParentVendorQuestion => Construct(0x54c2);
    }
}
