using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            private static FormLink<IScriptGetter> Construct(uint id) => new FormLink<IScriptGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScriptGetter> HorsePCOldNagScript => Construct(0x3e9b);
            public static FormLink<IScriptGetter> DLCHorseArmorScriptSnakGraBura => Construct(0x4382);
            public static FormLink<IScriptGetter> DLCHorseArmorDoorScript => Construct(0x6ab8);
            public static FormLink<IScriptGetter> DLCHorseArmorScript => Construct(0xced);
        }
    }
}
