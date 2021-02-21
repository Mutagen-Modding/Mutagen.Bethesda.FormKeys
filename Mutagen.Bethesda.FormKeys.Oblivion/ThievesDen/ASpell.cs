using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> DLC06FortifySkillSecurity2Apprentice => Construct(0xba56);
            public static FormLink<IASpellGetter> DLC06FortifySkillSecurity3Journeyman => Construct(0xba58);
            public static FormLink<IASpellGetter> DLC06Wraithwind2Apprentice => Construct(0xba5a);
            public static FormLink<IASpellGetter> DLC06Wraithwind3Journeyman => Construct(0xba5c);
            public static FormLink<IASpellGetter> DLC06Nightshadow3Journeyman => Construct(0xba60);
            public static FormLink<IASpellGetter> DLC06Nightshadow2Apprentice => Construct(0xba61);
            public static FormLink<IASpellGetter> DLC06StalkersInstinct2Apprentice => Construct(0xba63);
            public static FormLink<IASpellGetter> DLC06StalkersInstinct3Journeyman => Construct(0xba65);
            public static FormLink<IASpellGetter> DLC06FortifySkillMarskman3Journeyman => Construct(0x79be);
            public static FormLink<IASpellGetter> DLC06FortifySkillMarskman1Novice => Construct(0x79c0);
            public static FormLink<IASpellGetter> DLC06FortifySkillSneak1Novice => Construct(0xba3b);
            public static FormLink<IASpellGetter> DLC06FortifySkillSneak2Apprentice => Construct(0xba3c);
            public static FormLink<IASpellGetter> DLC06FortifySkillSneak3Journeyman => Construct(0xba3e);
            public static FormLink<IASpellGetter> DLC06FortifySkillMarskman2Apprentice => Construct(0x79bd);
            public static FormLink<IASpellGetter> DLC06FortifySkillSecurity1Novice => Construct(0xba55);
        }
    }
}
