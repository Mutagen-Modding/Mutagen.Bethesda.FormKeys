using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class BodyPartData
        {
            private static FormLink<IBodyPartDataGetter> Construct(uint id) => new FormLink<IBodyPartDataGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBodyPartDataGetter> ChickenBodyPartData => Construct(0xa919e);
            public static FormLink<IBodyPartDataGetter> HareBodyPartData => Construct(0x6dc9c);
            public static FormLink<IBodyPartDataGetter> WerewolfBeastBodyPartData => Construct(0xcdd85);
            public static FormLink<IBodyPartDataGetter> MudcrabPartData => Construct(0xba549);
            public static FormLink<IBodyPartDataGetter> SprigganBodyPartData => Construct(0xa0420);
            public static FormLink<IBodyPartDataGetter> HagravenBodyPartData => Construct(0x97242);
            public static FormLink<IBodyPartDataGetter> TrollBodyPartData => Construct(0x92c93);
            public static FormLink<IBodyPartDataGetter> HorkerBodyPartData => Construct(0x8ca6b);
            public static FormLink<IBodyPartDataGetter> WispBodyPartData => Construct(0x42529);
            public static FormLink<IBodyPartDataGetter> WitchlightBodyPartData => Construct(0x86f43);
            public static FormLink<IBodyPartDataGetter> AtronachFlameBodyPartData => Construct(0x8691c);
            public static FormLink<IBodyPartDataGetter> BearBodyPartData => Construct(0x868fc);
            public static FormLink<IBodyPartDataGetter> DwarvenSpiderPartData => Construct(0x81c7a);
            public static FormLink<IBodyPartDataGetter> DwarvenSteamCenturionBodyPartData => Construct(0x800ec);
            public static FormLink<IBodyPartDataGetter> DwarvenSphereCenturionBodyPartData => Construct(0x7874d);
            public static FormLink<IBodyPartDataGetter> DeerBodyPartData => Construct(0x76b30);
            public static FormLink<IBodyPartDataGetter> MammothBodyPartData => Construct(0x59255);
            public static FormLink<IBodyPartDataGetter> GoatBodyPartData => Construct(0x6f276);
            public static FormLink<IBodyPartDataGetter> AtronachStormBodyPartData => Construct(0x6b7c9);
            public static FormLink<IBodyPartDataGetter> HorseBodyPartData => Construct(0x60716);
            public static FormLink<IBodyPartDataGetter> FalmerBodyPartData => Construct(0x5dda2);
            public static FormLink<IBodyPartDataGetter> AtronachFrostBodyPartData => Construct(0x5b2e9);
            public static FormLink<IBodyPartDataGetter> ChaurusBodyPartData => Construct(0x59060);
            public static FormLink<IBodyPartDataGetter> IceWraithBodyPartData => Construct(0x538f9);
            public static FormLink<IBodyPartDataGetter> GiantBodyPartData => Construct(0x517ab);
            public static FormLink<IBodyPartDataGetter> DogBodyPartData => Construct(0x4fbf5);
            public static FormLink<IBodyPartDataGetter> CowBodyPartData => Construct(0x4e782);
            public static FormLink<IBodyPartDataGetter> SkeeverBodyPartData => Construct(0x264ef);
            public static FormLink<IBodyPartDataGetter> DraugrBodyPartData => Construct(0x48c13);
            public static FormLink<IBodyPartDataGetter> DragonPriestBodyPartData => Construct(0x43592);
            public static FormLink<IBodyPartDataGetter> SlaughterfishBodyPartData => Construct(0x40c6a);
            public static FormLink<IBodyPartDataGetter> FrostbiteSpiderPartData => Construct(0x17929);
            public static FormLink<IBodyPartDataGetter> SabreCatBodyPartData => Construct(0x20e26);
            public static FormLink<IBodyPartDataGetter> DragonBodyPartData => Construct(0x13492);
            public static FormLink<IBodyPartDataGetter> DefaultBodyPartData => Construct(0x1d);
        }
    }
}
