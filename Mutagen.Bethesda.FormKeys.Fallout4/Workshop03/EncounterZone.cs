// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class EncounterZone
    {
        private static FormLink<IEncounterZoneGetter> Construct(uint id) => new FormLink<IEncounterZoneGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IEncounterZoneGetter> Vault88Zone => Construct(0x3de0);
    }
}
