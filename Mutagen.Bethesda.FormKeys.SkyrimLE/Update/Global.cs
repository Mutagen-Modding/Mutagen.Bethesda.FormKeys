// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Update
{
    public static partial class Global
    {
        private static FormLink<IGlobalGetter> Construct(uint id) => new FormLink<IGlobalGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGlobalGetter> OghmaInfiniumBookHasBeenRead => Construct(0x9de);
        public static FormLink<IGlobalGetter> RiftenUngrienGlobal => Construct(0x9db);
        public static FormLink<IGlobalGetter> WEDL06LetrushKilled => Construct(0x99c);
    }
}
