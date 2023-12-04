﻿namespace AdventOfCode2023;

public class Dec01 : ISolution
{
    public string Input { get; set; } = "7jlncfksix7rjgrpglmn9\r\nvcgkgxninerqjltdbhqzzpd4nine23\r\nfx3\r\n8nrbjbpjpnineseven\r\n7qlfhcsnxn7fpfhjcgr6eightsevenjlpchjtzpztwo\r\n28rzgskgk94ninefive\r\nzdpxcql1eight5\r\n8two5six37\r\n9khfphjl71trppsrtwo\r\nlxthkgbbf2jdcssfiveqksvbqvm8four4\r\nseven9tjcgztctxzzttct\r\nonetljcfh9fivesvgcqnklz9four\r\n4mptgcnzmvvsevenzmjjzhndzdvxmz59bm\r\n1hrqthmr\r\n7eightqmfmsn\r\njkgdnpzjkzzceighttklsfiveqxgsvxdq4\r\nhdk28lqhhttjz6one2\r\n2five524\r\n363mtk\r\nqlmtpch9eightlzddxs7one\r\none6five1hxphtl687rllvb\r\n31gdnsxtpnn\r\nsqvbcqlnjhk135\r\neightgcdszrsghmmfsevendr2844\r\neightthreecdpccfj7\r\nljfgt9kvnine175kpnrbttktktf\r\nzjfeightfive9nine44seven4\r\nsixshbrtr4nmjr\r\n3two54\r\n26sixbhmmgdcl\r\ndrxfnbsdzf3gnxbtmmggvkxrsevenbbzdfxnrdnkfivefive\r\ntwo8591mrvchg4\r\n3jjhfzlnklpvvfcnsjbdmgvlfkeight2snxrkzzsx\r\nztwo79onesix56seven\r\nthreeeightrhlxptmtwofivenfourthree3\r\nfbhcqcttgxlrstcqeight4dbfjp\r\nprsevenfournineglccpgssix7\r\nhzprzdvbsxzllgvttworstxtwodstxbtjnzm6\r\n99sevenfive\r\nfdvnvc2\r\nvmpnpqg32llcxpbzcxqvseven\r\ndc9fgvrvsqqhlj2nq97three\r\nfour77twothreeonenine9\r\n3kfkfour\r\nxfg58six8cjtvmrgvsq5l\r\ngmfxvhftld2hbmmprpppzchcqmxninethreethree3mmplrvbtkf\r\n3fourqndl6\r\nrj6ninenzkbktfqsc2\r\n9konehdmllc\r\nmneightzzqvdm14\r\n8oneseventlrsrzflccrbv\r\n9vvvgqdkrckjlzcfsbdgrqrhhtbb7fnhcxzmk9nine7\r\n825ngddfhpfrsl6\r\nmc6tjxxll9seven\r\nfxbgccqmmh2\r\nfive7three4vmxjlqcnc3\r\n9mninehkmlpcxqnfkqfbg6six3\r\n3onefourrv1ninesixfour8\r\nfourtwosdtz817fivevjvlzr\r\nseventhvxk1fournqqqfjrvdvbpkvd\r\nv733rklzvnslkonefive6zbvq\r\n178ncllbfkkh4eightwoq\r\nglbxfjhskzbseven6mjzlxccfive3\r\nfptwoneonefivefive2ztxpndjdq2\r\nlxzhsgqkx5mjxtrmbkdtfeightsrchzmq6\r\n1nngc2338ninedjkvszdmnjrl\r\nfive6six7\r\nbcpxbcbssbtmdfninefivesevendtm9eighthxtvxb\r\nmzdttqmfpssevensixeight3twoone4\r\nrrtzlhkgrgtmrvlcthreeonefour5\r\n75threeeight4\r\n3ttcjsdrj6one91t\r\n3twofgdpfqxxp\r\nseven3gjslxpltpbonemt\r\n82jcvqkrgzkx8three8rmszgdj4\r\nctwone41fnjksbxb1mxxzznsvg35fivesix\r\nfour7bzfeight3one\r\nheightwo24cxs\r\nfdtwone8sevenfour37\r\n1sevenmdmlrgmqnnth1mrone\r\n7nqxzdrblffcdm22six\r\n5ttpzlv\r\nzhqjlfive3\r\njvzpgppblkb6\r\nnine77lmfour\r\nkqnvgtkgphxcxsixfoursix2\r\npjjdlnineltbcknfqvhj8tworbkqhdcp\r\nnine65fiveeightjmeight\r\nj1sptkfhsczt\r\n4czpqqglpc41bzkss1\r\nqd28j\r\nthree1fourfourm\r\nfour5seven4twodvmzzdtn\r\nzj4\r\ndzzrdkjjdxspfrjsonefive8brrzlrjvzfour\r\nzrjzfxxddn66\r\nfourrnsphsdzmv9xznt6seven\r\n56eightcbhkmjfourone\r\nfivejzlbvqzb3sixsix\r\nfiveghfclksgqffdpb7\r\ncmmplbcnml36threetrxnhrrdonelmspsbhfd9twonenn\r\nccxrlmzrreightone9three9\r\nzg6four1eight\r\n1ngv\r\nbfhptfjzlgkxtftwo7gthree\r\ntxrpbzgjzg272three9jlstdb8\r\n3seven6twofxvxdlcqj33\r\nsix3eightjrdxgkrkm5five\r\none67one3\r\ngnfhhkffqfctxmvznmftwo34gjsrpxlv43\r\nfive6zjdjpptnthreefour7sevenqfjlpshg\r\nonesevenninesvnnrvxxeightrdbvsbdnzgtmlmf1\r\n2six8seven\r\n3eightjrpqdrtwoxjvmgzpbffjnfdps9\r\ntptlcldftc3\r\nlcpqlbjfgmhkjpkhc4eight9ninesixsixseven\r\neightxjfqqtxnsbsnrdxdjv8six79\r\ntvkthbbrr8five\r\nseven35threerrkdqjgps58two\r\n5dln1rqqgdjlcmmrvm2pmhvhcxhfsbxkfqngp5\r\nsixnpvbq36514one\r\nmxdvxfgdfzmkjcrtl2\r\nonejv7lxmbrbzjsthreesevenninesm\r\nthreehbhnm8nine\r\nbvhgqz6\r\n9two89sixfxjz37\r\n8xninepvggctk85fivefkj\r\n8sixdjndzzzrkk\r\nfive61oneightr\r\ncmthreesixeight7jlvdvmdjfzbv3\r\n9two1onefour1clxjonetwo\r\n9sixtzphqltmeightlbrhjone1ktrvjldff6\r\nfive68eightfourqpfcxftzlxrhgdcvpd\r\nnxvdtfkltwozzl72fourhzxtqjf1\r\n91fiveeightthree65twoneh\r\n3eight6ninexqqgxzxfgmsixseveneightfqk\r\ndlpsfmsthree2zgfpdnftvfqgsgr\r\n4kggfpxg8jpxzdqsixeight\r\nfivefourtwo923\r\nz3gx\r\nsix4prlsp84tgvc\r\n1foursrznv62k\r\nvmzr829nkxtlf\r\n3dzsx2two7sixfivebkktgfbzdt\r\nfourpzpmvxc2zvvrhrbhf\r\nfrpddtknqjxpqqzhdnfour9sixdqjbqxh\r\n89sevengkbeight6mn\r\ntwo7jcpnxhbtmhtwo39twoone\r\ncvdqlfkrs821fourrrgnmm\r\n6onefhnnbrzgx7fourxcj\r\nseveneighthfr6rz\r\n9vvqlpnzbxfct8\r\ntwo8three2fpseveneight\r\n2three75three2\r\nznvbrbrqlfive8\r\nlnfjqfkk8\r\n14tvvmdlntrv6three\r\n5twor2chtvj\r\nthreetwomgrcfivefive7\r\nfive4qbvxthrfxdkjkk\r\nsixthreethree5scmqrfq4vf3\r\nrjsljnqcrttbpfhfxbfourone4\r\nthreeseventwoseven87dnmqjbbxfoneighttfz\r\nseven4four9eightxqlsixthreeone\r\n1ninesix43bmsttggvzn14\r\nseven1sixbmnxmz\r\ngrqhlkrcdzbhstgtvpclvtphph4twoseven\r\nfgfprscb27pzfvvblxhkvonefive\r\nfive77fivethreefive3vddgfngng\r\n13nllfsevenfour6four\r\nthreenineeightfour173three\r\nfourqvsbxxzmfh2hhcjxsrkz\r\n4jdtxgltkkkvlnhrztwofxppsdlcqztwo3gdlctj\r\n5four334rvfour9\r\n551threenine\r\neightonenineeight8\r\nqmjqmjvvfkdbnjgkrqh8two\r\nsevenjzqnv32lldmr5one\r\n6five8fivefour\r\nljvhqqvqxqsix1367\r\ntwo6kvjtwonenzf\r\n2p5chjdcseven9\r\nlnrrrkkdsvfhkl9vfqfgnvonegtwo6\r\ntwoseven4lhhpcvthree4tkrone\r\n8hllnnmpm3rjxndcmpt9jfjqng\r\nqbnlgqeight2csvjshglqzmgkqqxqzq95\r\ntwo2nine\r\nrrpffkq15foureighttwo2\r\nfive3ninetpx5fmrzsqvfzq\r\nmrqhcpgvblhvskv5pdsdzzfzfsix\r\ntwo7fvmhvseventwo7\r\n3sixone94three8fdplbm2\r\nloneightseveng79\r\nfourone7\r\nzvgjt1\r\nxpgbfghsmj2six8eight8mzlnvmv7\r\ngrjtwo48\r\njhcgjlgxt1seven1\r\n5dhtppxrxcsbjsm37\r\ncbhmtp56xbqzppjjfivezhtxxvkrzsix\r\nhctwonelcninefourfive2\r\nfour4rcxpkzbeight95xxdb3\r\nfivejlplgzflone963two\r\ntrgninefourtwo6five\r\n66fournine535foursxbvsfvf\r\n1bskfour\r\ndvlmbrxssevenhldvjxdzcfdvbfourthree2seven6\r\n6two92635\r\n8dzszone\r\nhfcm6\r\ndxrfhpdbrqmqq8four\r\nbfclp5sixeight81three\r\neightffsqgkmt53gfjxqsskpsfpbcmqvdfour9\r\n6sevensevenfour1v\r\n9threetfspsfxhnzblgsxz\r\nseven5tz7pfhlpt9qxrqz\r\npmbeightwooneonefiveseventft4\r\nxhjhmzljnx7\r\ntwotgdvhkpmg1rthzfc6\r\nonesevennpcsbfive9sixseven\r\n7sevenmbhlrjxrpddcnl\r\n8fsvntpptctwobjmkgzvc4two\r\nonetwosix4\r\nfourthree4fourlqbvscdponeights\r\n1glkfrdb69sixsrvvb\r\nninetwoeight7cvjtdmgpsfivefnlvgsqtstwo9\r\n9threejtfoureightseven\r\n38nine8\r\n87two7onetwo\r\n2vkkcgxdqpnthreehklfmfmjdpkz9fivetwofour\r\none5oneone5oneone\r\nthree5hlxkxrmxsbgrzqsgrone\r\ntwokbbnbjp7\r\nmvxpdllxrvfthreeone51eight\r\nrrqvfiveseven5two1qgqppn\r\n92s\r\nfourxcj8frbvlxzgpvoneone\r\n648211\r\n4eightgzxnsixlvksllptszztmkjb3four\r\nfivegqg6\r\nfoureightmmnknlseven1\r\n83kx\r\nsixeight12kskzhrjjpslmprtwo\r\n1xzncrsfrlfivetwoxptv46nine\r\nfourmxfq6twotwo4\r\noneht8\r\n3prjdlrcznine\r\nbtkpqmxxmggkzftmkxbzqvdccchxdmjlqztzfgfour7\r\ntvbstznine9z\r\ntwo1fivemmnlcnmqlrnbp95gjjh\r\ndq671ninezk\r\n6cmxtt769\r\n629rkhc198\r\n2fourfiver\r\nthree5nqkjdsixfrjnf4gcbjrznine\r\nxjhqqf7oneeightrgkdprrssmxp63\r\n5fourfivekpvmnlpfrt1\r\nxnqkjcldhttbpjr8\r\nfdntjsb957sevenhbmntp\r\njlmmmmdv482three\r\n63lnbhmdhpsp32\r\n99cmntldfdflqkfkv\r\nkqnlqqkpr9eighteightthree15threenine\r\n6threefttghrvjsjg6\r\nspmrjzfm6eightwokn\r\nbdcjfqvsdronertfztlblqbgfgtkjv8qhbjfhthree6nine\r\n9fvltpsxtcbtjxbtlfdvm7\r\n6jxvxrdmpjthreefstfgrsixfourzbfznjjlqtjx\r\n8onesixkmhgvsnfhqnxlkn\r\nrrjxvqjbnvvsgddtvmb3six5\r\neight8sevenbmtgbvdzcpqnzqone1hbhlgcfour\r\n2nineseven41\r\n8xptgrh1njz\r\ngeightwo93sevenseventwobpdhhjsrbfour57\r\nm4kd9four\r\n6nine5seven9v\r\nglzc1fiveeightvbmvk\r\nninesixone3sevenzmvrqbtwo4four\r\n9onefoureightfivefour\r\nfjqpgnjdd1twoninecgsqsmtonenine1f\r\n94sixthreedflcddxnvvrthree\r\nvvfnbgpkgsnjtszxhrsixfive5rrdtfpkdhdvsg\r\n39four1pjfkt\r\n45sixkhlfc1fivetcvnlstnine\r\nsevenone2seven\r\ntwofiveonenine6eight5\r\ngrxzndnqpd56\r\nxnpdfnfgt5fivetwotwo\r\n9four6two\r\nsgmlzbpnkrmfivesbdzbnhkcxndpone49\r\n88six2hrmkl2\r\nmthree3eightfiveone\r\nsmrzqc7twothree2three\r\nnmtwo8cr\r\n378one47four\r\n27four\r\n5two7seven68six\r\n9onecnonethree9\r\nnineqhvbjqbrkpjhjhdbpk3twoseven\r\nrq4qldc\r\n86bqzct2nine\r\neightsnfgrjzhsnxbfivethree6ljxx\r\noneeight1threevzdcplnqrbk92\r\n8k9dkqmqhndthreethree\r\n9sp6j5two\r\n4rsone1seven2seventwo\r\nninehhdcbxfgs7fljclncb6vpzhqphxz\r\ndrplsnsch3zfr\r\n86nine\r\n2threeeightsixvzpcqjs\r\ndmkhbxsggeight7seven9\r\nfourshjlmrbbcnznstgj2sx\r\ngcbzbldk6nine\r\nfourskpc1vzfxsrjckcmccljtt9\r\n1oneone53oneeight6\r\nsix3fourqxqbs9nkbsixthreesix\r\npmlrkrhqdjgg121nineseven9\r\ndmgnq6\r\nkpmponeone5\r\nmxmhbqnrcjj1threeeightxzfive\r\nonebzxnrqqfltfourglvkqfive4nine5\r\nthreezvmfl7vsdrthsdsjsix9mbrqqmz1\r\nboneight8onelrtjkj\r\ntqxbbceight9rqbthreek\r\n3h32nklscdkfhtztwontprj\r\n2threesix\r\nqkzmpvkvsixxfzlrfrgv682\r\n3seven6mvkeight2fourvhvvqone\r\nthree389sixeight\r\nbx664nine\r\nnine82rcdvqtj91dbffscng4\r\n2sixsixtbqhvcndjtcvrrbtdzsxrlrvdxjtd7fzdtlrhlxvbpvhknmm\r\n6zbpblsznhlzljtmstwothree28ngdcfkk\r\neight8nbfmdqlcvonenine\r\n8two4sx7rffstvxlq1seven4\r\ngmzbd8nine5nine1one\r\nsevenfivezdfbn7six\r\n5892\r\nss9\r\n8xcvzgzkjcdg\r\n1seven7three\r\n8four1fourtwonezs\r\nhnjzk8\r\nxfour5mrj\r\nvnkspgtkxspdtwofxlvtlkqpqcffxbqth13cll\r\nmmjkshtmtwofour1\r\nsixthree6\r\nseven9mzmbkkrzsix5five\r\n9cbrsqjlhntpzfivegmgn1six\r\nbdbnlrdpsninenine3twotwocpvjd3\r\ntwonine193\r\ntwothree1twor8cmtxtd\r\nbvgtninevfrjs6\r\neightsix8\r\nsixfbzsxfjtfv8\r\n5onethreeone\r\ndgzcksnqz8foursix\r\n9onetsrtwotwothreerbv\r\n4dnzc8\r\nfivenine4sjzsdgvdqsix3511\r\n7twofivefivefourqdgpmfblgv\r\noneonelgjsk9\r\nzcfhrrpseven8tlffkfnineeightttwoknlfdjpj\r\nnine5nine\r\n8sixtwotwooneoneeightcdklzjgvnqrsvvkbtfj\r\n7one9vxjdkbhqmfbpt\r\n6twoeighttwo\r\nsixthreesix162\r\n5jhxxchf69twosxjckh5\r\nsevenxspmvxpmc788one\r\n9fseven4\r\nvxzqgxbmtgxnm588seventwoqtmfsb9\r\nfour8nine4ftn5\r\neighteightrhjzcmxql28four\r\ntwogqjdbmmxqgtxdppchr2xxhcptq2mrvgsdccs\r\nsix24\r\nnqdptone3drgtwoone8\r\nthreesixnine8hlkrj\r\nfour7pvvljkscc6hvsppgxrsixknrnrvfjqqfive\r\n7tdnbzqqxftqtxjqxgmbdhbvsqdone22drc\r\n59rqhzrfrps\r\nsix1scbkqjd4\r\n89blbn\r\nlqhoneightthree96tppmhtpmlt7\r\nthreeqpnsevengfx3\r\nsixk27lfjrvhvtsixtwo\r\nfour5slf8onefournine5\r\nninehgczrdslkstltfive96bqtz5\r\nscfkzsr4fournine325\r\n5eighthzn9rjdzxllvg\r\n1six1threedrfpflhqfour64\r\nfivekdtgcdsjxone8nine\r\n7sevensevenhronepdgbxvfd5\r\n619nine6threetwo6\r\nfivehchdssjrlshfqjlptsxghzrcsfcglm4\r\n6two73smnqbbmsix\r\n84fivermpjpjgkn\r\noneeighteightfhjtxbjc94threefrnnnncdz\r\nlrckglbdn94eightqbfxp\r\nmtztmbhthzone26sixgjvnbzsjfmthreevqdqrld\r\npnrtpgzcnznfive3eightwogkq\r\nthreevfpkrjddtpszxddckhftt6txkszsbxnn\r\nninecxdtmdnineseveneight5fivesd\r\nxjvv7one\r\n5eightfiveseven\r\ntwodpfdzvqmpzmvs7tpjnpmv5\r\n75fivethreesixsfqpzdonefive4\r\n4onefive6bsvtplblfbmnjjlb\r\neight75one73pjgdqq\r\nntcnmnkvjzpvxpmb7twokqfour1\r\nzd1sevenmgdrgrzvvh\r\n65four\r\n3kzfztjxjbseven67bnfcntfknlxlv\r\neightfive8xnnkeightfive\r\n6three95eighttwonineonevkrtwonebgs\r\n92seven2cndf\r\nonezxphkcrsix7klrhnhdcxrpz\r\nmgl8ldbxzdlgtwo6cdvxbp\r\nfoursix7lzcddxnjdrfqtthree7six\r\nhxheightwoncdcrkczbninefour3lfdtgnqgcnbfxbqlnt\r\n2pmcvctfml1one92\r\nnineone9eight\r\n6crppdpp4cmngqseven3mmv\r\n473sevensqpvvhfdrfiventgvmvrhtqx\r\ngpnzc1rmfxqgj8nine271\r\n84sixtwo\r\nfrcrtsqhfour3threefivesix\r\nbhcvf6\r\nseven2seveneightzqmdqhb9\r\n28hjjrgqklqgbm\r\n98three\r\njqzjntlc541\r\noneq22\r\n7fc92ljfmqt19\r\nsixzpzkgfiveonezjvrzfdcf43lbqxqseven\r\n1two4kfxglzcdjc3dpvb\r\nfivembfkfdq6\r\nnplrclbrbf5ks6five4hzzbsnine\r\n3mkmbgxhn\r\nseven9d\r\nvnfj8qng\r\neightrgtjpdjjktwo1lphnlrtjfxtvghhbncj2two\r\neight66frbpds5g\r\n3one8four9two5\r\n9ninefouronefcckhcdfb1mnmdsltdrsix\r\neightsvsix122241\r\n3fgpmgxcdqfourkhnrptlktrchfqbxcbbcxvjgznfjkj\r\neighthbhsgrqkgcxtwofour2nzj\r\n93xnjrphktk6vshpvnftblggghskg34\r\nseven2sixsdvmcfgq64\r\ntwothreefive3hrmkbmrskcvknineninebnjksp\r\n82fourninetwothree8\r\n2two158threeninesix\r\nhgltdx48onetwofvnsmmsdzjthree\r\nk38\r\nninenine4sixctnznsb3tkpx\r\npvfzqtgpntnfhfp47rhllqrlx22\r\n815qxtrghrsg\r\n5vhfourvdblpninemdzbbgmvsfone\r\nnine8nine6four\r\nthreebcbsmxbks2two5twon\r\nkzpsc74qxflxpsix6jgmzgqxvsngc\r\n7dbrsmpksixqttqsphqpd7twoeight\r\nkffivefourdknzqsevenvkssgvhxf1\r\nsixeight5sljd5fourxkkxv6\r\nrnsjsmfcbp4twofour\r\nzdfour5pktmsmxf3\r\nthreen42\r\nstgtphmjk7onexfour2foursrpj8\r\npjbgtsevenseven7zzhgxlmz\r\nsixeightfivefourseven9bpjbcmvkrfive\r\nhfhxfqlbqtwo4cdfksbbtlcsix\r\n778lkffbzmpdbxjbpfoursdbp\r\ntvpjnvtxeight1onefive3nvncq\r\n38seven47\r\nfive8threexqtglzmpmvbzfour\r\nnmtsjjfvfzbhpltbbsrjphrnxhr1two3sixvp\r\n4gbvkbfqrfgrbr85sixone\r\n6mxqltfsxqxnpdrjkxhrp\r\nlftdxbhhzvvhpone51six\r\n3grhbqf5one\r\nsix9four94tthree\r\nsevenh1bdcgdtmjqhnkzxlkxsevenonecbx\r\njvtwonecfksxckgq6\r\nzvmjbthreecbpfdvd6\r\n6bsvrsevenbcbcgrrhpxtvbhhfp1\r\nsevenfivemtmpcgml9mljnhcrdbfvksvlbpmvhs\r\n8nine9\r\nmszqdg7jsrcckxn\r\neightseven9zzsixninexhscseventhree\r\neight57\r\n4zjpjz26dxnzfb\r\nrmcnbnlpd3nine4gngphqfmc24\r\n1vvgfxdfourprlmsjmvvtxnn8seven\r\nnineonethree6zznkfrcgzvfour\r\ngcnjsdlhptwofourtwoonemggshpdh3eight\r\n4eightfivenxftjch\r\neightthreeseven94\r\ntwokvtjgcq992\r\n69psqdmgbtljjzjmpsbs1fiveoneggjbbk\r\n3k\r\neightsix3seven4twosevenq7\r\njlthbzsc2\r\n22nine8jhmktwo5\r\n8pzmtnlfptpjckftzrzqsrxkkcc3\r\nfour33jfxmhcdktzhqvmkxhklxjllx\r\nnine3lqcsbmmh4f\r\nthree514twonellp\r\n4qhn5\r\nsixbmkxqdgtkbcghvpzonecfmgkpfrxv68six\r\n6threeeightjhfsmp8mpvhrjcxzsevenone\r\nsevens9two37fjdfrnk\r\njhzpvfldrbmmmglvrkz2ninelbgpdlpdcteight\r\nqj9\r\nrxfhkkvheightfouronejh8238\r\nzfsixvbqngj1vhbvxpfk6\r\nvjbqvcm3\r\n51six38ngvq42three\r\n7zjtcczjz79seven\r\nfive8fivexxmrn\r\nsixseventhree3sixcsk\r\nzninefour8tworxkfb48\r\n63nine3\r\n11eight\r\nbxlgdzqthree2ninegqn6kvktfts8\r\ntvmzzlpnineztxdbkxgthree1four1\r\ngxcnhxone9\r\n8eightfive5jkqx\r\nqcfgbpgdveighteightone7seven\r\n86eight2five\r\ntftbbfpsvhtwo8eight8seventwo2\r\nskfp8\r\n8hdlhh4ninenxllmthreefivebhslxkvtcp\r\nsixbmljnmhseven4sevenmsfbsbqlzrrseven3\r\nv1828\r\n6seven53hhtj\r\nfive51lkfsrm2\r\nbvnrdvjnxjbfv9prx\r\ntqbnxeight6hztrsbvronethreethreeqvh\r\npcbjr3cjhrqxbcvpzdmfive6oneightgt\r\nqdeightl6four\r\nncprx96ninegn3\r\nsevenb4eightwonr\r\nqbslkmkqlf8ztzeightpcn\r\nfiveeightcpn7hvxmtpcsbqfvpnmvgncfbpxzhfive\r\n3rxxcqhlp4five\r\nthreefouronevdbdmktp17\r\nsixdtmnlhth9onefive\r\nfouronelxgxpvtmseven2ninesix\r\neightrfxrkcfive21ftlcgdcrmbsnrr\r\nnine1fourfourxkppvqrxfdhsdphjcgnhnfnzlld\r\n562\r\n4sixhj4eightzkbfpdrtzcsp2\r\nddfdbdqzfshfxnseven6onetwo2\r\nfive915b3\r\nsghrbfzmmrrbnone9four5rkmqgh\r\nthreedmmsdvgs6twotwochp\r\nseven1fivesixnine9four\r\n6dvmgsjcfour3q\r\ncschsrvz3nkk\r\n4fnqmnd4rnxbjvcbxpchfour\r\n3eight9\r\ntboneninerzhsgqqcxd2gxhm2mhdpkjeight\r\nvpsbgmzbjk6nineeight\r\nsixsjbzldfive6\r\nqjprfk1eight7vbdshhnfive59\r\ndbxdgt6\r\npdgghktdjhsxnblgpzmtc24onecmctldqtsc\r\nbgfzght2szvttsdndfiveqgns3\r\n6ninebdnbxzmeightfivevff8pdllfour\r\nfour2nineeightvfeighttwo\r\nfiveone3sevenhfqnfbjg3five\r\neight19two\r\nfqkeightwosvszgpjvbl2xtmgmc6128six\r\n6five6one24fivemcgpx\r\npmvrz6threemlhoneightdjf\r\n7cxrgxx53gksgdsv9\r\nsix3two\r\nnfqffqrvkvhqfzthgxp3fivesix7gb\r\nnlqdkgllxdvgj8xdhdfnnnfive\r\nfournine1nineseven\r\nfour35djzxvsvvdfxbnhsixfouroneseven\r\n9fourhntsmprtddm\r\nfourfsix81sixvxmz8eight\r\n3pqngffjxqpntqtl8zz4\r\nfive325ninemfqxnseven1\r\n1one2gqx3\r\nhqsfive67rr3q4\r\nonefblnbfvzlzthreenine1\r\n96zsvdl2\r\n1fourjjhf1tn18\r\nsixfdpljnbpzxlvhncjs9threefckbgtcm\r\nseven6ffmvnnmxl8fxskzvpfs\r\n5tgbqdkfive\r\n52czvkbqgztwo17ninesix\r\nbmshtrzdcmkfour5\r\nnrfn25one\r\n9two4plklcqzjftj7\r\nonedks4five6hdllqssixbssl\r\n2xftcfnd2twotwo\r\nrzxzkcdtnmsbhnncltpj62\r\n6snszfour\r\n398seven58\r\nvstfive8869\r\n1fivesevenvgjrlqqlthjz1\r\ntpg7eightseven\r\ngqvpptsix356\r\n7nineone9fournineeight\r\ntr1threenine\r\ntvz8xconeightfz\r\ntwo11five1nine\r\njntkxfvt2threegseven3\r\nb69ztbtgmqfntdnine4two4\r\nthreedsgrrfcpzpfivebrpjhzfhs96gxmfhkhfive3\r\neighteightthree5crdbzgqvtxx6two\r\nnine4onepxjtmbhrpklmlhcfspxrjdnd\r\n7fivetpttvnmgzd\r\n8lmddfzjeightxxvvcvp\r\nloneight1three4dmzxqncjbninerbsrjxxlsb\r\n657fourdjkhrlxjdp3ninepvlqhz\r\nthree4threekddjrfsdk3\r\n8xbjcnsjq89\r\nsix8ninesixfourpcsfhnsxgrz\r\n8twosixmvhmsps3\r\nsix9sixeight\r\n4seven175\r\n4twomspqqn6929\r\n71seven9eight\r\n4znc92eight\r\nninetwo2blcllflxonezljhhsfivelngxk\r\nnmbrjnsqhkxzxhmxsix1oneeight5fourseven\r\n42kvzlcdjzxmgnpqmsmkxq3seven43eightwovms\r\nrj5hxkldqseven\r\nf7\r\n5sskjblmnbzjhctvmttwotwott\r\n9ftmpxlbphsfxzsbktjttkxclknsbkftwo7\r\n3ndmzlfbsfqhxrlj2fourfive\r\n8378vkthreemggtf2\r\n2hprlpkbsfzbnbpsmflxjh15one\r\ndxvtfrhhxthree68four529eight\r\nxgjvjddtnine1zxeightwosnx\r\nsixblpgkznvjseven2oneskvxgngzlpzvjcxkcjgblh\r\nbhhkfive4jgngngjfhbp8kpnjtgrmblone\r\n8vmfivetwo9eightthreefxbvf\r\n8738\r\n8sixlgnpbpqpltbqqjjxpkcdfourhxzqpmm\r\nseventwo5three\r\nh46ssnqlfrl8\r\nninetwokrkfqhh2jbznndtchssjtbpqdhtnrhsix\r\n254\r\n1nhbdtwosixonezxtnvhjnine\r\nqxx97d1dcnqzqhsixnzbrvrksnc\r\nfivegnxzgvmzone8fourfivethree5\r\nfivexhx7six87\r\nzngqzxpmd63bgfzjpftsjgzghdppqfqbnblt7sixone\r\nninemzlgnkglj1\r\nfiveninesixeightthree4six1\r\nfivesix5ninethreeqkxczhp3\r\neight19two16pqdstm\r\nmplj637sjtgzltwo\r\n7lvs7xzmjmxjhlgdqhtqllhtzlkmbfm5\r\nsix6kqvbjfoureight94\r\none9qdjpfszz6vxbrdnntfz8btft6\r\n65onendmdgtr\r\nseven368\r\neight31ngsdmnm\r\n2threetgpvcseven\r\nnine297zqgvglthreel\r\n7eighttxvrbjsnbcseven\r\nrdpcnrscggv1cxv63\r\n2cdfltscsnzg8eightwosg\r\njrszpsjthree8n8bdjtlcbxtsixktkcc\r\ndns3\r\n2threebpkctf\r\n5pgzpfqntc\r\n9pkone\r\noneseven2fm545two3\r\n9threegtctbldnnclqpdmjnps7seven\r\n1dknxbdcvpssix413\r\nrzrvm77one2\r\nsixnttfive97jdcjvcmg\r\nspdmkhnthreebqsmtqgnm5threedxjcvsrxbq\r\nbtzkx8ckninevffmmfm3four\r\nhgx8fivenine2oneightc\r\nthdfczcpnxctgfiveseven65threeeight4\r\nfive6nine\r\nqgtds7\r\nhqnzcfleight8two2\r\n8q8zbkjrqxzhlzgmqmzrbfqceight\r\nnbbrrmksdm2ninefive3x\r\nfivec2sixsixmngbsjzk71\r\n821one4\r\n5eightvpxfpnzvsfhcdtn7kdkjdpsqcl\r\n6seventwotwogxvgvxzjbvcqcl38\r\nonetwo23863\r\n24qtzzxfhq\r\none7six814\r\nczdhrn2twoninetwo8\r\none54\r\nfoursslpnrqcv7sixtwoned\r\n9xsptsgfplpbrtpc1sevenjrggpr52\r\nzoneightg6sixgfdtwo7\r\n34twodhthree2tqsevenvqqrxq\r\nmonektltrghq97seven\r\nggeightwothree5cpfvrnp48\r\nnine7zpcbx33bbmd\r\nsix831\r\n63vjlqdc5one\r\nnine9cgxgrq8\r\n5sixxpeightsix\r\nonecgpxlhhgtthreetwo3\r\n336\r\nxcdjlblthreefourqrcxbxlhsdlseven5five\r\n9znnlhrrmb1999drzkckthreehghffcgfr\r\ntwo8one\r\nztwogggh48\r\nsix4pcmqkpqb\r\n14two47vmhbsgrgdone3\r\n84eight2\r\n5cnoneskjzppm\r\nnine8threecstfxqp7\r\nthreecsbhnn22three9three4xphcvgnz\r\nvjq8ninenhr7\r\nqcffmrfthreexgjjrdbdthree3\r\neightsix5\r\nthreeeightfcsmrvdqzp6\r\nsevendcpm3five4eightbthreefive\r\nkq9one46dqnr\r\njbmtdqbzn5sixlnthree\r\nninebdz4fourbvq\r\nphbzxtvtthreerm89\r\ndqlgfoursix5k3mcrkmxcp\r\n3fivesixqrrvtsjdxtdqp14pznxpnrgkrvg\r\n5cnkfz4lxbvbpmcfninetgn9\r\nmtjq8threeninefourhnzgctvtrfive\r\n47l6784\r\ntwopdmponenzpjfbqgt2nine1qccqx\r\n77hspkdhqfztwomkdshrkn3nt\r\nfive7pjrslqhkzcjzhn6\r\ntwoqvgphqs8zzmgclhsseven5eightfive\r\nthreehmkjmrqqblnrfvbpzhrsix4zvlmcqeight\r\n6lcfjthree8ninefive54\r\nsevenfive558four\r\nhtbdrfh8bthreeninedrjdbjbzlknine\r\nhkhknzrbfsevenhcvbdfs2sixcbjqzltfour4\r\nqrvfpxdseven2\r\n139msnzkfgpzdz5nine1\r\nrbdone3ftvrdkssvmnzjgpcbdjzdkcgbcs69\r\nnine58\r\n2ckxdtcqc5seveneight4two\r\nqtgndtm4mrqvtgbgjf7nzhvtvjqqrdmfiverzzgn\r\n3rchqn37tlvgtftdjqxgbvhlpclpneightfive\r\n11sfhcntjzpnkvpzjfhhpmbtjptngpnbqthreethree6\r\nfivenine4cthreeeightzqlckkvs\r\n5threekjqxkddgvzph92\r\nfive372seven8eightthreefour\r\nfivegjjxh15zdnbxzlhleight5fourqrpxj\r\n84sevenvckrdpxlgzkcbpr76fjzbpn\r\nmvvxgjfqj9five1psvtflxhkpfourdxzxhvxmthreekp\r\nseven7pnltbp1twotwo9lfdgzpj\r\nsevenfkrtsgrnhgfive54three8csmsg\r\nsevendczlbgjbg6srsbtseven\r\nonejscsevensix2oneightd\r\nmchrcflvfj3znrzhrvbhm\r\nbrfninexxntnine83kfzbn\r\n97tfgthreefxpv\r\nkspdrcnvvntts8bb4sixvghhjcpt\r\n8onedxcbnlvpntljztxs\r\nc91drttnrsevenxj9\r\n9onethree9fivexrszjfxcrjdbskdmn\r\ncjtnzpfourxspsjvmrbqclkzkdftc8pdfbfxjnvflgfkqctvcsc\r\n5seventkqrdpmrrchxfournczqzlqqm7p\r\nnhpbdxgzzjltdftqc5fivelgvjshonervrxmgscvhnnfl\r\n2gcqpdcgjv\r\nbqhzdzxb54\r\nnsmxljkjcmnmxvcrj7threegcrjs7\r\n2cninev1eightdjcztnrk\r\ncmjskeightmjfrlfhm22fivetzmfive\r\n8ndsix\r\nnzrgmlcrg5r4eighthfxm4\r\nthreeptlf3x4\r\n3bhd\r\ncbmzrtglngmghmonezdqnhxxd1ctpghbfzqfivefour8\r\neightpdzftbdlcrtwonine29bcgxflmf\r\n69crzsmjfivecxcqtffoursix4two\r\n92zghnv\r\nfivejmdxvnf1\r\n1ntvtnrjmeight1onegckvcnsjnthree\r\nncxgppbsnhsfnhlonelfbxqzsgfjj8\r\neightfhjbrlzxcgtls42sixtjk7two\r\nczrtnfzjnjhxdxtbgtmntkcpninejtzrprsstm4eight2\r\n483nine\r\nonecnxpmhjjcvdtzc71seven\r\n5l15\r\n19jmkmrxbdbtz4shpdgmmhzrxtbftpgrj3plvlqdvnr\r\ntwo4two\r\nkqgtjstcpnhf8\r\nsn6\r\ngrtgjxgqhv2fourbjmfnb\r\nbfmtkqfcp5hks74fivesevenbgvgzr\r\npeightwoninef2ninejmlhndvjd92\r\n1qxm\r\n2drkgnvghqrjtfxrvnthreesevenpzzldp\r\nfour4zcmmzgbzc\r\n4nfbpctgmx\r\n3threemfbgthree19sixone8\r\nggc1gldjhxsgvq\r\n1four4seven824nineeight\r\nninefour6one5ninetwo\r\nbpjs8rjdxpm\r\nzggcvkzeight7onejgkhpsrdkfvfx5three\r\n7h7lpjzsdv4six1\r\n6seven9one4\r\nsixfour6\r\n4hkddrmgfp\r\n43ninecrtoneseven2qbhkkbzdltfour\r\n85\r\nhlfive3dqzdvjkdd\r\n5chpcxbjkrdzbjtwofivethreem\r\n6ninenineonefour\r\n5five8twoonesf2\r\nfour1seven5pbbjgmxgxmvfzjtvr6vttbnd\r\nzzkcpcckmsixeightnine4\r\n9xxzzvcsg45one\r\nxmd3ninerxllskrl\r\nxxj2onesixfive3six\r\nthreeseven8\r\none43\r\n1sixthreelcbcfgbone3bzgrl5\r\nfour12535three5\r\njztxrtwo8495\r\nthreeqhsvcvzfnsevenfourtwothreeffrz9\r\nonevqlxcz461five4fthree\r\nznine5\r\ncch5ptlbcbh2ngnlqnrdsjv6mfhndf2\r\nthreehblbzlddttzkrsl51eightzrj\r\n68pgmnbz7seven\r\ntwotfhcgltpp1ntpcvrmkgd998\r\nseven3fourfive7eightsevendlqqseven\r\njqtcrf43zkktbqhsevendljgb5two\r\n3one5threethree\r\nvvpjcnine9seventhreeninebtzmr\r\njfourp7twoseven32\r\n2prjqnineninevjlmqkrkdxv\r\n67six1oneddp9\r\ntcbcttxninenine21hrmphqrjkvtnfgchjnb3\r\nsg1six5sevennineone\r\nninet7jkrzxtmmz\r\nninesixtslvqck9\r\ndnhsp9sevenrrsjdn\r\nonekqkvb7\r\n2sfflskftk\r\n79four\r\njnngdkghtwo1two\r\nfptfourseven4hjvkz3onesix\r\ntzhtsgkcp8\r\n9n\r\nsix4294seven8\r\nseveneight74five1\r\nkfghjdssttgrfour2two5three1nine\r\n5gkhgsixvlpcdmpgbjkqtjlthreetwo3one\r\nsevenfour1tfxzgsnldk1fiveqg\r\n187qhhqlrjx\r\n2lthreethreexthjqcsix\r\ncgpxkxgkmcpdzhtpc363\r\nsixbtkvqt3\r\n4twotwoqqmtb7dczgqrtsixseven\r\nseventwo7z9fzgjkl5fjndrznc\r\nqsgfnjqsghtwoninethree8lppsthree\r\nthreesevenkdzzvzbl2foursxrlq4sevensix\r\nseven8bjbmcnhrcp3one\r\ngg531\r\none8sfvzplxlknine54\r\ndlxeightwo48fourthreeninethreeeight\r\nsixxlglqsjtmqmgcnfvpljsevenqlgllg6\r\ntszncfour7one\r\nthree54three4\r\nqkjxzcdmxqvjngmrkpmleight83\r\n5twoksv49\r\n7six58sseven87two\r\nfourseven6ndsgfjv8\r\nppmclkxhpjpqrjoneeight8two\r\n538\r\nsixlhsixfive5\r\ntwosevenb3f2twonebpb\r\nlxqbgl55fgzfmvtpgjbxxgffsixlkxlbvmjkkslqpkq5\r\n7ptnpseven6one\r\n3mtlbfc6tx46five\r\n99pgdmnrbjv\r\n7twokvzlvptxcrfbfzqsxsqvxtfkcpkczkr9fjxsr\r\neight82lfivenine\r\nonetwo2jvqdhkktbeight\r\n8zhxksgcc79one\r\nknqqz4\r\n36twofour\r\n2gdssixtnineeight2\r\nfoursix4\r\n49hjbscbjvbckhjmjrdbh3one\r\nfivesixdqpnv2\r\n7ftwo\r\nfourffhffkphssbxzsgeight68dvhgrb\r\ntwo8sevenfive1\r\ndggljb5nvhpspbscfhd21\r\ntwokeightthreeone6lqglrseven\r\ncklfcsqgtwohptslmlgdpjktvvbbx3\r\ntwo3sixthreesevennine\r\n7ninepnclmdnv7ninevmqoneightpct\r\nczzbhfhhrfonetwo1ttvpgxkgsonektpnfrptjltklj4\r\n7sixthree1five45\r\nbtwone3fivelfzmfxsr81oneqhkzjvt\r\n5kmrlbvpcdrfivefourfive3\r\n9fsl3nine12\r\n1seven1seventwofivetwosix\r\nsixzdeight9fcpzvsbtz85\r\nn1jmxjvgfiveone\r\n1qsptpfbqtrl19three\r\n5twoeight3grrksgjdkgn\r\n1dq4sjknrp755\r\n2three2five\r\ntxktfive2ngqfl57\r\nvnrjvh1qpbbzqlgjpgrsgrqgggthreeone\r\nsevenone8srlxqqlvv\r\neightsbfivefourfourseven6\r\n853\r\neight53b3sxfvnz7\r\nqbhrhkhcbnsfivenszghnbhsix2ggvv\r\ntwo28three9\r\nrltzcpbqxfive1nineone\r\n5threedcfspjkm62seven8\r\ntlndznhtthree268\r\nndfgfkphmn2sixjxxtlbqlnine\r\n51eight682fivepnine\r\ndqvrvthreesixsix2fivenrjeight\r\nseven69\r\n4qlkktltwo8tqgxcninefour21\r\nthreefour32j\r\n4nine27ngxp8\r\nseven5ghxkb8\r\nnineone56\r\ntwo8onezonesctsttzt5\r\n64km6ttncd\r\nthree6six6\r\nthreetwoeight7six7jgmhreightwocl\r\n3sixfivehjgvqjlrsfivesix6\r\nfiveeight3sppjtccnineeighteightnffgtlsdj\r\n12seven9fbqxhs9jgh4five\r\n7dmbqrqsnckxtpt\r\nktvlgfzt95lfdvf4lbppfccjcprdpkdj\r\nseven65lrjmmqdfjfourtslnhdh5\r\nsblgrkqccmpqhfksmg5532\r\nrgqzkmmv4ctgzcgvqdghmvfour3\r\n24rtxdxqnbvdnkgtgcbfkfbtwo\r\n63seven78hrdnnsh\r\neighttpj79\r\nfoursix6\r\n6czcdgdmrmzcdcfmsixfkdnbdsplcscqh27\r\n3333dgrd\r\n8threeltfpfz3\r\nxgxddj3qkcnbbbhtvbzkmvh8\r\ns2pzqkldrcx43xzmxqvspm\r\neight1gkvlt24twothree19\r\nlkrzltxknd5fmjgbds2klkfgcgp3xcbxxpnl9hzfbfclrx\r\n2zhn73\r\nsixone4eightninelthreeeight\r\nseven8vlqqfjfmltwosevenfivetwo\r\nspfkzfmssfjrsevennine8ltlrnrjbcfive8\r\n1spbthreeshsgmrbcp\r\nninefive7cnxznfmcp6nine\r\neight4one9x3nine\r\neightnine4kgxhxx1ckrqlrn\r\n6sevenkjmfxrbhck\r\njsgtwonefvmcdsnqfp4fivefivesevenhkbkqcb1vgkshfnxfc\r\neightcvzmtlvsm49\r\n78four\r\nthreeoneninecjzs75\r\nxrxrsrh58\r\n1zqkhcvoneseventwohbrfbqgvp\r\n9zfznrfvtgjfhsk\r\nv5jcblbstnvxk\r\n6s1\r\n6three1seven\r\n75xpmzmhqqphgtrblhkcdxczcvbmg\r\n2rqv989fourthreefourone\r\nzmghjgrfqlzpdcqq9fjnkbl7btgf\r\n2three3qvbfbn\r\nfivehnklrqktnqqlqfslfjpfpfx9six\r\n3xvskqbjzrlonetwo\r\n95fx6sevenseven3grfncsdttt\r\ntwo8twoklgnrm\r\ntwo9seven6eight\r\n7lh2sevenshfvljtphhnbhvkzxxgjjrvlq7\r\nninemdgkndsevensevensix4seven\r\n4three6eight1lkdmtbh\r\n7rdpvbqljvnine82pmqclfive\r\nnine6nine7seven6\r\n54rvpqphbpxmcfjmcspsnhrjp\r\neightn2skzmpmtgqhvvfxgqonevtbfsmfklzspxdrgj\r\nnine276rzshsrvncjrdzfxbmzzlvkhdlcc\r\nsevenfivexgznfftgthree44\r\nfivekltdkmm3rdmdnm32nineddsfdzpks";
    string[] allCodes;

    public int Answer1 {  get; set; }
    public int Answer2 { get; set; }
    
    public Dec01()
    {
        allCodes = Input.Split("\r\n");
    }

    public void Solve()
    {
        Solve1();
        Solve2();
    }

    public void Solve1()
    {
        foreach (string code in allCodes)
        {
            Answer1 += ((code.First(x => Char.IsDigit(x)) - '0') * 10) + (code.Last(x => Char.IsDigit(x)) - '0');
        }
        Console.WriteLine("First: \t" + Answer1);        
    }

    public void Solve2()
    {
        string[] stringDigits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        int firstDigitDigitIndex = 0;
        int lastDigitDigitIndex = 0;
        foreach (var code in allCodes)
        {            
            int firstStringDigitIndex = int.MaxValue;
            int lastStringDigitIndex = -1;
            string firstStringDigit = "";
            string lastStringDigit = "";
            foreach (var digit in stringDigits)
            {
                if (code.IndexOf(digit) >= 0 && code.IndexOf(digit) < firstStringDigitIndex)
                {
                    firstStringDigitIndex = code.IndexOf(digit);
                    firstStringDigit = digit;
                }

                if (code.LastIndexOf(digit) >= 0 && code.LastIndexOf(digit) > lastStringDigitIndex)
                {
                    lastStringDigitIndex = code.LastIndexOf(digit);
                    lastStringDigit = digit;
                }
            }
            firstDigitDigitIndex = code.IndexOf(code.First(c => Char.IsDigit(c)));
            lastDigitDigitIndex = code.LastIndexOf(code.Last(c => Char.IsDigit(c)));
            int firstDigit = firstDigitDigitIndex < firstStringDigitIndex ? code[firstDigitDigitIndex] - '0' : Array.IndexOf(stringDigits, firstStringDigit) + 1;
            int lastDigit = lastDigitDigitIndex > lastStringDigitIndex ? code[lastDigitDigitIndex] - '0' : Array.IndexOf(stringDigits, lastStringDigit) + 1;
            Answer2 += (firstDigit * 10) + lastDigit;
        }
       
        Console.WriteLine("Second:\t" +Answer2);
    }
}
