// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static class SceneCollection
    {
        private static FormLink<ISceneCollectionGetter> Construct(uint id) => new FormLink<ISceneCollectionGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISceneCollectionGetter> DLC04_KiddieKingdomStageShowNewColl => Construct(0x49f1f);
        public static FormLink<ISceneCollectionGetter> DLC04_KiddieKingdomRoofSceneColl => Construct(0x486b9);
        public static FormLink<ISceneCollectionGetter> DLC04MQ04View => Construct(0x379fa);
        public static FormLink<ISceneCollectionGetter> DLC04WorkshopBOSAttack03View => Construct(0x363a5);
        public static FormLink<ISceneCollectionGetter> DLC04ConvPackGeneric_SceneCollection => Construct(0x33bb6);
        public static FormLink<ISceneCollectionGetter> DLC04View => Construct(0x33836);
        public static FormLink<ISceneCollectionGetter> DLC04RaidSelectQuestCollection => Construct(0x1b032);
    }
}
