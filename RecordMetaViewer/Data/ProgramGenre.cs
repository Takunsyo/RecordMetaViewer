using System.ComponentModel;

namespace RecordMetaViewer.Data
{

    public enum ProgramGenre
    {
        /// <summary> ニュース・報道 </summary>
        [Description("ニュース・報道")]
        News = 0b1,
        /// <summary> スポーツ </summary>
        [Description("スポーツ")]
        Sports = 0b10,
        /// <summary> ドラマ </summary>
        [Description("ドラマ")]
        Infomation = 0b100,
        /// <summary> ドキュメンタリー </summary>
        [Description("ドキュメンタリー")]
        Drama = 0b1000,
        /// <summary> 音楽 </summary>
        [Description("音楽")]
        Music = 0b10000,
        /// <summary> バラエティー </summary>
        [Description("バラエティー")]
        Variety = 0b100000,
        /// <summary> 映画 </summary>
        [Description("映画")]
        Movie = 0b1000000,
        /// <summary> アニメ・特撮 </summary>
        [Description("アニメ・特撮")]
        Anime = 0b10000000,
        /// <summary> 情報・ワイドショー </summary>
        [Description("情報・ワイドショー")]
        Documantry = 0b100000000,
        /// <summary> 劇場・公演 </summary>
        [Description("劇場・公演")]
        Live = 0b1000000000,
        /// <summary> 趣味・教育 </summary>
        [Description("趣味・教育")]
        Education = 0b10000000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others,
        Default = Others
    }

    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.News"/>
    /// </summary> 
    public enum NewsGenre
    {
        /// <summary>
        /// 定時・総合
        /// </summary>
        [Description("定時・総合")]
        Comprehensive = 0b1,
        /// <summary>
        /// 天気
        /// </summary>
        [Description("天気")]
        Weather = 0b10,
        /// <summary>
        /// 特集・ドキュメント
        /// </summary>
        [Description("特集・ドキュメント")]
        Documental = 0b100,
        /// <summary>
        /// 政治・国会
        /// </summary>
        [Description("政治・国会")]
        Political = 0b1000,
        /// <summary>
        /// 経済・市況
        /// </summary>
        [Description("経済・市況")]
        Economic = 0b10000,
        /// <summary>
        /// 海外・国際
        /// </summary>
        [Description("海外・国際")]
        International = 0b100000,
        /// <summary>
        /// 解説
        /// </summary>
        [Description("解説")]
        Commentary = 0b1000000,
        /// <summary>
        /// 討論・会談
        /// </summary>
        [Description("討論・会談")]
        Discussion = 0b10000000,
        /// <summary>
        /// 報道特集
        /// </summary>
        [Description("報道特集")]
        Special = 0b100000000,
        /// <summary>
        /// ローカル・地域
        /// </summary> 
        [Description("ローカル・地域")] 
        Local = 0b1000000000,
        /// <summary>
        /// 交通
        /// </summary> 
        [Description("交通")] 
        Traffic = 0b10000000000,
        /// <summary>
        /// その他
        /// </summary> 
        [Description("その他")] 
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Sports"/>
    /// </summary> 
    public enum SportsGenre
    {
        /// <summary>
        /// スポーツニュース
        /// </summary> 
        [Description("スポーツニュース")] 
        SportNews = 0b1,
        /// <summary>
        /// 野球
        /// </summary> 
        [Description("野球")] 
        BaseBall = 0b10,
        /// <summary>
        /// サッカー
        /// </summary> 
        [Description("サッカー")] 
        Soccer = 0b100,
        /// <summary>
        /// ゴルフ
        /// </summary> 
        [Description("ゴルフ")] 
        Golf = 0b1000,
        /// <summary>
        /// その他の球技
        /// </summary> 
        [Description("その他の球技")] 
        OtherBalls = 0b10000,
        /// <summary>
        /// 相撲・格闘技
        /// </summary> 
        [Description("相撲・格闘技")] 
        Fighting = 0b100000,
        /// <summary>
        /// オリンピック・国際大会
        /// </summary> 
        [Description("オリンピック・国際大会")] 
        Olympics = 0b1000000,
        /// <summary>
        /// マラソン・陸上・水泳
        /// </summary> 
        [Description("マラソン・陸上・水泳")] 
        Athletics = 0b10000000,
        /// <summary>
        /// モータースポーツ
        /// </summary> 
        [Description("モータースポーツ")] 
        Motor = 0b100000000,
        /// <summary>
        /// マリン・ウィンタースポーツ
        /// </summary> 
        [Description("マリン・ウィンタースポーツ")] 
        Marine = 0b1000000000,
        /// <summary>
        /// 競馬・公営競技
        /// </summary> 
        [Description("競馬・公営競技")] 
        Horseracing = 0b10000000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Infomation"/>
    /// </summary> 
    public enum InfomationGenre
    {
        /// <summary>
        /// 芸能・ワイドショー
        /// </summary> 
        [Description("芸能・ワイドショー")] 
        Performing = 0b1,
        /// <summary>
        /// ファッション
        /// </summary> 
        [Description("ファッション")] 
        Faison = 0b10,
        /// <summary>
        /// 暮らし・住まい
        /// </summary> 
        [Description("暮らし・住まい")] 
        Dwelling = 0b100,
        /// <summary>
        /// 健康・医療
        /// </summary> 
        [Description("健康・医療")] 
        Medical = 0b1000,
        /// <summary>
        /// ショッピング・通販
        /// </summary> 
        [Description("ショッピング・通販")] 
        OnlineBusiness = 0b10000,
        /// <summary>
        /// グルメ・料理
        /// </summary> 
        [Description("グルメ・料理")] 
        Gourmet = 0b100000,
        /// <summary>
        /// イベント
        /// </summary> 
        [Description("イベント")] 
        Event = 0b1000000,
        /// <summary>
        /// 番組紹介・お知らせ
        /// </summary> 
        [Description("番組紹介・お知らせ")] 
        Notification = 0b10000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others

    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Drama"/>
    /// </summary> 
    public enum DramaGenre
    {
        /// <summary>
        /// 国内ドラマ
        /// </summary> 
        [Description("国内ドラマ")] 
        DomesticDrama = 0b1,
        /// <summary>
        /// 海外ドラマ
        /// </summary> 
        [Description("海外ドラマ")] 
        ForeignDrama = 0b10,
        /// <summary>
        /// 時代劇
        /// </summary> 
        [Description("時代劇")] 
        HistoricalDrama = 0b100,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Music"/>
    /// </summary> 
    public enum MusicGenre
    {
        /// <summary>
        /// 国内ロック・ポップス
        /// </summary> 
        [Description("国内ロック・ポップス")] 
        DomesticPops = 0b1,
        /// <summary>
        /// 海外ロック・ポップス
        /// </summary> 
        [Description("海外ロック・ポップス")] 
        ForeignPops = 0b10,
        /// <summary>
        /// クラシック・オペラ
        /// </summary> 
        [Description("クラシック・オペラ")] 
        Classic = 0b100,
        /// <summary>
        /// ジャズ・フュージョン
        /// </summary> 
        [Description("ジャズ・フュージョン")] 
        Jazz = 0b1000,
        /// <summary>
        /// 歌謡曲・演歌
        /// </summary> 
        [Description("歌謡曲・演歌")] 
        Ballad = 0b10000,
        /// <summary>
        /// ライブ・コンサート
        /// </summary> 
        [Description("ライブ・コンサート")] 
        Concert = 0b100000,
        /// <summary>
        /// ランキング・リクエスト
        /// </summary> 
        [Description("ランキング・リクエスト")] 
        Ranks = 0b1000000,
        /// <summary>
        /// カラオケ・のど自慢
        /// </summary> 
        [Description("カラオケ・のど自慢")] 
        Karaoke = 0b10000000,
        /// <summary>
        /// 民謡・邦楽
        /// </summary> 
        [Description("民謡・邦楽")] 
        FolkSong = 0b100000000,
        /// <summary>
        /// 童謡・キッズ
        /// </summary> 
        [Description("童謡・キッズ")] 
        Kids = 0b1000000000,
        /// <summary>
        /// 民族音楽・ワールドミュージック
        /// </summary> 
        [Description("民族音楽・ワールドミュージック")] 
        EthnicMusic = 0b10000000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Variety"/>
    /// </summary> 
    public enum VarietyGenre
    {
        /// <summary>
        /// クイズ
        /// </summary> 
        [Description("クイズ")] 
        Quiz = 0b1,
        /// <summary>
        /// ゲーム
        /// </summary> 
        [Description("ゲーム")] 
        Game = 0b10,
        /// <summary>
        /// トークバラエティ
        /// </summary> 
        [Description("トークバラエティ")] 
        Talk = 0b100,
        /// <summary>
        /// お笑い・コメディ
        /// </summary> 
        [Description("お笑い・コメディ")] 
        Comedy = 0b1000,
        /// <summary>
        /// 音楽バラエティ
        /// </summary> 
        [Description("音楽バラエティ")] 
        Musical = 0b10000,
        /// <summary>
        /// 旅バラエティ
        /// </summary> 
        [Description("旅バラエティ")] 
        Travel = 0b100000,
        /// <summary>
        /// 料理バラエティ
        /// </summary> 
        [Description("料理バラエティ")] 
        Gourmet = 0b1000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Movie"/>
    /// </summary> 
    public enum MovieGenre
    {
        /// <summary>
        /// 洋画
        /// </summary> 
        [Description("洋画")] 
        ForeignMovie = 0b1,
        /// <summary>
        /// 邦画
        /// </summary> 
        [Description("邦画")] 
        DomesticMovie = 0b10,
        /// <summary>
        /// アニメ
        /// </summary> 
        [Description("アニメ")] 
        AnimeMovie = 0b100,
        /// <summary> その他 </summary>
        [Description("その他")]
        Other
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Anime"/>
    /// </summary> 
    public enum AnimeGenre
    {
        /// <summary>
        /// 国内アニメ
        /// </summary> 
        [Description("国内アニメ")] 
        DomesticAnime = 0b1,
        /// <summary>
        /// 海外アニメ
        /// </summary> 
        [Description("海外アニメ")] 
        ForeignAnime = 0b10,
        /// <summary>
        /// 特撮
        /// </summary> 
        [Description("特撮")] 
        SFX = 0b100,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Documantry"/>
    /// </summary> 
    public enum DocumantryGenre
    {
        /// <summary>
        /// 社会・時事
        /// </summary> 
        [Description("社会・時事")] 
        Society = 0b1,
        /// <summary>
        /// 歴史・紀行
        /// </summary> 
        [Description("歴史・紀行")] 
        History = 0b10,
        /// <summary>
        /// 自然・動物・環境
        /// </summary> 
        [Description("自然・動物・環境")] 
        Nature = 0b100,
        /// <summary>
        /// 宇宙・科学・医学
        /// </summary> 
        [Description("宙・科学・医学")] 
        Science = 0b1000,
        /// <summary>
        /// カルチャー・伝統文化
        /// </summary> 
        [Description("カルチャー・伝統文化")] 
        Culture = 0b10000,
        /// <summary>
        /// 文学・文芸
        /// </summary> 
        [Description("文学・文芸")] 
        Literature = 0b100000,
        /// <summary>
        /// スポーツ
        /// </summary> 
        [Description("スポーツ")] 
        Sports = 0b1000000,
        /// <summary>
        /// ドキュメンタリー全般
        /// </summary> 
        [Description("ドキュメンタリー全般")] 
        General = 0b10000000,
        /// <summary>
        /// インタビュー・討論
        /// </summary> 
        [Description("インタビュー・討論")] 
        Interview = 0b100000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Live"/>
    /// </summary> 
    public enum LiveGenre
    {
        /// <summary>
        /// 現代劇・新劇
        /// </summary> 
        [Description("現代劇・新劇")] 
        Contemporary = 0b1,
        /// <summary>
        /// ミュージカル
        /// </summary> 
        [Description("ミュージカル")] 
        Musical = 0b10,
        /// <summary>
        /// ダンス・バレエ
        /// </summary> 
        [Description("ダンス・バレエ")] 
        Dance = 0b100,
        /// <summary>
        /// 落語・演芸
        /// </summary> 
        [Description("落語・演芸")] 
        Entertainment = 0b1000,
        /// <summary>
        /// 歌舞伎・古典
        /// </summary> 
        [Description("歌舞伎・古典")] 
        JClassic = 0b10000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
    /// <summary>
    /// Sub genre under <see cref="ProgramGenre.Education"/>
    /// </summary> 
    public enum EducationGenre
    {
        /// <summary>
        /// 旅・釣り・アウトドア
        /// </summary> 
        [Description("旅・釣り・アウトドア")] 
        Outdoor = 0b1,
        /// <summary>
        /// 園芸・ペット・手芸
        /// </summary> 
        [Description("園芸・ペット・手芸")] 
        Handicraft = 0b10,
        /// <summary>
        /// 音楽・美術・工芸
        /// </summary> 
        [Description("音楽・美術・工芸")] 
        Art = 0b100,
        /// <summary>
        /// 囲碁・将棋
        /// </summary> 
        [Description("囲碁・将棋")] 
        Go = 0b1000,
        /// <summary>
        /// 麻雀・パチンコ
        /// </summary> 
        [Description("麻雀・パチンコ")] 
        Gambling = 0b10000,
        /// <summary>
        /// 車・オートバイ
        /// </summary> 
        [Description("車・オートバイ")] 
        Motor = 0b100000,
        /// <summary>
        /// コンピューター・ＴＶゲーム
        /// </summary> 
        [Description("コンピューター・ＴＶゲーム")] 
        Computer = 0b1000000,
        /// <summary>
        /// 会話・語学
        /// </summary> 
        [Description("会話・語学")] 
        Language = 0b10000000,
        /// <summary>
        /// 幼児・小学生
        /// </summary> 
        [Description("児・小学生")] 
        ElementaryStudent = 0b100000000,
        /// <summary>
        /// 中学生・高校生
        /// </summary> 
        [Description("中学生・高校生")] 
        JuniorHighStudent = 0b1000000000,
        /// <summary>
        /// 大学生・受験
        /// </summary> 
        [Description("大学生・受験")] 
        CollegeStudent = 0b10000000000,
        /// <summary>
        /// 生涯教育・資格
        /// </summary> 
        [Description("生涯教育・資格")] 
        AdultEducation = 0b100000000000,
        /// <summary>
        /// 教育問題
        /// </summary> 
        [Description("教育問題")] 
        EducationProblems = 0b1000000000000,
        /// <summary> その他 </summary>
        [Description("その他")]
        Others
    }
}
