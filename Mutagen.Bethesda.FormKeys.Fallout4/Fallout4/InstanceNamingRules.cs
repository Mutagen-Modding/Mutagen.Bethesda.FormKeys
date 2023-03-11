// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static class InstanceNamingRules
    {
        private static FormLink<IInstanceNamingRulesGetter> Construct(uint id) => new FormLink<IInstanceNamingRulesGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IInstanceNamingRulesGetter> dn_VaultSuit => Construct(0x23c063);
        public static FormLink<IInstanceNamingRulesGetter> dn_BACKUP => Construct(0x23844c);
        public static FormLink<IInstanceNamingRulesGetter> dn_CommonGun => Construct(0x2377cf);
        public static FormLink<IInstanceNamingRulesGetter> dn_Clothes => Construct(0x20de44);
        public static FormLink<IInstanceNamingRulesGetter> dn_CommonMelee => Construct(0xb9738);
        public static FormLink<IInstanceNamingRulesGetter> dn_PowerArmor => Construct(0x188160);
        public static FormLink<IInstanceNamingRulesGetter> dn_CommonArmor => Construct(0x184bc1);
    }
}