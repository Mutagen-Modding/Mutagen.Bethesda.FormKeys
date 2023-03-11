// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class ActionRecord
    {
        private static FormLink<IActionRecordGetter> Construct(uint id) => new FormLink<IActionRecordGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IActionRecordGetter> DLC04_ActionRaiderCheering => Construct(0x19e8a);
    }
}