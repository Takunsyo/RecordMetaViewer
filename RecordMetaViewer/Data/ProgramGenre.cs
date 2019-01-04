using System.ComponentModel;

namespace RecordMetaViewer.Data
{
    /// <summary>
    /// Primary genre
    /// </summary>
    public enum ProgramGenre
    {
        /// <summary> ニュース・報道 </summary>
        [EnumDescription("ニュース・報道",typeof(NewsGenre))]
        News =                         0b1,
        /// <summary> スポーツ </summary>
        [EnumDescription("スポーツ", typeof(SportsGenre))]
        Sports =                      0b10,
        /// <summary> ドラマ </summary>
        [EnumDescription("ドラマ", typeof(InfomationGenre))]
        Infomation =                 0b100,
        /// <summary> ドキュメンタリー </summary>
        [EnumDescription("ドキュメンタリー", typeof(DramaGenre))]
        Drama =                     0b1000,
        /// <summary> 音楽 </summary>
        [EnumDescription("音楽", typeof(MusicGenre))]
        Music =                   0b1_0000,
        /// <summary> バラエティー </summary>
        [ EnumDescription("バラエティー", typeof(VarietyGenre))]
        Variety =                0b10_0000,
        /// <summary> 映画 </summary>
        [EnumDescription("映画", typeof(MovieGenre))]
        Movie =                 0b100_0000,
        /// <summary> アニメ・特撮 </summary>
        [EnumDescription("アニメ・特撮", typeof(AnimeGenre))]
        Anime =                0b1000_0000,
        /// <summary> 情報・ワイドショー </summary>
        [EnumDescription("情報・ワイドショー", typeof(DocumantryGenre))]
        Documantry =         0b1_0000_0000,
        /// <summary> 劇場・公演 </summary>
        [EnumDescription("劇場・公演", typeof(LiveGenre))]
        Live =              0b10_0000_0000,
        /// <summary> 趣味・教育 </summary>
        [EnumDescription("趣味・教育", typeof(EducationGenre))]
        Education =        0b100_0000_0000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("定時・総合")]
        Comprehensive = 0b1,
        /// <summary>
        /// 天気
        /// </summary>
        [EnumDescription("天気")]
        Weather = 0b10,
        /// <summary>
        /// 特集・ドキュメント
        /// </summary>
        [EnumDescription("特集・ドキュメント")]
        Documental = 0b100,
        /// <summary>
        /// 政治・国会
        /// </summary>
        [EnumDescription("政治・国会")]
        Political = 0b1000,
        /// <summary>
        /// 経済・市況
        /// </summary>
        [EnumDescription("経済・市況")]
        Economic = 0b10000,
        /// <summary>
        /// 海外・国際
        /// </summary>
        [EnumDescription("海外・国際")]
        International = 0b100000,
        /// <summary>
        /// 解説
        /// </summary>
        [EnumDescription("解説")]
        Commentary = 0b1000000,
        /// <summary>
        /// 討論・会談
        /// </summary>
        [EnumDescription("討論・会談")]
        Discussion = 0b10000000,
        /// <summary>
        /// 報道特集
        /// </summary>
        [EnumDescription("報道特集")]
        Special = 0b100000000,
        /// <summary>
        /// ローカル・地域
        /// </summary> 
        [EnumDescription("ローカル・地域")] 
        Local = 0b1000000000,
        /// <summary>
        /// 交通
        /// </summary> 
        [EnumDescription("交通")] 
        Traffic = 0b10000000000,
        /// <summary>
        /// その他
        /// </summary> 
        [EnumDescription("その他")] 
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
        [EnumDescription("スポーツニュース")] 
        SportNews = 0b1,
        /// <summary>
        /// 野球
        /// </summary> 
        [EnumDescription("野球")] 
        BaseBall = 0b10,
        /// <summary>
        /// サッカー
        /// </summary> 
        [EnumDescription("サッカー")] 
        Soccer = 0b100,
        /// <summary>
        /// ゴルフ
        /// </summary> 
        [EnumDescription("ゴルフ")] 
        Golf = 0b1000,
        /// <summary>
        /// その他の球技
        /// </summary> 
        [EnumDescription("その他の球技")] 
        OtherBalls = 0b10000,
        /// <summary>
        /// 相撲・格闘技
        /// </summary> 
        [EnumDescription("相撲・格闘技")] 
        Fighting = 0b100000,
        /// <summary>
        /// オリンピック・国際大会
        /// </summary> 
        [EnumDescription("オリンピック・国際大会")] 
        Olympics = 0b1000000,
        /// <summary>
        /// マラソン・陸上・水泳
        /// </summary> 
        [EnumDescription("マラソン・陸上・水泳")] 
        Athletics = 0b10000000,
        /// <summary>
        /// モータースポーツ
        /// </summary> 
        [EnumDescription("モータースポーツ")] 
        Motor = 0b100000000,
        /// <summary>
        /// マリン・ウィンタースポーツ
        /// </summary> 
        [EnumDescription("マリン・ウィンタースポーツ")] 
        Marine = 0b1000000000,
        /// <summary>
        /// 競馬・公営競技
        /// </summary> 
        [EnumDescription("競馬・公営競技")] 
        Horseracing = 0b10000000000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("芸能・ワイドショー")] 
        Performing = 0b1,
        /// <summary>
        /// ファッション
        /// </summary> 
        [EnumDescription("ファッション")] 
        Faison = 0b10,
        /// <summary>
        /// 暮らし・住まい
        /// </summary> 
        [EnumDescription("暮らし・住まい")] 
        Dwelling = 0b100,
        /// <summary>
        /// 健康・医療
        /// </summary> 
        [EnumDescription("健康・医療")] 
        Medical = 0b1000,
        /// <summary>
        /// ショッピング・通販
        /// </summary> 
        [EnumDescription("ショッピング・通販")] 
        OnlineBusiness = 0b10000,
        /// <summary>
        /// グルメ・料理
        /// </summary> 
        [EnumDescription("グルメ・料理")] 
        Gourmet = 0b100000,
        /// <summary>
        /// イベント
        /// </summary> 
        [EnumDescription("イベント")] 
        Event = 0b1000000,
        /// <summary>
        /// 番組紹介・お知らせ
        /// </summary> 
        [EnumDescription("番組紹介・お知らせ")] 
        Notification = 0b10000000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("国内ドラマ")] 
        DomesticDrama = 0b1,
        /// <summary>
        /// 海外ドラマ
        /// </summary> 
        [EnumDescription("海外ドラマ")] 
        ForeignDrama = 0b10,
        /// <summary>
        /// 時代劇
        /// </summary> 
        [EnumDescription("時代劇")] 
        HistoricalDrama = 0b100,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("国内ロック・ポップス")] 
        DomesticPops = 0b1,
        /// <summary>
        /// 海外ロック・ポップス
        /// </summary> 
        [EnumDescription("海外ロック・ポップス")] 
        ForeignPops = 0b10,
        /// <summary>
        /// クラシック・オペラ
        /// </summary> 
        [EnumDescription("クラシック・オペラ")] 
        Classic = 0b100,
        /// <summary>
        /// ジャズ・フュージョン
        /// </summary> 
        [EnumDescription("ジャズ・フュージョン")] 
        Jazz = 0b1000,
        /// <summary>
        /// 歌謡曲・演歌
        /// </summary> 
        [EnumDescription("歌謡曲・演歌")] 
        Ballad = 0b10000,
        /// <summary>
        /// ライブ・コンサート
        /// </summary> 
        [EnumDescription("ライブ・コンサート")] 
        Concert = 0b100000,
        /// <summary>
        /// ランキング・リクエスト
        /// </summary> 
        [EnumDescription("ランキング・リクエスト")] 
        Ranks = 0b1000000,
        /// <summary>
        /// カラオケ・のど自慢
        /// </summary> 
        [EnumDescription("カラオケ・のど自慢")] 
        Karaoke = 0b10000000,
        /// <summary>
        /// 民謡・邦楽
        /// </summary> 
        [EnumDescription("民謡・邦楽")] 
        FolkSong = 0b100000000,
        /// <summary>
        /// 童謡・キッズ
        /// </summary> 
        [EnumDescription("童謡・キッズ")] 
        Kids = 0b1000000000,
        /// <summary>
        /// 民族音楽・ワールドミュージック
        /// </summary> 
        [EnumDescription("民族音楽・ワールドミュージック")] 
        EthnicMusic = 0b10000000000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("クイズ")] 
        Quiz = 0b1,
        /// <summary>
        /// ゲーム
        /// </summary> 
        [EnumDescription("ゲーム")] 
        Game = 0b10,
        /// <summary>
        /// トークバラエティ
        /// </summary> 
        [EnumDescription("トークバラエティ")] 
        Talk = 0b100,
        /// <summary>
        /// お笑い・コメディ
        /// </summary> 
        [EnumDescription("お笑い・コメディ")] 
        Comedy = 0b1000,
        /// <summary>
        /// 音楽バラエティ
        /// </summary> 
        [EnumDescription("音楽バラエティ")] 
        Musical = 0b10000,
        /// <summary>
        /// 旅バラエティ
        /// </summary> 
        [EnumDescription("旅バラエティ")] 
        Travel = 0b100000,
        /// <summary>
        /// 料理バラエティ
        /// </summary> 
        [EnumDescription("料理バラエティ")] 
        Gourmet = 0b1000000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("洋画")] 
        ForeignMovie = 0b1,
        /// <summary>
        /// 邦画
        /// </summary> 
        [EnumDescription("邦画")] 
        DomesticMovie = 0b10,
        /// <summary>
        /// アニメ
        /// </summary> 
        [EnumDescription("アニメ")] 
        AnimeMovie = 0b100,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("国内アニメ")] 
        DomesticAnime = 0b1,
        /// <summary>
        /// 海外アニメ
        /// </summary> 
        [EnumDescription("海外アニメ")] 
        ForeignAnime = 0b10,
        /// <summary>
        /// 特撮
        /// </summary> 
        [EnumDescription("特撮")] 
        SFX = 0b100,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("社会・時事")] 
        Society = 0b1,
        /// <summary>
        /// 歴史・紀行
        /// </summary> 
        [EnumDescription("歴史・紀行")] 
        History = 0b10,
        /// <summary>
        /// 自然・動物・環境
        /// </summary> 
        [EnumDescription("自然・動物・環境")] 
        Nature = 0b100,
        /// <summary>
        /// 宇宙・科学・医学
        /// </summary> 
        [EnumDescription("宙・科学・医学")] 
        Science = 0b1000,
        /// <summary>
        /// カルチャー・伝統文化
        /// </summary> 
        [EnumDescription("カルチャー・伝統文化")] 
        Culture = 0b10000,
        /// <summary>
        /// 文学・文芸
        /// </summary> 
        [EnumDescription("文学・文芸")] 
        Literature = 0b100000,
        /// <summary>
        /// スポーツ
        /// </summary> 
        [EnumDescription("スポーツ")] 
        Sports = 0b1000000,
        /// <summary>
        /// ドキュメンタリー全般
        /// </summary> 
        [EnumDescription("ドキュメンタリー全般")] 
        General = 0b10000000,
        /// <summary>
        /// インタビュー・討論
        /// </summary> 
        [EnumDescription("インタビュー・討論")] 
        Interview = 0b100000000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("現代劇・新劇")] 
        Contemporary = 0b1,
        /// <summary>
        /// ミュージカル
        /// </summary> 
        [EnumDescription("ミュージカル")] 
        Musical = 0b10,
        /// <summary>
        /// ダンス・バレエ
        /// </summary> 
        [EnumDescription("ダンス・バレエ")] 
        Dance = 0b100,
        /// <summary>
        /// 落語・演芸
        /// </summary> 
        [EnumDescription("落語・演芸")] 
        Entertainment = 0b1000,
        /// <summary>
        /// 歌舞伎・古典
        /// </summary> 
        [EnumDescription("歌舞伎・古典")] 
        JClassic = 0b10000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
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
        [EnumDescription("旅・釣り・アウトドア")] 
        Outdoor = 0b1,
        /// <summary>
        /// 園芸・ペット・手芸
        /// </summary> 
        [EnumDescription("園芸・ペット・手芸")] 
        Handicraft = 0b10,
        /// <summary>
        /// 音楽・美術・工芸
        /// </summary> 
        [EnumDescription("音楽・美術・工芸")] 
        Art = 0b100,
        /// <summary>
        /// 囲碁・将棋
        /// </summary> 
        [EnumDescription("囲碁・将棋")] 
        Go = 0b1000,
        /// <summary>
        /// 麻雀・パチンコ
        /// </summary> 
        [EnumDescription("麻雀・パチンコ")] 
        Gambling = 0b10000,
        /// <summary>
        /// 車・オートバイ
        /// </summary> 
        [EnumDescription("車・オートバイ")] 
        Motor = 0b100000,
        /// <summary>
        /// コンピューター・ＴＶゲーム
        /// </summary> 
        [EnumDescription("コンピューター・ＴＶゲーム")] 
        Computer = 0b1000000,
        /// <summary>
        /// 会話・語学
        /// </summary> 
        [EnumDescription("会話・語学")] 
        Language = 0b10000000,
        /// <summary>
        /// 幼児・小学生
        /// </summary> 
        [EnumDescription("児・小学生")] 
        ElementaryStudent = 0b100000000,
        /// <summary>
        /// 中学生・高校生
        /// </summary> 
        [EnumDescription("中学生・高校生")] 
        JuniorHighStudent = 0b1000000000,
        /// <summary>
        /// 大学生・受験
        /// </summary> 
        [EnumDescription("大学生・受験")] 
        CollegeStudent = 0b10000000000,
        /// <summary>
        /// 生涯教育・資格
        /// </summary> 
        [EnumDescription("生涯教育・資格")] 
        AdultEducation = 0b100000000000,
        /// <summary>
        /// 教育問題
        /// </summary> 
        [EnumDescription("教育問題")] 
        EducationProblems = 0b1000000000000,
        /// <summary> その他 </summary>
        [EnumDescription("その他")]
        Others
    }
}
