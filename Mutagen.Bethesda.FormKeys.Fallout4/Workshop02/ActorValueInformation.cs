// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static class ActorValueInformation
    {
        private static FormLink<IActorValueInformationGetter> Construct(uint id) => new FormLink<IActorValueInformationGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IActorValueInformationGetter> DLC05Force => Construct(0xddc);
    }
}