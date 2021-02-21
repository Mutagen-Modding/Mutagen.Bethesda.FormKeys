using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Worldspace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IWorldspaceGetter> Construct(uint id) => new FormLink<IWorldspaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWorldspaceGetter> Tamriel => Construct(0x3c);
            public static FormLink<IWorldspaceGetter> WindhelmWorld => Construct(0x1691d);
            public static FormLink<IWorldspaceGetter> RiftenWorld => Construct(0x16bb4);
            public static FormLink<IWorldspaceGetter> MarkarthWorld => Construct(0x16d71);
            public static FormLink<IWorldspaceGetter> WhiterunWorld => Construct(0x1a26f);
            public static FormLink<IWorldspaceGetter> CWTestHold => Construct(0x1b44a);
            public static FormLink<IWorldspaceGetter> LabyrinthianWorld => Construct(0x1cdd3);
            public static FormLink<IWorldspaceGetter> LabyrinthianWorld03 => Construct(0x1cdd9);
            public static FormLink<IWorldspaceGetter> MossMotherCavernWorld => Construct(0x1e49d);
            public static FormLink<IWorldspaceGetter> Blackreach => Construct(0x1ee62);
            public static FormLink<IWorldspaceGetter> BloatedMansGrottoWorld => Construct(0x1fae2);
            public static FormLink<IWorldspaceGetter> FallowstoneCaveWorldEnd => Construct(0x204c7);
            public static FormLink<IWorldspaceGetter> SouthfringeWorld => Construct(0x20bfe);
            public static FormLink<IWorldspaceGetter> BlindCliffCaveWorld => Construct(0x20dcb);
            public static FormLink<IWorldspaceGetter> LabyrinthianWorld04 => Construct(0x21edb);
            public static FormLink<IWorldspaceGetter> FallowstoneCaveWorldStart => Construct(0x243de);
            public static FormLink<IWorldspaceGetter> SkuldafnWorld => Construct(0x278dd);
            public static FormLink<IWorldspaceGetter> DeepwoodRedoubtWorld => Construct(0x29ab7);
            public static FormLink<IWorldspaceGetter> ShadowgreenCavernWorld => Construct(0x2a9d8);
            public static FormLink<IWorldspaceGetter> RedEagleRedoubtWorld => Construct(0x2b101);
            public static FormLink<IWorldspaceGetter> DarkwaterWorld => Construct(0x2c965);
            public static FormLink<IWorldspaceGetter> Sovngarde => Construct(0x2ee41);
            public static FormLink<IWorldspaceGetter> BluePalaceWingWorld => Construct(0x34240);
            public static FormLink<IWorldspaceGetter> KarthspireRedoubtWorld => Construct(0x35699);
            public static FormLink<IWorldspaceGetter> SolitudeWorld => Construct(0x37edf);
            public static FormLink<IWorldspaceGetter> EldergleamSanctuaryWorld => Construct(0x3a9d6);
            public static FormLink<IWorldspaceGetter> CWSiegeTestWorld => Construct(0x419e1);
            public static FormLink<IWorldspaceGetter> WhiterunDragonsreachWorld => Construct(0x46033);
            public static FormLink<IWorldspaceGetter> EastEmpireWarehouse => Construct(0x4f838);
            public static FormLink<IWorldspaceGetter> BrinewaterGrottoWorld => Construct(0x50015);
            public static FormLink<IWorldspaceGetter> AlftandWorld => Construct(0x69857);
            public static FormLink<IWorldspaceGetter> FXLightWorldSpace => Construct(0x6ed38);
            public static FormLink<IWorldspaceGetter> JaphetsFollyWorld => Construct(0x94b35);
            public static FormLink<IWorldspaceGetter> KatariahWorld => Construct(0xc350d);
            public static FormLink<IWorldspaceGetter> FrostmereCryptWorld => Construct(0xc97eb);
            public static FormLink<IWorldspaceGetter> WindhelmPitWorldspace => Construct(0xd45f0);
            public static FormLink<IWorldspaceGetter> LabyrinthianMazeWorld => Construct(0x104217);
        }
    }
}
