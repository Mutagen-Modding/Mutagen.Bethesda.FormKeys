using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class CollisionLayer
        {
            private static FormLink<ICollisionLayerGetter> Construct(uint id) => new FormLink<ICollisionLayerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICollisionLayerGetter> L_TRAP_TRIGGER => Construct(0x10fb43);
            public static FormLink<ICollisionLayerGetter> L_DETECTION => Construct(0x10aa40);
            public static FormLink<ICollisionLayerGetter> L_LIVING_AND_DEAD_ACTORS => Construct(0x109e3a);
            public static FormLink<ICollisionLayerGetter> L_SPELLTRIGGER => Construct(0x100f2f);
            public static FormLink<ICollisionLayerGetter> L_CRITTER => Construct(0x93685);
            public static FormLink<ICollisionLayerGetter> L_NAVCUT => Construct(0xe7518);
            public static FormLink<ICollisionLayerGetter> L_TRIGGER_FALLINGTRAP => Construct(0xaaac7);
            public static FormLink<ICollisionLayerGetter> L_DEADACTORZONE => Construct(0x8889c);
            public static FormLink<ICollisionLayerGetter> L_DROPPINGPICK => Construct(0x8878f);
            public static FormLink<ICollisionLayerGetter> L_SPELLEXPLOSION => Construct(0x8878e);
            public static FormLink<ICollisionLayerGetter> L_CUSTOMPICK2 => Construct(0x8878d);
            public static FormLink<ICollisionLayerGetter> L_CUSTOMPICK1 => Construct(0x8878c);
            public static FormLink<ICollisionLayerGetter> L_PATHINGPICK => Construct(0x8878b);
            public static FormLink<ICollisionLayerGetter> L_LOS => Construct(0x8878a);
            public static FormLink<ICollisionLayerGetter> L_ITEMPICKER => Construct(0x88789);
            public static FormLink<ICollisionLayerGetter> L_CAMERA => Construct(0x88788);
            public static FormLink<ICollisionLayerGetter> L_CONEPROJECTILE => Construct(0x88787);
            public static FormLink<ICollisionLayerGetter> L_DOORDETECTION => Construct(0x88786);
            public static FormLink<ICollisionLayerGetter> L_CAMERASPHERE => Construct(0x88785);
            public static FormLink<ICollisionLayerGetter> L_COLLISIONBOX => Construct(0x88784);
            public static FormLink<ICollisionLayerGetter> L_AVOIDBOX => Construct(0x88783);
            public static FormLink<ICollisionLayerGetter> L_BIPED_NO_CC => Construct(0x88782);
            public static FormLink<ICollisionLayerGetter> L_DEADBIP => Construct(0x88781);
            public static FormLink<ICollisionLayerGetter> L_STAIRHELPER => Construct(0x88780);
            public static FormLink<ICollisionLayerGetter> L_CHARCONTROLLER => Construct(0x8877f);
            public static FormLink<ICollisionLayerGetter> L_WARD => Construct(0x8877e);
            public static FormLink<ICollisionLayerGetter> L_TRANSPARENT_SMALL_ANIM => Construct(0x8877d);
            public static FormLink<ICollisionLayerGetter> L_INVISIBLE_WALL => Construct(0x8877c);
            public static FormLink<ICollisionLayerGetter> L_TRANSPARENT_SMALL => Construct(0x8877b);
            public static FormLink<ICollisionLayerGetter> L_SHELLCASING => Construct(0x8877a);
            public static FormLink<ICollisionLayerGetter> L_GASTRAP => Construct(0x88779);
            public static FormLink<ICollisionLayerGetter> L_PROJECTILEZONE => Construct(0x88778);
            public static FormLink<ICollisionLayerGetter> L_ACTORZONE => Construct(0x88777);
            public static FormLink<ICollisionLayerGetter> L_ACOUSTIC_SPACE => Construct(0x88776);
            public static FormLink<ICollisionLayerGetter> L_DEBRIS_LARGE => Construct(0x88775);
            public static FormLink<ICollisionLayerGetter> L_DEBRIS_SMALL => Construct(0x88774);
            public static FormLink<ICollisionLayerGetter> L_PORTAL => Construct(0x88773);
            public static FormLink<ICollisionLayerGetter> L_GROUND => Construct(0x88772);
            public static FormLink<ICollisionLayerGetter> L_CLOUDTRAP => Construct(0x88771);
            public static FormLink<ICollisionLayerGetter> L_NONCOLLIDABLE => Construct(0x88770);
            public static FormLink<ICollisionLayerGetter> L_TRAP => Construct(0x8876f);
            public static FormLink<ICollisionLayerGetter> L_TERRAIN => Construct(0x8876e);
            public static FormLink<ICollisionLayerGetter> L_TRIGGER => Construct(0x8876d);
            public static FormLink<ICollisionLayerGetter> L_WATER => Construct(0x8876c);
            public static FormLink<ICollisionLayerGetter> L_PROPS => Construct(0x8876b);
            public static FormLink<ICollisionLayerGetter> L_TREES => Construct(0x8876a);
            public static FormLink<ICollisionLayerGetter> L_BIPED => Construct(0x88769);
            public static FormLink<ICollisionLayerGetter> L_SPELL => Construct(0x88768);
            public static FormLink<ICollisionLayerGetter> L_PROJECTILE => Construct(0x88767);
            public static FormLink<ICollisionLayerGetter> L_WEAPON => Construct(0x88766);
            public static FormLink<ICollisionLayerGetter> L_CLUTTER => Construct(0x88765);
            public static FormLink<ICollisionLayerGetter> L_TRANSPARENT => Construct(0x88764);
            public static FormLink<ICollisionLayerGetter> L_ANIMSTATIC => Construct(0x88763);
            public static FormLink<ICollisionLayerGetter> L_STATIC => Construct(0x88762);
            public static FormLink<ICollisionLayerGetter> L_UNIDENTIFIED => Construct(0x88761);
        }
    }
}
