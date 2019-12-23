namespace Leder.Migrations
{
    using Leder.Models;
    using Leder.ViewModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Leder.Models.LederContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LederContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
                x => x.ProductId,
                new Product { ProductId = 1, Name = "Diario 迷你隨行斜肩袋", Price = 12856, CategoryId = 1, Color = "brown", Photos = "Totebag1.jpg,Totebag1_D_1.jpg,Totebag1_D_2.jpg,Totebag1_D_3.jpg,Totebag1_D_4.jpg,Totebag1_D_5.jpg", Description = "「Diario」是義大利文中的「日記」之意。我們期望此系列製品能夠像日記一般， 將每天記錄下來， 就算是傷痕、髒污， 所有痕跡都是珍貴的回憶。Diario 系列採用產自北美的去勢成年牛皮， 以植物鞣法進行鞣製， 再浸泡於油脂裡完成「Oil Mellow Leather」後， 所製作而成；革面擁有虎斑紋理、肋部傷痕、色素黑點等天然皮革樣貌， 具有豐足厚度與張力；此外， 如果想要在手感柔順的皮革中， 保持堅固耐用的強韌度， 就需要製革職人的技術。" },
                new Product { ProductId = 2, Name = "Clarte 流蘇迷你箱型包", Price = 15438, CategoryId = 1, Color = "pink", Photos = "Totebag2.jpg,Totebag2_D_1.jpg,Totebag2_D_2.jpg,Totebag2_D_3.jpg,Totebag2_D_4.jpg,Totebag2_D_5.jpg", Description = "獻給您, 在秋冬裝扮上, 增添成熟女子氣息與質感的 2 款限定色。在花朵靜靜地綻放之際, 以季節香氣醺染而成的「薔薇茶紅色」, 或以溫柔姿態守護花朵, 帶著濃厚深情的「深秋葉綠色」, 秋冬限定的獨有氛圍, 也在呈現低調奢侈亮金感的金屬部件上展現, 帶出秋冬視覺的強調色彩之餘, 和諧地回應皮革內層與皮革表面同色系的巧妙。" },
                new Product { ProductId = 3, Name = "Tone Oilnume 迷你郵差包", Price = 18378, CategoryId = 1, Color = "green", Photos = "Totebag3.jpg,Totebag3_D_1.jpg,Totebag3_D_2.jpg,Totebag3_D_3.jpg,Totebag3_D_4.jpg,Totebag3_D_5.jpg", Description = "經典的「 Tone Oilnume 系列」, 此次增添了聖誕專屬的 2 款限定色。取自針葉樹及桉樹樹葉裝飾的聖誕花圈, 帶有森林深處傳來祝福話語的「午夜針葉綠色」, 內層是有如澄澈冬夜裡, 披上一片凜然夜色的「星夜醇藍」。另一款限定色, 從被火光映照著的明亮臉龐裡, 細聽爐火裡傳來的劈啪低語, 餘溫的柴火, 於是成了聖誕冬夜裡迷人的「星燦暖灰棕色」, 在大地色裡的朦朧色調, 並為內層添入柔和明亮的極地色彩「苔原橄欖綠」。" },
                new Product { ProductId = 4, Name = "Tone Oilnume 兩用托特包", Price = 26648, CategoryId = 1, Color = "lightbrown", Photos = "Totebag4.jpg,Totebag4_D_1.jpg,Totebag4_D_2.jpg,Totebag4_D_3.jpg,Totebag4_D_4.jpg,Totebag4_D_5.jpg", Description = "沉穩色調中透著溫暖明亮, 在工作與日常風格間, 都是能自然契合生活的搭配夥伴。一同共度的時光裡, 將愈發契合與柔軟, 逐漸加深的色澤, 也將醞釀出專屬自己的獨特韻味, 敬請享受今年呈現給您的聖誕限定色。" },
                new Product { ProductId = 5, Name = "Tone Oilnume 拉鍊斜背包", Price = 25729, CategoryId = 1, Color = "darkbrown", Photos = "Totebag5.jpg,Totebag5_D_1.jpg,Totebag5_D_2.jpg,Totebag5_D_3.jpg,Totebag5_D_4.jpg,Totebag5_D_5.jpg", Description = "特大的容量能放進很多物品 , 無論斜背或側背都能夠很貼身 , 感覺就像把皮革穿戴在身上一樣自然。皮革包經使用後而出現的轉變 , 更添個人風格。底部的四個角落特意設計成圓角 , 考驗著職人們的手藝 , 請務必仔細端詳所有細節 , 逐一感受箇中的細膩心思。" },
                new Product { ProductId = 6, Name = "Plota 防水兩用斜背包", Price = 12497, CategoryId = 1, Color = "darkbrown", Photos = "Totebag6.jpg,Totebag6_D_1.jpg,Totebag6_D_2.jpg,Totebag6_D_3.jpg,Totebag6_D_4.jpg,Totebag6_D_5.jpg", Description = "Plota 系列選用油水平衡的 Waterproof Fine Leather, 保留皮革原有質感的同時, 以 3M 的 Scotchguard 防水劑滲透至皮革纖維內, 增添強力的防水與防油性, 使皮革內裡或緞面、傷痕等處都不易附著水、油、髒污, 並獨具皮革少有的輕量魅力。擁有如肌膚水分飽滿的滑順質地, 動靜之中展現高級的霧面光澤, 是最易保養且輕便實用的防水皮革。" },
                new Product { ProductId = 7, Name = "Urbano 公事托特包", Price = 38717, CategoryId = 1, Color = "darkbrown", Photos = "Totebag7.jpg,Totebag7_D_1.jpg,Totebag7_D_2.jpg,Totebag7_D_3.jpg,Totebag7_D_4.jpg,Totebag7_D_5.jpg", Description = "在靜謐知性的氛圍中, 醞釀出成熟的紳士氣度。2019 年的秋冬限定色「優雅紫棕色」, 以略帶淺灰色調的紫色為基礎色底, 加入深邃柔和的棕色調。內斂沉穩的氣息, 能自然地融合紳士風格的基本色彩: 黑色、深藍色及灰色, 自帶的雅緻質感, 無論襯衫或夾克風格, 皆能優雅以對。隨著使用時間增長, 光澤及韻味也將逐漸加深, 會隨著時間醞釀產生獨特的成熟韻味。" },
                new Product { ProductId = 8, Name = "Armas 水牛皮兩用直式托特包", Price = 27655, CategoryId = 1, Color = "black", Photos = "Totebag8.jpg,Totebag8_D_1.jpg,Totebag8_D_2.jpg,Totebag8_D_3.jpg,Totebag8_D_4.jpg,Totebag8_D_5.jpg", Description = "帶有俐落時尚感且實用功能的商務包款, 能活躍搭配多樣工作情境。直立長型的款式, 帶有整齊俐落的都會風格, 附有可拆卸揹帶, 並可根據不同使用情境, 隨興調整手提、肩揹姿態。主要開口的拉鍊設計, 能保護重要文件不被探視, 也給予人可信賴的安穩感。以水牛皮和義大利 Nume 皮革的組合搭配, 兼具男士的性格魅力和成熟的大人氛圍, 隨著使用時間變化出獨具個人韻味的表情, 越使用越愛不釋手, 是能俐落回應各式場合, 能靈活攜帶的現代都市風格包款。" },

                new Product { ProductId = 9, Name = "Tone Oilnume 中型後背包", Price = 27199, CategoryId = 2, Color = "grenn", Photos = "Backpack1.jpg,Backpack1_D_1.jpg,Backpack1_D_2.jpg,Backpack1_D_3.jpg,Backpack1_D_4.jpg,Backpack1_D_5.jpg", Description = "每次揹上身都能感受到柔軟皮革與自己互相契合 , 逐漸地讓人更加愛用它的後背包。包款大小是適合平時使用的中型尺寸 , 卻能夠完整收納 A4 資料。彷彿箱體的外型 , 適合裝入有些厚度的物品 , 即使是收納兩天一夜的旅行衣物也相當合宜。簡約設計搭配著柔軟貼合的皮革感 , 讓您在每次使用時都可享受不同的表情。" },
                new Product { ProductId = 10, Name = "Tone Oilnume 後背包", Price = 28670, CategoryId = 2, Color = "lightbrown", Photos = "Backpack2.jpg,Backpack2_D_1.jpg,Backpack2_D_2.jpg,Backpack2_D_3.jpg,Backpack2_D_4.jpg,Backpack2_D_5.jpg", Description = "背包外層是植鞣革 , 內層為麂皮 , 素材天然又富華麗感。質地耐用和舒適之餘 , 亦方便使用。例如背包頂部的開口及側面的拉鍊 , 均可直接取放主袋物品。背部使用了製作小學生書包的技術 , 可減輕肩膀負擔。" },

                new Product { ProductId = 11, Name = "Belchord 長夾", Price = 22605, CategoryId = 3, Color = "black", Photos = "Longclip1.jpg,Longclip1_D_1.jpg,Longclip1_D_2.jpg,Longclip1_D_3.jpg,Longclip1_D_4.jpg,Longclip1_D_5.jpg", Description = "為了相襯您在商務場合中的洗鍊而經過精細計算 , 利用纖薄縫製的技藝使整體呈現簡約外型。外層採用紋理細緻且具鑽石光感的 Cordovan 馬臀皮革 , 內層為灌注職人精巧工藝的手揉水波紋小牛皮 , 開闔間盡顯優雅 , 於各式場合皆能展現出高端品味 , 是首屈一指的頂級長夾。" },
                new Product { ProductId = 12, Name = "Diario 長夾", Price = 9189, CategoryId = 3, Color = "brown", Photos = "Longclip2.jpg,Longclip2_D_1.jpg,Longclip2_D_2.jpg,Longclip2_D_3.jpg,Longclip2_D_4.jpg,Longclip2_D_5.jpg", Description = "不斷增添色澤, 含有豐富油脂且深層韻味的天然皮革。簡約設計可充分展現出皮革質樸的表情。使用愈久, 愈有專屬韻味。「Diario」是義大利文中的「日記」之意。我們期望此系列製品能夠像日記一般, 將每天記錄下來, 就算是傷痕、髒污, 所有痕跡都是珍貴的回憶。" },
                new Product { ProductId = 13, Name = "Tone Oilnume 蛙嘴式零錢長夾", Price = 8822, CategoryId = 3, Color = "green", Photos = "Longclip3.jpg,Longclip3_D_1.jpg,Longclip3_D_2.jpg,Longclip3_D_3.jpg,Longclip3_D_4.jpg,Longclip3_D_5.jpg", Description = "取放零錢時 , 都會聽到清脆的聲響。此款長夾最富有魅力的零錢袋口採用可愛的蛙嘴式設計 , 開闔之間會發出「喀」的聲音。卡片及紙鈔則整齊收納於錢包另一側 , 功能性充足。每日享受柔軟 Oilnume 皮革 , 見證天然素材逐漸展現自身品味的過程 , 令人心情越來越愉悅。" },
                new Product { ProductId = 14, Name = "Tone Oilnume 纏繞式長夾", Price = 8454, CategoryId = 3, Color = "lightbrown", Photos = "Longclip4.jpg,Longclip4_D_1.jpg,Longclip4_D_2.jpg,Longclip4_D_3.jpg,Longclip4_D_4.jpg,Longclip4_D_5.jpg", Description = "纏繞式長夾的基本概念是用皮革包裹著金錢 , 外型就像一個質地柔軟的皮革包。不設置傳統的金屬鈕扣 , 反而使用長皮帶去纏繞綑綁長夾 , 可按照放置物品多少去增減皮帶纏繞的圈數與長度。它不只是一個長夾 , 更可作為一個皮革套隨個人喜好而改變使用。在使用概念上非常創新也相當有日本感。" },
                new Product { ProductId = 15, Name = "Urbano 長皮夾", Price = 9924, CategoryId = 3, Color = "darkbrown", Photos = "Longclip5.jpg,Longclip5_D_1.jpg,Longclip5_D_2.jpg,Longclip5_D_3.jpg,Longclip5_D_4.jpg,Longclip5_D_5.jpg", Description = "「生活以使用信用卡為主 , 錢包中備有少量的現金即可」, 職人以此概念製作出商品。尺寸適中 , 容易放入外套 , 適合習慣信用卡消費的時尚男士使用。著重信用卡的收納與紙幣的存放空間 , 還有從外套內袋中取出的優雅表現。義大利優質皮革手感上乘 , 愈使用愈有韻味。" },

                new Product { ProductId = 16, Name = "Belchord 零錢包", Price = 7719, CategoryId = 4, Color = "darkbrown", Photos = "Coinwallet1.jpg,Coinwallet1_D_1.jpg,Coinwallet1_D_2.jpg,Coinwallet1_D_3.jpg,Coinwallet1_D_4.jpg,Coinwallet1_D_5.jpg", Description = "寬口的風琴摺使開闔之間順暢便利 , 3 個副口袋能充分收納信用卡與摺疊紙鈔 , 支付時刻亦從容優雅。外層採用紋理細緻且具鑽石光感的 Cordovan 馬臀皮革 , 內層為灌注職人精巧工藝的手揉水波紋小牛皮 , 與同系列皮夾一同使用 , 更加深您注重細節的品味印象。" },
                new Product { ProductId = 17, Name = "Urbano 零錢包", Price = 4044, CategoryId = 4, Color = "darkbrown", Photos = "Coinwallet2.jpg,Coinwallet2_D_1.jpg,Coinwallet2_D_2.jpg,Coinwallet2_D_3.jpg,Coinwallet2_D_4.jpg,Coinwallet2_D_5.jpg", Description = "皮革源自義大利最美麗的地區托斯卡納州，由當地鞣革工人遵循著千年以上的傳統鞣製法所製成的 Vachetta Milling Leather。採植物鞣製法和牛蹄油共同浸泡，花費數月鞣製。充滿自然手感、紋理平滑、強韌的纖維分布密集的特色。當皮革相互磨擦會發出生動聲響，這是皮革蘊含油分的緣故。隨著使用後，皮革包的顏色和味道都會加深，透明感光澤也會遍布在皮革之上，是可以用心細品的高級皮革。" },
                new Product { ProductId = 18, Name = "Bridle 方形零錢包", Price = 3910, CategoryId = 4, Color = "black", Photos = "Coinwallet3.jpg,Coinwallet3_D_1.jpg,Coinwallet3_D_2.jpg,Coinwallet3_D_3.jpg,Coinwallet3_D_4.jpg,Coinwallet3_D_5.jpg", Description = "Bridle Leather 是英國製作馬具時所採用的傳統頂級素材。堅固強韌的原皮取自成年牛隻肩部 , 經過數月植物鞣製再手工上蠟進行多次擦拭加工 , 歷時四至六個月才能完成。剛開始使用時 , 表面會遍佈霜狀白色粉末 , 隨牛隻、部位、溫度、濕度等要素不同 , 白色霜狀物也不同。霜狀白色粉末會隨著不斷使用與摩擦後會逐漸被皮革吸收 , 有助皮革色澤加深。" },
                new Product { ProductId = 19, Name = "Tone Oilnume 蛙嘴式零錢袋", Price = 5514, CategoryId = 4, Color = "lightbrown", Photos = "Coinwallet4.jpg,Coinwallet4_D_1.jpg,Coinwallet4_D_2.jpg,Coinwallet4_D_3.jpg,Coinwallet4_D_4.jpg,Coinwallet4_D_5.jpg", Description = "百看不厭的復古造型 , 一摸就能感受皮革柔軟質地 , 在使用時會發出「喀」的清脆金屬聲響。它的魅力不需要解釋 , 無論視覺、觸覺、聽覺等都可感受到。使用愈久皮革表面更加柔軟 , 讓人愛不釋手。這個零錢袋的開口較寬大 , 內部有兩個空間可分別收納紙鈔跟票卡 , 相信能夠能滿足喜愛金屬蛙嘴的您。" },
                new Product { ProductId = 20, Name = "Diario 雙釦式零錢包", Price = 2757, CategoryId = 4, Color = "brown", Photos = "Coinwallet5.jpg,Coinwallet5_D_1.jpg,Coinwallet5_D_2.jpg,Coinwallet5_D_3.jpg,Coinwallet5_D_4.jpg,Coinwallet5_D_5.jpg", Description = "一款充滿設計師玩心與巧思得零錢包。內含 1 個零錢包、2 個票卡夾層 , 使用方式由您決定 , 想當成票卡夾、證件夾,都可隨心所欲地變換功能。相信您一定會喜歡上它獨特的外型與皮革的風味。" },
                new Product { ProductId = 21, Name = "Tone Oilnume 蛙嘴式迷你零錢包", Price = 2573, CategoryId = 4, Color = "lightbrown", Photos = "Coinwallet6.jpg,Coinwallet6_D_1.jpg,Coinwallet6_D_2.jpg,Coinwallet6_D_3.jpg,Coinwallet6_D_4.jpg,Coinwallet6_D_5.jpg", Description = "小巧的蛙嘴式零錢包充滿可愛魅力。「啪」一聲就可打開的蛙嘴開口 , 相當方便。好拿好握的圓弧外型 , 一眼看過去也相當簡潔俐落。柔軟的 Oilnume 皮革更為其增加魅力 , 讓人不忍放手。它是一款相當適合送禮的小物喔 !" },
                new Product { ProductId = 22, Name = "Cordovan 馬蹄形零錢包", Price = 8150, CategoryId = 4, Color = "darkbrown", Photos = "Coinwallet7.jpg,Coinwallet7_D_1.jpg,Coinwallet7_D_2.jpg,Coinwallet7_D_3.jpg,Coinwallet7_D_4.jpg,Coinwallet7_D_5.jpg", Description = "馬蹄形在歐洲普遍被視為幸運的象徵。採用皮革中的鑽石作為素材基底 , 並以全手工縫製出擁有優美弧線的馬蹄型零錢包。由於體積精緻小巧 , 又有立體結構與弧形彎曲的技術考驗 , 因此製作時間比想象更加費時。單一使用當然很棒 , 但若搭配上同樣以馬臀皮革所製成的長夾一起使用 , 或許更能整體提昇品味的層次與高度。" },
                new Product { ProductId = 23, Name = "Diario L型拉鍊短夾", Price = 4261, CategoryId = 4, Color = "brown", Photos = "Coinwallet8.jpg,Coinwallet8_D_1.jpg,Coinwallet8_D_2.jpg,Coinwallet8_D_3.jpg,Coinwallet8_D_4.jpg,Coinwallet8_D_5.jpg", Description = "握在手中的輕巧 , 不僅可以作為皮夾也適合收納隨身小物 , 輕鬆配合每個人的生活方式 , 變化性高也是受歡迎的原因之一。每天開闔的 L 型拉鍊 , 在延展性高的皮革上被美麗地縫製固定 , 這需要仰賴資深職人的眼力與手感 , 憑藉經驗仔細製作。精巧的短夾 , 讓您無論是想輕便度過週末或外出旅遊時 , 皆能安心且聰明地運用。" },

                new Product { ProductId = 24, Name = "Bridle 名片夾", Price = 5113, CategoryId = 5, Color = "black", Photos = "Namecard1.jpg,Namecard1_D_1.jpg,Namecard1_D_2.jpg,Namecard1_D_3.jpg,Namecard1_D_4.jpg,Namecard1_D_5.jpg", Description = "英國高級馬具「Bridle Leather」皮革的精美加上職人精緻且強軔的縫製 , 成為一款可以帶來高雅印象的名片夾。外觀簡約端正 , 但具有充足的收納空間 , 主收納袋可放入約 40 張名片 , 次要内袋可放入交換收到的名片。隨著每一次外出拜訪 , 相信您會越來越喜歡它。" },
                new Product { ProductId = 25, Name = "Clarte 信封名片夾", Price = 3492, CategoryId = 5, Color = "blue", Photos = "Namecard2.jpg,Namecard2_D_1.jpg,Namecard2_D_2.jpg,Namecard2_D_3.jpg,Namecard2_D_4.jpg,Namecard2_D_5.jpg", Description = "不妨嘗試使用 Clarte 信封名片夾, 襯托女性工作中散發出的優雅氣息。選用觸感絕佳、具有沉穩光澤的柔軟皮革製成, 未設置任何金屬配件, 僅用插入式皮蓋保護收納在內的名片, 讓整體外觀簡約卻富含細節。打開皮蓋後將驚喜發現撞色搭配, 如此低調卻不失華麗的設計, 讓人在重要場合綻放自信與獨特性。" },
                new Product { ProductId = 26, Name = "Urbano 名片夾", Price = 7719, CategoryId = 5, Color = "darkbrown", Photos = "Namecard3.jpg,Namecard3_D_1.jpg,Namecard3_D_2.jpg,Namecard3_D_3.jpg,Namecard3_D_4.jpg,Namecard3_D_5.jpg", Description = "名片夾設置皮帶來固定皮蓋 , 在質感強烈的皮革上展現出清晰顯眼的縫線。它非常適合要隨身攜帶卡片的商務人員。如此一見難忘的設計 , 確實能以第一印象鎖定對方視線 , 且能容納 70 張卡片 , 更加錦上添花。" },
                new Product { ProductId = 27, Name = "Cordovan 馬臀皮名片夾", Price = 4962, CategoryId = 5, Color = "black", Photos = "Namecard4.jpg,Namecard4_D_1.jpg,Namecard4_D_2.jpg,Namecard4_D_3.jpg,Namecard4_D_4.jpg,Namecard4_D_5.jpg", Description = "Cordovan 有著皮革鑽石之美稱，也被譽為 “King of Leather” 是世界上最高級的皮革。原皮採用農耕馬的臀部，採用百分之百單寧耗費一個月的時間進行鞣製程序。鞣製完成的皮革會交由製革職人刨出細緻且強韌的皮層。Cordovan 採用「水染」製作工法，雖然需要耗時費力層層上蠟、上色，但此工法能讓人直接享受素材紋理，且不被色彩干擾。使用初期，光澤沉穩而安靜 ； 隨著時間增加，逐漸浮現出如同寶石般的透明光感。充滿著高端美麗的品味，絕對是皮革愛好者的極致目標。" },
                new Product { ProductId = 28, Name = "Cordovan 馬臀皮票卡套", Price = 6249, CategoryId = 5, Color = "brown", Photos = "Namecard5.jpg,Namecard5_D_1.jpg,Namecard5_D_2.jpg,Namecard5_D_3.jpg,Namecard5_D_4.jpg,Namecard5_D_5.jpg", Description = "不僅能順暢的刷卡通關 , 還可在手中展現出優美姿態的上等皮製票卡夾。隨著 IC 卡的精簡與多樣化 , 只要放入通勤使用的 IC 卡與公司的 ID 卡 , 一日通勤準備就完成了 ! 接著體驗放在外套或襯衫胸前口袋裡的輕薄感受吧 !" },
                new Product { ProductId = 29, Name = "Urbano 拉鍊卡片夾", Price = 5514, CategoryId = 5, Color = "darkbrown", Photos = "Namecard6.jpg,Namecard6_D_1.jpg,Namecard6_D_2.jpg,Namecard6_D_3.jpg,Namecard6_D_4.jpg,Namecard6_D_5.jpg", Description = "展現極致的簡約洗鍊, 是款帶著雅緻自持的輕薄卡片夾。無多餘設計的外型, 有著恰如其分的機能性。極簡的設計, 能貼合現代無現金支付的生活模式, 將基本機能集中卡片夾層內, 能讓人幾乎忘了存在感的輕薄度, 是款嚮往俐落且優雅結帳的紳士配件。因應偶爾需要現金結帳的場合, 也設計一處拉鍊口袋, 能放入摺疊後的紙鈔及零錢, 是另一處令人著實安心的體貼細節。選用義大利傳統製法鞣製而成的「Vachetta Milling Leather」主要素材, 頂級的皮革質感, 拿握手中, 皆能優雅展現獨特的紳士氣質, 平整的縫線與端正雅緻的設計, 成為每次使用都能讓人沉醉其中的新時代錢包。" },
                new Product { ProductId = 30, Name = "Bridle 拉鍊卡片夾", Price = 5153, CategoryId = 5, Color = "green", Photos = "Namecard7.jpg,Namecard7_D_1.jpg,Namecard7_D_2.jpg,Namecard7_D_3.jpg,Namecard7_D_4.jpg,Namecard7_D_5.jpg", Description = "專門收納放不進皮夾內的卡片、名片。它既輕巧又可隨身攜帶 , 將經常使用的卡片就放入皮夾內 , 其餘的就整齊地收納在這卡片夾吧 ! 三邊使用拉鍊封口 , 開口寬大更容易收納卡片、名片 ; 握在手中十分舒適 , 可一邊享受皮革舊化 (Aging) , 一邊有條理的管理卡片或名片。" }

                );

            context.Categories.AddOrUpdate(
              x => x.CategoryId,
              new Category { CategoryId = 1, CategoryName = "Totebag" },
              new Category { CategoryId = 2, CategoryName = "Backpack" },
              new Category { CategoryId = 3, CategoryName = "Longclip" },
              new Category { CategoryId = 4, CategoryName = "Coinwallet" },
              new Category { CategoryId = 5, CategoryName = "Namecard" }
              );


        }
    }
}
