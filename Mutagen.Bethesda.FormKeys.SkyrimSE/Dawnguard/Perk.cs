using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Perk
        {
            private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPerkGetter> DLC1HarkonTurningImmunity => Construct(0x14cce);
            public static FormLink<IPerkGetter> DLC1VampireSeductionBoost => Construct(0x1459d);
            public static FormLink<IPerkGetter> DLC1VyrthurArmorBoost => Construct(0x138c3);
            public static FormLink<IPerkGetter> DLC1BestialStrength100Perk => Construct(0x11cfb);
            public static FormLink<IPerkGetter> DLC1BestialStrength75Perk => Construct(0x11cfa);
            public static FormLink<IPerkGetter> DLC1DawnguardItemPerk => Construct(0xd83a);
            public static FormLink<IPerkGetter> DLC1VampireFeedDexionVampireSeduction => Construct(0x5054);
            public static FormLink<IPerkGetter> DLC1EnchancedCrossbowArmorPiercingPerk => Construct(0x399b);
            public static FormLink<IPerkGetter> DLC1DurnehviirMultipleSummon => Construct(0x1a33c);
            public static FormLink<IPerkGetter> DLC1AurielsArrowsBlocker => Construct(0x1a189);
            public static FormLink<IPerkGetter> DLC1crExtraDamageScales03 => Construct(0x1a172);
            public static FormLink<IPerkGetter> DLC1crExtraDamageScales025 => Construct(0x1a171);
            public static FormLink<IPerkGetter> DLC1crExtraDamageScales015 => Construct(0x1a170);
            public static FormLink<IPerkGetter> DLC1crExtraDamageScales02 => Construct(0x1a16f);
            public static FormLink<IPerkGetter> DLC1GargoylePerk => Construct(0x16908);
            public static FormLink<IPerkGetter> DLC1crFalmerPoison06 => Construct(0x15cae);
            public static FormLink<IPerkGetter> crReduceDamage035 => Construct(0x15c62);
            public static FormLink<IPerkGetter> DLC1LD_AetherialShieldPerk => Construct(0x142ac);
            public static FormLink<IPerkGetter> DLC1VampireActivationBlocker => Construct(0x110cf);
            public static FormLink<IPerkGetter> DLC1LDPerk => Construct(0xd00b);
            public static FormLink<IPerkGetter> DLC1LD_AetherialCrownPerk => Construct(0xd00a);
            public static FormLink<IPerkGetter> DLC1VampireSleepPerk => Construct(0x8e3f);
            public static FormLink<IPerkGetter> DLC1CorpseCursePerk => Construct(0x8a70);
            public static FormLink<IPerkGetter> DLC1PlayerWerewolfSavageFeeding => Construct(0x8a6e);
            public static FormLink<IPerkGetter> DLC1BestialStrength50Perk => Construct(0x7a3f);
            public static FormLink<IPerkGetter> DLC1TotemOfTheMoonPerk => Construct(0x59ab);
            public static FormLink<IPerkGetter> DLC1TotemOfIceBrothersPerk => Construct(0x59aa);
            public static FormLink<IPerkGetter> DLC1TotemPredatorPerk => Construct(0x59a9);
            public static FormLink<IPerkGetter> DLC1TotemOfTerrorPerk => Construct(0x59a8);
            public static FormLink<IPerkGetter> DLC1GorgingPerk => Construct(0x59a7);
            public static FormLink<IPerkGetter> DLC1SavageFeedingPerk => Construct(0x59a6);
            public static FormLink<IPerkGetter> DLC1AnimalVigorPerk => Construct(0x59a5);
            public static FormLink<IPerkGetter> DLC1BestialStrength25Perk => Construct(0x59a4);
            public static FormLink<IPerkGetter> DLC1SupernaturalReflexesPerk => Construct(0x599e);
            public static FormLink<IPerkGetter> DLC1MistFormPerk => Construct(0x599c);
            public static FormLink<IPerkGetter> DLC1DetectLifePerk => Construct(0x599b);
            public static FormLink<IPerkGetter> DLC1VampiricGrip => Construct(0x599a);
            public static FormLink<IPerkGetter> DLC1PowerOfTheGrave => Construct(0x5998);
            public static FormLink<IPerkGetter> DLC1NightCloakPerk => Construct(0x5997);
            public static FormLink<IPerkGetter> DLC1PoisonTalons => Construct(0x5996);
            public static FormLink<IPerkGetter> DLC1UnearthlyWill => Construct(0x5995);
            public static FormLink<IPerkGetter> DLC1VampiricBite => Construct(0x5994);
            public static FormLink<IPerkGetter> DLC1VampireTurnPerk => Construct(0x588b);
        }
    }
}
