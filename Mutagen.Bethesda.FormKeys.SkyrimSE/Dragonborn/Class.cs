using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Class
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IClassGetter> Construct(uint id) => new FormLink<IClassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClassGetter> DLC2EncClassAshGuardian => Construct(0x3cf6a);
            public static FormLink<IClassGetter> DLC2EncClassSeeker => Construct(0x3c6a3);
            public static FormLink<IClassGetter> DLC2EncClassRiekling => Construct(0x3bd08);
            public static FormLink<IClassGetter> DLC2NPCClassTeldryn => Construct(0x38561);
            public static FormLink<IClassGetter> DLC2dunHaknirClass => Construct(0x37feb);
            public static FormLink<IClassGetter> DLC2EncClassLurker => Construct(0x3183a);
            public static FormLink<IClassGetter> DLC2csFrea => Construct(0x30cca);
            public static FormLink<IClassGetter> DLC2EbonyWarriorClass => Construct(0x285c2);
            public static FormLink<IClassGetter> DLC2dunKarstaagClass => Construct(0x28213);
            public static FormLink<IClassGetter> dlc2DBAncientDragonbornClass => Construct(0x265af);
            public static FormLink<IClassGetter> DLC2EncClassMiraak => Construct(0x23f78);
            public static FormLink<IClassGetter> DLC2EncClassAshHopper => Construct(0x20e8a);
            public static FormLink<IClassGetter> DLC2EncClassBanditBoss => Construct(0x1e8ac);
            public static FormLink<IClassGetter> DLC2dunKolbjornRalisClass => Construct(0x179c6);
            public static FormLink<IClassGetter> DLC2NelothClassTrainer => Construct(0x17774);
        }
    }
}
