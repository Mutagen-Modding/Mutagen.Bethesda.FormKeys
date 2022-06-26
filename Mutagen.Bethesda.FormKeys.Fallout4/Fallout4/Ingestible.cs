// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static class Ingestible
    {
        private static FormLink<IIngestibleGetter> Construct(uint id) => new FormLink<IIngestibleGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IIngestibleGetter> VRWorkshopShared_MutfruitFake => Construct(0x24a318);
        public static FormLink<IIngestibleGetter> VRWorkshopShared_WaterFake => Construct(0x24a317);
        public static FormLink<IIngestibleGetter> HC_Herbal_Antimicrobial => Construct(0x249f8f);
        public static FormLink<IIngestibleGetter> HC_Herbal_Anodyne => Construct(0x249f8e);
        public static FormLink<IIngestibleGetter> HC_Herbal_Stimulant => Construct(0x249f8d);
        public static FormLink<IIngestibleGetter> HC_AdrenalineEffect => Construct(0x249f5b);
        public static FormLink<IIngestibleGetter> HC_SippableDirtyWater => Construct(0x249f4c);
        public static FormLink<IIngestibleGetter> HC_SippableWater => Construct(0x249f3b);
        public static FormLink<IIngestibleGetter> HC_Effect_Caffeinated => Construct(0x249f33);
        public static FormLink<IIngestibleGetter> HC_Effect_Immunodeficiency => Construct(0x249f2d);
        public static FormLink<IIngestibleGetter> HC_Antibiotics_SILENT_SCRIPT_ONLY => Construct(0x249f2c);
        public static FormLink<IIngestibleGetter> HC_SleepEffect_Tired => Construct(0x818);
        public static FormLink<IIngestibleGetter> HC_SleepEffect_Overtired => Construct(0x81a);
        public static FormLink<IIngestibleGetter> HC_SleepEffect_Weary => Construct(0x81c);
        public static FormLink<IIngestibleGetter> HC_SleepEffect_Exhausted => Construct(0x81e);
        public static FormLink<IIngestibleGetter> HC_SleepEffect_Incapacitated => Construct(0x820);
        public static FormLink<IIngestibleGetter> HC_SleepEffect_Rested => Construct(0x827);
        public static FormLink<IIngestibleGetter> HC_EncumbranceEffect_OverEncumbered => Construct(0x83e);
        public static FormLink<IIngestibleGetter> HC_HungerEffect_Peckish => Construct(0x856);
        public static FormLink<IIngestibleGetter> HC_HungerEffect_Hungry => Construct(0x857);
        public static FormLink<IIngestibleGetter> HC_HungerEffect_Famished => Construct(0x858);
        public static FormLink<IIngestibleGetter> HC_HungerEffect_Ravenous => Construct(0x859);
        public static FormLink<IIngestibleGetter> HC_HungerEffect_Starving => Construct(0x85a);
        public static FormLink<IIngestibleGetter> HC_ThirstEffect_Thirsty => Construct(0x871);
        public static FormLink<IIngestibleGetter> HC_ThirstEffect_Parched => Construct(0x872);
        public static FormLink<IIngestibleGetter> HC_ThirstEffect_MildlyDehydrated => Construct(0x873);
        public static FormLink<IIngestibleGetter> HC_ThirstEffect_Dehydrated => Construct(0x874);
        public static FormLink<IIngestibleGetter> HC_ThirstEffect_SeverelyDehydrated => Construct(0x875);
        public static FormLink<IIngestibleGetter> HC_ThirstEffect_Hydrated => Construct(0x87b);
        public static FormLink<IIngestibleGetter> HC_DiseaseEffect_Insomnia => Construct(0x88b);
        public static FormLink<IIngestibleGetter> HC_DiseaseEffect_Lethargy => Construct(0x88c);
        public static FormLink<IIngestibleGetter> HC_DiseaseEffect_Fatigue => Construct(0x88d);
        public static FormLink<IIngestibleGetter> HC_DiseaseEffect_NeedMoreFood => Construct(0x88e);
        public static FormLink<IIngestibleGetter> HC_DiseaseEffect_Weakness => Construct(0x88f);
        public static FormLink<IIngestibleGetter> HC_DiseaseEffect_Infection => Construct(0x890);
        public static FormLink<IIngestibleGetter> HC_Antibiotics => Construct(0x8ab);
        public static FormLink<IIngestibleGetter> HC_Cannibal_RavenousHunger => Construct(0x8c2);
        public static FormLink<IIngestibleGetter> MS19MoleratPoison => Construct(0x249690);
        public static FormLink<IIngestibleGetter> MirelurkEgg => Construct(0x23e9d4);
        public static FormLink<IIngestibleGetter> SteakMirelurkQueen => Construct(0x21c00c);
        public static FormLink<IIngestibleGetter> FoodPackInstitute => Construct(0x21681e);
        public static FormLink<IIngestibleGetter> WaterInstitute => Construct(0x21681d);
        public static FormLink<IIngestibleGetter> steakMutantHound => Construct(0x21188e);
        public static FormLink<IIngestibleGetter> MeatMirelurkQueen => Construct(0x20d3de);
        public static FormLink<IIngestibleGetter> DN133_WineAmontillado => Construct(0x1f816a);
        public static FormLink<IIngestibleGetter> MelonWildGS => Construct(0x1f24b6);
        public static FormLink<IIngestibleGetter> BoSExperiment => Construct(0x1ee1ff);
        public static FormLink<IIngestibleGetter> SweetRollBirthday => Construct(0x1d33d2);
        public static FormLink<IIngestibleGetter> CarrotWild => Construct(0x1c4013);
        public static FormLink<IIngestibleGetter> CornWild => Construct(0x1c4012);
        public static FormLink<IIngestibleGetter> GourdWild => Construct(0x1c4011);
        public static FormLink<IIngestibleGetter> MelonWild => Construct(0x1c4010);
        public static FormLink<IIngestibleGetter> RazorgrainWild => Construct(0x1c400f);
        public static FormLink<IIngestibleGetter> MutfruitWild => Construct(0x1c400e);
        public static FormLink<IIngestibleGetter> TatoWild => Construct(0x1c400d);
        public static FormLink<IIngestibleGetter> HubFlower => Construct(0x1c3fdc);
        public static FormLink<IIngestibleGetter> BloodLeaf => Construct(0x1c25ee);
        public static FormLink<IIngestibleGetter> GlowingFungus => Construct(0x1c0fc3);
        public static FormLink<IIngestibleGetter> BrainFungus => Construct(0x1c0fc2);
        public static FormLink<IIngestibleGetter> SiltBean => Construct(0x1be2ab);
        public static FormLink<IIngestibleGetter> OmeletteEggDeathclawPristine => Construct(0x1b5cc4);
        public static FormLink<IIngestibleGetter> RRStealthBoy => Construct(0x1b5b28);
        public static FormLink<IIngestibleGetter> DNBostonCommon_BoylstonWine => Construct(0x1ad736);
        public static FormLink<IIngestibleGetter> MutfruitV81 => Construct(0x1847b6);
        public static FormLink<IIngestibleGetter> MeatGorilla => Construct(0x16ca4f);
        public static FormLink<IIngestibleGetter> DaddyO => Construct(0x156d0b);
        public static FormLink<IIngestibleGetter> DayTripper => Construct(0x150729);
        public static FormLink<IIngestibleGetter> XCell => Construct(0x1506f4);
        public static FormLink<IIngestibleGetter> MeatMutanthound => Construct(0x146156);
        public static FormLink<IIngestibleGetter> MS05BEggDeathclaw => Construct(0x134c68);
        public static FormLink<IIngestibleGetter> DN102_DruggedWater => Construct(0xa4944);
        public static FormLink<IIngestibleGetter> MeatCat => Construct(0x939b8);
        public static FormLink<IIngestibleGetter> BoSX111Compound => Construct(0x7238f);
        public static FormLink<IIngestibleGetter> TarberryWild => Construct(0x6654f);
        public static FormLink<IIngestibleGetter> Fury => Construct(0x628ca);
        public static FormLink<IIngestibleGetter> yellowBelly => Construct(0x58b0e);
        public static FormLink<IIngestibleGetter> radscorpionVenom => Construct(0x58b0c);
        public static FormLink<IIngestibleGetter> Pax => Construct(0x58af7);
        public static FormLink<IIngestibleGetter> mindCloud => Construct(0x58af5);
        public static FormLink<IIngestibleGetter> lockJoint => Construct(0x58af4);
        public static FormLink<IIngestibleGetter> Endangerol => Construct(0x58af2);
        public static FormLink<IIngestibleGetter> bleedOut => Construct(0x58aeb);
        public static FormLink<IIngestibleGetter> BloatflyLarva => Construct(0x58aea);
        public static FormLink<IIngestibleGetter> Berserk => Construct(0x58ae9);
        public static FormLink<IIngestibleGetter> SkeetoSpit => Construct(0x58abc);
        public static FormLink<IIngestibleGetter> RefreshingBeverage => Construct(0x58ab8);
        public static FormLink<IIngestibleGetter> BloodpackGlowing => Construct(0x58ab4);
        public static FormLink<IIngestibleGetter> Overdrive => Construct(0x58aad);
        public static FormLink<IIngestibleGetter> Psychobuff => Construct(0x58aac);
        public static FormLink<IIngestibleGetter> Psychotats => Construct(0x58aaa);
        public static FormLink<IIngestibleGetter> PsychoJet => Construct(0x58aa8);
        public static FormLink<IIngestibleGetter> Calmex => Construct(0x58aa7);
        public static FormLink<IIngestibleGetter> Bufftats => Construct(0x58aa5);
        public static FormLink<IIngestibleGetter> Buffjet => Construct(0x58aa3);
        public static FormLink<IIngestibleGetter> JetFuel => Construct(0x518d0);
        public static FormLink<IIngestibleGetter> OrangeMentats => Construct(0x518c5);
        public static FormLink<IIngestibleGetter> BerryMentats => Construct(0x518bb);
        public static FormLink<IIngestibleGetter> RoastYaoGuai => Construct(0x4696d);
        public static FormLink<IIngestibleGetter> stewRadStag => Construct(0x4696a);
        public static FormLink<IIngestibleGetter> steakBrahmin => Construct(0x4695a);
        public static FormLink<IIngestibleGetter> steakYaoGuai => Construct(0x46955);
        public static FormLink<IIngestibleGetter> steakRadStag => Construct(0x46952);
        public static FormLink<IIngestibleGetter> SteakRadscorpion => Construct(0x46950);
        public static FormLink<IIngestibleGetter> steakStingwing => Construct(0x46945);
        public static FormLink<IIngestibleGetter> steakMolerat => Construct(0x46943);
        public static FormLink<IIngestibleGetter> steakMirelurkSoftshell => Construct(0x46942);
        public static FormLink<IIngestibleGetter> steakMirelurk => Construct(0x46941);
        public static FormLink<IIngestibleGetter> steakDog => Construct(0x46940);
        public static FormLink<IIngestibleGetter> SteakBloodbug => Construct(0x4693f);
        public static FormLink<IIngestibleGetter> OmeletteEggMirelurk => Construct(0x4693e);
        public static FormLink<IIngestibleGetter> OmeletteEggRadscorpion => Construct(0x4693d);
        public static FormLink<IIngestibleGetter> OmeletteEggDeathclaw => Construct(0x4693c);
        public static FormLink<IIngestibleGetter> EggRadscorpion => Construct(0x4693b);
        public static FormLink<IIngestibleGetter> EggDeathclaw => Construct(0x46939);
        public static FormLink<IIngestibleGetter> SouffleDeathclaw => Construct(0x1a71e7);
        public static FormLink<IIngestibleGetter> MoldyFood01 => Construct(0x1a6397);
        public static FormLink<IIngestibleGetter> PreservedPie01 => Construct(0x1a6396);
        public static FormLink<IIngestibleGetter> MelonWarwick => Construct(0x1a0042);
        public static FormLink<IIngestibleGetter> CurieHealthpak => Construct(0x19c0d9);
        public static FormLink<IIngestibleGetter> MelonV81 => Construct(0x1994ab);
        public static FormLink<IIngestibleGetter> CarrotV81 => Construct(0x1994aa);
        public static FormLink<IIngestibleGetter> CornV81 => Construct(0x1994a9);
        public static FormLink<IIngestibleGetter> SteakRadroach => Construct(0x19797d);
        public static FormLink<IIngestibleGetter> NukaColaQuantum_Cold => Construct(0x178b25);
        public static FormLink<IIngestibleGetter> NukaColaCherry_Cold => Construct(0x178b24);
        public static FormLink<IIngestibleGetter> NukaCola_Cold => Construct(0x178b23);
        public static FormLink<IIngestibleGetter> BeerBottleStandard01_Cold => Construct(0x178b1d);
        public static FormLink<IIngestibleGetter> BeerGwinnettStout_Cold => Construct(0x178b1c);
        public static FormLink<IIngestibleGetter> BeerGwinnettPils_Cold => Construct(0x178b1b);
        public static FormLink<IIngestibleGetter> BeerGwinnettPale_Cold => Construct(0x178b1a);
        public static FormLink<IIngestibleGetter> BeerGwinnettLager_Cold => Construct(0x178b19);
        public static FormLink<IIngestibleGetter> BeerGwinnettBrew_Cold => Construct(0x178b18);
        public static FormLink<IIngestibleGetter> BeerGwinnettAle_Cold => Construct(0x178b17);
        public static FormLink<IIngestibleGetter> GourdInstitute => Construct(0x173b13);
        public static FormLink<IIngestibleGetter> LukowskisPottedMeat => Construct(0x16d8c8);
        public static FormLink<IIngestibleGetter> DogWhistle => Construct(0x14f5bf);
        public static FormLink<IIngestibleGetter> Rum => Construct(0x145857);
        public static FormLink<IIngestibleGetter> BeerBottleStandard01 => Construct(0x11ea93);
        public static FormLink<IIngestibleGetter> IguanaSoup => Construct(0x102157);
        public static FormLink<IIngestibleGetter> GrapeMentats => Construct(0x10129a);
        public static FormLink<IIngestibleGetter> UltraJet => Construct(0x101299);
        public static FormLink<IIngestibleGetter> DirtyWastelander => Construct(0x101295);
        public static FormLink<IIngestibleGetter> SteakDeathclaw => Construct(0x101293);
        public static FormLink<IIngestibleGetter> FernFlower => Construct(0xe34e9);
        public static FormLink<IIngestibleGetter> GlowingOneBlood => Construct(0xe2f68);
        public static FormLink<IIngestibleGetter> Melon => Construct(0xfafeb);
        public static FormLink<IIngestibleGetter> BeerGwinnettBrew => Construct(0xf932d);
        public static FormLink<IIngestibleGetter> BeerGwinnettAle => Construct(0xf932c);
        public static FormLink<IIngestibleGetter> BeerGwinnettLager => Construct(0xf932b);
        public static FormLink<IIngestibleGetter> BeerGwinnettPils => Construct(0xf932a);
        public static FormLink<IIngestibleGetter> BeerGwinnettPale => Construct(0xf9329);
        public static FormLink<IIngestibleGetter> Carrot => Construct(0xf742e);
        public static FormLink<IIngestibleGetter> Gourd => Construct(0xef24d);
        public static FormLink<IIngestibleGetter> MS09LorenzoSerum => Construct(0xec4f7);
        public static FormLink<IIngestibleGetter> MS17DeezerLemonade => Construct(0xe9284);
        public static FormLink<IIngestibleGetter> SugarBombs_PreWar => Construct(0xe3782);
        public static FormLink<IIngestibleGetter> SalisburySteak_PreWar => Construct(0xe3780);
        public static FormLink<IIngestibleGetter> InstaMash_PreWar => Construct(0xe377a);
        public static FormLink<IIngestibleGetter> FancyLadSnackCakes_PreWar => Construct(0xe3778);
        public static FormLink<IIngestibleGetter> BlamcoMacAndCheese_PreWar => Construct(0xe3768);
        public static FormLink<IIngestibleGetter> Razorgrain => Construct(0xe0043);
        public static FormLink<IIngestibleGetter> Tarberry => Construct(0xd981d);
        public static FormLink<IIngestibleGetter> Dogfood => Construct(0xbea58);
        public static FormLink<IIngestibleGetter> Thistle => Construct(0x9f24b);
        public static FormLink<IIngestibleGetter> Tato => Construct(0x9dcc4);
        public static FormLink<IIngestibleGetter> DN079_MeatGhoul => Construct(0x24075);
        public static FormLink<IIngestibleGetter> MeatRadscorpion => Construct(0x74d10);
        public static FormLink<IIngestibleGetter> MeatStingwing => Construct(0x74d0f);
        public static FormLink<IIngestibleGetter> MeatDeathclaw => Construct(0x74d0e);
        public static FormLink<IIngestibleGetter> MeatBloodbug => Construct(0x74d0d);
        public static FormLink<IIngestibleGetter> DN124_BuzzBites => Construct(0x6352f);
        public static FormLink<IIngestibleGetter> MS19Cure => Construct(0x55f10);
        public static FormLink<IIngestibleGetter> StealthBoy => Construct(0x4f4a6);
        public static FormLink<IIngestibleGetter> VegetableSoup => Construct(0x4a3b9);
        public static FormLink<IIngestibleGetter> GroundMolerat => Construct(0x4a3b8);
        public static FormLink<IIngestibleGetter> MirelurkCake => Construct(0x4a152);
        public static FormLink<IIngestibleGetter> SteakBloatfly => Construct(0x4a151);
        public static FormLink<IIngestibleGetter> MeatRadstag => Construct(0x4a14f);
        public static FormLink<IIngestibleGetter> MeatBrahmin => Construct(0x4a13f);
        public static FormLink<IIngestibleGetter> MeatYaoGuai => Construct(0x47660);
        public static FormLink<IIngestibleGetter> DN062FoodPaste => Construct(0x47648);
        public static FormLink<IIngestibleGetter> Addictol => Construct(0x459c5);
        public static FormLink<IIngestibleGetter> SquirrelStew => Construct(0x36927);
        public static FormLink<IIngestibleGetter> Jet => Construct(0x366c5);
        public static FormLink<IIngestibleGetter> bourbon => Construct(0x366c4);
        public static FormLink<IIngestibleGetter> Vodka => Construct(0x366c3);
        public static FormLink<IIngestibleGetter> Wine => Construct(0x366c2);
        public static FormLink<IIngestibleGetter> Whiskey => Construct(0x366c1);
        public static FormLink<IIngestibleGetter> WaterPurified => Construct(0x366c0);
        public static FormLink<IIngestibleGetter> WaterDirty => Construct(0x366bf);
        public static FormLink<IIngestibleGetter> SweetRoll => Construct(0x366be);
        public static FormLink<IIngestibleGetter> YumYumDeviledEggs => Construct(0x366bd);
        public static FormLink<IIngestibleGetter> SquirrelBits => Construct(0x366bc);
        public static FormLink<IIngestibleGetter> SquirrelStick => Construct(0x366bb);
        public static FormLink<IIngestibleGetter> SalisburySteak => Construct(0x366ba);
        public static FormLink<IIngestibleGetter> InstaMash => Construct(0x366b9);
        public static FormLink<IIngestibleGetter> Psycho => Construct(0x3377d);
        public static FormLink<IIngestibleGetter> Mentats => Construct(0x3377b);
        public static FormLink<IIngestibleGetter> MedX => Construct(0x33779);
        public static FormLink<IIngestibleGetter> Buffout => Construct(0x33778);
        public static FormLink<IIngestibleGetter> MeatRadroach => Construct(0x33106);
        public static FormLink<IIngestibleGetter> Mutfruit => Construct(0x33102);
        public static FormLink<IIngestibleGetter> MeatMolerat => Construct(0x33101);
        public static FormLink<IIngestibleGetter> MeatMirelurkSoftshell => Construct(0x33100);
        public static FormLink<IIngestibleGetter> MeatMirelurk => Construct(0x330ff);
        public static FormLink<IIngestibleGetter> IguanaStick => Construct(0x330fe);
        public static FormLink<IIngestibleGetter> IguanaBits => Construct(0x330fd);
        public static FormLink<IIngestibleGetter> Gumdrops => Construct(0x330fc);
        public static FormLink<IIngestibleGetter> Meatdog => Construct(0x330fb);
        public static FormLink<IIngestibleGetter> SquirrelBitsCrispy => Construct(0x330fa);
        public static FormLink<IIngestibleGetter> Corn => Construct(0x330f8);
        public static FormLink<IIngestibleGetter> CaveFungus => Construct(0x330f7);
        public static FormLink<IIngestibleGetter> Bubblegum => Construct(0x330f6);
        public static FormLink<IIngestibleGetter> MeatBloatfly => Construct(0x330f4);
        public static FormLink<IIngestibleGetter> SugarBombs => Construct(0x330f2);
        public static FormLink<IIngestibleGetter> PotatoCrisps => Construct(0x330f1);
        public static FormLink<IIngestibleGetter> PorknBeans => Construct(0x330f0);
        public static FormLink<IIngestibleGetter> Cram => Construct(0x330ee);
        public static FormLink<IIngestibleGetter> FancyLadSnackCakes => Construct(0x330b4);
        public static FormLink<IIngestibleGetter> DandyBoyApples => Construct(0x2fbf7);
        public static FormLink<IIngestibleGetter> BlamcoMacAndCheese => Construct(0x2fbe4);
        public static FormLink<IIngestibleGetter> Bloodpack => Construct(0x52409);
        public static FormLink<IIngestibleGetter> MoonshineBobrov => Construct(0x50c28);
        public static FormLink<IIngestibleGetter> NukaColaCherry => Construct(0x48360);
        public static FormLink<IIngestibleGetter> NukaColaQuantum => Construct(0x4835f);
        public static FormLink<IIngestibleGetter> NukaCola => Construct(0x4835d);
        public static FormLink<IIngestibleGetter> BeerGwinnettStout => Construct(0x22792);
        public static FormLink<IIngestibleGetter> NoodleCup => Construct(0x17c73);
        public static FormLink<IIngestibleGetter> Stimpak => Construct(0x23736);
        public static FormLink<IIngestibleGetter> RadAway => Construct(0x23742);
        public static FormLink<IIngestibleGetter> RadX => Construct(0x24057);
    }
}
