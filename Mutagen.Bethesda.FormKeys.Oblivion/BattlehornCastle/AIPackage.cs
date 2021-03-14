using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class AIPackage
        {
            private static FormLink<IAIPackageGetter> Construct(uint id) => new FormLink<IAIPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAIPackageGetter> BattlehornCaptainSleep => Construct(0xca47);
            public static FormLink<IAIPackageGetter> BattlehornKnightStartPatrolNightInterior1 => Construct(0xcf30);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrolInterior1to2Night => Construct(0xcf32);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrolInterior2to3Night => Construct(0xcf33);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrolInterior3to2Day => Construct(0xcf35);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrolInterior1to3Day => Construct(0xcf36);
            public static FormLink<IAIPackageGetter> BattlehornKnightStartPatrolDayInterior2 => Construct(0xcf37);
            public static FormLink<IAIPackageGetter> BattlehornCaptainPracticeMelee1 => Construct(0xcf39);
            public static FormLink<IAIPackageGetter> BattlehornCaptainRandomPatrol1 => Construct(0xcf3a);
            public static FormLink<IAIPackageGetter> BattlehornKnightFollowPlayer3 => Construct(0x11f08);
            public static FormLink<IAIPackageGetter> BattlehornKnightWaitHerePlayer3 => Construct(0x11f09);
            public static FormLink<IAIPackageGetter> BattlehornKnightFollowPlayer4 => Construct(0x11f0a);
            public static FormLink<IAIPackageGetter> BattlehornKnightWaitHerePlayer4 => Construct(0x11f0b);
            public static FormLink<IAIPackageGetter> BattlehornKnightCaptainFollowPlayer5 => Construct(0x11f0c);
            public static FormLink<IAIPackageGetter> BattlehornKnightCaptainWaitHerePlayer5 => Construct(0x11f0d);
            public static FormLink<IAIPackageGetter> BattlehornCaptainReadInChair => Construct(0xcf3b);
            public static FormLink<IAIPackageGetter> BattlehornTrainerPracticeArchery => Construct(0xc026);
            public static FormLink<IAIPackageGetter> BattlehornTrainerPracticeMelee2 => Construct(0xc027);
            public static FormLink<IAIPackageGetter> BattlehornTrainerPracticeMelee3 => Construct(0xc028);
            public static FormLink<IAIPackageGetter> BattlehornTrainerPracticeHandToHand => Construct(0xc02a);
            public static FormLink<IAIPackageGetter> BattlehornNilphasEats => Construct(0xb091);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineA => Construct(0xb604);
            public static FormLink<IAIPackageGetter> BattlehornNilphasSleeps => Construct(0xb08f);
            public static FormLink<IAIPackageGetter> BattlehornSmithWanderExterior => Construct(0xc518);
            public static FormLink<IAIPackageGetter> BattlehornDogFollowBlacksmith => Construct(0xc519);
            public static FormLink<IAIPackageGetter> BattlehornKnightDeliverMessage => Construct(0xd430);
            public static FormLink<IAIPackageGetter> BattlehornDinnerGreatHall => Construct(0xc51c);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistSleep => Construct(0xb0b2);
            public static FormLink<IAIPackageGetter> BattlehornNilphasOfferServices => Construct(0xb090);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistUseItem1 => Construct(0xb59a);
            public static FormLink<IAIPackageGetter> BattlehornKnightFollowPlayer => Construct(0xd438);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistUseItem2 => Construct(0xb59b);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistUseItem3 => Construct(0xb59c);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineB => Construct(0xb615);
            public static FormLink<IAIPackageGetter> BattlehornMaidSleep => Construct(0xd443);
            public static FormLink<IAIPackageGetter> BattlehornMaidBreakfast => Construct(0xd444);
            public static FormLink<IAIPackageGetter> BattlehornMaidDinner => Construct(0xd445);
            public static FormLink<IAIPackageGetter> BattlehornMaidWander1 => Construct(0xd447);
            public static FormLink<IAIPackageGetter> BattlehornMaidWander2 => Construct(0xd448);
            public static FormLink<IAIPackageGetter> BattlehornMaidWander3 => Construct(0xd449);
            public static FormLink<IAIPackageGetter> BattlehornMaidWanderBase => Construct(0xd44a);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineC => Construct(0xb616);
            public static FormLink<IAIPackageGetter> BattlehornCookSleep => Construct(0xd44e);
            public static FormLink<IAIPackageGetter> BattlehornCookBreakfast => Construct(0xd44f);
            public static FormLink<IAIPackageGetter> BattlehornCookWander1 => Construct(0xd450);
            public static FormLink<IAIPackageGetter> BattlehornCookWander2 => Construct(0xd451);
            public static FormLink<IAIPackageGetter> BattlehornCookServeDinnerGreatHall => Construct(0xd452);
            public static FormLink<IAIPackageGetter> BattlehornCookServeDinnerGreatHallWander => Construct(0xd453);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineD => Construct(0xb617);
            public static FormLink<IAIPackageGetter> BattlehornBlacksmithStayInside => Construct(0x13420);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineE => Construct(0xb618);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineF => Construct(0xb619);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyA => Construct(0xc539);
            public static FormLink<IAIPackageGetter> BattlehornMaidFollowPlayer => Construct(0xde26);
            public static FormLink<IAIPackageGetter> BattlehornMarauderOpenGate => Construct(0x1342b);
            public static FormLink<IAIPackageGetter> BattlehornKnightWelcomePlayerExterior => Construct(0x1342c);
            public static FormLink<IAIPackageGetter> BattlehornKnight1DefendCastle => Construct(0x1342d);
            public static FormLink<IAIPackageGetter> BattlehornKnight2DefendCastle => Construct(0x1342e);
            public static FormLink<IAIPackageGetter> BattlehornTrainerSleep => Construct(0xc009);
            public static FormLink<IAIPackageGetter> BattlehornMarauderInvadeCastle => Construct(0x13917);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyB => Construct(0xc53b);
            public static FormLink<IAIPackageGetter> BattlehornNilphasMeetPlayer => Construct(0x1391b);
            public static FormLink<IAIPackageGetter> BattlehornNilphasWalksHome => Construct(0x1391d);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyC => Construct(0xc53c);
            public static FormLink<IAIPackageGetter> BattlehornMarauderSleep0x6 => Construct(0x142ea);
            public static FormLink<IAIPackageGetter> BattlehornMarauderEat11x2 => Construct(0x142eb);
            public static FormLink<IAIPackageGetter> BattlehornMarauderSleepMasterBedroom => Construct(0x142ec);
            public static FormLink<IAIPackageGetter> BattlehornMarauderEat18x2 => Construct(0x142ed);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyD => Construct(0xc53d);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyE => Construct(0xc53e);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyF => Construct(0xc53f);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyG => Construct(0xc540);
            public static FormLink<IAIPackageGetter> BattlehornTaxidermistMakeTrophyH => Construct(0xc541);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineG => Construct(0xb61a);
            public static FormLink<IAIPackageGetter> BattlehornKnightWelcomePlayer => Construct(0xca2d);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineCheap => Construct(0xb61b);
            public static FormLink<IAIPackageGetter> BattlehornVintnerMakeWineMead => Construct(0xb61c);
            public static FormLink<IAIPackageGetter> BattlehornKnightStartPatrolDay => Construct(0xca35);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrol1to2Day => Construct(0xca36);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrol2to3Day => Construct(0xca37);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrol3to4Day => Construct(0xca38);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrol1to2Night => Construct(0xca39);
            public static FormLink<IAIPackageGetter> BattlehornKnightStartPatrolNight => Construct(0xca3a);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrol2to3Night => Construct(0xca3b);
            public static FormLink<IAIPackageGetter> BattlehornKnightPatrol3to4Night => Construct(0xca3c);
            public static FormLink<IAIPackageGetter> BattlehornKnightBaseWander => Construct(0xca3d);
            public static FormLink<IAIPackageGetter> BattlehornTrainerBaseWander => Construct(0xc010);
            public static FormLink<IAIPackageGetter> BattlehornVintnerUseItem1 => Construct(0xb61d);
            public static FormLink<IAIPackageGetter> BattlehornKnightWaitHerePlayer => Construct(0x11028);
            public static FormLink<IAIPackageGetter> BattlehornKnightDeliverMessage2 => Construct(0x1657d);
            public static FormLink<IAIPackageGetter> BattlehornKnightFollowPlayer2 => Construct(0x11029);
            public static FormLink<IAIPackageGetter> BattlehornKnightWaitHerePlayer2 => Construct(0x1102a);
            public static FormLink<IAIPackageGetter> BattlehornTrainerStartSparring => Construct(0xc012);
            public static FormLink<IAIPackageGetter> BattlehornVintnerSleep => Construct(0xb59d);
            public static FormLink<IAIPackageGetter> BattlehornTrainerPracticeMelee1 => Construct(0xc024);
        }
    }
}
