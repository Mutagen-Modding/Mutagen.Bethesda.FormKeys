using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ObjectEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IObjectEffectGetter> Construct(uint id) => new FormLink<IObjectEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IObjectEffectGetter> DLC1DawnguardRuneHammerEnchant => Construct(0x14556);
            public static FormLink<IObjectEffectGetter> DLC1HarkonsSwordAbsorbHMS => Construct(0x11ee9);
            public static FormLink<IObjectEffectGetter> TrapPoisonBloomGasEnch06 => Construct(0xf3cc);
            public static FormLink<IObjectEffectGetter> TrapPoisonBloomGasEnch05 => Construct(0xf3cb);
            public static FormLink<IObjectEffectGetter> TrapPoisonBloomGasEnch04 => Construct(0xf3ca);
            public static FormLink<IObjectEffectGetter> TrapPoisonBloomGasEnch03 => Construct(0xf3c9);
            public static FormLink<IObjectEffectGetter> TrapPoisonBloomGasEnch02 => Construct(0xf3c8);
            public static FormLink<IObjectEffectGetter> TrapPoisonBloomGasEnch01 => Construct(0xf3c7);
            public static FormLink<IObjectEffectGetter> DLC1nVampireBloodMagicRingEruditeEnch => Construct(0xe802);
            public static FormLink<IObjectEffectGetter> DLC1nVampireBloodMagicRingBeastEnch => Construct(0xe801);
            public static FormLink<IObjectEffectGetter> DLC1nVampireMagicaDrainClawsENCH => Construct(0xe7ea);
            public static FormLink<IObjectEffectGetter> DLC1nVampireBloodPlagueENCH => Construct(0xe7b5);
            public static FormLink<IObjectEffectGetter> DLC1DawnguardRuneVisualsEnchantment => Construct(0x6923);
            public static FormLink<IObjectEffectGetter> DLC1VampBatsAmulet => Construct(0x68af);
            public static FormLink<IObjectEffectGetter> DLC1EnchArmorJiubNecklace => Construct(0x1951a);
            public static FormLink<IObjectEffectGetter> DLC1DawnguardRuneAxeExtraDamage => Construct(0x1668f);
            public static FormLink<IObjectEffectGetter> DLCEnchAurielsBowBlessed => Construct(0x15718);
            public static FormLink<IObjectEffectGetter> DLC1LD_SteamEnch => Construct(0x1533e);
            public static FormLink<IObjectEffectGetter> DLC1LD_LavaEnch => Construct(0x1533d);
            public static FormLink<IObjectEffectGetter> DLC1LD_AetherialStaffEnch => Construct(0x142b1);
            public static FormLink<IObjectEffectGetter> DLC1LD_EnchKatriaBow => Construct(0x142aa);
            public static FormLink<IObjectEffectGetter> DLC1LD_EnchAetherialArmorNull => Construct(0xcfa9);
            public static FormLink<IObjectEffectGetter> DLCEnchAurielsBow => Construct(0x71df);
            public static FormLink<IObjectEffectGetter> DLC1SoulCairnCrystalEnch01 => Construct(0x69c5);
            public static FormLink<IObjectEffectGetter> DLC1EnchArmorReflectingShield => Construct(0x488b);
            public static FormLink<IObjectEffectGetter> TestEnchAxeFX => Construct(0x427c);
        }
    }
}
