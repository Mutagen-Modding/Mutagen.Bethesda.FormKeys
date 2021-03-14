using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Scene
        {
            private static FormLink<ISceneGetter> Construct(uint id) => new FormLink<ISceneGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISceneGetter> RelationshipAdoption_SceneNameCalling01 => Construct(0x1652e);
            public static FormLink<ISceneGetter> RelationshipAdoption_SceneNameCalling02 => Construct(0x1652d);
            public static FormLink<ISceneGetter> BYOHHouseStewardOfferScene => Construct(0x3179);
        }
    }
}
