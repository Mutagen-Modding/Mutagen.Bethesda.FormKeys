using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class AlchemicalApparatus
        {
            private static FormLink<IAlchemicalApparatusGetter> Construct(uint id) => new FormLink<IAlchemicalApparatusGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAlchemicalApparatusGetter> SE38MuseumItem8 => Construct(0x81e6f);
            public static FormLink<IAlchemicalApparatusGetter> SE38Item8 => Construct(0x81e6e);
            public static FormLink<IAlchemicalApparatusGetter> CGMortarPestle => Construct(0xc7968);
            public static FormLink<IAlchemicalApparatusGetter> RetortMaster => Construct(0x6ee6a);
            public static FormLink<IAlchemicalApparatusGetter> MortarPestleMaster => Construct(0x6ee68);
            public static FormLink<IAlchemicalApparatusGetter> CalcinatorMaster => Construct(0x6ee66);
            public static FormLink<IAlchemicalApparatusGetter> AlembicMaster => Construct(0x6ee64);
            public static FormLink<IAlchemicalApparatusGetter> RetortExpert => Construct(0x6ee62);
            public static FormLink<IAlchemicalApparatusGetter> MortarPestleExpert => Construct(0x6ee60);
            public static FormLink<IAlchemicalApparatusGetter> CalcinatorExpert => Construct(0x6ee5e);
            public static FormLink<IAlchemicalApparatusGetter> AlembicExpert => Construct(0x6ee5c);
            public static FormLink<IAlchemicalApparatusGetter> RetortJourneyman => Construct(0x6ee59);
            public static FormLink<IAlchemicalApparatusGetter> MortarPestleJourneyman => Construct(0x6ee57);
            public static FormLink<IAlchemicalApparatusGetter> CalcinatorJourneyman => Construct(0x6ee55);
            public static FormLink<IAlchemicalApparatusGetter> AlembicJourneyMan => Construct(0x6ee52);
            public static FormLink<IAlchemicalApparatusGetter> RetortApprentice => Construct(0x6e313);
            public static FormLink<IAlchemicalApparatusGetter> MortarPestleApprentice => Construct(0x6e312);
            public static FormLink<IAlchemicalApparatusGetter> CalcinatorApprentice => Construct(0x6e311);
            public static FormLink<IAlchemicalApparatusGetter> AlembicApprentice => Construct(0x6e310);
            public static FormLink<IAlchemicalApparatusGetter> Alembic => Construct(0x10604);
            public static FormLink<IAlchemicalApparatusGetter> Calcinator => Construct(0x1057d);
            public static FormLink<IAlchemicalApparatusGetter> Retort => Construct(0xc4f);
            public static FormLink<IAlchemicalApparatusGetter> MortarPestle => Construct(0x105e3);
        }
    }
}