// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Dragonborn
{
    public static partial class FootstepSet
    {
        private static FormLink<IFootstepSetGetter> Construct(uint id) => new FormLink<IFootstepSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFootstepSetGetter> FSTArmorSkaalFootstepSet => Construct(0x3d377);
        public static FormLink<IFootstepSetGetter> NPCDwarvenBallistaFootWalkFootstepSet => Construct(0x3cf92);
        public static FormLink<IFootstepSetGetter> NPCRieklingBristlebackFootFootstepSet => Construct(0x337de);
        public static FormLink<IFootstepSetGetter> NPCRieklingFootstepSet => Construct(0x28b91);
        public static FormLink<IFootstepSetGetter> NPCSpiderHandFootWalkFootstepSet => Construct(0x28b56);
        public static FormLink<IFootstepSetGetter> NPCNetchFootFootstepSet => Construct(0x28590);
        public static FormLink<IFootstepSetGetter> NPCBristlebackFootFootstepSet => Construct(0x25c69);
        public static FormLink<IFootstepSetGetter> NPCAshGhoulFootWalkFootstepSet => Construct(0x23f8a);
        public static FormLink<IFootstepSetGetter> NPCScribFootWalkFootstepSet => Construct(0x1f176);
        public static FormLink<IFootstepSetGetter> NPCScribWalkFootstepSet => Construct(0x1f16d);
        public static FormLink<IFootstepSetGetter> NPCFishmanFootWalkFootstepSet => Construct(0x1f14c);
    }
}
