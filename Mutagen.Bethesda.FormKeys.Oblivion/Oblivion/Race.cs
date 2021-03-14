using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Race
        {
            private static FormLink<IRaceGetter> Construct(uint id) => new FormLink<IRaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRaceGetter> Sheogorath => Construct(0x5308e);
            public static FormLink<IRaceGetter> GoldenSaint => Construct(0x1208f);
            public static FormLink<IRaceGetter> DarkSeducer => Construct(0x1208e);
            public static FormLink<IRaceGetter> VampireRace => Construct(0x19);
            public static FormLink<IRaceGetter> Dremora => Construct(0x38010);
            public static FormLink<IRaceGetter> Argonian => Construct(0x23fe9);
            public static FormLink<IRaceGetter> Nord => Construct(0x224fd);
            public static FormLink<IRaceGetter> Breton => Construct(0x224fc);
            public static FormLink<IRaceGetter> WoodElf => Construct(0x223c8);
            public static FormLink<IRaceGetter> Khajiit => Construct(0x223c7);
            public static FormLink<IRaceGetter> DarkElf => Construct(0x191c1);
            public static FormLink<IRaceGetter> Orc => Construct(0x191c0);
            public static FormLink<IRaceGetter> HighElf => Construct(0x19204);
            public static FormLink<IRaceGetter> Redguard => Construct(0xd43);
            public static FormLink<IRaceGetter> Imperial => Construct(0x907);
        }
    }
}
