// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> ccBGSSSE003_LvlBoneWolfZombie => Construct(0x3025);
            public static FormLink<INpcGetter> dunBluePalaceWingEncGoatDomestic => Construct(0x804);
        }
    }
}
