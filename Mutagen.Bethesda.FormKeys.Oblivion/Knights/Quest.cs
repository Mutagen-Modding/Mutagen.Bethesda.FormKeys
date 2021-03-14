using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class Quest
        {
            private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> ND10FIN => Construct(0x2d32);
            public static FormLink<IQuestGetter> NDKnightsConvSystem => Construct(0x2d33);
            public static FormLink<IQuestGetter> NDGreetings => Construct(0x2d34);
            public static FormLink<IQuestGetter> NDStartingRumors => Construct(0x2d35);
            public static FormLink<IQuestGetter> NDConversations => Construct(0x2d36);
            public static FormLink<IQuestGetter> ND10 => Construct(0x2d37);
            public static FormLink<IQuestGetter> ND09 => Construct(0x2d38);
            public static FormLink<IQuestGetter> ND08 => Construct(0x2d39);
            public static FormLink<IQuestGetter> ND07 => Construct(0x2d3a);
            public static FormLink<IQuestGetter> ND06 => Construct(0x2d3b);
            public static FormLink<IQuestGetter> ND05 => Construct(0x2d3c);
            public static FormLink<IQuestGetter> ND04 => Construct(0x2d3d);
            public static FormLink<IQuestGetter> ND03 => Construct(0x2d3e);
            public static FormLink<IQuestGetter> ND02 => Construct(0x2d3f);
            public static FormLink<IQuestGetter> ND01 => Construct(0x2d40);
            public static FormLink<IQuestGetter> NDPilgrim => Construct(0x2d41);
            public static FormLink<IQuestGetter> ND00 => Construct(0x2d42);
        }
    }
}
