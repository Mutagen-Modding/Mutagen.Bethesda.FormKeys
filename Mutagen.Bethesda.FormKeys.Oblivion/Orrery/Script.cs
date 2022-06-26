// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Orrery
{
    public static class Script
    {
        private static FormLink<IScriptGetter> Construct(uint id) => new FormLink<IScriptGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IScriptGetter> DLCOrreryDwarvenCog1Script => Construct(0x11e63f);
        public static FormLink<IScriptGetter> DLCOrreryDwarvenCog2Script => Construct(0x11e640);
        public static FormLink<IScriptGetter> DLCOrreryDwarvenCohererScript => Construct(0x11e641);
        public static FormLink<IScriptGetter> DLCOrreryDwarvenCylinderScript => Construct(0x11e642);
        public static FormLink<IScriptGetter> DLCOrreryDwarvenTubeScript => Construct(0x11e643);
        public static FormLink<IScriptGetter> DLCOrreryQuestScript => Construct(0x11b9fc);
        public static FormLink<IScriptGetter> DLCOrreryConsoleScript => Construct(0x11d290);
    }
}
