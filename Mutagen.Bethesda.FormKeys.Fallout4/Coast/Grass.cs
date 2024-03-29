// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static partial class Grass
    {
        private static FormLink<IGrassGetter> Construct(uint id) => new FormLink<IGrassGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGrassGetter> DLC03DebrisGroundOystersGrass04 => Construct(0xd821);
        public static FormLink<IGrassGetter> DLC03DebrisGroundOystersGrass03 => Construct(0xd81e);
        public static FormLink<IGrassGetter> DLC03DebrisGroundOystersGrass02 => Construct(0xd81d);
        public static FormLink<IGrassGetter> DLC03DebrisGroundOystersGrass01 => Construct(0xd81c);
        public static FormLink<IGrassGetter> DLC03PineForestGrass03 => Construct(0x87ff);
        public static FormLink<IGrassGetter> DLC03PineForestGrass02 => Construct(0x87fe);
        public static FormLink<IGrassGetter> DLC03PineForestGrass01 => Construct(0x87fd);
        public static FormLink<IGrassGetter> RockyCoastGrass03 => Construct(0x3908);
        public static FormLink<IGrassGetter> RockyCoastGrass02 => Construct(0x3907);
        public static FormLink<IGrassGetter> RockyCoastGrass01 => Construct(0x3906);
    }
}
