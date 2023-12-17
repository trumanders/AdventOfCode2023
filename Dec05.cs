﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AdventOfCode2023;

public class Dec05 : ISolution
{
    public string Input { get; set; }


    public int Answer1 { get; set; }
    public int Answer2 { get; set; }
    private string seedSoil = "931304316 1786548802 232453384\r\n3500539319 2322065235 6421609\r\n496396007 147739714 266329192\r\n3169724489 768672891 39526579\r\n3689153715 1361862036 346985\r\n1936948751 3328259881 542896984\r\n3209251068 3154345676 173914205\r\n1163757700 2814318523 24125066\r\n2484210664 1362209021 231487475\r\n3991904247 2133571422 188493813\r\n1187882766 4045525873 83717994\r\n861951350 3084992710 69352966\r\n2715698139 2838443589 43714032\r\n3830303258 4025104215 20421658\r\n768672891 1268583577 93278459\r\n4180398060 2019002186 114569236\r\n3689500700 1593696496 10659519\r\n1271600760 808199470 460384107\r\n166497091 526585653 102729094\r\n3700160219 3894961176 130143039\r\n2966889400 2882157621 202835089\r\n147739714 414068906 18757377\r\n3850724916 4133608796 141179331\r\n2759412171 2328486844 183672918\r\n2479845735 4129243867 4364929\r\n3480360150 4274788127 20179169\r\n402636637 432826283 93759370\r\n3383165273 2717123646 97194877\r\n3506960928 1604356015 182192787\r\n269226185 629314747 133410452\r\n2943085089 3871156865 23804311\r\n1731984867 2512159762 204963884";
    private string soilFert = "3368312743 826425240 243745914\r\n1045038113 3682756471 174490549\r\n3931158487 1530223690 363808809\r\n1219528662 2460222182 131099318\r\n3020480207 1894032499 63879875\r\n121779694 248970341 36319877\r\n1993634034 2662348686 86667553\r\n3612058657 1323325837 196530127\r\n1531175223 2604354699 57993987\r\n158099571 121779694 127190647\r\n1867147432 3317666386 126486602\r\n2080301587 2768963716 548702670\r\n1402482267 1070171154 21180243\r\n2959841028 4051272297 60639179\r\n834756529 1966243663 128160296\r\n3911211010 2749016239 19947477\r\n962916825 3857247020 82121288\r\n2629004257 3444152988 238603483\r\n826425240 1957912374 8331289\r\n1350627980 3939368308 51854287\r\n1589169210 4214533702 80433594\r\n2867607740 2094403959 92233288\r\n1669602804 1125781209 197544628\r\n3084360082 1519855964 10367726\r\n1483712212 1091351397 34429812\r\n3094727808 2186637247 273584935\r\n1423662510 3991222595 60049702\r\n3808588784 4111911476 102622226\r\n1518142024 2591321500 13033199";
    private string fertWater = "206818393 1973789958 18543481\r\n2641351404 1992333439 41420268\r\n58400970 2574944960 107826712\r\n3710426911 4065366707 42793360\r\n4217161704 4274048011 20919285\r\n1926695368 705931711 328031436\r\n1449580741 1210970895 50549447\r\n907984567 1421828853 15115545\r\n769748018 1108192216 102778679\r\n451427938 35457870 38201654\r\n2254726804 2033892789 137829519\r\n923239194 1513967644 270588891\r\n3753220271 4108160067 165887944\r\n499804857 310274559 109862756\r\n3061525238 3535532059 426476055\r\n1193828085 73659524 196024324\r\n872526697 0 35457870\r\n1766386857 1261520342 160308511\r\n4057593930 3283950856 159567774\r\n1389852409 646203379 59728332\r\n3919108215 3962008114 103358593\r\n1577153434 1784556535 189233423\r\n4022466808 3443518630 35127122\r\n489629592 1098016951 10175265\r\n923100112 2033753707 139082\r\n2392556323 2390203683 158894869\r\n1500130188 1436944398 77023246\r\n2577297600 1033963147 64053804\r\n609667613 2171722308 160080405\r\n3488001293 3061525238 222425618\r\n2551451192 2549098552 25846408\r\n4238080989 3478645752 56886307\r\n166227682 269683848 40590711\r\n0 2331802713 58400970\r\n225361874 420137315 226066064";
    private string waterLight = "1833244152 0 764535859\r\n212138399 2132863085 224047237\r\n445686952 1600446740 163005122\r\n3322180377 2914685303 488586806\r\n2739726430 3712513349 582453947\r\n3946546331 3589340640 8839399\r\n1441711040 799272484 245821386\r\n1038755613 1763451862 6623730\r\n608692074 1587251997 13194743\r\n701103180 2356910322 39153476\r\n1687532426 1045093870 145711726\r\n2597780011 764535859 34736625\r\n740256656 1490869662 54307168\r\n0 1920724686 212138399\r\n2632516636 1545176830 9229765\r\n668257778 1554406595 32845402\r\n3955385730 2739726430 39179725\r\n4180633986 3598180039 114333310\r\n3810767183 2778906155 135779148\r\n1291061946 1770075592 150649094\r\n436185636 1481368346 9501316\r\n1045379343 2396063798 245682603\r\n794563824 1237176557 244191789\r\n621886817 1190805596 46370961\r\n3994565455 3403272109 186068531";
    private string lightTemp = "432141642 1268486741 19474646\r\n3617581823 3276436954 357008111\r\n3505110084 3786131308 49942802\r\n0 1287961387 432141642\r\n3096011130 1808659179 409098954\r\n1347993824 2675880000 161612192\r\n3019335150 3199760974 76675980\r\n3555052886 3137232037 62528937\r\n2778092757 1720103029 88556150\r\n451616288 2217758133 458121867\r\n1509606016 0 1268486741\r\n909738155 3836074110 138515824\r\n1048253979 2837492192 299739845\r\n2866648907 3633445065 152686243";
    private string tempHum = "646729740 1519504972 559297346\r\n1894539176 2990410634 44298872\r\n232257988 972432123 414471752\r\n2277879451 278205785 108711195\r\n1775790220 132298732 118748956\r\n3371687162 2663455233 326955401\r\n1612056920 272509895 5695890\r\n1208383109 3703499740 147415518\r\n4070380190 4053129082 69974785\r\n4155541210 3305585510 139426086\r\n81956384 386916980 150301604\r\n3987543096 896459472 75972651\r\n2148980475 1386903875 128898976\r\n1617752810 3445011596 154599732\r\n4063515747 2078802318 6864443\r\n2392568787 3599611328 101532389\r\n2386590646 4123103867 5978141\r\n2494101176 2122546980 187027686\r\n2681128862 2085666761 36880219\r\n4140354975 2648268998 15186235\r\n1772352542 3051742077 3437678\r\n1355798627 3850915258 202213824\r\n3720104770 3055179755 250405755\r\n3032992830 2309574666 338694332\r\n1206027086 3701143717 2356023\r\n1938838048 537218584 44257139\r\n1558012451 81956384 50342348\r\n3970510525 3034709506 17032571\r\n1608354799 1515802851 3702121\r\n1983095187 4129082008 165885288\r\n3698642563 251047688 21462207\r\n2718009081 581475723 314983749";
    private string humLoc = "971626884 4275486551 19480745\r\n1218249913 2090555906 502249162\r\n2914848039 2902831882 224865747\r\n3341591733 2819947352 82884530\r\n991107629 2592805068 227142284\r\n3424476263 606585628 95279547\r\n4279176998 2064757318 10971709\r\n3139713786 4068790015 201877947\r\n606585628 701865175 365041256\r\n3534582689 3291885426 744594309\r\n1916997152 1066906431 997850887\r\n1752809355 3127697629 164187797\r\n1720499075 4036479735 32310280\r\n4290148707 4270667962 4818589\r\n3519755810 2075729027 14826879";
    private string initSeeds = "3127166940 109160474 3265086325 86449584 1581539098 205205726 3646327835 184743451 2671979893 17148151 305618297 40401857 2462071712 203075200 358806266 131147346 1802185716 538526744 635790399 705979250";
    //private string initSeeds = "3127166940 10000 3265086325 10000 1581539098 10000 3646327835 10000 2671979893 10000 305618297 10000 2462071712 10000 358806266 10000 1802185716 10000 635790399 10000";

    string[] allMaps;
    long minLocation;
    Stopwatch sw = new Stopwatch();
    private static object consoleLock = new object();

    public Dec05()
    {

    }

    public void Solve()
    {
        Solve1();
        Solve2Async();
    }

    public void Solve1()
    {
        // Convert all to int
        var sw = new Stopwatch();
        sw.Start();
        string[] allMaps = { seedSoil, soilFert, fertWater, waterLight, lightTemp, tempHum, humLoc };
        ulong minLocation = ulong.MaxValue;
        foreach (var seed in initSeeds.Split(" "))
        {
            ulong inputValue = Convert.ToUInt64(seed);
            foreach (var map in allMaps)
            {
                ulong conversionRangeForThisValueAndMap = 0;
                foreach (var row in map.Split("\r\n"))
                {
                    ulong destRangeStart = Convert.ToUInt64(row.Split(" ")[0]);
                    ulong sourceRangeStart = Convert.ToUInt64(row.Split(" ")[1]);
                    ulong rangeLenth = Convert.ToUInt64(row.Split(" ")[2]);

                    if (inputValue >= sourceRangeStart && inputValue < sourceRangeStart + rangeLenth)
                    {
                        conversionRangeForThisValueAndMap = destRangeStart - sourceRangeStart;
                        break;
                    }
                }
                inputValue += conversionRangeForThisValueAndMap;
            }
            minLocation = minLocation < inputValue ? minLocation : inputValue;
        }
        sw.Stop();
        Console.WriteLine("First: \t" + minLocation + " (" + sw.ElapsedMilliseconds + ")");
    }

    public void Solve2() { }

    public void Solve2Async()
    {
        sw.Restart();
        allMaps = new string[] { seedSoil, soilFert, fertWater, waterLight, lightTemp, tempHum, humLoc };

        minLocation = long.MaxValue;
        var seedData = initSeeds.Split(" ");
        List<Task> tasks = new List<Task>();
        Parallel.ForEach(Enumerable.Range(0, 10), i =>
        {
            RunSeedAndRangePair(seedData, i * 2, i * 6);
            //await Task.WhenAll(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);

        });


        sw.Stop();
        Console.WriteLine("Second:\t" + minLocation + " (" + sw.ElapsedMilliseconds + ")");
    }

    private void RunSeedAndRangePair(string[] seedData, int seedRangeData, int cursorRow)
    {
        var sw = new Stopwatch();
        sw.Start();

        long startSeed = Convert.ToUInt32(seedData[seedRangeData]);
        long numOfSeeds = Convert.ToUInt32(seedData[seedRangeData + 1]);
        long endSeed = startSeed + numOfSeeds - 1;
        long count = 1;
        for (long seed = startSeed; seed <= endSeed; seed++)
        {
            long destRangeStart = 0;
            long sourceRangeStart = 0;
            long rangeLength = 0;

            long inputValue = Convert.ToUInt32(seed);
            foreach (var map in allMaps)
            {
                var rowsInMap = map.Split("\r\n");
                foreach (var row in rowsInMap)
                {
                    destRangeStart = Convert.ToUInt32(row.Split(" ")[0]);
                    sourceRangeStart = Convert.ToUInt32(row.Split(" ")[1]);
                    rangeLength = Convert.ToUInt32(row.Split(" ")[2]);
                }
                inputValue += inputValue >= sourceRangeStart && inputValue < sourceRangeStart + rangeLength ? destRangeStart + rangeLength : 0;
            }
             minLocation = minLocation < inputValue ? minLocation : inputValue;
            count++;

            //if (sw.ElapsedMilliseconds % 2000 == 0)
            //{
            //    lock (consoleLock)
            //    {
            //        Console.SetCursorPosition(0, cursorRow);
            //        Console.Write("\rSeed data position:\t\t" + (seedRangeData + 1) + "/" + seedData.Length);
            //        double percentDone = ((double)count / numOfSeeds) * 100;
            //        Console.SetCursorPosition(0, cursorRow + 1);
            //        Console.Write($"\rSeed number:\t\t\t{count}/{numOfSeeds}\t-{percentDone,0:N2}%");
            //        Console.SetCursorPosition(0, cursorRow + 2);
            //        Console.Write("\rNearest location:\t\t" + minLocation + "                                ");
            //        int secondsPerPercent = (int)((sw.ElapsedMilliseconds / 1000) / percentDone);
            //        double estimatedTimeHoursLeft = ((100 - percentDone) * secondsPerPercent) / 3600.0;
            //        int estSeconds = (int)((estimatedTimeHoursLeft - (int)estimatedTimeHoursLeft) * 60);

            //        Console.SetCursorPosition(0, cursorRow + 3);
            //        Console.WriteLine("\rEstimated hours:minutes:\t" + (int)estimatedTimeHoursLeft + ":" + estSeconds + "                        ");
            //    }
            //}
        }
    }
}
