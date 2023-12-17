using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace AdventOfCode2023;

public class Dec07 : ISolution
{
    public string Input { get; set; }


    public int Answer1 { get; set; }
    public int Answer2 { get; set; }
    Char[] cardSet;
    List<HandInfo> allHands;
    public static bool isJJoker;
    public Dec07()
    {
        Input = "757T6 637\r\nTTT2T 589\r\n4567T 670\r\nJ77QQ 261\r\nQ63KQ 179\r\nT87KQ 969\r\nQ2Q62 401\r\n333Q3 241\r\nK5A64 839\r\n3JKJ4 152\r\nQ8332 122\r\n59K7J 32\r\nA6666 977\r\nQ76JJ 522\r\nQ8992 704\r\n58555 402\r\n79987 147\r\nT9K27 364\r\n83J38 74\r\n48442 128\r\n789J8 223\r\n4QT43 625\r\nT5557 525\r\n222J9 329\r\n6AQ65 386\r\n5J924 255\r\n6326T 848\r\n9Q398 108\r\n8ATTT 150\r\n6JT6A 160\r\n32T9A 587\r\n9T874 49\r\n66686 669\r\n26666 887\r\n89K46 768\r\n88T85 846\r\nJTA9T 582\r\nJK494 722\r\nK5855 437\r\nT4J8T 851\r\nJ3J99 299\r\n639KK 436\r\nK4JK3 219\r\n99797 211\r\n4A797 18\r\nKT6JT 31\r\n237T5 711\r\n95599 491\r\n946K9 941\r\nAKKQ7 621\r\nQ24T8 460\r\n66J3J 756\r\n3QK24 760\r\n69A5K 280\r\nQ42A4 20\r\n43939 931\r\n567JT 506\r\n29992 177\r\nA9TJA 62\r\nK666A 440\r\nAA8AA 707\r\n9K9K9 125\r\nK6J22 442\r\n59T28 53\r\n4K5T4 238\r\nJK6JK 636\r\n4922K 120\r\n5A837 814\r\nQ55J8 627\r\n5QQ5J 925\r\nJA8A8 39\r\n4J482 483\r\nAA323 302\r\n95439 315\r\nT5T45 724\r\n64J44 679\r\nJAA93 618\r\nT69T5 623\r\n47744 630\r\nA77A7 78\r\n88A8A 469\r\n9A357 828\r\n72A68 106\r\n6AQT9 278\r\n77557 447\r\n757J7 899\r\n7T264 40\r\n7K77K 264\r\nJQ98Q 256\r\nA7377 50\r\n443TK 493\r\n99898 205\r\nA8AAK 93\r\nA525A 408\r\nJQKKQ 526\r\n64J74 651\r\nK2KTK 661\r\n9999J 616\r\nT9TJK 486\r\nQ9J9Q 176\r\n8T838 895\r\n2K222 877\r\n399J9 251\r\nAA7KT 936\r\nT494K 249\r\nAQAAQ 90\r\n5TTT5 750\r\n48843 689\r\n37Q7Q 823\r\n77722 236\r\n9K482 390\r\nAQQ76 712\r\n2QQQ9 270\r\nQKQKQ 320\r\n35Q33 396\r\nT52T2 967\r\n3Q3QQ 2\r\nKT57K 709\r\n8AT8A 672\r\nA7799 59\r\nTT888 880\r\n5TTT2 648\r\n3A62J 654\r\n22545 960\r\n34T9Q 757\r\n74477 311\r\nAQAJ5 989\r\n3K366 138\r\n4AA44 987\r\n85458 206\r\n2K322 259\r\n2822J 660\r\nJJ73K 371\r\n44Q4Q 954\r\n7A3TA 529\r\nQ794J 418\r\n84488 742\r\n7J77J 6\r\nJ4459 165\r\nJQK9K 345\r\n22ATT 154\r\n88778 729\r\n97497 600\r\n55AQQ 42\r\n68888 172\r\n69JJQ 970\r\n85A38 746\r\n57J55 189\r\n74977 114\r\nQ3389 605\r\n37883 499\r\nQQ3QJ 734\r\n955K9 590\r\n3T5J6 488\r\n7227J 296\r\n3K63K 753\r\nQQJJJ 260\r\nK4867 766\r\nJ4TKQ 307\r\nTJAJ2 514\r\n99AQ5 662\r\nK2A2T 774\r\n29242 169\r\nT99J9 393\r\nT5QQ3 213\r\nK4K4K 567\r\nJATQ6 520\r\n93J78 463\r\nJ43JJ 56\r\n2J222 7\r\n9T374 638\r\n76695 694\r\n3J748 641\r\nAA4A4 549\r\n4444J 412\r\nJ8Q99 309\r\n99695 680\r\n7Q7QQ 112\r\nKK2KQ 728\r\n5746A 971\r\nJA4J4 952\r\n599Q9 391\r\n74574 457\r\n5K477 642\r\nKK899 751\r\n9JK25 12\r\nTKK9J 257\r\n35333 235\r\n7KKKK 407\r\n22442 141\r\nKJ55K 565\r\nJQQQQ 933\r\n22323 888\r\nAT2Q4 560\r\n5T5T5 357\r\n38KA5 431\r\n86668 869\r\nQJ44Q 715\r\nTAT8A 603\r\n6J6J6 573\r\nKJKK5 174\r\n7T6TT 900\r\n36353 350\r\n545J5 508\r\n39336 476\r\n7Q977 535\r\n99A99 470\r\n8898J 234\r\nQJ9QQ 304\r\nJ5892 13\r\nK8427 765\r\nJ2555 541\r\n6257Q 862\r\n63529 272\r\n3KK55 339\r\n68A2K 867\r\n4JJJT 949\r\n2A2Q7 510\r\n6KAKK 721\r\nQAAQJ 703\r\n3K343 875\r\nA25A6 564\r\nQ9977 873\r\n99222 795\r\n47772 30\r\nQT4K5 864\r\nK5978 216\r\nQQQ4Q 76\r\nK3KJJ 419\r\nKKKJK 305\r\n57272 594\r\nTTT87 341\r\nQ2AQJ 335\r\n5Q23Q 444\r\n77774 972\r\nJ8Q44 700\r\nJJ444 314\r\nA428J 183\r\nTK725 290\r\n332T3 929\r\nTQ5J2 321\r\n797K9 163\r\nJT222 983\r\nA666A 441\r\nQTQQ7 790\r\nAKKAT 400\r\nJ9JQA 596\r\n7K93A 443\r\n3Q869 904\r\n5TTQ5 609\r\nKTK8J 33\r\n9A338 131\r\nTK22T 650\r\n5J25T 732\r\nA5422 190\r\nKK68K 719\r\nTQ7KT 367\r\n92438 217\r\n89895 3\r\n8J8QQ 1\r\nJJJJJ 613\r\n6366T 584\r\nTQ4QQ 745\r\n6KJJQ 449\r\nJTT88 502\r\n736QQ 847\r\n687Q3 570\r\nK8TA4 807\r\nTATTA 298\r\nTTKTT 186\r\n47KKK 597\r\nTAAJT 145\r\nQQ6TQ 926\r\n739Q9 519\r\n43895 922\r\n795TQ 389\r\n264AJ 996\r\nA5Q4T 166\r\n77JQJ 914\r\nQ5T99 720\r\n67Q66 45\r\n8J499 859\r\n393K3 501\r\n3TQ4A 63\r\nAA8AJ 254\r\nA343Q 375\r\nT6T6J 965\r\nQ594A 838\r\n4T29Q 101\r\n3QJJ3 267\r\nK3J3K 958\r\n78K88 126\r\nJ42KJ 824\r\n78T53 195\r\n44Q9Q 676\r\n43434 592\r\n6J524 918\r\nKQK85 88\r\nQ66Q6 671\r\n45Q34 207\r\nJ95KK 810\r\n9J997 588\r\n42944 882\r\nJQQQJ 871\r\n98Q9Q 490\r\nAAJA5 279\r\n5A87T 285\r\nAAAJ2 252\r\n77KA3 932\r\n7J68K 699\r\nA3Q33 944\r\n8634T 303\r\n5T555 373\r\n27865 752\r\n94999 27\r\nA7JJJ 579\r\n22J26 577\r\n99944 659\r\n444T4 903\r\n66Q9Q 340\r\nQQJQ7 404\r\nK29JJ 487\r\n6QQ64 4\r\n88A88 158\r\n444Q4 845\r\n7JT29 657\r\n92KQ5 889\r\n36JJQ 366\r\nQ4866 865\r\n4433J 376\r\nQ98TK 975\r\nJ9734 192\r\n9JAAA 817\r\n22779 674\r\n6Q877 917\r\n77773 553\r\nQ9899 28\r\nT4A32 198\r\n64448 11\r\n92T8Q 181\r\n36233 123\r\n6KK46 44\r\n23273 829\r\n8AJ7Q 83\r\n64293 966\r\nQ6666 295\r\n3T2J3 812\r\n63633 962\r\n37T2A 355\r\nKQ565 726\r\n3TQJT 149\r\n999T9 681\r\n7AKK5 66\r\n44T4T 9\r\n2TTT2 702\r\nKK82K 313\r\nTTJT7 538\r\n8JKAA 548\r\nJJ222 593\r\nK3JKK 855\r\n23KQ6 432\r\n33745 531\r\n6393J 324\r\n75885 982\r\n656KK 91\r\nA7JKA 383\r\n73979 919\r\nAAKA7 948\r\n56565 536\r\n8A345 119\r\n3QT37 911\r\n5T5T8 504\r\n96Q4T 552\r\nKAJKK 271\r\n5T57T 148\r\n3K6Q7 433\r\n3K98K 316\r\n77TT6 837\r\nQ4QQJ 178\r\n7T7TT 602\r\n75AA5 527\r\n42K2K 992\r\n53JAA 910\r\nAJ6K6 629\r\n38333 769\r\nKK668 533\r\nTK77T 439\r\n67Q57 598\r\nA2AA2 416\r\n888QA 156\r\nQ2J6J 951\r\n32568 673\r\n57377 569\r\n9T954 47\r\n65523 292\r\n46754 98\r\n55367 248\r\nQ2JJ3 532\r\n6826K 731\r\n44227 231\r\n92223 95\r\nKQQ2Q 701\r\nQQ9A5 262\r\nT42T4 534\r\n8T4Q4 868\r\n4TTJK 139\r\n46589 934\r\n5252K 717\r\n2TQT2 118\r\n5JT82 414\r\n5T4T3 852\r\n599QQ 913\r\n67765 51\r\n67777 968\r\nK2K22 682\r\nA49J7 453\r\n232J4 388\r\n23585 892\r\n92988 980\r\nJQ9T9 323\r\nT3T33 545\r\n2QKT5 94\r\nK859Q 777\r\nTQJ3K 758\r\nQT8J3 110\r\nA3AA2 326\r\n8TJ88 187\r\n8K8K8 22\r\n99J89 617\r\nJ4KA4 844\r\nA2A22 863\r\n46Q75 981\r\nQ55AA 666\r\n9J555 737\r\n92295 599\r\nJ7482 785\r\nAA77A 772\r\nQ8QQJ 872\r\n777A7 467\r\n444AT 542\r\n9K9AA 834\r\n27222 784\r\n5357T 878\r\n4T2T3 343\r\nA8996 8\r\n73A3A 19\r\nAA592 151\r\n3JT48 38\r\n5QQ5Q 286\r\nKK573 793\r\nQQQ2Q 497\r\nJ6T65 274\r\n8K56T 233\r\n2299J 735\r\nAA47Q 413\r\n529A3 344\r\nK5955 706\r\n77Q7Q 245\r\n66J44 116\r\n999A8 804\r\n75J8A 434\r\n57525 111\r\n4K4TK 107\r\n98A88 781\r\nQT896 767\r\nJ6666 691\r\nAJT9Q 764\r\nQ66TT 991\r\nQTTQQ 96\r\n77679 132\r\n59J2Q 310\r\n8T886 803\r\nAQ379 17\r\n4TQTT 301\r\n2J882 606\r\n848TK 15\r\nTQQ7A 927\r\nQQ5TA 964\r\n222TT 759\r\n444K4 399\r\nJ6356 204\r\n59549 334\r\nAJTT3 780\r\n97J97 137\r\nAAJAA 782\r\n5T37T 820\r\n5T9TT 663\r\n4A969 406\r\n6Q595 164\r\n66J26 220\r\n965T3 41\r\n44949 716\r\nA5555 771\r\n3366J 586\r\nQJ3TQ 48\r\n94464 336\r\n7KQ53 456\r\n75JA9 718\r\n3Q3TQ 668\r\n589A4 369\r\n9K437 228\r\nQ5347 438\r\n9J758 492\r\nKTA7K 747\r\nQ333K 129\r\n3Q294 370\r\n2K7A7 832\r\n4445J 561\r\n63333 513\r\nT3J47 656\r\n74444 612\r\nKK69K 325\r\n55575 557\r\n8JK82 622\r\n42KT7 896\r\nJTAJA 422\r\nK7843 318\r\n5AA59 273\r\nJ3373 595\r\nTQJ88 244\r\nTK637 884\r\n6J496 485\r\nTTQT2 997\r\n679J6 489\r\nA692K 909\r\n2J834 854\r\n69A35 201\r\n77KJ6 171\r\n4QKT4 52\r\nQJ88A 349\r\n5A3QK 692\r\n69943 221\r\n9Q3QQ 374\r\n92J78 686\r\n3KA7Q 224\r\n33898 794\r\n44666 104\r\nTK23A 841\r\n22327 97\r\n39377 842\r\n35335 836\r\nKA383 604\r\n87J53 450\r\n5KQ88 723\r\nTJTQ7 54\r\n33343 876\r\n77667 539\r\nK9K4Q 558\r\nQ737J 505\r\n88223 498\r\n278A3 827\r\nAJAJA 426\r\n7KKK7 976\r\n76J94 461\r\n5666J 959\r\nA872Q 879\r\n999AJ 347\r\n66888 749\r\nQJQQT 544\r\n9666Q 109\r\nKJ72T 755\r\n4J829 620\r\n22888 372\r\nJJTT9 853\r\nQJQT9 105\r\nQ32T4 687\r\n5T5KJ 800\r\nJJ464 494\r\nJT565 819\r\nA4635 639\r\n79475 571\r\nTATTT 822\r\n98656 559\r\n62276 268\r\n9TK4A 826\r\nJ2K55 275\r\n4QQ4K 84\r\n73878 354\r\n82593 825\r\nJ5TT5 902\r\n22626 801\r\nK63Q3 175\r\n4Q8TT 874\r\n9TT8T 363\r\nK2K5K 25\r\n22525 986\r\n33443 776\r\n977A7 675\r\nTT9TT 332\r\n4A6AA 23\r\nJAAJ8 802\r\nQ99J9 649\r\n33J99 956\r\n4K74T 495\r\nK38Q6 479\r\n245QK 521\r\nK25K5 395\r\nQAAAA 16\r\nQQQKQ 46\r\nJ8488 300\r\n3JTTT 835\r\n66993 478\r\n44356 554\r\n93329 883\r\n55545 167\r\n39999 477\r\n29999 392\r\nJ3AJ5 738\r\nKKK33 87\r\nTTTT8 144\r\nA33AA 831\r\n52555 287\r\n3TT3T 658\r\n5KK55 199\r\n8J6AA 237\r\nJ5TJ8 619\r\nJJAT3 218\r\nA7A62 786\r\n5KKK5 379\r\n9A8AA 247\r\nKKA5K 857\r\n56555 736\r\n8637A 197\r\n7AA25 365\r\n9K474 516\r\n74944 792\r\nK66K6 890\r\n7222A 912\r\nJA55A 67\r\n768TJ 284\r\n26222 240\r\nT7K5Q 833\r\n76357 162\r\nT2KJT 632\r\nJAQQQ 468\r\n6T769 984\r\n88J62 773\r\n393Q3 405\r\nKQKJ4 79\r\n422A3 640\r\n743KT 924\r\nTA5KA 420\r\n4A7QJ 950\r\n9297J 282\r\nA33JA 928\r\n45296 317\r\nT7279 979\r\nJ3AAA 555\r\nA75KQ 92\r\n5J662 387\r\nK999Q 741\r\nTT4TT 466\r\nT8JK5 998\r\nAQA83 5\r\n42374 696\r\nA23QT 893\r\nKQ49A 362\r\n4KKJK 427\r\nJ7K7K 86\r\n853AJ 830\r\nA888T 184\r\nK3KKK 957\r\nQ2425 474\r\n82822 923\r\n9JKKK 475\r\nJA6A9 540\r\n88577 645\r\n44443 653\r\n6Q444 518\r\n2833J 667\r\nAK685 194\r\n2783J 243\r\nT6JA5 543\r\nTA887 43\r\n47958 799\r\n9399T 955\r\n6AT23 276\r\n4AA88 610\r\nJA9K8 860\r\nQQ5QQ 743\r\n5J6Q4 698\r\nJJ56J 89\r\nAT9AA 563\r\n4JA44 464\r\n24444 938\r\n882K3 524\r\n4KJKT 646\r\n5T525 209\r\nT8TT8 870\r\n59555 75\r\n6KTQJ 840\r\n288Q2 68\r\nTT777 985\r\n9TTJ4 410\r\nJTJ36 818\r\n39Q37 953\r\n36T6T 10\r\nA8AJ7 193\r\n5599J 124\r\nAT8JA 961\r\n3J3T3 121\r\n9Q637 55\r\n66K88 170\r\n44449 159\r\nQ6688 65\r\n73AT7 117\r\n3K2AQ 103\r\n77878 338\r\n3669A 378\r\nJA552 377\r\nTTJTT 342\r\nJA27K 451\r\n5JKKJ 849\r\n2998J 465\r\nA4Q4A 359\r\nJ3393 210\r\n7KA83 142\r\n4T3KJ 417\r\n27QQQ 291\r\nQ4QQ4 288\r\n35ATJ 289\r\n7T292 787\r\n9966J 748\r\nA9A99 113\r\n2JK74 906\r\nT856Q 683\r\n8KKK7 77\r\nQ2727 385\r\n882TA 202\r\nAA298 655\r\n9TT92 945\r\n738K9 943\r\nKKKTT 61\r\nQ3T3T 821\r\n88T88 788\r\n57TTK 60\r\nT7QK9 994\r\n2Q3A3 523\r\n73377 226\r\n3T337 452\r\nJTJ94 306\r\n766JT 423\r\nQ555Q 269\r\nAJQAA 730\r\n75T5A 808\r\nQ6A7T 29\r\nKQKQT 551\r\nQ7T38 381\r\nJ7567 283\r\n4ATA2 239\r\n333J3 935\r\nA232A 789\r\n44623 115\r\nKT77A 915\r\n4888K 230\r\nK398T 693\r\n8AAA8 102\r\n3KT3K 763\r\n27272 665\r\n52222 937\r\n96966 939\r\nAT4TT 222\r\n8JJTJ 294\r\nJ33Q4 398\r\nJ5886 140\r\nKT26Q 575\r\n68788 99\r\n6TKTT 999\r\nTJ823 861\r\n22246 293\r\nKQK7K 705\r\n6A3T8 739\r\nT4T6T 568\r\nA8373 225\r\n663J6 127\r\n5KA52 644\r\n66ATT 916\r\n88863 446\r\n84444 196\r\n99298 34\r\n3TAJ8 26\r\n3A746 633\r\n33838 481\r\nKJ66K 806\r\nT9577 566\r\nTAAJQ 677\r\n76875 473\r\nQ88Q8 448\r\n8995Q 454\r\nAJ766 35\r\n26A9J 635\r\n2TJ7A 229\r\nT2242 615\r\nQA3JT 214\r\n373A7 500\r\n5TT33 330\r\n63TQ7 990\r\n2522J 684\r\n99339 942\r\nKT63A 576\r\n93226 995\r\n86T5A 628\r\n9QAK8 312\r\n7J797 697\r\nT2TJT 797\r\n8Q28Q 963\r\nJ45TK 168\r\n7777J 394\r\n33424 624\r\nA7A3A 72\r\nATAKT 511\r\n6K4QA 778\r\nQ5Q4Q 974\r\nJQ333 988\r\nAA2J2 459\r\nTK68Q 556\r\nQ8888 462\r\n7J676 70\r\n4A72T 445\r\nQAQQA 901\r\nT6QQ5 608\r\n4K44Q 881\r\n2A33K 81\r\n74AK2 253\r\n6J6QQ 775\r\n2Q77J 509\r\n78K69 770\r\n2JAQK 537\r\nT66T6 482\r\n2K2KT 322\r\n3TT37 607\r\nATAAT 744\r\nTTKK8 409\r\n22333 783\r\n44422 708\r\nJT39T 424\r\n79279 348\r\nQQQ9K 811\r\nJKTQ7 908\r\n8AA7A 580\r\n33K37 626\r\n27962 429\r\n8Q838 250\r\nJQ24J 153\r\nT5599 796\r\n23333 421\r\n8KJ8J 188\r\nT4544 815\r\nT8QT2 71\r\nA9J43 425\r\n4J4TT 740\r\nKJ73A 319\r\n2T6TT 327\r\n5KK7K 517\r\nA5AAA 581\r\n8868J 993\r\nT5A5T 856\r\nTQQ48 14\r\nATTT6 346\r\nTQ3TQ 136\r\n6A9JJ 308\r\n9Q5QK 471\r\nJ99KQ 161\r\n999Q9 130\r\nJ9692 258\r\n64TT6 182\r\nQ2534 227\r\n97779 710\r\n8632Q 905\r\n56TQT 263\r\n55JJ5 173\r\n99799 100\r\n3Q489 185\r\n2Q2TJ 208\r\n99693 73\r\n5555J 191\r\nA4JA9 134\r\n27426 528\r\n5AKJK 215\r\n789AJ 921\r\n53435 885\r\n6626A 664\r\nK634T 384\r\n4388T 356\r\nJJ8JJ 36\r\n7QQ6Q 685\r\n43664 266\r\nQ4593 920\r\n88884 200\r\n244QJ 733\r\n99JJ9 82\r\n4474T 816\r\n64TA9 382\r\n42Q55 562\r\nJ6646 337\r\n6TQTQ 688\r\n4J4JT 57\r\n3Q373 472\r\n25QJA 946\r\n99QKQ 64\r\n9T929 647\r\n3JQ83 591\r\n8JK86 265\r\n78Q37 331\r\n7A965 368\r\nT3T7Q 85\r\n58642 643\r\n2944Q 695\r\n8JJ88 411\r\n23K43 798\r\n63663 1000\r\nJ895Q 973\r\nK9T3T 886\r\nTQJ98 351\r\n7KJ4T 480\r\n56566 761\r\nAAKAA 940\r\n5JTTJ 484\r\nQ45A4 80\r\nJJKKK 403\r\n55298 297\r\n4K4TT 547\r\nJQQ6Q 546\r\n89AJT 809\r\nJ33J3 578\r\n8A5A8 246\r\nJA8KJ 21\r\n62426 203\r\nK43Q9 690\r\nJ2Q85 813\r\n6AK27 727\r\nQQ8QQ 333\r\n6A9T3 435\r\n22242 805\r\n55K66 428\r\nK4K2K 894\r\nT7T44 37\r\nTQTJT 898\r\nAA2AA 978\r\n7AKA9 277\r\n5KA56 430\r\n99989 652\r\n4A8AQ 58\r\n5KJ55 843\r\n4KQ5A 550\r\nK976T 157\r\nT2222 24\r\n37733 358\r\nA9AQ5 631\r\nT2847 583\r\n27226 714\r\n92332 503\r\n94K4K 515\r\nJTTJT 507\r\nK8A89 135\r\nAT72T 530\r\n269J8 512\r\n59Q3T 69\r\n8822K 397\r\nKJQ42 455\r\nQ9T47 496\r\n62KAJ 907\r\n3KKK6 574\r\n4K7K8 713\r\n55AAK 930\r\nT9878 133\r\n2JTTQ 380\r\n79K87 611\r\n4K72K 212\r\n44643 180\r\nK5555 281\r\nK7276 458\r\n7224Q 634\r\nT9TT9 143\r\nA44JA 614\r\n4J5A6 754\r\n88J88 155\r\nA4938 866\r\nK22J2 762\r\n684KT 678\r\n99599 779\r\nT78J9 353\r\nA7A37 572\r\n9KKKK 601\r\n6T666 361\r\n4949J 328\r\n76784 791\r\n2T68T 850\r\nK4KKK 725\r\n37J6T 897\r\nA327A 146\r\n39J7A 858\r\n8TA4Q 415\r\n5T83K 352\r\nJJ99J 360\r\n8894T 242\r\nQ49QQ 232\r\nQ9QQQ 891\r\n6262A 585\r\nK2K2K 947";
        cardSet = new char[] { 'A', 'K', 'Q', 'J', 'T', '9', '8', '7', '6', '5', '4', '3', '2' };
    }

    public void Solve()
    {
        Solve1();
        Solve2();
    }

    public void Solve1()
    {
        isJJoker = false;
        allHands = new List<HandInfo>();
        foreach (var inputRow in Input.Split("\r\n"))
        {
            allHands.Add(new HandInfo(inputRow.Split(' ')[0], inputRow.Split(' ')[1]));
        }

        SortAllHandsByCardStrength(allHands);
        allHands.ForEach(hand => SetHandType(hand.HandCards, hand));

        List<HandInfo> allHandsSortedByTotalStrength = new List<HandInfo>();
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.FiveOfKind).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.FourOfKind).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.FullHouse).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.ThreeOfKind).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.TwoPair).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.OnePair).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.HighCard).ToList());
        allHandsSortedByTotalStrength.Reverse();

        long result = 0;
        for (int i = 0; i < allHandsSortedByTotalStrength.Count; i++)
        {
            result += allHandsSortedByTotalStrength[i].Bid * (i + 1);
        }

        Console.WriteLine("First: \t" + result);
    }

    public void Solve2()
    {
        char[] jokerSubstitutes = new char[] { 'A', 'K', 'Q', 'T', '9', '8', '7', '6', '5', '4', '3', '2' };
        isJJoker = true;
        allHands = new List<HandInfo>();
        foreach (var inputRow in Input.Split("\r\n"))
        {
            allHands.Add(new HandInfo(inputRow.Split(' ')[0], inputRow.Split(' ')[1]));
        }

        SortAllHandsByCardStrength(allHands);
        List<HandInfo> allHandsSortedByTotalStrength = new List<HandInfo>();

        foreach (var hand in allHands)
        {            
            if (hand.HandCards.Contains('J'))
            {
                int numberOfCardsToTest = jokerSubstitutes.Length;
                var numberOfJacks = hand.HandCards.Count(ch => ch == 'J');

                // Store the jacks' positions in the hand
                List<int> jacksIndexes = new List<int>();                
                for (int i = 0; i < hand.HandCards.Length; i++)
                {
                    if (hand.HandCards[i] == 'J')
                        jacksIndexes.Add(i);
                }

                // Loop every combination for all the jacks' substitutes
                int numberOfCombinations = (int)Math.Pow(numberOfCardsToTest, numberOfJacks);
                for (int combination = 0; combination < numberOfCombinations; combination++)
                {
                    string testHand = hand.HandCards;
                    int tempCombination = combination;
                    // byt ut alla jack till substitut för aktuell kombination
                    for (int jack = 0; jack < numberOfJacks; jack++)
                    {
                        int jokerSubstituteCardIndex = tempCombination % numberOfCardsToTest;
                        testHand = testHand.Substring(0, jacksIndexes[jack]) + jokerSubstitutes[jokerSubstituteCardIndex] + hand.HandCards.Substring(jacksIndexes[jack] + 1);
                        tempCombination /=  jokerSubstitutes.Length;
                    }

                    SetHandType(testHand, hand);
                }                
            }
            else
                SetHandType(hand.HandCards, hand);
        }

        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.FiveOfKind).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.FourOfKind).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.FullHouse).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.ThreeOfKind).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.TwoPair).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.OnePair).ToList());
        allHandsSortedByTotalStrength.AddRange(allHands.Where(hand => hand.Type == HandType.HighCard).ToList());
        allHandsSortedByTotalStrength.Reverse();

        long result = 0;
        for (int i = 0; i < allHandsSortedByTotalStrength.Count; i++)
        {
            result += allHandsSortedByTotalStrength[i].Bid * (i + 1);
        }
        Console.WriteLine("Second:\t" + result);
    }

    private void SetHandType(string testHand, HandInfo hand)    
    {
        var groupedHand = testHand.ToCharArray().GroupBy(card => card);
        if (groupedHand.All(group => group.Count() == 1))
        {
            if (hand.Type <= HandType.HighCard)
                hand.Type = HandType.HighCard;
        }
        if (groupedHand.Any(group => group.Count() == 2))
        {
            if (hand.Type < HandType.OnePair)
                hand.Type = HandType.OnePair;
        }
        if (groupedHand.Count(group => group.Count() == 2) == 2)
        {
            if (hand.Type < HandType.TwoPair)
                hand.Type = HandType.TwoPair;
        }
        if (groupedHand.Any(group => group.Count() == 3))
        {
            if (hand.Type < HandType.ThreeOfKind)
                hand.Type = HandType.ThreeOfKind;
        }
        if (groupedHand.Any(group => group.Count() == 3) && groupedHand.Any(group => group.Count() == 2))
        {
            if (hand.Type < HandType.FullHouse)
                hand.Type = HandType.FullHouse;
        }
        if (groupedHand.Any(group => group.Count() == 4))
        {
            if (hand.Type < HandType.FourOfKind)
                hand.Type = HandType.FourOfKind;
        }
        if (groupedHand.Any(group => group.Count() == 5))
        {
            hand.Type = HandType.FiveOfKind;
        }
    }

    private void SortAllHandsByCardStrength(List<HandInfo> originalList)
    {
        allHands = allHands.OrderBy(o => o.SortBy).ToList();
    }    
}

public class HandInfo
{
    public string HandCards { get; set; }
    public int Bid { get; set; }
    public string SortBy { get; set; } = string.Empty;

    public bool isAdded = false;
    
    public HandType Type { get; set; }


    public HandInfo(string handCards, string bid)
    {
        HandCards = handCards;
        Bid = Convert.ToInt32(bid);
        SetSortBy();
    }

    private void SetSortBy()
    {
        char substituteForJ = Dec07.isJJoker ? 'Z' : 'D';
        foreach (var card in HandCards)
        {
            switch (card)
            {
                case 'A': SortBy += 'A'; break;
                case 'K': SortBy += 'B'; break;
                case 'Q': SortBy += 'C'; break;
                case 'J': SortBy += substituteForJ; break;
                case 'T': SortBy += 'E'; break;
                case '9': SortBy += 'F'; break;
                case '8': SortBy += 'G'; break;
                case '7': SortBy += 'H'; break;
                case '6': SortBy += 'I'; break;
                case '5': SortBy += 'J'; break;
                case '4': SortBy += 'K'; break;
                case '3': SortBy += 'L'; break;
                case '2': SortBy += 'M'; break;
            }
        }
    }    
}

public enum HandType
{
    HighCard,
    OnePair,
    TwoPair,
    ThreeOfKind,
    FullHouse,
    FourOfKind,
    FiveOfKind
}