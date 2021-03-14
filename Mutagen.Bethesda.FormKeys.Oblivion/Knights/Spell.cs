using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> NDAbGhostResist => Construct(0xdf6);
            public static FormLink<ISpellGetter> TestResistMagicka => Construct(0xdf7);
            public static FormLink<ISpellGetter> ND06AltarSpell => Construct(0xdf8);
            public static FormLink<ISpellGetter> NDAbRewardBlessing08 => Construct(0xdf9);
            public static FormLink<ISpellGetter> NDAbRewardBlessing07 => Construct(0xdfa);
            public static FormLink<ISpellGetter> NDAbRewardBlessing06 => Construct(0xdfb);
            public static FormLink<ISpellGetter> NDAbRewardBlessing05 => Construct(0xdfc);
            public static FormLink<ISpellGetter> NDAbRewardBlessing04 => Construct(0xdfd);
            public static FormLink<ISpellGetter> NDAbRewardBlessing03 => Construct(0xdfe);
            public static FormLink<ISpellGetter> NDAbRewardBlessing02 => Construct(0xdff);
            public static FormLink<ISpellGetter> NDAbRewardBlessing01 => Construct(0xe00);
            public static FormLink<ISpellGetter> NDAbArmorCumulative => Construct(0xe01);
            public static FormLink<ISpellGetter> NDAbUmarilArmorReact => Construct(0xe02);
            public static FormLink<ISpellGetter> NDAbGhostNPC => Construct(0xe03);
            public static FormLink<ISpellGetter> NDAbWoodlandGrace => Construct(0xe04);
            public static FormLink<ISpellGetter> NDAbSwordFortBlade => Construct(0xe05);
            public static FormLink<ISpellGetter> NDLpGauntletsHealOther => Construct(0xe06);
            public static FormLink<ISpellGetter> NDAbUmarilWeakFire => Construct(0xe07);
            public static FormLink<ISpellGetter> NDLpGreavesShieldOther => Construct(0xe08);
            public static FormLink<ISpellGetter> NDLpHelmetCalm => Construct(0xe09);
            public static FormLink<ISpellGetter> NDAbMaceFortBlunt => Construct(0xe0a);
            public static FormLink<ISpellGetter> NDAbSpiritNPC => Construct(0xe0b);
            public static FormLink<ISpellGetter> NDBlessingOfTalos => Construct(0xe0c);
            public static FormLink<ISpellGetter> NDLpUmaril1ShockDam => Construct(0xe0d);
            public static FormLink<ISpellGetter> NDLpUmaril8ShockDam => Construct(0xe0e);
            public static FormLink<ISpellGetter> NDLpUmaril7ShockDam => Construct(0xe0f);
            public static FormLink<ISpellGetter> NDLpUmaril6ShockDam => Construct(0xe10);
            public static FormLink<ISpellGetter> NDLpUmaril5ShockDam => Construct(0xe11);
            public static FormLink<ISpellGetter> NDLpUmaril4ShockDam => Construct(0xe12);
            public static FormLink<ISpellGetter> NDLpUmaril3ShockDam => Construct(0xe13);
            public static FormLink<ISpellGetter> NDLpUmaril2ShockDam => Construct(0xe14);
            public static FormLink<ISpellGetter> NDAbUmarilResist => Construct(0xe15);
            public static FormLink<ISpellGetter> NDLpAuroran5ShockShield => Construct(0xe16);
            public static FormLink<ISpellGetter> NDLpAuroran5ShockDam => Construct(0xe17);
            public static FormLink<ISpellGetter> NDLpAuroran4ShockShield => Construct(0xe18);
            public static FormLink<ISpellGetter> NDLpAuroran4ShockDam => Construct(0xe19);
            public static FormLink<ISpellGetter> NDLpAuroran3ShockShield => Construct(0xe1a);
            public static FormLink<ISpellGetter> NDLpAuroran3ShockDam => Construct(0xe1b);
            public static FormLink<ISpellGetter> NDLpAuroran1ShockShield => Construct(0xe1c);
            public static FormLink<ISpellGetter> NDLpAuroran1ShockDam => Construct(0xe1d);
            public static FormLink<ISpellGetter> NDLpAuroran2ShockShield => Construct(0xe1e);
            public static FormLink<ISpellGetter> NDLpAuroran2ShockDam => Construct(0xe1f);
            public static FormLink<ISpellGetter> NDAbAuroranResist => Construct(0xe20);
            public static FormLink<ISpellGetter> ND10TimeStopParalyze => Construct(0xe21);
            public static FormLink<ISpellGetter> ND10TimeStopParalysis => Construct(0xe22);
            public static FormLink<ISpellGetter> ND10TimeStopSpell => Construct(0xe23);
            public static FormLink<ISpellGetter> NDTESTAbRegen => Construct(0xe24);
            public static FormLink<ISpellGetter> ND06LayHands => Construct(0xe25);
            public static FormLink<ISpellGetter> ND06Curse => Construct(0xe26);
            public static FormLink<ISpellGetter> TRAPShockArea03 => Construct(0xe27);
            public static FormLink<ISpellGetter> TRAPShockArea02 => Construct(0xe28);
            public static FormLink<ISpellGetter> TRAPShockArea01 => Construct(0xe29);
            public static FormLink<ISpellGetter> TRAPShockArea05 => Construct(0xe2a);
            public static FormLink<ISpellGetter> TRAPShockArea06 => Construct(0xe2b);
            public static FormLink<ISpellGetter> TRAPShockArea04 => Construct(0xe2c);
            public static FormLink<ISpellGetter> ND08SwordCurse => Construct(0xe2d);
        }
    }
}
