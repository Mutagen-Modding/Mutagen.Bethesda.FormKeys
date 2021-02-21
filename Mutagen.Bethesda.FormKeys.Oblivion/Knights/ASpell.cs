using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Knights.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> NDAbGhostResist => Construct(0xdf6);
            public static FormLink<IASpellGetter> TestResistMagicka => Construct(0xdf7);
            public static FormLink<IASpellGetter> ND06AltarSpell => Construct(0xdf8);
            public static FormLink<IASpellGetter> NDAbRewardBlessing08 => Construct(0xdf9);
            public static FormLink<IASpellGetter> NDAbRewardBlessing07 => Construct(0xdfa);
            public static FormLink<IASpellGetter> NDAbRewardBlessing06 => Construct(0xdfb);
            public static FormLink<IASpellGetter> NDAbRewardBlessing05 => Construct(0xdfc);
            public static FormLink<IASpellGetter> NDAbRewardBlessing04 => Construct(0xdfd);
            public static FormLink<IASpellGetter> NDAbRewardBlessing03 => Construct(0xdfe);
            public static FormLink<IASpellGetter> NDAbRewardBlessing02 => Construct(0xdff);
            public static FormLink<IASpellGetter> NDAbRewardBlessing01 => Construct(0xe00);
            public static FormLink<IASpellGetter> NDAbArmorCumulative => Construct(0xe01);
            public static FormLink<IASpellGetter> NDAbUmarilArmorReact => Construct(0xe02);
            public static FormLink<IASpellGetter> NDAbGhostNPC => Construct(0xe03);
            public static FormLink<IASpellGetter> NDAbWoodlandGrace => Construct(0xe04);
            public static FormLink<IASpellGetter> NDAbSwordFortBlade => Construct(0xe05);
            public static FormLink<IASpellGetter> NDLpGauntletsHealOther => Construct(0xe06);
            public static FormLink<IASpellGetter> NDAbUmarilWeakFire => Construct(0xe07);
            public static FormLink<IASpellGetter> NDLpGreavesShieldOther => Construct(0xe08);
            public static FormLink<IASpellGetter> NDLpHelmetCalm => Construct(0xe09);
            public static FormLink<IASpellGetter> NDAbMaceFortBlunt => Construct(0xe0a);
            public static FormLink<IASpellGetter> NDAbSpiritNPC => Construct(0xe0b);
            public static FormLink<IASpellGetter> NDBlessingOfTalos => Construct(0xe0c);
            public static FormLink<IASpellGetter> NDLpUmaril1ShockDam => Construct(0xe0d);
            public static FormLink<IASpellGetter> NDLpUmaril8ShockDam => Construct(0xe0e);
            public static FormLink<IASpellGetter> NDLpUmaril7ShockDam => Construct(0xe0f);
            public static FormLink<IASpellGetter> NDLpUmaril6ShockDam => Construct(0xe10);
            public static FormLink<IASpellGetter> NDLpUmaril5ShockDam => Construct(0xe11);
            public static FormLink<IASpellGetter> NDLpUmaril4ShockDam => Construct(0xe12);
            public static FormLink<IASpellGetter> NDLpUmaril3ShockDam => Construct(0xe13);
            public static FormLink<IASpellGetter> NDLpUmaril2ShockDam => Construct(0xe14);
            public static FormLink<IASpellGetter> NDAbUmarilResist => Construct(0xe15);
            public static FormLink<IASpellGetter> NDLpAuroran5ShockShield => Construct(0xe16);
            public static FormLink<IASpellGetter> NDLpAuroran5ShockDam => Construct(0xe17);
            public static FormLink<IASpellGetter> NDLpAuroran4ShockShield => Construct(0xe18);
            public static FormLink<IASpellGetter> NDLpAuroran4ShockDam => Construct(0xe19);
            public static FormLink<IASpellGetter> NDLpAuroran3ShockShield => Construct(0xe1a);
            public static FormLink<IASpellGetter> NDLpAuroran3ShockDam => Construct(0xe1b);
            public static FormLink<IASpellGetter> NDLpAuroran1ShockShield => Construct(0xe1c);
            public static FormLink<IASpellGetter> NDLpAuroran1ShockDam => Construct(0xe1d);
            public static FormLink<IASpellGetter> NDLpAuroran2ShockShield => Construct(0xe1e);
            public static FormLink<IASpellGetter> NDLpAuroran2ShockDam => Construct(0xe1f);
            public static FormLink<IASpellGetter> NDAbAuroranResist => Construct(0xe20);
            public static FormLink<IASpellGetter> ND10TimeStopParalyze => Construct(0xe21);
            public static FormLink<IASpellGetter> ND10TimeStopParalysis => Construct(0xe22);
            public static FormLink<IASpellGetter> ND10TimeStopSpell => Construct(0xe23);
            public static FormLink<IASpellGetter> NDTESTAbRegen => Construct(0xe24);
            public static FormLink<IASpellGetter> ND06LayHands => Construct(0xe25);
            public static FormLink<IASpellGetter> ND06Curse => Construct(0xe26);
            public static FormLink<IASpellGetter> TRAPShockArea03 => Construct(0xe27);
            public static FormLink<IASpellGetter> TRAPShockArea02 => Construct(0xe28);
            public static FormLink<IASpellGetter> TRAPShockArea01 => Construct(0xe29);
            public static FormLink<IASpellGetter> TRAPShockArea05 => Construct(0xe2a);
            public static FormLink<IASpellGetter> TRAPShockArea06 => Construct(0xe2b);
            public static FormLink<IASpellGetter> TRAPShockArea04 => Construct(0xe2c);
            public static FormLink<IASpellGetter> ND08SwordCurse => Construct(0xe2d);
        }
    }
}
