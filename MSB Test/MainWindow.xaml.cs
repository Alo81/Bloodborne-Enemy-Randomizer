using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SoulsFormats;
using System.IO;

namespace MSB_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int newNumber = 9999;
        List<string> unusedList = new List<string>();
        List<string> bossList = new List<string>();
        List<string> unusedPlusBossList = new List<string>();
        List<string> addedBosses = new List<string>();
        List<MSBB.Part.Enemy> addedEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> addedBossesList = new List<MSBB.Part.Enemy>();
        List<string> logList = new List<string>();
        List<long> npcParams = new List<long>();
        List<long> longList = new List<long>();
        List<MSBB.Part.Enemy> oopsAllEnemyList = new List<MSBB.Part.Enemy>();
        List<string> oopsAllEnemyString = new List<string>();
        string oopsBossString;
        List<MSBB.Part.Enemy> oopsAllBossList = new List<MSBB.Part.Enemy>();
        List<string> oopsAllBossString = new List<string>();
        List<string> BossListString = new List<string>();
        bool includeBosses;
        bool randomize = true;
        bool oopsAllBosses;
        string thisnpc;
        string thismo;
        string thisthink;
        string thisentityID;
        bool insertBossesBool;
        double bossPercentage;
        double chaliceChanceFloat;
        int bossCount = 0;
        bool chaliceBosses;
        bool chaliceEnemies;
        List<string> chaliceEnemiesString = new List<string>();
        List<MSBB.Part.Enemy> chaliceEnemiesMSB = new List<MSBB.Part.Enemy>();
        string bossLogFilePath;
        string enemyLogFilePath;
        bool oopsAll;
        List<string> oopsAllList = new List<string>();
        string oopsAllString;
        List<string> secondaryBosses = new List<string>();
        int totalBossesToReplace = 0;
        List<long> newNPCParam = new List<long>();
        List<long> oldNPCParam = new List<long>();
        long paramNumber = 999999;
        List<string> mapsForParamChanges = new List<string>();
        List<string> chaliceBossString = new List<string>();
        List<MSBB.Part.Enemy> chaliceBossMSB = new List<MSBB.Part.Enemy>();
        List<string> chaliceBossParams = new List<string>();
        List<string> insertBossesString = new List<string>();
        List<MSBB.Part.Enemy> insertBossesEnemy = new List<MSBB.Part.Enemy>();

        public MainWindow()
        {
            InitializeComponent();

            chaliceBossParams.Add("10313090");
            chaliceBossParams.Add("110304090");
            chaliceBossParams.Add("110304098");
            chaliceBossParams.Add("110304096");
            chaliceBossParams.Add("210501006");
            chaliceBossParams.Add("310501006");
            chaliceBossParams.Add("10750090");
            chaliceBossParams.Add("110216090");
            chaliceBossParams.Add("210305006");
            chaliceBossParams.Add("310305006");
            chaliceBossParams.Add("10127090");
            chaliceBossParams.Add("110313080");
            chaliceBossParams.Add("210209096");
            chaliceBossParams.Add("310209096");
            chaliceBossParams.Add("10304090");
            chaliceBossParams.Add("10304096");
            chaliceBossParams.Add("10304098");
            chaliceBossParams.Add("110313070");
            chaliceBossParams.Add("210510096");
            chaliceBossParams.Add("310509006");
            chaliceBossParams.Add("10106090");
            chaliceBossParams.Add("210305016");
            chaliceBossParams.Add("10216090");
            chaliceBossParams.Add("110501000");
            chaliceBossParams.Add("210512096");
            chaliceBossParams.Add("110209090");
            chaliceBossParams.Add("210504000");
            chaliceBossParams.Add("310504000");
            chaliceBossParams.Add("10305006");
            chaliceBossParams.Add("110509010");
            chaliceBossParams.Add("210306016");
            chaliceBossParams.Add("10218090");
            chaliceBossParams.Add("110504000");
            chaliceBossParams.Add("210508006");
            chaliceBossParams.Add("310504000");
            chaliceBossParams.Add("110257000");
            chaliceBossParams.Add("210251096");
            chaliceBossParams.Add("310305016");
            chaliceBossParams.Add("210306015");

            npcParams.Add(100010);
            npcParams.Add(100020);
            npcParams.Add(100021);
            npcParams.Add(100060);
            npcParams.Add(100100);
            npcParams.Add(10100080);
            npcParams.Add(10105080);
            npcParams.Add(10106080);
            npcParams.Add(10106090);
            npcParams.Add(10109080);
            npcParams.Add(10109580);
            npcParams.Add(10110080);
            npcParams.Add(10110081);
            npcParams.Add(10111085);
            npcParams.Add(10111095);
            npcParams.Add(10114080);
            npcParams.Add(10115080);
            npcParams.Add(10116080);
            npcParams.Add(10118080);
            npcParams.Add(10119080);
            npcParams.Add(10121080);
            npcParams.Add(10121180);
            npcParams.Add(10124090);
            npcParams.Add(10127090);
            npcParams.Add(10129000);
            npcParams.Add(10201020);
            npcParams.Add(10201080);
            npcParams.Add(10201081);
            npcParams.Add(10202080);
            npcParams.Add(10213000);
            npcParams.Add(10216000);
            npcParams.Add(10216090);
            npcParams.Add(10218000);
            npcParams.Add(10218090);
            npcParams.Add(10219000);
            npcParams.Add(10252080);
            npcParams.Add(10300000);
            npcParams.Add(10301000);
            npcParams.Add(10301005);
            npcParams.Add(10301010);
            npcParams.Add(10301011);
            npcParams.Add(10301030);
            npcParams.Add(10301040);
            npcParams.Add(10301050);
            npcParams.Add(10301060);
            npcParams.Add(10301147);
            npcParams.Add(10301269);
            npcParams.Add(10301329);
            npcParams.Add(10301349);
            npcParams.Add(10301369);
            npcParams.Add(10301500);
            npcParams.Add(10301510);
            npcParams.Add(10301511);
            npcParams.Add(10301540);
            npcParams.Add(10301550);
            npcParams.Add(10302020);
            npcParams.Add(10304090);
            npcParams.Add(10304096);
            npcParams.Add(10304098);
            npcParams.Add(10312000);
            npcParams.Add(105220);
            npcParams.Add(105230);
            npcParams.Add(105240);
            npcParams.Add(105241);
            npcParams.Add(105242);
            npcParams.Add(105250);
            npcParams.Add(105260);
            npcParams.Add(105270);
            npcParams.Add(105280);
            npcParams.Add(105320);
            npcParams.Add(105330);
            npcParams.Add(105340);
            npcParams.Add(105350);
            npcParams.Add(105360);
            npcParams.Add(105800);
            npcParams.Add(105810);
            npcParams.Add(106020);
            npcParams.Add(106021);
            npcParams.Add(106030);
            npcParams.Add(106101);
            npcParams.Add(106200);
            npcParams.Add(10750090);
            npcParams.Add(109000);
            npcParams.Add(109003);
            npcParams.Add(109010);
            npcParams.Add(109100);
            npcParams.Add(109800);
            npcParams.Add(110010);
            npcParams.Add(110100080);
            npcParams.Add(110101095);
            npcParams.Add(110105080);
            npcParams.Add(110106080);
            npcParams.Add(110106085);
            npcParams.Add(110109080);
            npcParams.Add(110109580);
            npcParams.Add(110110080);
            npcParams.Add(110110081);
            npcParams.Add(110111085);
            npcParams.Add(110111095);
            npcParams.Add(110112080);
            npcParams.Add(110115080);
            npcParams.Add(110118080);
            npcParams.Add(110119080);
            npcParams.Add(110121080);
            npcParams.Add(110121090);
            npcParams.Add(110122081);
            npcParams.Add(110124090);
            npcParams.Add(110126000);
            npcParams.Add(110129000);
            npcParams.Add(110201020);
            npcParams.Add(110201080);
            npcParams.Add(110201081);
            npcParams.Add(110201128);
            npcParams.Add(110202080);
            npcParams.Add(110209090);
            npcParams.Add(110216090);
            npcParams.Add(110218000);
            npcParams.Add(110250080);
            npcParams.Add(110252080);
            npcParams.Add(110257000);
            npcParams.Add(110300000);
            npcParams.Add(110301000);
            npcParams.Add(110301005);
            npcParams.Add(110301009);
            npcParams.Add(110301010);
            npcParams.Add(110301011);
            npcParams.Add(110301030);
            npcParams.Add(110301040);
            npcParams.Add(110301050);
            npcParams.Add(110301060);
            npcParams.Add(110301070);
            npcParams.Add(110301147);
            npcParams.Add(110301149);
            npcParams.Add(110301169);
            npcParams.Add(110301247);
            npcParams.Add(110301249);
            npcParams.Add(110301267);
            npcParams.Add(110301329);
            npcParams.Add(110301349);
            npcParams.Add(110301369);
            npcParams.Add(110301500);
            npcParams.Add(110301510);
            npcParams.Add(110301530);
            npcParams.Add(110301540);
            npcParams.Add(110301550);
            npcParams.Add(110302020);
            npcParams.Add(110304090);
            npcParams.Add(110304096);
            npcParams.Add(110304098);
            npcParams.Add(110312000);
            npcParams.Add(110313010);
            npcParams.Add(110350);
            npcParams.Add(110351);
            npcParams.Add(110352);
            npcParams.Add(110504000);
            npcParams.Add(111010);
            npcParams.Add(111012);
            npcParams.Add(111600);
            npcParams.Add(111610);
            npcParams.Add(112070);
            npcParams.Add(112071);
            npcParams.Add(112400);
            npcParams.Add(112401);
            npcParams.Add(112402);
            npcParams.Add(114000);
            npcParams.Add(117000);
            npcParams.Add(117070);
            npcParams.Add(117100);
            npcParams.Add(117300);
            npcParams.Add(117301);
            npcParams.Add(117350);
            npcParams.Add(117351);
            npcParams.Add(117400);
            npcParams.Add(117450);
            npcParams.Add(117460);
            npcParams.Add(117600);
            npcParams.Add(117900);
            npcParams.Add(118010);
            npcParams.Add(118011);
            npcParams.Add(118012);
            npcParams.Add(118013);
            npcParams.Add(118014);
            npcParams.Add(118015);
            npcParams.Add(118020);
            npcParams.Add(118021);
            npcParams.Add(118022);
            npcParams.Add(118030);
            npcParams.Add(118040);
            npcParams.Add(118041);
            npcParams.Add(118052);
            npcParams.Add(118070);
            npcParams.Add(118082);
            npcParams.Add(118090);
            npcParams.Add(118091);
            npcParams.Add(118092);
            npcParams.Add(118100);
            npcParams.Add(118101);
            npcParams.Add(118103);
            npcParams.Add(118110);
            npcParams.Add(118111);
            npcParams.Add(118112);
            npcParams.Add(118113);
            npcParams.Add(118115);
            npcParams.Add(118116);
            npcParams.Add(118118);
            npcParams.Add(118120);
            npcParams.Add(118122);
            npcParams.Add(118124);
            npcParams.Add(118126);
            npcParams.Add(118127);
            npcParams.Add(118129);
            npcParams.Add(118130);
            npcParams.Add(118131);
            npcParams.Add(118132);
            npcParams.Add(118134);
            npcParams.Add(118135);
            npcParams.Add(118136);
            npcParams.Add(118139);
            npcParams.Add(118700);
            npcParams.Add(118701);
            npcParams.Add(118800);
            npcParams.Add(118801);
            npcParams.Add(118802);
            npcParams.Add(118900);
            npcParams.Add(119002);
            npcParams.Add(119004);
            npcParams.Add(119005);
            npcParams.Add(119007);
            npcParams.Add(119009);
            npcParams.Add(120110080);
            npcParams.Add(120111080);
            npcParams.Add(120111085);
            npcParams.Add(120121080);
            npcParams.Add(120124090);
            npcParams.Add(120126000);
            npcParams.Add(120201080);
            npcParams.Add(120201081);
            npcParams.Add(120301000);
            npcParams.Add(120301010);
            npcParams.Add(120301011);
            npcParams.Add(120301030);
            npcParams.Add(120301040);
            npcParams.Add(120301050);
            npcParams.Add(120301060);
            npcParams.Add(120301500);
            npcParams.Add(120301501);
            npcParams.Add(120301510);
            npcParams.Add(120301511);
            npcParams.Add(120301520);
            npcParams.Add(120301540);
            npcParams.Add(120301550);
            npcParams.Add(120302010);
            npcParams.Add(120303000);
            npcParams.Add(120303020);
            npcParams.Add(120304000);
            npcParams.Add(120304020);
            npcParams.Add(120304040);
            npcParams.Add(120304050);
            npcParams.Add(122000);
            npcParams.Add(122002);
            npcParams.Add(124080);
            npcParams.Add(124400);
            npcParams.Add(124401);
            npcParams.Add(124410);
            npcParams.Add(124412);
            npcParams.Add(124500);
            npcParams.Add(124501);
            npcParams.Add(124600);
            npcParams.Add(124700);
            npcParams.Add(124800);
            npcParams.Add(124910);
            npcParams.Add(125001);
            npcParams.Add(125002);
            npcParams.Add(125303000);
            npcParams.Add(125303010);
            npcParams.Add(125303169);
            npcParams.Add(125304000);
            npcParams.Add(125304050);
            npcParams.Add(125304128);
            npcParams.Add(126000);
            npcParams.Add(126001);
            npcParams.Add(126002);
            npcParams.Add(127400);
            npcParams.Add(127500);
            npcParams.Add(127600);
            npcParams.Add(127800);
            npcParams.Add(129010);
            npcParams.Add(129050);
            npcParams.Add(130000);
            npcParams.Add(140010);
            npcParams.Add(200000);
            npcParams.Add(200090);
            npcParams.Add(200110);
            npcParams.Add(200200);
            npcParams.Add(20110080);
            npcParams.Add(20111011);
            npcParams.Add(20111085);
            npcParams.Add(20114080);
            npcParams.Add(20124090);
            npcParams.Add(202000);
            npcParams.Add(202006);
            npcParams.Add(20201080);
            npcParams.Add(20201081);
            npcParams.Add(20301000);
            npcParams.Add(20301010);
            npcParams.Add(20301011);
            npcParams.Add(20301040);
            npcParams.Add(20301050);
            npcParams.Add(20301060);
            npcParams.Add(20301500);
            npcParams.Add(20301510);
            npcParams.Add(20301511);
            npcParams.Add(20301540);
            npcParams.Add(20301550);
            npcParams.Add(20302030);
            npcParams.Add(20303000);
            npcParams.Add(20303020);
            npcParams.Add(20304000);
            npcParams.Add(20304010);
            npcParams.Add(20304020);
            npcParams.Add(20304040);
            npcParams.Add(204600);
            npcParams.Add(205010);
            npcParams.Add(205220);
            npcParams.Add(209010);
            npcParams.Add(210005);
            npcParams.Add(210100080);
            npcParams.Add(210100102);
            npcParams.Add(210100180);
            npcParams.Add(210101095);
            npcParams.Add(210105080);
            npcParams.Add(210106080);
            npcParams.Add(210106085);
            npcParams.Add(210109080);
            npcParams.Add(210109580);
            npcParams.Add(210110080);
            npcParams.Add(210110081);
            npcParams.Add(210111085);
            npcParams.Add(210111095);
            npcParams.Add(210115080);
            npcParams.Add(210116080);
            npcParams.Add(210118080);
            npcParams.Add(210122081);
            npcParams.Add(210124090);
            npcParams.Add(210140000);
            npcParams.Add(210140010);
            npcParams.Add(210201020);
            npcParams.Add(210201080);
            npcParams.Add(210201081);
            npcParams.Add(210202080);
            npcParams.Add(210208080);
            npcParams.Add(210209096);
            npcParams.Add(210216000);
            npcParams.Add(210218000);
            npcParams.Add(210250080);
            npcParams.Add(210250206);
            npcParams.Add(210252080);
            npcParams.Add(210253000);
            npcParams.Add(210253010);
            npcParams.Add(210300000);
            npcParams.Add(210301000);
            npcParams.Add(210301005);
            npcParams.Add(210301010);
            npcParams.Add(210301030);
            npcParams.Add(210301040);
            npcParams.Add(210301050);
            npcParams.Add(210301060);
            npcParams.Add(210301070);
            npcParams.Add(210301147);
            npcParams.Add(210301149);
            npcParams.Add(210301169);
            npcParams.Add(210301249);
            npcParams.Add(210301267);
            npcParams.Add(210301329);
            npcParams.Add(210301349);
            npcParams.Add(210301369);
            npcParams.Add(210301500);
            npcParams.Add(210301510);
            npcParams.Add(210301511);
            npcParams.Add(210301540);
            npcParams.Add(210301550);
            npcParams.Add(210302030);
            npcParams.Add(210302109);
            npcParams.Add(210302169);
            npcParams.Add(210306015);
            npcParams.Add(210306100);
            npcParams.Add(210312000);
            npcParams.Add(210313010);
            npcParams.Add(210313012);
            npcParams.Add(210504000);
            npcParams.Add(210512096);
            npcParams.Add(210750080);
            npcParams.Add(211000);
            npcParams.Add(212600);
            npcParams.Add(212610);
            npcParams.Add(212620);
            npcParams.Add(213500);
            npcParams.Add(213510);
            npcParams.Add(213530);
            npcParams.Add(215000);
            npcParams.Add(215010);
            npcParams.Add(217000);
            npcParams.Add(217001);
            npcParams.Add(217002);
            npcParams.Add(217003);
            npcParams.Add(218300);
            npcParams.Add(218310);
            npcParams.Add(218320);
            npcParams.Add(218400);
            npcParams.Add(218600);
            npcParams.Add(218610);
            npcParams.Add(219400);
            npcParams.Add(219500);
            npcParams.Add(219600);
            npcParams.Add(2200111);
            npcParams.Add(2200130);
            npcParams.Add(2200140);
            npcParams.Add(2200170);
            npcParams.Add(2200200);
            npcParams.Add(2200230);
            npcParams.Add(2200240);
            npcParams.Add(2200250);
            npcParams.Add(2200261);
            npcParams.Add(2200280);
            npcParams.Add(2200410);
            npcParams.Add(2200440);
            npcParams.Add(2200502);
            npcParams.Add(2200710);
            npcParams.Add(2200810);
            npcParams.Add(220110080);
            npcParams.Add(220111085);
            npcParams.Add(220121080);
            npcParams.Add(220124090);
            npcParams.Add(220201080);
            npcParams.Add(220201081);
            npcParams.Add(220301000);
            npcParams.Add(220301010);
            npcParams.Add(220301011);
            npcParams.Add(220301040);
            npcParams.Add(220301050);
            npcParams.Add(220301060);
            npcParams.Add(220301329);
            npcParams.Add(220301500);
            npcParams.Add(220301501);
            npcParams.Add(220301510);
            npcParams.Add(220301511);
            npcParams.Add(220301520);
            npcParams.Add(220301530);
            npcParams.Add(220301540);
            npcParams.Add(220301550);
            npcParams.Add(220302030);
            npcParams.Add(220303000);
            npcParams.Add(220303020);
            npcParams.Add(220304020);
            npcParams.Add(220304050);
            npcParams.Add(225000);
            npcParams.Add(225020);
            npcParams.Add(225040);
            npcParams.Add(225303000);
            npcParams.Add(225303010);
            npcParams.Add(225303020);
            npcParams.Add(225303162);
            npcParams.Add(225304000);
            npcParams.Add(225304010);
            npcParams.Add(225304020);
            npcParams.Add(225304040);
            npcParams.Add(226000);
            npcParams.Add(2300200);
            npcParams.Add(2300220);
            npcParams.Add(2300250);
            npcParams.Add(2300251);
            npcParams.Add(2300252);
            npcParams.Add(2300300);
            npcParams.Add(2300314);
            npcParams.Add(2300400);
            npcParams.Add(2300500);
            npcParams.Add(2300600);
            npcParams.Add(2300750);
            npcParams.Add(232100);
            npcParams.Add(233000);
            npcParams.Add(233010);
            npcParams.Add(233011);
            npcParams.Add(233020);
            npcParams.Add(233021);
            npcParams.Add(240010);
            npcParams.Add(2400106);
            npcParams.Add(2400107);
            npcParams.Add(2400109);
            npcParams.Add(2400110);
            npcParams.Add(2400111);
            npcParams.Add(2400116);
            npcParams.Add(2400126);
            npcParams.Add(2400127);
            npcParams.Add(2400128);
            npcParams.Add(2400136);
            npcParams.Add(2400137);
            npcParams.Add(2400139);
            npcParams.Add(2400156);
            npcParams.Add(2400160);
            npcParams.Add(2400161);
            npcParams.Add(2400162);
            npcParams.Add(2400163);
            npcParams.Add(2400172);
            npcParams.Add(2400203);
            npcParams.Add(2400205);
            npcParams.Add(2400207);
            npcParams.Add(2400211);
            npcParams.Add(2400220);
            npcParams.Add(2400230);
            npcParams.Add(2400231);
            npcParams.Add(2400344);
            npcParams.Add(2400360);
            npcParams.Add(2400371);
            npcParams.Add(2400372);
            npcParams.Add(2400373);
            npcParams.Add(2400374);
            npcParams.Add(2400375);
            npcParams.Add(2400391);
            npcParams.Add(2400392);
            npcParams.Add(2400400);
            npcParams.Add(2400402);
            npcParams.Add(2400403);
            npcParams.Add(2400405);
            npcParams.Add(2400406);
            npcParams.Add(2400422);
            npcParams.Add(2400423);
            npcParams.Add(2400450);
            npcParams.Add(2400500);
            npcParams.Add(2400501);
            npcParams.Add(2400503);
            npcParams.Add(2400509);
            npcParams.Add(2400601);
            npcParams.Add(2400603);
            npcParams.Add(2400710);
            npcParams.Add(2400756);
            npcParams.Add(240600);
            npcParams.Add(240610);
            npcParams.Add(2410015);
            npcParams.Add(2410019);
            npcParams.Add(2410023);
            npcParams.Add(2410026);
            npcParams.Add(2410027);
            npcParams.Add(2410102);
            npcParams.Add(2410103);
            npcParams.Add(2410113);
            npcParams.Add(2410132);
            npcParams.Add(2410148);
            npcParams.Add(2410149);
            npcParams.Add(2410150);
            npcParams.Add(2410158);
            npcParams.Add(2410194);
            npcParams.Add(2410200);
            npcParams.Add(2410202);
            npcParams.Add(2410226);
            npcParams.Add(2410275);
            npcParams.Add(2410291);
            npcParams.Add(2410292);
            npcParams.Add(2410293);
            npcParams.Add(2410294);
            npcParams.Add(2410295);
            npcParams.Add(2410296);
            npcParams.Add(2410750);
            npcParams.Add(2410771);
            npcParams.Add(2410781);
            npcParams.Add(2420200);
            npcParams.Add(2420268);
            npcParams.Add(2420300);
            npcParams.Add(2420350);
            npcParams.Add(2420388);
            npcParams.Add(2420400);
            npcParams.Add(2420450);
            npcParams.Add(2420451);
            npcParams.Add(2420452);
            npcParams.Add(2420710);
            npcParams.Add(2420711);
            npcParams.Add(2420811);
            npcParams.Add(2500102);
            npcParams.Add(2500106);
            npcParams.Add(2500115);
            npcParams.Add(2500137);
            npcParams.Add(2500180);
            npcParams.Add(2500191);
            npcParams.Add(2500200);
            npcParams.Add(2500241);
            npcParams.Add(2500280);
            npcParams.Add(2500402);
            npcParams.Add(250061);
            npcParams.Add(250062);
            npcParams.Add(250063);
            npcParams.Add(250064);
            npcParams.Add(250065);
            npcParams.Add(250066);
            npcParams.Add(250070);
            npcParams.Add(2500710);
            npcParams.Add(2500801);
            npcParams.Add(250081);
            npcParams.Add(250082);
            npcParams.Add(252000);
            npcParams.Add(252001);
            npcParams.Add(252100);
            npcParams.Add(25303000);
            npcParams.Add(25303010);
            npcParams.Add(25303020);
            npcParams.Add(25303169);
            npcParams.Add(25304000);
            npcParams.Add(25304040);
            npcParams.Add(25304148);
            npcParams.Add(253200);
            npcParams.Add(254000);
            npcParams.Add(254010);
            npcParams.Add(255000);
            npcParams.Add(255010);
            npcParams.Add(256000);
            npcParams.Add(256100);
            npcParams.Add(256600);
            npcParams.Add(256610);
            npcParams.Add(256699);
            npcParams.Add(256900);
            npcParams.Add(256910);
            npcParams.Add(257010);
            npcParams.Add(2600100);
            npcParams.Add(2600102);
            npcParams.Add(2600103);
            npcParams.Add(2600106);
            npcParams.Add(2600114);
            npcParams.Add(2600129);
            npcParams.Add(2600145);
            npcParams.Add(2600150);
            npcParams.Add(2600161);
            npcParams.Add(2600180);
            npcParams.Add(2600190);
            npcParams.Add(260020);
            npcParams.Add(2600201);
            npcParams.Add(2600210);
            npcParams.Add(2600300);
            npcParams.Add(2600310);
            npcParams.Add(2600400);
            npcParams.Add(2600401);
            npcParams.Add(2600403);
            npcParams.Add(260060);
            npcParams.Add(2600700);
            npcParams.Add(260240);
            npcParams.Add(260241);
            npcParams.Add(260242);
            npcParams.Add(260300);
            npcParams.Add(260320);
            npcParams.Add(261000);
            npcParams.Add(261010);
            npcParams.Add(261020);
            npcParams.Add(261030);
            npcParams.Add(261040);
            npcParams.Add(261800);
            npcParams.Add(261810);
            npcParams.Add(261820);
            npcParams.Add(261830);
            npcParams.Add(261840);
            npcParams.Add(262001);
            npcParams.Add(262030);
            npcParams.Add(262121);
            npcParams.Add(262310);
            npcParams.Add(262410);
            npcParams.Add(262800);
            npcParams.Add(262810);
            npcParams.Add(262820);
            npcParams.Add(262910);
            npcParams.Add(262915);
            npcParams.Add(262920);
            npcParams.Add(262930);
            npcParams.Add(263000);
            npcParams.Add(263010);
            npcParams.Add(263030);
            npcParams.Add(263040);
            npcParams.Add(263050);
            npcParams.Add(263060);
            npcParams.Add(263061);
            npcParams.Add(263066);
            npcParams.Add(263070);
            npcParams.Add(263080);
            npcParams.Add(263081);
            npcParams.Add(263100);
            npcParams.Add(263130);
            npcParams.Add(263180);
            npcParams.Add(263182);
            npcParams.Add(263200);
            npcParams.Add(263202);
            npcParams.Add(263203);
            npcParams.Add(263233);
            npcParams.Add(263250);
            npcParams.Add(263252);
            npcParams.Add(263254);
            npcParams.Add(263270);
            npcParams.Add(263273);
            npcParams.Add(263280);
            npcParams.Add(263281);
            npcParams.Add(263282);
            npcParams.Add(263400);
            npcParams.Add(263410);
            npcParams.Add(263430);
            npcParams.Add(263432);
            npcParams.Add(263433);
            npcParams.Add(263440);
            npcParams.Add(263450);
            npcParams.Add(263470);
            npcParams.Add(263530);
            npcParams.Add(263540);
            npcParams.Add(263550);
            npcParams.Add(263581);
            npcParams.Add(263610);
            npcParams.Add(263630);
            npcParams.Add(263681);
            npcParams.Add(263800);
            npcParams.Add(263801);
            npcParams.Add(263810);
            npcParams.Add(263830);
            npcParams.Add(263831);
            npcParams.Add(263835);
            npcParams.Add(263841);
            npcParams.Add(263850);
            npcParams.Add(263851);
            npcParams.Add(263860);
            npcParams.Add(263870);
            npcParams.Add(263895);
            npcParams.Add(264100);
            npcParams.Add(264200);
            npcParams.Add(264210);
            npcParams.Add(264400);
            npcParams.Add(264401);
            npcParams.Add(264410);
            npcParams.Add(264601);
            npcParams.Add(264800);
            npcParams.Add(264801);
            npcParams.Add(264810);
            npcParams.Add(264811);
            npcParams.Add(2700100);
            npcParams.Add(2700101);
            npcParams.Add(2700104);
            npcParams.Add(2700110);
            npcParams.Add(2700114);
            npcParams.Add(2700117);
            npcParams.Add(2700128);
            npcParams.Add(2700131);
            npcParams.Add(2700135);
            npcParams.Add(2700139);
            npcParams.Add(2700146);
            npcParams.Add(2700151);
            npcParams.Add(2700155);
            npcParams.Add(2700200);
            npcParams.Add(2700256);
            npcParams.Add(2700300);
            npcParams.Add(2700301);
            npcParams.Add(2700351);
            npcParams.Add(2700354);
            npcParams.Add(2700402);
            npcParams.Add(2700417);
            npcParams.Add(2700419);
            npcParams.Add(2700450);
            npcParams.Add(2700500);
            npcParams.Add(2700512);
            npcParams.Add(2700513);
            npcParams.Add(2700551);
            npcParams.Add(2700610);
            npcParams.Add(2700650);
            npcParams.Add(2700652);
            npcParams.Add(2700680);
            npcParams.Add(2700703);
            npcParams.Add(2700706);
            npcParams.Add(2700710);
            npcParams.Add(2700750);
            npcParams.Add(2700756);
            npcParams.Add(2700804);
            npcParams.Add(270100);
            npcParams.Add(270102);
            npcParams.Add(270112);
            npcParams.Add(270120);
            npcParams.Add(270121);
            npcParams.Add(270122);
            npcParams.Add(270142);
            npcParams.Add(270152);
            npcParams.Add(270161);
            npcParams.Add(270200);
            npcParams.Add(270220);
            npcParams.Add(270250);
            npcParams.Add(270350);
            npcParams.Add(271010);
            npcParams.Add(273100);
            npcParams.Add(273101);
            npcParams.Add(273102);
            npcParams.Add(273120);
            npcParams.Add(273211);
            npcParams.Add(273300);
            npcParams.Add(273400);
            npcParams.Add(274000);
            npcParams.Add(274001);
            npcParams.Add(274010);
            npcParams.Add(274100);
            npcParams.Add(274101);
            npcParams.Add(274111);
            npcParams.Add(2800104);
            npcParams.Add(2800140);
            npcParams.Add(2800162);
            npcParams.Add(2800180);
            npcParams.Add(2800200);
            npcParams.Add(2800210);
            npcParams.Add(2800220);
            npcParams.Add(2800240);
            npcParams.Add(2800241);
            npcParams.Add(2800300);
            npcParams.Add(2800301);
            npcParams.Add(2800302);
            npcParams.Add(2800303);
            npcParams.Add(2800304);
            npcParams.Add(2800309);
            npcParams.Add(2800310);
            npcParams.Add(2800311);
            npcParams.Add(2800312);
            npcParams.Add(2800313);
            npcParams.Add(2800319);
            npcParams.Add(2800380);
            npcParams.Add(2800382);
            npcParams.Add(2800383);
            npcParams.Add(2800384);
            npcParams.Add(2800400);
            npcParams.Add(2800401);
            npcParams.Add(2800402);
            npcParams.Add(2800404);
            npcParams.Add(2800406);
            npcParams.Add(2800460);
            npcParams.Add(2800461);
            npcParams.Add(2800462);
            npcParams.Add(2800480);
            npcParams.Add(2800500);
            npcParams.Add(2800520);
            npcParams.Add(2800540);
            npcParams.Add(2800560);
            npcParams.Add(2800572);
            npcParams.Add(2800710);
            npcParams.Add(2800720);
            npcParams.Add(2800721);
            npcParams.Add(2800722);
            npcParams.Add(2800723);
            npcParams.Add(30111011);
            npcParams.Add(310000);
            npcParams.Add(310001);
            npcParams.Add(310100080);
            npcParams.Add(310100102);
            npcParams.Add(310100180);
            npcParams.Add(310101095);
            npcParams.Add(310105080);
            npcParams.Add(310106080);
            npcParams.Add(310106085);
            npcParams.Add(310109080);
            npcParams.Add(310109102);
            npcParams.Add(310109580);
            npcParams.Add(310110080);
            npcParams.Add(310110081);
            npcParams.Add(310111085);
            npcParams.Add(310111095);
            npcParams.Add(310112080);
            npcParams.Add(310115080);
            npcParams.Add(310116080);
            npcParams.Add(310118080);
            npcParams.Add(310124090);
            npcParams.Add(310126000);
            npcParams.Add(310201020);
            npcParams.Add(310201080);
            npcParams.Add(310201081);
            npcParams.Add(310201108);
            npcParams.Add(310201128);
            npcParams.Add(310202080);
            npcParams.Add(310208080);
            npcParams.Add(310209096);
            npcParams.Add(310210180);
            npcParams.Add(310216000);
            npcParams.Add(310218000);
            npcParams.Add(310218010);
            npcParams.Add(310250080);
            npcParams.Add(310250081);
            npcParams.Add(310252080);
            npcParams.Add(310253000);
            npcParams.Add(310253010);
            npcParams.Add(310253020);
            npcParams.Add(310300000);
            npcParams.Add(310301000);
            npcParams.Add(310301005);
            npcParams.Add(310301009);
            npcParams.Add(310301010);
            npcParams.Add(310301011);
            npcParams.Add(310301030);
            npcParams.Add(310301040);
            npcParams.Add(310301050);
            npcParams.Add(310301060);
            npcParams.Add(310301070);
            npcParams.Add(310301147);
            npcParams.Add(310301149);
            npcParams.Add(310301167);
            npcParams.Add(310301169);
            npcParams.Add(310301229);
            npcParams.Add(310301247);
            npcParams.Add(310301329);
            npcParams.Add(310301349);
            npcParams.Add(310301369);
            npcParams.Add(310301500);
            npcParams.Add(310301510);
            npcParams.Add(310301540);
            npcParams.Add(310301550);
            npcParams.Add(310302030);
            npcParams.Add(310302108);
            npcParams.Add(310305006);
            npcParams.Add(310305016);
            npcParams.Add(310312000);
            npcParams.Add(310313001);
            npcParams.Add(310501006);
            npcParams.Add(310504000);
            npcParams.Add(310750080);
            npcParams.Add(3200200);
            npcParams.Add(3200316);
            npcParams.Add(3200317);
            npcParams.Add(3200333);
            npcParams.Add(3200336);
            npcParams.Add(3200337);
            npcParams.Add(3200338);
            npcParams.Add(3200421);
            npcParams.Add(3200500);
            npcParams.Add(3200600);
            npcParams.Add(3200620);
            npcParams.Add(3200710);
            npcParams.Add(320110080);
            npcParams.Add(320111085);
            npcParams.Add(320121080);
            npcParams.Add(320124090);
            npcParams.Add(320126000);
            npcParams.Add(320201080);
            npcParams.Add(320201081);
            npcParams.Add(320301000);
            npcParams.Add(320301010);
            npcParams.Add(320301011);
            npcParams.Add(320301030);
            npcParams.Add(320301040);
            npcParams.Add(320301050);
            npcParams.Add(320301060);
            npcParams.Add(320301500);
            npcParams.Add(320301510);
            npcParams.Add(320301530);
            npcParams.Add(320301540);
            npcParams.Add(320301550);
            npcParams.Add(320303000);
            npcParams.Add(320303020);
            npcParams.Add(320304000);
            npcParams.Add(320304010);
            npcParams.Add(320304040);
            npcParams.Add(325303000);
            npcParams.Add(325303020);
            npcParams.Add(325303122);
            npcParams.Add(325304000);
            npcParams.Add(325304010);
            npcParams.Add(325304020);
            npcParams.Add(325304040);
            npcParams.Add(325304168);
            npcParams.Add(3300101);
            npcParams.Add(3300102);
            npcParams.Add(3300104);
            npcParams.Add(3300202);
            npcParams.Add(3300252);
            npcParams.Add(3300254);
            npcParams.Add(3300257);
            npcParams.Add(3300259);
            npcParams.Add(3300262);
            npcParams.Add(3300350);
            npcParams.Add(3300400);
            npcParams.Add(3300417);
            npcParams.Add(3300450);
            npcParams.Add(3300453);
            npcParams.Add(3300500);
            npcParams.Add(3300520);
            npcParams.Add(3300551);
            npcParams.Add(3300555);
            npcParams.Add(3300558);
            npcParams.Add(3300560);
            npcParams.Add(3300562);
            npcParams.Add(3300565);
            npcParams.Add(3300569);
            npcParams.Add(3300573);
            npcParams.Add(3300575);
            npcParams.Add(3300576);
            npcParams.Add(3300578);
            npcParams.Add(3300581);
            npcParams.Add(3300582);
            npcParams.Add(3300583);
            npcParams.Add(3300587);
            npcParams.Add(3300588);
            npcParams.Add(3300589);
            npcParams.Add(3300590);
            npcParams.Add(3300591);
            npcParams.Add(3300593);
            npcParams.Add(3300700);
            npcParams.Add(3400106);
            npcParams.Add(3400139);
            npcParams.Add(3400165);
            npcParams.Add(3400200);
            npcParams.Add(3400202);
            npcParams.Add(3400282);
            npcParams.Add(3400303);
            npcParams.Add(3400315);
            npcParams.Add(3400403);
            npcParams.Add(3400404);
            npcParams.Add(3400406);
            npcParams.Add(3400408);
            npcParams.Add(3400456);
            npcParams.Add(3400508);
            npcParams.Add(3400551);
            npcParams.Add(3400552);
            npcParams.Add(3400601);
            npcParams.Add(3400650);
            npcParams.Add(3400680);
            npcParams.Add(3400681);
            npcParams.Add(3400790);
            npcParams.Add(3400810);
            npcParams.Add(3500301);
            npcParams.Add(3500306);
            npcParams.Add(3500315);
            npcParams.Add(3500316);
            npcParams.Add(3500321);
            npcParams.Add(3500322);
            npcParams.Add(3500342);
            npcParams.Add(3500346);
            npcParams.Add(3500347);
            npcParams.Add(3500392);
            npcParams.Add(3500393);
            npcParams.Add(3500400);
            npcParams.Add(3500451);
            npcParams.Add(3500452);
            npcParams.Add(3500500);
            npcParams.Add(3500501);
            npcParams.Add(3500600);
            npcParams.Add(3500655);
            npcParams.Add(3500740);
            npcParams.Add(3500741);
            npcParams.Add(3500742);
            npcParams.Add(3500750);
            npcParams.Add(3500760);
            npcParams.Add(3500764);
            npcParams.Add(3500770);
            npcParams.Add(3500773);
            npcParams.Add(3500775);
            npcParams.Add(3500780);
            npcParams.Add(3500781);
            npcParams.Add(3500790);
            npcParams.Add(3600200);
            npcParams.Add(3600201);
            npcParams.Add(3600210);
            npcParams.Add(3600215);
            npcParams.Add(3600222);
            npcParams.Add(3600229);
            npcParams.Add(3600232);
            npcParams.Add(3600250);
            npcParams.Add(3600300);
            npcParams.Add(3600301);
            npcParams.Add(3600302);
            npcParams.Add(3600303);
            npcParams.Add(3600310);
            npcParams.Add(3600330);
            npcParams.Add(3600400);
            npcParams.Add(3600401);
            npcParams.Add(3600450);
            npcParams.Add(3600500);
            npcParams.Add(3600510);
            npcParams.Add(3600600);
            npcParams.Add(3600710);
            npcParams.Add(3600790);
            npcParams.Add(3600920);
            npcParams.Add(400000);
            npcParams.Add(400002);
            npcParams.Add(400010);
            npcParams.Add(400020);
            npcParams.Add(400022);
            npcParams.Add(400025);
            npcParams.Add(400026);
            npcParams.Add(400028);
            npcParams.Add(401000);
            npcParams.Add(401001);
            npcParams.Add(401010);
            npcParams.Add(402010);
            npcParams.Add(402020);
            npcParams.Add(402024);
            npcParams.Add(402025);
            npcParams.Add(402026);
            npcParams.Add(402028);
            npcParams.Add(402030);
            npcParams.Add(402035);
            npcParams.Add(402040);
            npcParams.Add(402044);
            npcParams.Add(402045);
            npcParams.Add(402048);
            npcParams.Add(402050);
            npcParams.Add(402060);
            npcParams.Add(402100);
            npcParams.Add(402200);
            npcParams.Add(404000);
            npcParams.Add(404001);
            npcParams.Add(404005);
            npcParams.Add(404006);
            npcParams.Add(404010);
            npcParams.Add(404020);
            npcParams.Add(404025);
            npcParams.Add(404030);
            npcParams.Add(405000);
            npcParams.Add(405020);
            npcParams.Add(405100);
            npcParams.Add(406000);
            npcParams.Add(406005);
            npcParams.Add(406010);
            npcParams.Add(406015);
            npcParams.Add(407000);
            npcParams.Add(407011);
            npcParams.Add(407021);
            npcParams.Add(408000);
            npcParams.Add(409000);
            npcParams.Add(411000);
            npcParams.Add(411030);
            npcParams.Add(411041);
            npcParams.Add(411051);
            npcParams.Add(411060);
            npcParams.Add(412000);
            npcParams.Add(412001);
            npcParams.Add(413000);
            npcParams.Add(414000);
            npcParams.Add(414001);
            npcParams.Add(503300);
            npcParams.Add(504020);
            npcParams.Add(504030);
            npcParams.Add(516000);
            npcParams.Add(750100);

            unusedList.Add("c2120_9999");
            unusedList.Add("c2120_9998");
            unusedList.Add("c0000");
            unusedList.Add("c0");
            unusedList.Add("c1020");
            unusedList.Add("c1030");
            unusedList.Add("c1040");
            unusedList.Add("c1070");
            unusedList.Add("c1080");
            unusedList.Add("c2030");
            unusedList.Add("c2300");
            unusedList.Add("c2310");
            unusedList.Add("c2800");
            unusedList.Add("c2810");
            unusedList.Add("c2910");
            unusedList.Add("c3110");
            unusedList.Add("c4150");
            unusedList.Add("c5030");
            unusedList.Add("c5110");
            unusedList.Add("c5140");
            unusedList.Add("c5150");
            unusedList.Add("c5400");
            unusedList.Add("c5420");
            unusedList.Add("c5500");
            unusedList.Add("c5501");
            unusedList.Add("c5502");
            unusedList.Add("c5520");
            unusedList.Add("c5521");
            unusedList.Add("c5522");
            unusedList.Add("c7000");
            unusedList.Add("c7010");
            unusedList.Add("c7100");
            unusedList.Add("c8010");
            unusedList.Add("c8020");
            unusedList.Add("c2501");
            unusedList.Add("c90");
            unusedList.Add("9999_9999");
            unusedList.Add("9998_9998");
            unusedList.Add("9997_9997");
            unusedList.Add("9996_9996");
            unusedList.Add("9995_9995");
            unusedList.Add("9994_9994");
            unusedList.Add("9993_9993");
            unusedList.Add("9992_9992");
            unusedList.Add("9991_9991");
            unusedList.Add("9990_9990");
            unusedList.Add("9989_9989");
            unusedList.Add("9988_9988");
            unusedList.Add("9987_9987");
            unusedList.Add("9986_9986");
            unusedList.Add("9985_9985");
            unusedList.Add("9984_9984");
            unusedList.Add("9983_9983");
            unusedList.Add("9982_9982");
            unusedList.Add("9981_9981");
            unusedList.Add("9980_9980");
            unusedList.Add("9979_9979");
            unusedList.Add("9978_9978");
            unusedList.Add("9977_9977");
            unusedList.Add("9976_9976");
            unusedList.Add("9975_9975");
            unusedList.Add("9974_9974");
            unusedList.Add("9973_9973");
            unusedList.Add("9972_9972");
            unusedList.Add("9971_9971");
            unusedList.Add("9970_9970");
            unusedList.Add("9969_9969");
            unusedList.Add("9968_9968");
            unusedList.Add("9967_9967");
            unusedList.Add("9966_9966");
            unusedList.Add("9965_9965");
            unusedList.Add("9964_9964");
            unusedList.Add("9963_9963");
            unusedList.Add("9962_9962");
            unusedList.Add("9961_9961");
            unusedList.Add("9960_9960");
            unusedList.Add("9959_9959");
            unusedList.Add("9958_9958");
            unusedList.Add("9957_9957");
            unusedList.Add("9956_9956");
            unusedList.Add("9955_9955");
            unusedList.Add("9954_9954");
            unusedList.Add("9953_9953");
            unusedList.Add("9952_9952");
            unusedList.Add("9951_9951");
            unusedList.Add("9950_9950");
            unusedList.Add("9949_9949");
            unusedList.Add("9948_9948");
            unusedList.Add("9947_9947");
            unusedList.Add("9946_9946");
            unusedList.Add("9945_9945");
            unusedList.Add("9944_9944");
            unusedList.Add("c9030");
            unusedList.Add("c2501");
            unusedList.Add("c2571");
            unusedList.Add("c1130_0000");
            unusedList.Add("c8030_0000");
            unusedList.Add("c8040_0000");
            unusedList.Add("c9020_0000");
            unusedList.Add("c9020_0001");
            unusedList.Add("c9020_0002");
            unusedList.Add("c9020_0003");
            unusedList.Add("c8030_0000");
            unusedList.Add("c5072_0000");
            unusedList.Add("c4023_0000");
            unusedList.Add("c4160_0000");
            unusedList.Add("c4160_0001");
            unusedList.Add("c4160_0002");
            unusedList.Add("c4160_0003");
            unusedList.Add("c4550_0000");
            unusedList.Add("c7110_0000");
            unusedList.Add("c5071_0000");
            unusedList.Add("c4511_0000");
            unusedList.Add("c5510_0001");
            unusedList.Add("c5510_0002");
            unusedList.Add("c4540_0000");
            unusedList.Add("c4543_0000");
            unusedList.Add("c3060_0000");
            unusedList.Add("c8070_0000");
            unusedList.Add("c5130_0000");
            //unusedList.Add("c1110_0000"); patches
            unusedList.Add("c4031_0000");
            unusedList.Add("c4520_0000");

            bossList.Add("5090");
            bossList.Add("c2090_0003");
            bossList.Add("c2100_0000");
            bossList.Add("c2100_0001");
            bossList.Add("c2120_0000");
            bossList.Add("c2120_0001");
            bossList.Add("c2120_0002");
            //bossList.Add("c2121");
            bossList.Add("c2320_0000");
            //bossList.Add("c2321");
            bossList.Add("c2500_0000"); //celestial emmisary (remove)
            bossList.Add("c2570_0001");
            bossList.Add("c2510_0000");
            //bossList.Add("c2570");
            //bossList.Add("c2571");
            bossList.Add("c2710_0000"); //gascoigne
            bossList.Add("c2720_0000");
            //bossList.Add("c4520_0000");
            bossList.Add("c4520_0002");
            bossList.Add("c4030_0000"); //living failures (remove)
            bossList.Add("c4030_0001");
            bossList.Add("c4030_0002");
            bossList.Add("c4030_0003");
            bossList.Add("c4030_0004");
            //bossList.Add("c4031_0000");
            bossList.Add("c4500_0000");
            bossList.Add("c4510_0000");
            bossList.Add("c4540_0000"); //fix kos first phase no death
            //bossList.Add("c4543_0000"); second kos phase?
            bossList.Add("c4541_0000");
            //bossList.Add("c4541");
            //bossList.Add("c4542");
            bossList.Add("c5000_0000"); //cleric beast
            //bossList.Add("c5010");
            bossList.Add("c5020_0000");
            //bossList.Add("c5040");
            
            bossList.Add("c5070_0000");
            //bossList.Add("c5071");
            bossList.Add("c5080_0000");
            //bossList.Add("c5090");
            bossList.Add("c5100_0000");
            bossList.Add("c5120_0001");
            //bossList.Add("c5130");
            //bossList.Add("c5140");
            //bossList.Add("c5150");
            bossList.Add("c5400_0000");
            bossList.Add("c5510_0000");
            //bossList.Add("c8060_0000");
            bossList.Add("c8050_0000");
            bossList.Add("c3130_0000");
            bossList.Add("c5010_0000");
            bossList.Add("c4510_0002");
            bossList.Add("c3050_0000");
            //c3130_0000
            //c5010_0000
            //c3050_0000
            //c5090_0000 110509010
            //c3060_0000 210306016
            //
            //


            for (int i = 0; i < unusedList.Count; i ++)
            {
                unusedPlusBossList.Add(unusedList[i]);
            }
            for(int i = 0; i < bossList.Count; i ++)
            {
                unusedPlusBossList.Add(bossList[i]);
            }
        }

        string currentDirectory;
        string filePath;


        ///regular maps
        List<string> mapList = new List<string>();

        List<MSBB.Part.Enemy> randEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> newEnemyList = new List<MSBB.Part.Enemy>();
        List<string> enemyData = new List<string>();
        List<string> enemyDataRandomized = new List<string>();
        List<MSBB.Model.Enemy> modelList = new List<MSBB.Model.Enemy>();

        private void ParamScalingForBosses(string currentMap)
        {
            var tempMap = MSBB.Read(currentMap);
            
            for(int i = 0; i < tempMap.Parts.Enemies.Count; i ++)
            {
                //Blood Starved Beast
                //209000
                if (tempMap.Parts.Enemies[i].NPCParamID == 209000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097021;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097008;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097004;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097006;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097002;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097016;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097014;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097020;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097010;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097015;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097013;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097011;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097481;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097483;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                        tempMap.Parts.Enemies[i].NPCParamID = 992097486;
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992097001
                //992097002
                //992097003
                //992097004
                //992097006
                //992097007
                //992097008
                //992097009
                //992097010
                //992097011
                //992097013
                //992097014
                //992097015
                //992097016
                //992097017
                //992097019
                //992097020
                //992097021
                //992097022
                //992097023
                //992097024
                //992097480
                //992097481
                //992097482
                //992097483
                //992097484
                //992097485
                //992097486
                //992097487
                //FatherGascoigne
                //271000
                if (tempMap.Parts.Enemies[i].NPCParamID == 271000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992717486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992717001
                //992717002
                //992717003
                //992717004
                //992717006
                //992717007
                //992717008
                //992717009
                //992717010
                //992717011
                //992717013
                //992717014
                //992717015
                //992717016
                //992717017
                //992717019
                //992717020
                //992717021
                //992717022
                //992717023
                //992717024
                //992717480
                //992717481
                //992717482
                //992717483
                //992717484
                //992717485
                //992717486
                //992717487
                //Beast Gascoigne
                //272000
                if (tempMap.Parts.Enemies[i].NPCParamID == 272000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992727486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992727001
                //992727002
                //992727003
                //992727004
                //992727006
                //992727007
                //992727008
                //992727009
                //992727010
                //992727011
                //992727013
                //992727014
                //992727015
                //992727016
                //992727017
                //992727019
                //992727020
                //992727021
                //992727022
                //992727023
                //992727024
                //992727480
                //992727481
                //992727482
                //992727483
                //992727484
                //992727485
                //992727486
                //992727487
                //Cleric Beast
                //500241
                if (tempMap.Parts.Enemies[i].NPCParamID == 500241)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995007486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995007001
                //995007002
                //995007003
                //995007004
                //995007006
                //995007007
                //995007008
                //995007009
                //995007010
                //995007011
                //995007013
                //995007014
                //995007015
                //995007016
                //995007017
                //995007019
                //995007020
                //995007021
                //995007022
                //995007023
                //995007024
                //995007480
                //995007481
                //995007482
                //995007483
                //995007484
                //995007485
                //995007486
                //995007487
                //Vicar Amelia
                //502000
                if (tempMap.Parts.Enemies[i].NPCParamID == 502000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995027486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995027001
                //995027002
                //995027003
                //995027004
                //995027006
                //995027007
                //995027008
                //995027009
                //995027010
                //995027011
                //995027013
                //995027014
                //995027015
                //995027016
                //995027017
                //995027019
                //995027020
                //995027021
                //995027022
                //995027023
                //995027024
                //995027480
                //995027481
                //995027482
                //995027483
                //995027484
                //995027485
                //995027486
                //995027487
                //Darkbeast Paarl
                //508000
                if (tempMap.Parts.Enemies[i].NPCParamID == 508000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995087486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995087001
                //995087002
                //995087003
                //995087004
                //995087006
                //995087007
                //995087008
                //995087009
                //995087010
                //995087011
                //995087013
                //995087014
                //995087015
                //995087016
                //995087017
                //995087019
                //995087020
                //995087021
                //995087022
                //995087023
                //995087024
                //995087480
                //995087481
                //995087482
                //995087483
                //995087484
                //995087485
                //995087486
                //995087487
                //Moon Presence
                //540000
                if (tempMap.Parts.Enemies[i].NPCParamID == 540000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995407486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995407001
                //995407002
                //995407003
                //995407004
                //995407006
                //995407007
                //995407008
                //995407009
                //995407010
                //995407011
                //995407013
                //995407014
                //995407015
                //995407016
                //995407017
                //995407019
                //995407020
                //995407021
                //995407022
                //995407023
                //995407024
                //995407480
                //995407481
                //995407482
                //995407483
                //995407484
                //995407485
                //995407486
                //995407487
                //Gehrman
                //805000
                if (tempMap.Parts.Enemies[i].NPCParamID == 805000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 998057486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //998057001
                //998057002
                //998057003
                //998057004
                //998057006
                //998057007
                //998057008
                //998057009
                //998057010
                //998057011
                //998057013
                //998057014
                //998057015
                //998057016
                //998057017
                //998057019
                //998057020
                //998057021
                //998057022
                //998057023
                //998057024
                //998057480
                //998057481
                //998057482
                //998057483
                //998057484
                //998057485
                //998057486
                //998057487
                //Logarius
                //232000
                if (tempMap.Parts.Enemies[i].NPCParamID == 232000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992327486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992327001
                //992327002
                //992327003
                //992327004
                //992327006
                //992327007
                //992327008
                //992327009
                //992327010
                //992327011
                //992327013
                //992327014
                //992327015
                //992327016
                //992327017
                //992327019
                //992327020
                //992327021
                //992327022
                //992327023
                //992327024
                //992327480
                //992327481
                //992327482
                //992327483
                //992327484
                //992327485
                //992327486
                //992327487
                //One Reborn
                //507000
                if (tempMap.Parts.Enemies[i].NPCParamID == 507000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995077486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995077001
                //995077002
                //995077003
                //995077004
                //995077006
                //995077007
                //995077008
                //995077009
                //995077010
                //995077011
                //995077013
                //995077014
                //995077015
                //995077016
                //995077017
                //995077019
                //995077020
                //995077021
                //995077022
                //995077023
                //995077024
                //995077480
                //995077481
                //995077482
                //995077483
                //995077484
                //995077485
                //995077486
                //995077487
                //Amygdala
                //512000
                if (tempMap.Parts.Enemies[i].NPCParamID == 512000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995127486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995127001
                //995127002
                //995127003
                //995127004
                //995127006
                //995127007
                //995127008
                //995127009
                //995127010
                //995127011
                //995127013
                //995127014
                //995127015
                //995127016
                //995127017
                //995127019
                //995127020
                //995127021
                //995127022
                //995127023
                //995127024
                //995127480
                //995127481
                //995127482
                //995127483
                //995127484
                //995127485
                //995127486
                //995127487
                //Ebrietas
                //251000
                if (tempMap.Parts.Enemies[i].NPCParamID == 251000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992517486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992517001
                //992517002
                //992517003
                //992517004
                //992517006
                //992517007
                //992517008
                //992517009
                //992517010
                //992517011
                //992517013
                //992517014
                //992517015
                //992517016
                //992517017
                //992517019
                //992517020
                //992517021
                //992517022
                //992517023
                //992517024
                //992517480
                //992517481
                //992517482
                //992517483
                //992517484
                //992517485
                //992517486
                //992517487
                //Mergo's Wet Nurse
                //551000
                if (tempMap.Parts.Enemies[i].NPCParamID == 551000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995517486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995517001
                //995517002
                //995517003
                //995517004
                //995517006
                //995517007
                //995517008
                //995517009
                //995517010
                //995517011
                //995517013
                //995517014
                //995517015
                //995517016
                //995517017
                //995517019
                //995517020
                //995517021
                //995517022
                //995517023
                //995517024
                //995517480
                //995517481
                //995517482
                //995517483
                //995517484
                //995517485
                //995517486
                //995517487
                //Rom
                //510000
                if (tempMap.Parts.Enemies[i].NPCParamID == 510000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 995107486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //995107001
                //995107002
                //995107003
                //995107004
                //995107006
                //995107007
                //995107008
                //995107009
                //995107010
                //995107011
                //995107013
                //995107014
                //995107015
                //995107016
                //995107017
                //995107019
                //995107020
                //995107021
                //995107022
                //995107023
                //995107024
                //995107480
                //995107481
                //995107482
                //995107483
                //995107484
                //995107485
                //995107486
                //995107487
                //Ludwig
                //451000
                if (tempMap.Parts.Enemies[i].NPCParamID == 451000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994517486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //994517001
                //994517002
                //994517003
                //994517004
                //994517006
                //994517007
                //994517008
                //994517009
                //994517010
                //994517011
                //994517013
                //994517014
                //994517015
                //994517016
                //994517017
                //994517019
                //994517020
                //994517021
                //994517022
                //994517023
                //994517024
                //994517480
                //994517481
                //994517482
                //994517483
                //994517484
                //994517485
                //994517486
                //994517487
                //Ludwig
                //451001
                if (tempMap.Parts.Enemies[i].NPCParamID == 451001)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994527486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //994527001
                //994527002
                //994527003
                //994527004
                //994527006
                //994527007
                //994527008
                //994527009
                //994527010
                //994527011
                //994527013
                //994527014
                //994527015
                //994527016
                //994527017
                //994527019
                //994527020
                //994527021
                //994527022
                //994527023
                //994527024
                //994527480
                //994527481
                //994527482
                //994527483
                //994527484
                //994527485
                //994527486
                //994527487
                //Orphan
                //454000
                if (tempMap.Parts.Enemies[i].NPCParamID == 454000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994547486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //994547001
                //994547002
                //994547003
                //994547004
                //994547006
                //994547007
                //994547008
                //994547009
                //994547010
                //994547011
                //994547013
                //994547014
                //994547015
                //994547016
                //994547017
                //994547019
                //994547020
                //994547021
                //994547022
                //994547023
                //994547024
                //994547480
                //994547481
                //994547482
                //994547483
                //994547484
                //994547485
                //994547486
                //994547487
                //Maria
                //452000
                if (tempMap.Parts.Enemies[i].NPCParamID == 452000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994537486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //994537001
                //994537002
                //994537003
                //994537004
                //994537006
                //994537007
                //994537008
                //994537009
                //994537010
                //994537011
                //994537013
                //994537014
                //994537015
                //994537016
                //994537017
                //994537019
                //994537020
                //994537021
                //994537022
                //994537023
                //994537024
                //994537480
                //994537481
                //994537482
                //994537483
                //994537484
                //994537485
                //994537486
                //994537487
                //Laurence
                //450000
                if (tempMap.Parts.Enemies[i].NPCParamID == 450000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994507486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //994507001
                //994507002
                //994507003
                //994507004
                //994507006
                //994507007
                //994507008
                //994507009
                //994507010
                //994507011
                //994507013
                //994507014
                //994507015
                //994507016
                //994507017
                //994507019
                //994507020
                //994507021
                //994507022
                //994507023
                //994507024
                //994507480
                //994507481
                //994507482
                //994507483
                //994507484
                //994507485
                //994507486
                //994507487
                //Shadows
                //212700
                if (tempMap.Parts.Enemies[i].NPCParamID == 212700)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992117486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992117001
                //992117002
                //992117003
                //992117004
                //992117006
                //992117007
                //992117008
                //992117009
                //992117010
                //992117011
                //992117013
                //992117014
                //992117015
                //992117016
                //992117017
                //992117019
                //992117020
                //992117021
                //992117022
                //992117023
                //992117024
                //992117480
                //992117481
                //992117482
                //992117483
                //992117484
                //992117485
                //992117486
                //992117487
                //Shadows
                //212710
                if (tempMap.Parts.Enemies[i].NPCParamID == 212710)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992127486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992127001
                //992127002
                //992127003
                //992127004
                //992127006
                //992127007
                //992127008
                //992127009
                //992127010
                //992127011
                //992127013
                //992127014
                //992127015
                //992127016
                //992127017
                //992127019
                //992127020
                //992127021
                //992127022
                //992127023
                //992127024
                //992127480
                //992127481
                //992127482
                //992127483
                //992127484
                //992127485
                //992127486
                //992127487
                //Shadows
                //212720
                if (tempMap.Parts.Enemies[i].NPCParamID == 212720)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992137486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992137001
                //992137002
                //992137003
                //992137004
                //992137006
                //992137007
                //992137008
                //992137009
                //992137010
                //992137011
                //992137013
                //992137014
                //992137015
                //992137016
                //992137017
                //992137019
                //992137020
                //992137021
                //992137022
                //992137023
                //992137024
                //992137480
                //992137481
                //992137482
                //992137483
                //992137484
                //992137485
                //992137486
                //992137487
                //Living failures
                //403000
                if (tempMap.Parts.Enemies[i].NPCParamID == 403000)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 994037486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //994037001
                //994037002
                //994037003
                //994037004
                //994037006
                //994037007
                //994037008
                //994037009
                //994037010
                //994037011
                //994037013
                //994037014
                //994037015
                //994037016
                //994037017
                //994037019
                //994037020
                //994037021
                //994037022
                //994037023
                //994037024
                //994037480
                //994037481
                //994037482
                //994037483
                //994037484
                //994037485
                //994037486
                //994037487
                //Watchdog of the Old Lords
                //210501006
                if (tempMap.Parts.Enemies[i].NPCParamID == 210501006)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992157486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992157001
                //992157002
                //992157003
                //992157004
                //992157006
                //992157007
                //992157008
                //992157009
                //992157010
                //992157011
                //992157013
                //992157014
                //992157015
                //992157016
                //992157017
                //992157019
                //992157020
                //992157021
                //992157022
                //992157023
                //992157024
                //992157480
                //992157481
                //992157482
                //992157483
                //992157484
                //992157485
                //992157486
                //992157487
                //Bloodletting Beast
                //310509006
                if (tempMap.Parts.Enemies[i].NPCParamID == 310509006)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992167486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992167001
                //992167002
                //992167003
                //992167004
                //992167006
                //992167007
                //992167008
                //992167009
                //992167010
                //992167011
                //992167013
                //992167014
                //992167015
                //992167016
                //992167017
                //992167019
                //992167020
                //992167021
                //992167022
                //992167023
                //992167024
                //992167480
                //992167481
                //992167482
                //992167483
                //992167484
                //992167485
                //992167486
                //992167487
                //Undead Giant
                //10313090
                if (tempMap.Parts.Enemies[i].NPCParamID == 10313090)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992177486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992177001
                //992177002
                //992177003
                //992177004
                //992177006
                //992177007
                //992177008
                //992177009
                //992177010
                //992177011
                //992177013
                //992177014
                //992177015
                //992177016
                //992177017
                //992177019
                //992177020
                //992177021
                //992177022
                //992177023
                //992177024
                //992177480
                //992177481
                //992177482
                //992177483
                //992177484
                //992177485
                //992177486
                //992177487
                //Pthumerian Elder
                //210305006
                if (tempMap.Parts.Enemies[i].NPCParamID == 210305006)
                {
                    if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187021;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187008;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187004;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187006;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187002;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187016;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187014;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187020;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187010;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187015;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187013;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187011;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187481;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187483;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                    else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                    {
                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("Old " + tempMap.Parts.Enemies[i].NPCParamID);
                        }

                        tempMap.Parts.Enemies[i].NPCParamID = 992187486;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine("New " + tempMap.Parts.Enemies[i].NPCParamID);
                        }
                    }
                }
                //992187001
                //992187002
                //992187003
                //992187004
                //992187006
                //992187007
                //992187008
                //992187009
                //992187010
                //992187011
                //992187013
                //992187014
                //992187015
                //992187016
                //992187017
                //992187019
                //992187020
                //992187021
                //992187022
                //992187023
                //992187024
                //992187480
                //992187481
                //992187482
                //992187483
                //992187484
                //992187485
                //992187486
                //992187487
            }

            List<int> npcParamPositions = new List<int>();
            for(int i = 0; i < npcParams.Count; i ++)
            {
                for(int j = 0; j < longList.Count; j ++)
                {
                    if(npcParams[i] == longList[j])
                    {
                        npcParamPositions.Add(j);
                    }
                }
            }

            //int position = 0;

            //m21_00 Hunter's Dream														 7021 7022
            //m21_01 Abandoned Old Workshop
            //m22_00 Hemwick Charnel Lane                                                7008
            //m23_00 Old Yharnam                                                         7004
            //m24_00 Cathedral Ward                                                      7006 7023 7024
            //m24_01 Central Yharnam, Iosefka's Clinic									 7001 7002 7003
            //m24_02 Upper Cathedral Ward, Healing Church Workshop, Altar of Despair     7007 7016 7017
            //m25_00 Forsaken Castle Cainhurst                                           7014
            //m26_00 Nightmare of Mensis                                                 7019 7020
            //m27_00 Forbidden Woods                                                     7010
            //m28_00 Yahar'gul, Unseen Village											 7009 7015
            //m32_00 Byrgenwerth, Lecture Building, Moonside Lake                        7013
            //m33_00 Nightmare Frontier                                                  7011
            //m34_00 Hunter's Nightmare													 7480 7481 7484
            //m35_00 Research Hall                                                       7482 7483 7487
            //m36_00 Fishing Hamlet                                                      7485
            //
            //7001 1
            //7002 2
            //7003 3
            //7004 4
            //7006 5
            //7007 6
            //7008 7
            //7009 8
            //7010 9
            //7011 10
            //7013 11
            //7014 12
            //7015 13
            //7016 14
            //7016 15
            //7017 16
            //7019 17
            //7020 18
            //7021 19
            //7022 20
            //7023 21
            //7024 22
            //7480 23
            //7481 24
            //7482 25
            //7483 26
            //7483 27
            //7484 28
            //7485 29
            //7486 30
            //7487 31
            for (int i = 0; i < npcParamPositions.Count; i ++)
            {
                for(int j = 0; j < tempMap.Parts.Enemies.Count; j ++)
                {
                    if(tempMap.Parts.Enemies[j].NPCParamID == longList[npcParamPositions[i]])
                    {
                        //filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx"
                        if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 20;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx")
                        {
                            
                        }
                        //filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 7;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 4;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 21;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 1;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 14;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 12;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 18;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 9;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 13;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 11;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 10;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 24;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 27;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                        //filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 29;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                        }
                    }
                }
            }

            tempMap.Write(currentMap);
        }

        private void GenerateEnemyList(string currentMap, List<string> noNoList)
        {
            string enemyEntityID;
            //var asstwo = LUAGNL.Read(ass);
                Random rand = new Random();

                var tempGUY = MSBB.Read(currentMap);

                List<MSBB.Part.Enemy> tempList = new List<MSBB.Part.Enemy>();

                bool addEnemy;

                for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                {
                    addEnemy = true;

                    if (!oopsAll)
                    {
                        for (int j = 0; j < noNoList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(noNoList[j]))
                            {
                                addEnemy = false;
                                j = noNoList.Count + 1;
                            }
                            else if(tempGUY.Parts.Enemies[i].ThinkParamID <= 1)
                            {
                                addEnemy = false;
                                j = noNoList.Count + 1;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID <= 1)
                            {
                                addEnemy = false;
                                j = noNoList.Count + 1;
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            for (int j = 0; j < chaliceBossParams.Count; j++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[j])
                                {
                                    addEnemy = false;
                                }
                            }
                        }

                        if (addEnemy)
                        {
                            if (randomize)
                            {
                                if (!tempList.Contains(tempGUY.Parts.Enemies[i]))
                                {
                                    if (tempGUY.Parts.Enemies[i].Name.Contains("c1110_0000"))
                                    {
                                        if (tempGUY.Parts.Enemies[i].TalkID != 111010)
                                        {
                                            bool add = true;

                                            for (int n = 0; n < tempList.Count; n++)
                                            {
                                                if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                                {
                                                    add = false;
                                                }
                                            }
                                            if (add)
                                            {
                                                if (currentMap.Contains("m29"))
                                                {
                                                    chaliceEnemiesMSB.Add(tempGUY.Parts.Enemies[i]);
                                                    addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                                else
                                                {
                                                    tempList.Add(tempGUY.Parts.Enemies[i]);
                                                    addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool add = true;

                                        for (int n = 0; n < tempList.Count; n++)
                                        {
                                            if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                            {
                                                add = false;
                                            }
                                        }

                                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2561"))
                                    {
                                        add = false;
                                    }

                                    if (add)
                                        {
                                            if (currentMap.Contains("m29"))
                                            {
                                                chaliceEnemiesMSB.Add(tempGUY.Parts.Enemies[i]);
                                                addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                            }
                                            else
                                            {
                                                tempList.Add(tempGUY.Parts.Enemies[i]);
                                                addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                                enemyEntityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            if (!oopsAll)
            {
                for (int i = 0; i < tempList.Count; i++)
                {
                    string tempString = tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName;
                    ////ShowText.Text += tempString;
                    if (tempList[i].ThinkParamID.ToString() != "1")
                    {
                        enemyData.Add(tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName);

                    }
                }
                if (chaliceEnemies)
                {
                    chaliceEnemiesString.Add("110123000*123000*c1230");
                }
                for (int i = 0; i < chaliceEnemiesMSB.Count; i++)
                {
                    string tempString = chaliceEnemiesMSB[i].NPCParamID.ToString() + "*" + chaliceEnemiesMSB[i].ThinkParamID.ToString() + "*" + chaliceEnemiesMSB[i].ModelName;
                    ////ShowText.Text += tempString;
                    if (chaliceEnemiesMSB[i].ThinkParamID.ToString() != "1")
                    {
                        chaliceEnemiesString.Add(chaliceEnemiesMSB[i].NPCParamID.ToString() + "*" + chaliceEnemiesMSB[i].ThinkParamID.ToString() + "*" + chaliceEnemiesMSB[i].ModelName);

                    }
                }
            }
        }

        

        private void OopsAll(string currentMap)
        {
            var tempMap = MSBB.Read(currentMap);

            for(int i = 0; i < tempMap.Parts.Enemies.Count; i ++)
            {
                for (int j = 0; j < oopsAllList.Count; j++)
                {
                    if (tempMap.Parts.Enemies[i].Name.Contains(oopsAllList[j]))
                    {
                        oopsAllEnemyList.Add(tempMap.Parts.Enemies[i]);
                    }
                }
            }
        }

        private void OopsAllBoss(string currentMap)
        {
            var tempMap = MSBB.Read(currentMap);

            for (int i = 0; i < tempMap.Parts.Enemies.Count; i++)
            {
                for (int j = 0; j < oopsAllBossString.Count; j++)
                {
                    if (tempMap.Parts.Enemies[i].Name.Contains(oopsAllBossString[j]))
                    {
                        oopsAllBossList.Add(tempMap.Parts.Enemies[i]);
                    }
                }
            }
        }

        private void Open_MSB_Click(object sender, RoutedEventArgs e)
        {

            currentDirectory = Directory.GetCurrentDirectory();
            var parentDir = Directory.GetParent(currentDirectory);
            filePath = parentDir + "\\dvdroot_ps4";

            var logFile = File.ReadAllLines(filePath + "\\Mod Files\\NPC Scaling File\\NPCScalingFile.txt");
            logList = new List<string>(logFile);

            longList = new List<long>();
            for (int i = 0; i < logList.Count; i++)
            {
                longList.Add(long.Parse(logList[i]));
            }


            mapList = new List<string>();

            mapList.Add(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");

            List<string> tempDirList = new List<string>();
            List<string> chaliceMapListString = new List<string>();

            //if(seedString == "" || seedString == "Insert Seed.... Numbers Only")
            Random rand = new Random();

            if (File.Exists(mapList[0] + ".bak"))
            {
                for(int i = 0; i < mapList.Count; i ++)
                {
                    File.Delete(mapList[i]);
                }

                for (int i = 0; i < mapList.Count; i++)
                {
                    File.Copy(mapList[i] + ".bak", mapList[i]);
                    File.Delete(mapList[i] + ".bak");
                }
            }

            for (int i = 0; i < mapList.Count; i++)
            {
                File.Copy(mapList[i], mapList[i] + ".bak");
            }

            //setting models in list to paste into all maps
            for (int i = 0; i < mapList.Count; i ++)
            {
                var tempAss = MSBB.Read(mapList[i]);

                for(int j = 0; j < tempAss.Models.Enemies.Count; j ++)
                {
                    modelList.Add(tempAss.Models.Enemies[j]);
                }
            }

            var tempMap = MSBB.Read(filePath + "\\map\\mapstudio\\" + "\\m29_52_01_00\\m29_52_01_91.msb.dcx");

            for(int i = 0; i < tempMap.Models.Enemies.Count; i ++)
            {
                modelList.Add(tempMap.Models.Enemies[i]);
            }

            for(int i = 0; i < mapList.Count; i ++)
            {
                var tempAss = MSBB.Read(mapList[i]);

                for(int j = 0; j < modelList.Count; j ++)
                {
                    tempAss.Models.Add(modelList[j]);
                }

                tempAss.Write(mapList[i]);
            }

            if (oopsAll)
            {

                if(oopsAllString.Length > 5)
                {
                    string tempOopsString = oopsAllString.Replace(" ","");
                    int totalStrings = tempOopsString.Length / 5;
                    int startingNumber = 0;
                    for(int i = 0; i < totalStrings; i ++)
                    {
                        oopsAllList.Add(tempOopsString.Substring(startingNumber, 5));
                        startingNumber = startingNumber + 5;
                    }
                }
                else if(oopsAllString.Length == 5)
                {
                    oopsAllList.Add(oopsAllString);
                }

                oopsAllEnemyList = new List<MSBB.Part.Enemy>();

                for (int i = 0; i < mapList.Count; i++)
                {
                    OopsAll(mapList[i]);
                }


                for (int i = 0; i < oopsAllEnemyList.Count; i++)
                {
                    string tempString = oopsAllEnemyList[i].NPCParamID.ToString() + "*" + oopsAllEnemyList[i].ThinkParamID.ToString() + "*" + oopsAllEnemyList[i].ModelName;
                    if (oopsAllEnemyList[i].ThinkParamID.ToString() != "1")
                    {
                        oopsAllEnemyString.Add(oopsAllEnemyList[i].NPCParamID.ToString() + "*" + oopsAllEnemyList[i].ThinkParamID.ToString() + "*" + oopsAllEnemyList[i].ModelName);

                    }
                }
                if(oopsAllString.Contains("c1230"))
                {
                    oopsAllEnemyString.Add("110123000*123000*c1230");
                }
            }

            if (oopsAllBosses) 
            {
                if (oopsBossString.Length > 5)
                {
                    string tempOopsString = oopsBossString.Replace(" ", "");
                    int totalStrings = tempOopsString.Length / 5;
                    int startingNumber = 0;
                    for (int i = 0; i < totalStrings; i++)
                    {
                        oopsAllBossString.Add(tempOopsString.Substring(startingNumber, 5));
                        startingNumber = startingNumber + 5;
                    }
                }
                else if (oopsBossString.Length == 5)
                {
                    oopsAllBossString.Add(oopsBossString);
                }

                oopsAllBossList = new List<MSBB.Part.Enemy>();

                for (int i = 0; i < mapList.Count; i++)
                {
                    OopsAllBoss(mapList[i]);
                }

                for (int i = 0; i < oopsAllBossList.Count; i++)
                {
                    string tempString = oopsAllBossList[i].NPCParamID.ToString() + "*" + oopsAllBossList[i].ThinkParamID.ToString() + "*" + oopsAllBossList[i].ModelName;
                    if (oopsAllBossList[i].ThinkParamID.ToString() != "1")
                    {
                        BossListString.Add(oopsAllBossList[i].NPCParamID.ToString() + "*" + oopsAllBossList[i].ThinkParamID.ToString() + "*" + oopsAllBossList[i].ModelName);

                    }
                }

                if (oopsBossString.Contains("c1230"))
                {
                    BossListString.Add("110123000*123000*c1230");
                }
            }

            if (!oopsAll)
            {
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                if (chaliceEnemies)
                {
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", nonoList);
                }

                while (enemyData.Count > 0)
                {
                    int index = rand.Next(0, enemyData.Count);
                    enemyDataRandomized.Add(enemyData[index]);
                    enemyData.RemoveAt(index);
                }
            }

            string dateNow = DateTime.Now.ToString("h:mm:ss tt");
            string butts = dateNow.Replace(":", "-");
            enemyLogFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butts + "-EnemyLog.txt";
            using (FileStream sw1 = File.Create(enemyLogFilePath))
            {

            }

            Randomize(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
            if (chaliceEnemies)
            {
                
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                //(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", unusedPlusBossList);
                
            }

                enemyData = new List<string>();
                enemyDataRandomized = new List<string>();

            if (!oopsAll)
            {
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", nonoList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                if (chaliceBosses)
                {
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", nonoList);
                }

                for (int i = 0; i < enemyData.Count; i++)
                {
                    secondaryBosses.Add(enemyData[i]);
                }

                while (secondaryBosses.Count <= totalBossesToReplace + 1)
                {
                    int ass = rand.Next(0, enemyData.Count);
                    secondaryBosses.Add(enemyData[ass]);
                }

                while (secondaryBosses.Count > 0)
                {
                    int index = rand.Next(0, secondaryBosses.Count);
                    enemyDataRandomized.Add(secondaryBosses[index]);
                    secondaryBosses.RemoveAt(index);
                }
            }
                dateNow = DateTime.Now.ToString("h:mm:ss tt");
                butts = dateNow.Replace(":", "-");
                bossLogFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butts + "-BossLog.txt";
                using (FileStream sw = File.Create(bossLogFilePath))
                {

                }

            if (includeBosses)
            {

                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", nonoList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                if (chaliceBosses)
                {
                    
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", unusedPlusBossList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", unusedPlusBossList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", unusedPlusBossList);
                    
                }
            }
            if (insertBossesBool)
            {
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", nonoList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", nonoList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", nonoList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", nonoList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", nonoList);
                if (chaliceBosses)
                {
                    
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", unusedPlusBossList);
                    //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", nonoList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", unusedPlusBossList);
                        
                }
            }

            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");

            MessageBox.Show("Finished.");
        }

        private void InsertBossesVoid(string currentMap, List<string> nonoList)
        {
            for(int i = 0; i < insertBossesString.Count; i ++)
            {
                if(insertBossesString[i].Contains("c5400"))
                {
                    insertBossesString.RemoveAt(i);
                    i = insertBossesString.Count + 3;
                }
            }

            if (randomize)
            {
                var tempGUY = MSBB.Read(currentMap);

                bool changeData;

                for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                {
                    changeData = true;

                    for (int j = 0; j < nonoList.Count; j++)
                    {
                        if (tempGUY.Parts.Enemies[i].Name.Contains(nonoList[j]))
                        {
                            changeData = false;
                        }
                    }


                    if (changeData && insertBossesString.Count > 0)
                    {
                        Random rand = new Random();
                        int random = rand.Next(0, insertBossesString.Count);
                        int randomChalice = rand.Next(0,chaliceBossString.Count);
                        string thisEnemy;
                        if (currentMap.Contains("m29"))
                        {
                            thisEnemy = chaliceBossString[randomChalice];
                        }
                        else
                        {
                            thisEnemy = insertBossesString[random];
                        }


                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        Console.WriteLine(enemyData[0]);

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);
                        Random ass = new Random();
                        float assass = ass.Next(0,100);
                        if (assass <= bossPercentage)
                        {
                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            if (tempNpcParamInt == 551000)
                            {
                                tempThinkIdInt = 551111;
                            }
                            else
                            {
                                tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            }
                            tempGUY.Parts.Enemies[i].ModelName = modelName;
                        }
                    }
                }
                tempGUY.Write(currentMap);
            }
        }

        private void GenerateBossList(string currentMap, List<string> noNoList)
        {
            Random rand = new Random();

            var tempGUY = MSBB.Read(currentMap);

            List<MSBB.Part.Enemy> tempList = new List<MSBB.Part.Enemy>();


            bool addEnemy;

            if (!oopsAll)
            {
                for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                {
                    addEnemy = false;

                    for (int j = 0; j < bossList.Count; j++)
                    {
                        if (tempGUY.Parts.Enemies[i].Name.Contains(bossList[j]))
                        {
                            if (tempGUY.Parts.Enemies[i].NPCParamID == 250060)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 250070)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 250090)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 212600)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 212610)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 212620)
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].EntityID == -1)
                            {
                                addEnemy = false;
                            }
                            else if (tempList.Contains(tempGUY.Parts.Enemies[i]))
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].NPCParamID == 0 || tempGUY.Parts.Enemies[i].NPCParamID == -1)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].ThinkParamID == -1)
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].Name.Contains("c5070"))
                            {
                                addEnemy = false;
                            }
                            else
                            {
                                addEnemy = true;

                                if (currentMap.Contains("m29"))
                                {
                                    for (int k = 0; k < chaliceBossParams.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[k])
                                        {
                                            chaliceBossMSB.Add(tempGUY.Parts.Enemies[i]);
                                        }
                                    }
                                }

                                if (!currentMap.Contains("m29"))
                                {
                                    insertBossesEnemy.Add(tempGUY.Parts.Enemies[i]);
                                }
                            }

                            if (currentMap.Contains("34"))
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID == 210030)
                                {
                                    addEnemy = false;
                                }
                            }

                            
                        }
                    }

                    if (addEnemy)
                    {
                        if (randomize)
                        {
                            if (!tempList.Contains(tempGUY.Parts.Enemies[i]))
                            {
                                if (!tempGUY.Parts.Enemies[i].Name.Contains("c2500_0000") && !tempGUY.Parts.Enemies[i].Name.Contains("c5071_0000") 
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0004") && !tempGUY.Parts.Enemies[i].Name.Contains("c2100_0000")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2100_0001") && !tempGUY.Parts.Enemies[i].Name.Contains("c4540_0000")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0001") && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0002")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0003") && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0001")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0000") && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2570") && !tempGUY.Parts.Enemies[i].Name.Contains("c2571")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002") && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0000"))
                                {
                                    bool add = true;

                                    for (int n = 0; n < tempList.Count; n++)
                                    {
                                        if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                        {
                                            add = false;
                                        }
                                    }
                                    if (add)
                                    {
                                        bool addThisBoss = true;
                                        if (currentMap.Contains("m29"))
                                        {
                                            if (addedBossesList.Count > 0 && addedBossesList != null)
                                            {
                                                for (int n = 0; n < addedBossesList.Count; n++)
                                                {
                                                    if (tempGUY.Parts.Enemies[i].ModelName == addedBossesList[n].ModelName)
                                                    {
                                                        addThisBoss = false;
                                                    }
                                                }
                                                if(addThisBoss)
                                                {
                                                    tempList.Add(tempGUY.Parts.Enemies[i]);
                                                    addedBossesList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            tempList.Add(tempGUY.Parts.Enemies[i]);
                                            addedBossesList.Add(tempGUY.Parts.Enemies[i]);
                                        }
                                    }
                                }
                                totalBossesToReplace++;
                            }
                        }
                    }
                }

                for (int i = 0; i < tempList.Count; i++)
                {
                    string tempString = tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName;
                    if (tempList[i].ThinkParamID.ToString() != "1")
                    {
                        enemyData.Add(tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName);

                    }
                }

                for (int i = 0; i < chaliceBossMSB.Count; i++)
                {
                    string tempString = chaliceBossMSB[i].NPCParamID.ToString() + "*" + chaliceBossMSB[i].ThinkParamID.ToString() + "*" + chaliceBossMSB[i].ModelName;
                    if (chaliceBossMSB[i].ThinkParamID.ToString() != "1")
                    {
                        chaliceBossString.Add(chaliceBossMSB[i].NPCParamID.ToString() + "*" + chaliceBossMSB[i].ThinkParamID.ToString() + "*" + chaliceBossMSB[i].ModelName);

                    }
                }

                for (int i = 0; i < insertBossesEnemy.Count; i++)
                {
                    string tempString = insertBossesEnemy[i].NPCParamID.ToString() + "*" + insertBossesEnemy[i].ThinkParamID.ToString() + "*" + insertBossesEnemy[i].ModelName;
                    if (insertBossesEnemy[i].ThinkParamID.ToString() != "1")
                    {
                        insertBossesString.Add(insertBossesEnemy[i].NPCParamID.ToString() + "*" + insertBossesEnemy[i].ThinkParamID.ToString() + "*" + insertBossesEnemy[i].ModelName);

                    }
                }
            }
        }


        private void RandomizeBosses(string currentMap, List<string> nonoList)
        {
            int removalNumber = 0;

            if (randomize)
            {
                var tempGUY = MSBB.Read(currentMap);

                bool changeData;

                int addCounter = 0;

                if (!oopsAllBosses)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = false;

                        for (int j = 0; j < bossList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(bossList[j]))
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID == 250060)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250070)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250090)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212600)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212610)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212620)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].EntityID == -1)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 0 || tempGUY.Parts.Enemies[i].NPCParamID == -1)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    changeData = true;
                                    thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                    thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                    thismo = tempGUY.Parts.Enemies[i].ModelName;
                                    thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                }

                                if (currentMap.Contains("34"))
                                {
                                    if (tempGUY.Parts.Enemies[i].NPCParamID == 210030)
                                    {
                                        changeData = false;
                                    }
                                }
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            changeData = false;

                            for (int k = 0; k < chaliceBossParams.Count; k++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[k])
                                {
                                    changeData = true;
                                }
                            }
                        }


                        if (changeData && enemyDataRandomized.Count > 0)
                        {
                            oldNPCParam.Add(tempGUY.Parts.Enemies[i].NPCParamID);

                            if (enemyDataRandomized.Count <= 2)
                            {
                                for (int k = 0; k < secondaryBosses.Count; k++)
                                {
                                    enemyDataRandomized.Add(secondaryBosses[k]);
                                }
                            }

                            Random rand = new Random();
                            int random = rand.Next(0, enemyDataRandomized.Count);
                            int randomChalice = rand.Next(0, chaliceBossString.Count);
                            string thisEnemy;
                            if (currentMap.Contains("m29"))
                            {
                                thisEnemy = chaliceBossString[randomChalice];

                            }
                            else
                            {
                                thisEnemy = enemyDataRandomized[random];
                            }
                            removalNumber = random;

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            if(currentMap.Contains("m24_00"))
                            {
                                while(modelName.Contains("4500"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }

                            if (currentMap.Contains("m24_02"))
                            {
                                while (modelName.Contains("5100") || modelName.Contains("8050"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }



                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;

                            if (!currentMap.Contains("m29"))
                            {
                                while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    removalNumber = random;

                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                    tempNpcParamInt = int.Parse(tempNpcParam);
                                    tempThinkIdInt = int.Parse(tempThinkId);

                                    addCounter++;
                                    if (addCounter >= enemyDataRandomized.Count)
                                    {
                                        enemyDataRandomized.Add(secondaryBosses[random]);
                                        addCounter = 0;
                                    }
                                }

                                if (addedBosses != null && addedBosses.Count >= 2)
                                {
                                    int counter = 0;
                                    for (int l = 0; l < addedBosses.Count; l++)
                                    {
                                        if (tempNpcParamInt.ToString().Contains(addedBosses[l]))
                                        {
                                            counter++;
                                            if (counter >= 2)
                                            {
                                                random = rand.Next(0, enemyDataRandomized.Count);
                                                thisEnemy = enemyDataRandomized[random];
                                                removalNumber = random;

                                                tempnpcint = thisEnemy.IndexOf("*");
                                                tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                                tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                                modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                                tempNpcParamInt = int.Parse(tempNpcParam);
                                                tempThinkIdInt = int.Parse(tempThinkId);
                                            }
                                        }
                                    }
                                }

                                string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                string mo = tempGUY.Parts.Enemies[i].ModelName;
                                string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                tempGUY.Parts.Enemies[i].ModelName = modelName;
                                if (tempNpcParamInt == 507200)
                                {
                                    tempGUY.Parts.Enemies[i].ThinkParamID = 507200;
                                }
                                //celestial emissary fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2570_0001")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }

                                        npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        mo = tempGUY.Parts.Enemies[i].ModelName;
                                        entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }
                                }
                                else if (tempGUY.Parts.Enemies[i].Name == "c2500_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c2570_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //enemyDataRandomized.RemoveAt(0);
                                if (tempGUY.Parts.Enemies[i].Name == "c5510_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0002")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //ludwig fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4510_0002")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }

                                        npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        mo = tempGUY.Parts.Enemies[i].ModelName;
                                        entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }
                                }
                                //maria fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4520_0002")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4520_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //living failures fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4030_0004")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4030_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //Orphan fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4541_0000")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }

                                        npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        mo = tempGUY.Parts.Enemies[i].ModelName;
                                        entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }
                                }
                                //gascoigne fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2720_0000")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }


                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }
                                }

                                using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                                {
                                    writetext.WriteLine(bossCount);
                                    writetext.WriteLine(currentMap);
                                    writetext.WriteLine(i + " Number in map list");
                                    writetext.WriteLine("Old Boss");
                                    writetext.WriteLine(thisnpc + " npcParam");
                                    writetext.WriteLine(thisthink + " thinkID");
                                    writetext.WriteLine(thismo + " model");
                                    writetext.WriteLine(thisentityID);

                                    writetext.WriteLine("New Boss");
                                    writetext.WriteLine(tempNpcParam + " npcParam");
                                    writetext.WriteLine(tempThinkId + " thinkID");
                                    writetext.WriteLine(modelName + " model");

                                    enemyDataRandomized.RemoveAt(removalNumber);
                                    writetext.WriteLine("Enemy Pool Count: " + enemyDataRandomized.Count + Environment.NewLine + Environment.NewLine);
                                }
                            }
                            bossCount++;
                            newNPCParam.Add(paramNumber);
                            mapsForParamChanges.Add(currentMap);
                            paramNumber--;

                        }

                    }
                }
                else if(oopsAllBosses)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = false;

                        for (int j = 0; j < bossList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(bossList[j]))
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID == 250060)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250070)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250090)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212600)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212610)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212620)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].EntityID == -1)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 0 || tempGUY.Parts.Enemies[i].NPCParamID == -1)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    changeData = true;
                                    thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                    thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                    thismo = tempGUY.Parts.Enemies[i].ModelName;
                                    thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                }

                                if (currentMap.Contains("34"))
                                {
                                    if (tempGUY.Parts.Enemies[i].NPCParamID == 210030)
                                    {
                                        changeData = false;
                                    }
                                }
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            changeData = false;

                            for (int k = 0; k < chaliceBossParams.Count; k++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[k])
                                {
                                    changeData = true;
                                }
                            }
                        }


                        if (changeData && BossListString.Count > 0)
                        {

                            Random rand = new Random();
                            int random = rand.Next(0, BossListString.Count);
                            string thisEnemy = BossListString[random];

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;


                            if (!currentMap.Contains("m29"))
                            {

                                string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                string mo = tempGUY.Parts.Enemies[i].ModelName;
                                string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                tempGUY.Parts.Enemies[i].ModelName = modelName;

                                if (tempNpcParamInt == 507200)
                                {
                                    tempGUY.Parts.Enemies[i].ThinkParamID = 507200;
                                }
                                //emissary fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2500_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c2570_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //wet nurse fix
                                if (tempGUY.Parts.Enemies[i].Name == "c5510_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0002")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //maria fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4520_0002")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4520_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //living failures fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4030_0004")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4030_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }

                                using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                                {
                                    writetext.WriteLine(bossCount);
                                    writetext.WriteLine(currentMap);
                                    writetext.WriteLine(i + " Number in map list");
                                    writetext.WriteLine("Old Boss");
                                    writetext.WriteLine(thisnpc + " npcParam");
                                    writetext.WriteLine(thisthink + " thinkID");
                                    writetext.WriteLine(thismo + " model");
                                    writetext.WriteLine(thisentityID);

                                    writetext.WriteLine("New Boss");
                                    writetext.WriteLine(tempNpcParam + " npcParam");
                                    writetext.WriteLine(tempThinkId + " thinkID");
                                    writetext.WriteLine(modelName + " model");

                                    writetext.WriteLine("Enemy Pool Count: " + BossListString.Count + Environment.NewLine + Environment.NewLine);
                                }
                            }
                            bossCount++;
                            newNPCParam.Add(paramNumber);
                            mapsForParamChanges.Add(currentMap);
                            paramNumber--;

                        }

                    }
                }

                tempGUY.Write(currentMap);
            }
        }

        private void Chalice_Checked(object sender, RoutedEventArgs e)
        {
            chaliceEnemies = ChaliceEnemies.IsChecked.Value;
        }



        private void Randomize(string currentMap, List<string> nonoList)
        {
            if(randomize)
            {
                var tempGUY = MSBB.Read(currentMap);

                bool changeData;

                if (!oopsAll)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = true;

                        for (int j = 0; j < nonoList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(nonoList[j]))
                            {
                                changeData = false;
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            for (int j = 0; j < chaliceBossParams.Count; j++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[j])
                                {
                                    changeData = false;
                                }

                                if (tempGUY.Parts.Enemies[i].ModelName.Contains("1050"))
                                {
                                    changeData = false;
                                }
                            }
                        }

                        if (currentMap.Contains("24_02"))
                        {
                            if (tempGUY.Parts.Enemies[i].ModelName.Contains("2520"))
                            {

                                Random chooseRand = new Random();
                                int randChoose = chooseRand.Next(0, 11);
                                if (randChoose >= 3)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("35"))
                        {
                            if (tempGUY.Parts.Enemies[i].ModelName.Contains("4020"))
                            {

                                Random chooseRand = new Random();
                                int randChoose = chooseRand.Next(0, 11);
                                if (randChoose >= 3)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (changeData && enemyDataRandomized.Count > 0)
                        {
                            Random rand = new Random();
                            float chaliceRandom = rand.Next(0, 100);
                            int randomChalice = 0;
                            if (chaliceEnemies)
                            {
                                randomChalice = rand.Next(0, chaliceEnemiesString.Count);
                            }
                            int random = rand.Next(0, enemyDataRandomized.Count);
                            string thisEnemy;
                            if (chaliceRandom <= chaliceChanceFloat && chaliceEnemies)
                            {
                                thisEnemy = chaliceEnemiesString[random];
                            }
                            else if (currentMap.Contains("m29") && chaliceEnemies)
                            {
                                thisEnemy = chaliceEnemiesString[randomChalice];
                            }
                            else
                            {
                                thisEnemy = enemyDataRandomized[random];
                            }

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            Console.WriteLine(enemyDataRandomized[0]);

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            if (currentMap.Contains("m24_02"))
                            {
                                while (modelName.Contains("c1000") || modelName.Contains("c5040") || modelName.Contains("2630")
                                    || modelName.Contains("1051") || modelName.Contains("c1180"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }

                            if (currentMap.Contains("m35"))
                            {
                                while (modelName.Contains("c1000") || modelName.Contains("c5040") || modelName.Contains("2630")
                                    || modelName.Contains("1051") || modelName.Contains("c1180") || modelName.Contains("c1111")
                                     || modelName.Contains("c2620") || modelName.Contains("2090") || modelName.Contains("1250")
                                      || modelName.Contains("1260"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }


                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                            string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                            string mo = tempGUY.Parts.Enemies[i].ModelName;
                            string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;

                            using (StreamWriter writetext = File.AppendText(enemyLogFilePath))
                            {
                                writetext.WriteLine(currentMap);
                                writetext.WriteLine(i + " Number in map list");
                                writetext.WriteLine("Old Enemy");
                                writetext.WriteLine(npc + " npcParam");
                                writetext.WriteLine(think + " thinkID");
                                writetext.WriteLine(mo + " model");
                                writetext.WriteLine(entityID);

                                writetext.WriteLine("New Enemy");
                                writetext.WriteLine(tempNpcParam + " npcParam");
                                writetext.WriteLine(tempThinkId + " thinkID");
                                writetext.WriteLine(modelName + " model" + Environment.NewLine);
                            }
                        }


                    }
                }
                else if(oopsAll)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = true;

                        for (int j = 0; j < unusedList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(nonoList[j]))
                            {
                                changeData = false;
                            }
                        }

                        if (changeData && oopsAllEnemyString.Count > 0)
                        {
                            Random rand = new Random();
                            int random = rand.Next(0, oopsAllEnemyString.Count);
                            string thisEnemy;
                            thisEnemy = oopsAllEnemyString[random];

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            Console.WriteLine(oopsAllEnemyString[0]);

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                            string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                            string mo = tempGUY.Parts.Enemies[i].ModelName;
                            string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;

                            using (StreamWriter writetext = File.AppendText(enemyLogFilePath))
                            {
                                writetext.WriteLine(currentMap);
                                writetext.WriteLine(i + " Number in map list");
                                writetext.WriteLine("Old Enemy");
                                writetext.WriteLine(npc + " npcParam");
                                writetext.WriteLine(think + " thinkID");
                                writetext.WriteLine(mo + " model");
                                writetext.WriteLine(entityID);

                                writetext.WriteLine("New Enemy");
                                writetext.WriteLine(tempNpcParam + " npcParam");
                                writetext.WriteLine(tempThinkId + " thinkID");
                                writetext.WriteLine(modelName + " model" + Environment.NewLine);
                            }
                        }


                    }
                }
                tempGUY.Write(currentMap);
            }
        }

        private void BossCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            includeBosses = BossCheckBox.IsChecked.Value;
        }

        private void InsertBosses_Checked(object sender, RoutedEventArgs e)
        {
            insertBossesBool = InsertBosses.IsChecked.Value;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bossPercentage = bossSlider.Value * 10;
            sliderValue.Content = (bossPercentage).ToString("0.0");

        }

        private void ChaliceBoss_Checked(object sender, RoutedEventArgs e)
        {
            chaliceBosses = ChaliceBoss.IsChecked.Value;
        }

        private void OopsAllCheck_Checked(object sender, RoutedEventArgs e)
        {
            oopsAll = OopsAllCheck.IsChecked.Value;
        }

        private void SeedBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OopsAllStringName_TextChanged(object sender, TextChangedEventArgs e)
        {
            oopsAllString = OopsAllStringName.Text;
        }

        private void ItemRandoCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void KeyItemCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void GetItemLot_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ChaliceSliderThing_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            chaliceChanceFloat = ChaliceSliderThing.Value * 10;
            ChaliceSliderValue.Content = (chaliceChanceFloat).ToString("0.0");
        }

        private void VFXCheck_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void TalkCheck_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void SpEffectCheck_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void BulletCheck_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void GemEffectCheck_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void MagicCheck_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void OopsBoss_TextChanged(object sender, TextChangedEventArgs e)
        {
            oopsBossString = OopsBoss.Text;
        }

        private void OopsAllBossesCheck_Checked(object sender, RoutedEventArgs e)
        {
            oopsAllBosses = OopsAllBossesCheck.IsChecked.Value;
            includeBosses = OopsAllBossesCheck.IsChecked.Value;
        }
    }
}
