using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class WordOfPower
        {
            private static FormLink<IWordOfPowerGetter> Construct(uint id) => new FormLink<IWordOfPowerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWordOfPowerGetter> DragonFakeWord => Construct(0x106acb);
            public static FormLink<IWordOfPowerGetter> MQFakeWord => Construct(0xff8d7);
            public static FormLink<IWordOfPowerGetter> HowlCallOfTheWild3 => Construct(0xe5f67);
            public static FormLink<IWordOfPowerGetter> HowlCallOfTheWild2 => Construct(0xe5f66);
            public static FormLink<IWordOfPowerGetter> HowlCallOfTheWild1 => Construct(0xe5f65);
            public static FormLink<IWordOfPowerGetter> WordWoodElfBeastTongue => Construct(0xe40d2);
            public static FormLink<IWordOfPowerGetter> WordImperialVoiceOfTheEmperor => Construct(0xe40cc);
            public static FormLink<IWordOfPowerGetter> WordNordBattleCry => Construct(0xe40c5);
            public static FormLink<IWordOfPowerGetter> HowlSummonWolves3 => Construct(0xcf79a);
            public static FormLink<IWordOfPowerGetter> HowlSummonWolves2 => Construct(0xcf799);
            public static FormLink<IWordOfPowerGetter> HowlFear3 => Construct(0xcf795);
            public static FormLink<IWordOfPowerGetter> HowlFear2 => Construct(0xcf794);
            public static FormLink<IWordOfPowerGetter> HowlSummonWolves1 => Construct(0xcf78f);
            public static FormLink<IWordOfPowerGetter> HowlFear1 => Construct(0xcf78e);
            public static FormLink<IWordOfPowerGetter> HowlDetectLife => Construct(0xce219);
            public static FormLink<IWordOfPowerGetter> WordNus => Construct(0x602a5);
            public static FormLink<IWordOfPowerGetter> WordSlen => Construct(0x602a4);
            public static FormLink<IWordOfPowerGetter> WordIiz => Construct(0x602a3);
            public static FormLink<IWordOfPowerGetter> WordGut => Construct(0x602a2);
            public static FormLink<IWordOfPowerGetter> WordMey => Construct(0x602a1);
            public static FormLink<IWordOfPowerGetter> WordZul => Construct(0x602a0);
            public static FormLink<IWordOfPowerGetter> WordOv => Construct(0x6029f);
            public static FormLink<IWordOfPowerGetter> WordDrem => Construct(0x6029e);
            public static FormLink<IWordOfPowerGetter> WordKaan => Construct(0x6029d);
            public static FormLink<IWordOfPowerGetter> WordQo => Construct(0x6029c);
            public static FormLink<IWordOfPowerGetter> WordBah => Construct(0x6029b);
            public static FormLink<IWordOfPowerGetter> WordStrun => Construct(0x6029a);
            public static FormLink<IWordOfPowerGetter> WordAus => Construct(0x60299);
            public static FormLink<IWordOfPowerGetter> WordLun => Construct(0x60298);
            public static FormLink<IWordOfPowerGetter> WordKrii => Construct(0x60297);
            public static FormLink<IWordOfPowerGetter> WordNir => Construct(0x60296);
            public static FormLink<IWordOfPowerGetter> WordYah => Construct(0x60295);
            public static FormLink<IWordOfPowerGetter> WordLaas => Construct(0x60294);
            public static FormLink<IWordOfPowerGetter> WordTah => Construct(0x60293);
            public static FormLink<IWordOfPowerGetter> WordMir => Construct(0x60292);
            public static FormLink<IWordOfPowerGetter> WordRaan => Construct(0x60291);
            public static FormLink<IWordOfPowerGetter> WordViik => Construct(0x5fb97);
            public static FormLink<IWordOfPowerGetter> WordHaal => Construct(0x5fb96);
            public static FormLink<IWordOfPowerGetter> WordZun => Construct(0x5fb95);
            public static FormLink<IWordOfPowerGetter> WordDiin => Construct(0x5d16e);
            public static FormLink<IWordOfPowerGetter> WordKrah => Construct(0x5d16d);
            public static FormLink<IWordOfPowerGetter> WordFo => Construct(0x5d16c);
            public static FormLink<IWordOfPowerGetter> WordZoor => Construct(0x51962);
            public static FormLink<IWordOfPowerGetter> WordKaal => Construct(0x51961);
            public static FormLink<IWordOfPowerGetter> WordHun => Construct(0x51960);
            public static FormLink<IWordOfPowerGetter> WordUl => Construct(0x48acc);
            public static FormLink<IWordOfPowerGetter> WordKlo => Construct(0x48acb);
            public static FormLink<IWordOfPowerGetter> WordTiid => Construct(0x48aca);
            public static FormLink<IWordOfPowerGetter> WordViing => Construct(0x46b8b);
            public static FormLink<IWordOfPowerGetter> WordAh => Construct(0x46b8a);
            public static FormLink<IWordOfPowerGetter> WordOd => Construct(0x46b89);
            public static FormLink<IWordOfPowerGetter> WordFrul => Construct(0x44253);
            public static FormLink<IWordOfPowerGetter> WordZah => Construct(0x44252);
            public static FormLink<IWordOfPowerGetter> WordJoor => Construct(0x44251);
            public static FormLink<IWordOfPowerGetter> WordKoor => Construct(0x3cd33);
            public static FormLink<IWordOfPowerGetter> WordVah => Construct(0x3cd32);
            public static FormLink<IWordOfPowerGetter> WordLok => Construct(0x3cd31);
            public static FormLink<IWordOfPowerGetter> WordDun => Construct(0x3291f);
            public static FormLink<IWordOfPowerGetter> WordGrah => Construct(0x3291e);
            public static FormLink<IWordOfPowerGetter> WordSu => Construct(0x3291d);
            public static FormLink<IWordOfPowerGetter> WordMaar => Construct(0x3291c);
            public static FormLink<IWordOfPowerGetter> WordRu => Construct(0x3291b);
            public static FormLink<IWordOfPowerGetter> WordFaas => Construct(0x3291a);
            public static FormLink<IWordOfPowerGetter> WordGron => Construct(0x32919);
            public static FormLink<IWordOfPowerGetter> WordZii => Construct(0x32918);
            public static FormLink<IWordOfPowerGetter> WordFeim => Construct(0x32917);
            public static FormLink<IWordOfPowerGetter> WordKest => Construct(0x2f7bd);
            public static FormLink<IWordOfPowerGetter> WordNah => Construct(0x2f7bc);
            public static FormLink<IWordOfPowerGetter> WordWuld => Construct(0x2f7bb);
            public static FormLink<IWordOfPowerGetter> TestWordSah => Construct(0x2f2ce);
            public static FormLink<IWordOfPowerGetter> TestWordLo => Construct(0x2f2cd);
            public static FormLink<IWordOfPowerGetter> TestWordFiik => Construct(0x2f2cc);
            public static FormLink<IWordOfPowerGetter> WordDragonFire03 => Construct(0x252c5);
            public static FormLink<IWordOfPowerGetter> WordDragonFire02 => Construct(0x252c4);
            public static FormLink<IWordOfPowerGetter> WordDragonFire01 => Construct(0x252c3);
            public static FormLink<IWordOfPowerGetter> WordShul => Construct(0x20e19);
            public static FormLink<IWordOfPowerGetter> WordToor => Construct(0x20e18);
            public static FormLink<IWordOfPowerGetter> WordYol => Construct(0x20e17);
            public static FormLink<IWordOfPowerGetter> WordDah => Construct(0x13e24);
            public static FormLink<IWordOfPowerGetter> WordRo => Construct(0x13e23);
            public static FormLink<IWordOfPowerGetter> WordFus => Construct(0x13e22);
        }
    }
}
