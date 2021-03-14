using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class AnimatedObject
        {
            private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAnimatedObjectGetter> AnimObjectIronSword => Construct(0x10fd00);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCoal => Construct(0x10c4f4);
            public static FormLink<IAnimatedObjectGetter> AnimObjectTG05Journal => Construct(0x105eea);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMQ201DrinkPlatter => Construct(0x103652);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMQ201Goblet => Construct(0x103651);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSoupSpoon => Construct(0x103275);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSilverBowl => Construct(0x103274);
            public static FormLink<IAnimatedObjectGetter> AnimObjectWoodenLadle => Construct(0x101043);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCastIronPotSmall => Construct(0x101042);
            public static FormLink<IAnimatedObjectGetter> AnimObjectChickenFeeding => Construct(0xfcc5f);
            public static FormLink<IAnimatedObjectGetter> AnimObjectStrHorn => Construct(0xf7c8e);
            public static FormLink<IAnimatedObjectGetter> AnimObjectHollowHorn => Construct(0xf7c8d);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMQ203Book => Construct(0xf5893);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBarRag => Construct(0xf5079);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMQ206Scroll => Construct(0xf44bd);
            public static FormLink<IAnimatedObjectGetter> AnimObjectDwemerExt => Construct(0xf3a94);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMQ206ScrollOpen => Construct(0xf37d2);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSkeletonKey => Construct(0xe88fa);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCuffLeftArm => Construct(0xf1c00);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCuffRightArm => Construct(0xf1bff);
            public static FormLink<IAnimatedObjectGetter> AnimObjectElderScroll => Construct(0xec9d1);
            public static FormLink<IAnimatedObjectGetter> AnimObjectLedger => Construct(0xeb058);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMetalScrap => Construct(0xeaa65);
            public static FormLink<IAnimatedObjectGetter> AnimObjectNote => Construct(0xea33a);
            public static FormLink<IAnimatedObjectGetter> AnimObjectQuill => Construct(0xea339);
            public static FormLink<IAnimatedObjectGetter> AnimObjectTGFalmerEye => Construct(0xdbe46);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMQ105Horn => Construct(0xbfa03);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSpoon => Construct(0x9e1cb);
            public static FormLink<IAnimatedObjectGetter> AnimObjectShovel => Construct(0x9c6d0);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBookPage => Construct(0x9920f);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBook => Construct(0x9920d);
            public static FormLink<IAnimatedObjectGetter> AnimObjectMortar => Construct(0x2a4d1);
            public static FormLink<IAnimatedObjectGetter> AnimObjectPestle => Construct(0x2a47b);
            public static FormLink<IAnimatedObjectGetter> AnimObjectIronDagger => Construct(0x727a7);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSellPotion => Construct(0xe7332);
            public static FormLink<IAnimatedObjectGetter> AnimObjectDrinkPotion => Construct(0xd36c8);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBlacksmithForgeHammer => Construct(0xcae10);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBlacksmithForgeIron => Construct(0xcae0f);
            public static FormLink<IAnimatedObjectGetter> AnimObjectHammerWall => Construct(0xc4324);
            public static FormLink<IAnimatedObjectGetter> AnimObjectHammerTable => Construct(0x62834);
            public static FormLink<IAnimatedObjectGetter> AnimObjectHoe => Construct(0x31985);
            public static FormLink<IAnimatedObjectGetter> AnimObjectPickAxeWall => Construct(0x31983);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCarryFirewood03 => Construct(0x8de73);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCarryFirewood02 => Construct(0x8de72);
            public static FormLink<IAnimatedObjectGetter> AnimObjectCarryFirewood01 => Construct(0x8de71);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBoundKneesLeatherCuffs => Construct(0x8de6f);
            public static FormLink<IAnimatedObjectGetter> AnimObjectExecutionerAxe => Construct(0x2e8e5);
            public static FormLink<IAnimatedObjectGetter> AnimObjectFlowerBasket => Construct(0xb1957);
            public static FormLink<IAnimatedObjectGetter> AnimObjectLog => Construct(0xb18f2);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBasket => Construct(0xb18f1);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBucket => Construct(0xb18f0);
            public static FormLink<IAnimatedObjectGetter> AnimObjectTankard => Construct(0x97274);
            public static FormLink<IAnimatedObjectGetter> AnimObjectDrum => Construct(0x93644);
            public static FormLink<IAnimatedObjectGetter> AnimObjectLute => Construct(0x93643);
            public static FormLink<IAnimatedObjectGetter> AnimObjectFlute => Construct(0x93642);
            public static FormLink<IAnimatedObjectGetter> AnimObjectHook => Construct(0x71c4b);
            public static FormLink<IAnimatedObjectGetter> AnimObjectChopWoodRight => Construct(0x6c1e3);
            public static FormLink<IAnimatedObjectGetter> AnimObjectChopWoodLeft => Construct(0x6c1e2);
            public static FormLink<IAnimatedObjectGetter> AnimObjectAxe => Construct(0x6c1e1);
            public static FormLink<IAnimatedObjectGetter> AnimObjectSweeping => Construct(0x64115);
            public static FormLink<IAnimatedObjectGetter> AnimObjectBread => Construct(0x64101);
            public static FormLink<IAnimatedObjectGetter> BlackSmithHotIronAnimObject => Construct(0x58e94);
            public static FormLink<IAnimatedObjectGetter> BlackSmithHammerAnimObject => Construct(0x48a7d);
        }
    }
}
