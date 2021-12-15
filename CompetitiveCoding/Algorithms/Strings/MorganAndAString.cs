﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveCoding.Algorithms.Strings
{
    public class MorganAndAString
    {
        static string morganAndString(string a, string b)
        {
            var result = "";
            var i = 0; var j = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    result += a[i];
                    i++;
                }
                else
                {
                    result += b[j];
                    j++;
                }
            }

            if (i < a.Length)
            {
                result += a.Substring(i, a.Length - i);
            }

            if (j < b.Length)
            {
                result += b.Substring(j, b.Length - j);
            }

            return result;
        }

        public static void Start()
        {
            //string a = "MZBMWEYYDIADTLCOUEGMDBYFWURPWBPUVHIFNUAPWYNDMHTQVKGKBHTYTSZOTWFLEGSJZZSZFWTZFPNSCGUEMWRCZQXYCIVDQNKYPNXNNPMUDUHZNOAQUUDHAVRNCWFWUJPCMIGGJMCMKKBNJFEODXKGJGWXTRXINGIQQUHUWQHDSWXXRXUZZFHKPLWUNFAGPPCOILDAGKTGDARVEUSJUQFISTULGBGLWMFGZRNYXRYETWZHLNFEWCZMNOOZLQATUGMDJWGZCFABBKOXYJXKATJMPPRSWKDKOBDAGWDWXSUFEESRVNCBSZCEPIGPBZUZOOOTORZFSKCWBQORVWDRMKLFDCZATFARQDKELALXZXILLKFDVPFPXABQLNGDSCRENTZAMZTVVCVRTCMBQLIZIJDWTUYFRXOLSYSXLFEBPOLCMQSPPMRFKYUNYDTMWBEXSNGXHWVROANDFQJAMZKPTTSLILDLRKJOYRPXUGICEAHGIAKEVSJOADMKFNKSWRAWKJXWCMCCIABZBRSKZAZJQTLKIQYDPTPKCSDGCQJSHZNDPVANNRYWFRNRGHLJJQRXPXNLKCWDPDKSWVTXGANWWYOOSXTNEXEEZJXOUYFJHNWPQFXEXZXFOLPCFBLPNCETYHTRWXKBOSCCSKXBUVCROSAVNPXZOEOYYGHBBQKFLSUTPWMHQWKVIRMLFCPIDLQYIKZMNTTAIFCBOPNWEZESOMKXHAIAFMVKBJAISYRBTULTPNXBCJMORNQUMATSERHIEQGGRIVOUWFNBNGHDFALLCPRVNGIKCAMVPRZAEAPQMILWKBKGOGOCNIAAISORFQXZJZTVCGVZLCEDWNEZBWXMPOBMRVXASKWVVWQUUDRNWHMMZHEQXIWHFUXAVLWFTGYXXHPYGSPVWDNVMGNWNPKDRNZNZVRKMJJMWISYRDKODOAFWSJFUVMEEWPDWPIYMWBHOXEBJIBXPHIEFGTSAWCDIVTLTRSHJQNKKMDTJGSCNOZMOJNHIGIPPJEMZZZBCVOYPLXENFFMFDZDIOJUODGBULVIVHTBHAYEEEBIACTYAOVQBIVUDYDGXWSGMHLRACAAYIPSOJLEQHPYGSHCVXWWLNEBLFMNQGDDQPCJXZFTWRLGPTRKBKRLWGSNLCAUDZDUJBBQLFZIKGXOHVHTUVCJMMWVHKXCGYEKJKKLCJQONEPPYDPSPIWQBKPSUNEDQIXLSIFCOKFRCVRSZCVDYFWUHTZPTBBNXBHQJOMXRBHJQXVDASERFFCVKECQYLQPRAWYQUEVHVUZCVFMBEWPXICSKPMZSBSUSMADDQKWGFIRLZZBCZEGHMUHXNXEJRSPCVQEJWOWQSFHOVHCTWNHUUVEPRRIYFWSTSJDECYYFJBJSDLEGQLKLXIYRWVLPPOMDFDTVTKWOKIWWPEJXIBDKNPONPSXRYTOQGJRTJPATMDLHMQEGVJHVLEHSYKRLVVSSMAMBZUSXUSZYYBDRDVZDBEXSGLYOKVMYKIFWGFNCSACJLKATHFMNLCTSQEJFOXYVMTOTTLHRLYPBZISUCLLQGAAITMXPMFINSOWJAAWSNMLUIZVPJBEWQCIPCQWVSQFBEUTDCSDRVIOZOBDYTWSIMSEETQCKLNKXTAWOXIYSVZRAKQEISPNDDXTNFQALSWXSMKSFOOIWXYNAMDJXNSMKIEWKWDPZJPKIBCBBMZBIWPMJCZCEHTCZQJZLKGYVSZPUUVETDFLUUHXPEOPUXMDYLAYSTTENJMCEDCUMOEEICJTXKKVXCXJOWRCVLTTSQHWKBBMIGTQLOVJGVIYZGCQJVPVOTWUCSETIDICYHTCMAJPHXYYOOEOVUXVUPLOKLPBOVQDWDYPBXGAJUQWADGEEDJKGURHSXDVYLMYFJQLWZLDROUYLQOBSGEMWDOIBQVCYEDFVQOPFHKQMHUSXQACOOGJXCOXBFZLWCXFVQAAVFEGKCIRQQGDYHLJMAQZQIFUAOUBUKYPAVEBVDUJGSULAHKPRFPNZQAQGVFDXWTQFLCEILPMSZIZFWBONXPLCYQITTPKPBCFSESGFBIQNIPOLEFRELPHJTHQRZSPHBNUMGRIFMWIZTFUHQIBGAXDVYSYVGXLSPMINYKBYUMEPUBRXUOAVYOVDBIELZDOBGQCJZNJBEXALKGHYWIOXZBVXZFCSHCOZMEFWCRVYIBJDFQVQMHXDPCCJODLGVKPLRFDEDPZOPRFEECHWSZHVCDOOEJLCHCWCEKTFRDMOWHSUEAVBRAWMIHZSNFHRAFBQEAWDIXZNPPFWIEAIVTMPQZQTSVNVWJMGVHUESSSAXGMOYWDGVWIOUZUQDEBIJCQYCFTAFTUWTGXAVEMCIUQMXENPRPMYZREXSHNVTESSTWHYTMATXBUZXPSTPYGFXPHPFCKJDBFBXIMEESWYNDFHOMCNWJTFRUVZWBHLZBVEBYEUCEPGCDPMGHCIBFXGRVNACXWLOPXSVZCLWYMWDMOLJTAGUWUVHXIFDJQSHLQAUEGLQRBXUWPOZFVEGDPVNWMEDXBMXAGIMXMXGJLNNFKWBRQSHXFCANWPOFLQEJAFDKTNLPGVLEXCYGLRZBKHCMXVUOBYXCXZXQMLSWVLMBVCSDTEFCQTMLILWZTBSCFHJTCYTONMLIIVRKBBLVNMHIPRGERYRPJPJYKCHNEYFYMIEFYMAJRNWJSLYTBXMDUWTFZAFKXYFMCNLJSEBZLEYGEGUUJMKYYLFMMVVILJWGCYHRDLDKZFZGTVMOWLBEQTJSODVHBUUMEXPPCDXQHCEQLDFAVGQLVITUZZNGJEOTBKJZCRTGGLUIAMNCORBKIWDOZITQGQIPHVWUIJWHSMGOGXOMLUQURCWOGGHHJJCEKGGLLAMQGXHCFCMRAKGROJGXIZWXASCASINZXCDXEWCULOFITYLHXHZXMJDLISUPDYLSHAHCIPZOPTULLYISXSCZJQAWAGNNGCGGIWKHNARJISVCDPZGGTLLUDVCSJXEUBFGYJDIMTPFTGYTKFNTYLNFLBFUTSYOVXMLIGOAIQZLXWFRSLJUCDXSSAMGCIFDLJASHCJJWHLKQNIPXZJGLPTEDZXMTHVZGRUHHCKUFDECAKRRZOQFQCDUZHJSDASKQGLQLNNBKUUYTQTHFCJRAAWTBCCURPZPUMCSMQHEBHQRFIGAMBLZXYCVEVLUZCUQXVRJGEKYAOFVRVCOHLDAVKJIYKHCCMNJPDHKKIMPSMVCYQXLGWLBHLDKJLZWTHKFNIZEBVLGOZRNWWVXDCKGNCKQTKQIDHOOCIWRPKXESLDTGXTAURGLBGMPYQLPZBNSBZHANBIYPUZIQURWRBRBXMHBRDPDRERBOBAJULDLWRPKRTFBLSPNKXYITIOHLPGJLCKTLAQSALNOIPHBTUYRRGHSEZNKMZUKAIIHATZTTIYLACTADTNINWCSUFBYNJKXAAJNAGFEVSCFUHOAJUQMISGBBSXQBYLMRASZACPLIUGLQYUZBNIZXXJXNNTSCKJZJZJMMYFMVXJAOPVEFHWHBYOAPKQEDYDDTRPBLPORURSKNPBTAMZKKZRRDDCMRAYGLNJUIKQYNJAUCAQEKHCWXDQPDOHYCVAEXJYULGVWTOVQGSFIVKVUNQDEKHNGXJYYCSPVZULHKYWGQJGAQCLPSXNSERDNRJXROZMXTJTVOSSYQPVOTKHMBQAXIQXUXZLZTKSOHUJRTAIMPDESFQJBJIFGYBEBNUIICFJTEQFVSYRWWJZISSAIMGCUSLEIACQXJIPDTILJQRBLDLIRSIEWJPLNAIDVVIXJQTQJDOZLDBBEEMVMVEQLHJZTCOUOSTCGROMEKRINQBGVGLJHVEAONQKRTJJTLGBKRNYOIXIRSLFSZFQIVGKAFLGKCTVBVKSIPWOMQXLYQXHLBCEUHBJBFNHOFCGPGWDSEFFYCTHMLPCQEJGSKWJKBKBBMIFNURNWYHEVSOQZMTVZGFIQAJFRGYUZXNRTXECTCNLYOISBGLPDBJBSLXLPOYMRCXMDTQHCNLVTQDWFTUZGBDXSYSCWBRGUOSTBELNVTAQDMKMIHMOXQTQLXVLSSSISVQVVZOTOYQRYUYQWOKNNQCQGGYSRQPKRCCVYHXSJMHOQOYOCWCRIPLARJOYIQRMMPMUEQBSBLJDDWRUMAUCZFZIODPUDHEEXALBWPIYPMDJLMWTGDRZHPXNEOFHQZJDMURGVMRWDOTUWYKNLRBVUVTNHIOUVQITGYFGFIEONBAAPYHWPCRMEHXCPKIJZFIAYFVOXKPASYIWXMRAHUWLAOOVREJHPBIIQMDPTEFNNGFZTQHHIFMTHLXKQBHISDXBGOTYSPNVUSLDLFCNOGNDBCJXQDUSSOEGPWPRFUSSJQHKHBHPHTJKYWSEBAAVJAUPVDBXFITSYOJEVYCPXWYXFKZDESBNOACIXWTRHQHFIMUKKDINHWYXNJKMOPBHOPLFMPLQJYFIAZKXXDMZBNDUOAXJDAEVIBEQACBDXWRGSFVPLKHFPNLPFLZNDTLUWRIGJJTTHZHPOWRYLZZYVNATBAWWXBYDUUSBDHBGGAWQVLRBMPGKNZVLKEEAVEKLVQUTZZDRQONOWWVWJFXXLTXMXKKPZKYFZSVYVKVNYCVPNPQBRIBPEMMAYFPNIWAZHBJEZMENVESSYPPASIFGSSFWVEUXASVKMPXZVZOOPTVOZCYQPXANFTSVGLUXXMWTERTADXMAMTXRDQNPLOAGMMGETHVBNEXECQIDNZPSZHLHPSOEMJFRDPFAWNFHYQUWIWNUQZTLHKLUBMJMQIMOYUMBUPRIGZZXVKJJOXHYUSUKLAIYMPOPZYVEWMVQMSOISXZUHSQAZGGGNMRUXDKVGPUCMTZOSJLRPDWAEKOXTRAWMHIJIZUQRLNKIEYLAIIYMTDFTXJUUCJIPOZZHGBIZWMNCRCABVMQWAFVMUXYYBVCIURGYAPTMPVLCNYUHAYTABVKSPWISDSDSPXYSOPDEMQDGQAXUOOOMPKYSOKVZZHDPMVNURNAULFUTCUKWGTXNQXMUKBXNLIDVYSEWBWMSNSRFPXXFTMJUEDKSDMNBKLSRNJPWVPQWMXXTFFGTBDBJIFNRVWZTBDJRBAZXOTGFQVYQPGRDOJJGJVQIWLDVJINOEEBSCJCISYVUTVHVMIYCOYSZFEXXAFMKAXSXWKTFCFAILJABWUNYLERKSNHSAQNHOVLTHJVSUMBZQSJHRLLOVOYUBXMXBYUNVAADRVBEJOORBYHWUNRHNIXRHWODLXNGPQURFPIQDFTESWNRNYFNRLLTCTMJVSJXPFQSGPZEQQTREWWSCEICEANFVODTIOKDWTZOQOBOIIOXGOMODFASZWZGUZZYQITDDCINEMYPCBFELHMHYPBTBWMCHQHYGFTVAOFPXWMPMFBCFNCLQEXJGVZPQBXCQOSKJDXWHIMEUWXOPZAFASCSXAWAROBLPMAMKLRWLZNPLGSPUZVNUBPUDIBPTDSLAAGXAAACQRSFVHCLAEDSMLKJAQSOQGFPOVIGXFVHLTPWPTOJSARDOZOGRLTULBERIYWIREEBJDDKDHPYLEYPYLEVVGLKCKUBMYGXZQMEEYEHJEHKNBKPRSVDGJOIZZGJSZEBTAQQGZWYFGDCBKDGXZURJPOAHRHDPQEXZSRPGVDUTABOGKWKUEHFZWHVAMSNTZUVCRQZPLXHYKIAOAPJZKZNMLSNEZSSKDLOSIYFAWAZNBUWENOVCSFKFUHNTGLVESXSRRNZKBHZKHZMVKJEVSRBDICLCKMSGPGNGYCKZVGYSVWCGWAYJOKQACTFXTIVFBDWPRUFIVTGGZHBPVLXFKISDNEOGDSEENJLEWROBJHPPPJCZYXEAIQANAZTKSNPFWYHDJVIPGWZZNMNNXWRAIIEICSCDHRYZVRHTOPRRATXUFCITHOKIOGUDGGZPVJCTBAHNZDWTOKIATSRIQZWEDRRFZBRKGVYNBBFOMOIAWWMMJIQVHDLNSVWNWBKTEHYKEVHACVDFLMNKRLJMIJVFXDVDYDMVKJSBPMCGMNFTSEUMHBDIOHZCJVPAYXQWDPYCHQCTUDLKEDTBJDUQBZWXVOXJLAJSTAOQNRRRPXCNDMWHLWDYGNNORDXMUJNZLKEAMDXANOKVBVPLRWXZIJPJKULODEULUEPKSLYIUZYWPYYFOCICAZYEWQYULJLFMTHLIEOLXUYPKQPEMFJJPSWULKNGYTFFIXVOIYUUSYBDMYGPUGZHUERHLFELEMNNAVEFSUQIKNYEDQTXYEKPWPDPCUUIMOSYTASPBMINXPVBCBQOLOSVBRPPGPYVIXLSXHQDRPHMJPIHERRWHDWOSAPJFTERGJSZLZWCIHWCUEGFCPSAQJNNFFMVVEUPTMNEFBHOHJBCAOCDWJYAYLNVZECIUCLQUQEDNWKYFYMGRFMZXQPEJCIXXPPQGVUAWUTGRMEZJKTEOFJBNRVZZKVJTACFXJJOKISAVSGRSLRYXFQGRMDSQWPTAJBQZVETHULJBDATXGHFZQRW";
            //string b = "FGAKWMOAWLZQJYPMHLLBBUUHBPRIQSNIBYWLGJLXOWYZAGRFNQAFVCQWKTKCJWEJEVZBNXHSFMWOJSHCDYPNVBUHHUZQMGOVMVGWIIZATOXGBLYUDIPAHFBKEWMUNEOQHJMBPDTWNZNBLWVTJRNIWLBYBLHPPNDSPOJROUFFAZPOXTQDFPJUHITVIJROHAVPQATOFXWMKSVJCVHDECXWWMOSQICZJPKFAFQLBOXOSNJGZGDRAEHZDLTTHEMEUSXHIIIMRDRUGABNXWSYGSKTKCSLHJEBFEXUCSYVLWRPTEBKJHEFSVFRMCQQDLANBETRGZWYLIZMRYSTVPGRKHLICFADCOGTNIGDRXASLQUOLBTOMEFRTOCGSYYXMMSOESSJMKVHSKPLOEETLFVCJLILCEMZWTVJILGDVBVAFAEQQOJYPXJDYXDZXBTKCCESYMPAXXHZCAQJDOIXJIIVINPIDPFJHVAVBWPCKQNCJWYGBBDWBQJVDEHKEVSNTANOWLERSAPPRUOKYWNEGNCMJVJXCSALRMIUSZJMKAPBWDVDNJXNXRNLMIRLMEHSAYUHJPAJKUXSYRIRKPMGZCYUPOIGWSDQSUXMAIXWSQGVLRJZFCQRPHSBGRSFNEAIJELHYRUMKQPKQKLSACNHPZNPXZSFGMCOUBKPCWZMKMAXJYPVSWRIGSVQGOGOQCIVAZSINDEHAOZDDWXTTFFSHOVPVPOLDLONLKEGGVXCYQKABPWNRZEJFDOPDHXKOQSPEVRRJEOCHBDFQBVCOYVFFVZAUUFRROHJTXNJZPMKDKJBFQFLIVIGIWZTGBYBUGIFDYHOJTJKOAQIEHKJMATGYHGKJUMWVALSQMCOIIJVWCHNENIKRLIZWKHKTDXTQVXIBCTBNBXFUDIVICNLJLNZPGHKVJCOSVFNRYIPIIYLOTXANMKCLJVYYCMRTSCNDZIVGHXAIGWXSKRKSQJOKVNCECTSFXPGYORKUFSAACIQGNCVXTGHWTPBNFSKRMPZCYMXUGWJDILCORKRZPUEWAHXYLCGNZKSUSRAUPTYMACGTSTKDXWYGKDRGGMQKOMLRWRROQFNZPVWOCUAGGXCVBFLAUQXQBWTFYHPEYFDPYDBFANCNKGTYOMYHDODVBIQNEQFWSVYFRPIJYGJDUHWAGGCWZIDPHKRWYJCQGZPSRLCJUYBMGAORPPYFFUNUONATQSEYSOUBMIAFJBZXUIWSZUOVQEWCOLEJFLIVCKBBWDJGMZVFKXZXFDCXBAYMMNTIELKJNZKODDCPFEPDQHGYRAWGYMAMLJWNBIEAWIUFAEPOCJMCSOYNMIUPLAEKAXEXIYJFHHGXEQPXSVIEVROOOPKWNVXQAZPXLDLYEQWDUIQURNWSMXXARZOAMPOQOXCMQGAMIHMSRJNRLNIJTNZXCDYCZMYFRUWSFKVXVLJUPORLHZEQQZRLYDQLXTGJMXDSTCRABJCOPYBQYBAALILYZHYSADROQIJFHYVGZUFDLRZGECMEQTGKFGIFPYIEHMCGRPOPMOZMAECXFPKWZEUALGFDMDEXMKSIPYMEGERUXGTGANELJAMWVTXFQFCEHNCNHXAYVDRKWPPXISCAYKVMKYJKJJGZIDBATJUJGDCSOQNLXGXXDEYEWHVTNCVPUSJINBRRJCWFXCAFBXPYTBEYPCOSWMPDCBDCMJSFZYOOHDZYUDJOUKIOWFCMHPLICCYHIIGRNJMXYAFNXNFZVNBNSXBKAMPSWFMOOFLQWWDNSAJUZISGRZOZDGNHHUAIBGYCTPYQHCXCHHYGIHQAERMSPSGOMQKYLTMRFGQBDHILOYXFITYHEWGMVCAKCXUNUXOGDVURUMQOGWLJLFHYSYJVVEFPKBYIBZEQFJHZYMHDKDZUEQDHNYVQTUNONRXJNFBRUKWLFITFMOVPQNROHZNPYFCOZUGJYBLUVNIQUKMSWCWSRIWFQNHOTBAYAEQVYPHRKWUTQICJOWQMQNEITNCVUAZZNJOJVLTIJKFXGMUUXQAYPFTSRHSIFDBPPEVHQEDZPWOMZRSDEJWFSUUXEWAUMEYNNLQRKNKOTNCFKNVZSGBKEECUVNQPEFKGBIDLRSKWXIOCWGRAIDGDLEDUTXCLALKBNJNWMGSBOTNPGRVZQRGJKWPKADHCSCCXYCUKRESWGWZYJORWCBOKBMKPFTUCREJBRLPNQHMCCQJNYVEGKVPEATDZWCWABGKZEKKDYFGUBJDFDJNILUMMWXGVHHCFGRZINRODTIDTVLUOBAWQMXEAMUMKSCVLHMIVFUBJCMBLWKOXSKIRGQGNILLTZTIEAIPFRRSHTQLHXXIBAQMQHMBKAIMRKZVGEWNJPEVFQGYWZPPBIEIGZKKMPPLSYWCOFXBLCYJVESUHOVQVUYGOLNPQFPYRWYIUBIWQJDJHVJNTTZFNJIMRYVPYHOFLQTFRRTLDUJWPINXMJMCMWZMDLUUBVWSPACMHCWANDVPQYIQTOZIPDDJLATRPRDNYGMBAYNLFZMBMTRYTSQSXSUEJLGOOQEYUCQVJFSMHXMHXBCBDQSKZNXNNPHSOQJFMAQKLCMCKFGIESZPIRGOTZGVLHINLOGMTFNRQNXOBYLZDDFYFPYTCDEZITDUQHOZQXQXXTXGPZKKBXMKUHDOMJNRFTOJTRFYUPNVUOJDBUYCZOAHWVUUVVZAPUNXUYPBQQXRYAHDFHFRJSXYUKJFMRUWPJAJJCVJBKXPTGQCYXDCVAAJMDHKBAAXQVZIGYBWNIUFUCUCBZTNISVHQSZVKTILNAGLUPTRWDGTCDZJJXCNWESQXFFBXYUQMQVYDZSRUHXEVQYMJURMJNILNRKEEPDSYYSVBAEKSOZXFNZXEWJRVCBOXLJNXJDXGFHTGRDXOHNJTIYNSPKWGTNXSXJRIJYTXLCASQPDLJZLNXVPSBJQEKRUNUEHMHNGYUMGJHBOEOBQNLIFESKIVABBAEPUTXUURWPOWHFUSACEJXOMOSQBOMLEUGDHZLVTZVJKZPFZYCZIVPIOARKAXAWRPXYZOSGLXXLPWNWNLZFJDLDRFFUDMYWWPJTLKXMOIRWVOLEKXPMYHDYJAEQWKNFPAPUEGIRCDOWKUSEYBNBRCWSCMLUGZFKOVXYSYPZEKEEDCEMNKIHRYLIZMAKZWCDHQDXFKRVSQFHCLIUBNUWCJKDGPOYNPPAGPZHMMOVFURADZEMPDWJFVVTGMSALSWWBVJAHWERCTOEZQYYZOSXHIJGKZKSPPPVVLJVEDHURQYXRLHTEZGPHNBPUHGKMRCLIVKHNZTOXSEJNOEPWPAJUQRWZXNOWQXQPJBXZSYBTYAFRQTLECKZUXDLWOUWIJCGHHGNSOWIJQPHEMOJMZAIEORVNBNSWIUUYYTMUTIVRDUPCGUVSGNGMQWWSKXGLDLVDRMMAQHCZCTLDSRYAYGNNDFGJGNUALNZRULIRVGRHHPSOZMSTVDJCSMAACHWIGJSCNAPSUMXPZLLLVJJFOAMEMXUUTILACVKECCFEZYWBFTNBWYJTYBGRJTQCKYTLHDZZUWQKCGESMFUCYQPJLQXSJRJSNFUWBDCDQSAJDIMLRCVTJCXOETTGXXJJBCNWUNUUYERUOTKWXKXCTOVEUNECFRCWVYTIYTUIWSVWQWPIJISKVOQGYEYORJHDSKBCATYUPYQPBXPVTLTUDZMIVFLMFCERJOPFQFWTJCYAZCGRMFDLVLBAXDNNBXTAOSQRGJERNPPFRMAXZJQCPQMQHMSIRUQEUXXVEVDTKBGHFVPNIPVGLDDRRZQWOHCPYAKJCXKBOPXMXJKIAWLYIBCDHBXEUNRSVHWSVEYYWAWNFPJKPBCPSSADRKYQVSJRQBYEBEBCBAAEJCJNOYVYRCJUNQYAGAZPGLNZYRZWMOUNBIIVRLFALQDKMIVHIXJQODZCMCGUQQYXTNOUARYQCMAEIDIQVRDUELOHDQBAGTNMIWEUGTLGUGDBGXRIKEWSVURSYBMOTAOOCREFBNBLEVNTPELPJKUOYHWQJJRIVBQWZVUZWOUBMQBOMBBGQBFXHWHIYBFKVURXXGKONDDFORJOJTUTTNSDRLICJRQSSAAPOWJZUIFXQMSVXQJNNOXIJPWCMHGCBIGWDADEARLEAYZOCHOCEGGMOPMXQSZWGEVPGJISNXEPRDYQQDFFIOAGLKBVXVMQOBEAXNFVERARXQLPTSVRNETGHETGLSKMDXUVOOCGPXLDYKTWUJXBBUVLNFBDCFCXDVGXVBVLXCQKCODATAEUHVSKLCGCWHSJWWGAZCZVZNYZRVHXETFZZAWPKYIGZATNXIAVEVWFJUONOQDSKGSNDFXRPDSNGZOFADTEIZSBIBRRVUBFANKRBKPXNJXQPIJMKSNJRTYFLTREYENPGSAITRJDLEYPOTIMVWOXNVOJZXBBNTNUMOMGZLIJHAFVZRODTNWETXETDNXQQRNNNGQITRTFQTUVMHUDFEUQPWCTKVQAUTEAZSJUCFGPLKPGEZVDHWVUZKBHBIDBTNSHGWPFSLNWJGPBPTAQYLIBHZFYWZUSZPACXUKBZWOPDRKTPYWOIRJWFEKXONWBYKSTQUKZAJLUJJULEQORUFTAFGNKISKXKTSASSJRRWPOCEGOWQKSBSZLSVSYGALCPESNTLDJGRAKLQZNGIQYNIFOWBGCTQVAZPKUULWUZYIMDLSGKONXBYYTNTZKXFTIJJRWCRSEKWATROTURZPNOSLDLWPBOGGNJCWTFOPDHQGLLWXRYDXERNSFECYJIXGWVETICATGAIJQIZLKGVHLHWSGLHEGZIYUOEQDOKCGBQFVBRNHHSBEPDYKKYYGEUTUIFLJAZBCNXISFCODIQOJDENGXJQFLODZVNEENRGLAVZYNYHSXRGDIQPNUSNCPYDZJQKTYELPGMSBKLVMNLPGXCIENKRBJUWCMLLBKPRLUFJLJOKYNPPXBKYISXMMANLXUYEIDFZVEFWWCDKRPIIUTRWMINFZXGETXTTSIGFKGOFEKPIUWYZFLPKLBIMTOFJPXQKDQYAOIWLWMJAKZVHICDMYHCXGERYPPFGVHEPIMGRQOLQYIBJPHSJKMDKAQBKYWTBQEHRMYBEVNQUTDLYQPOGEMUUDZXBHJLBGVDNZUNUBUEPBCSJBPCYDEHBRGJPPIQEBGXHDTQXWIZICHYTSCEWAOUDJZEVUODGDGQFDZVRBOXOPVFDBOYSKOLRVDFOIRKQPIWOWGYPYBCHBMWTBEAOLSRXQCOXWNTBYIMAJFPAUYMWJWIBOTKZIUTTJQCNHUDHYLQBXRBXKVMUDTHUTQQENFNCSHTAQSWMQUCJVUZCETVNQQJSSEBSLRICSVMWQAKEZGIRYRHLXPEUGVSBIPCSMYMHULYKRIYHDMASFCJUIGRWJCHMJSLMPYNEWNZPPHMUDZCBXZDEXJUHKTDTCOIBZVEVSMWAXAKRTDFOIVKVOOOYPYEMIIDADQUQEPXWQKESDNAKXKBZRCJKGVWWXTQXVFPXCWITLJYEHLDGSJYTMEKIMKKNDJVNZQTJYKIYMKMDZPWAKXDTKZCQCATLEVPPGFHYYKGMIPUODJRNFJZHCMJDBZVHYWPRBWDCFXIFFPZBJBMBYIJKQNOSSLQBFVVICXVOEUZRURAETGLTHGOURZHFPNUBZVBLFZMMBGEPJJYSHCHTHULXARZHIZEIOEPWBIZHZKBDLUYTBVWVQIPIZQCWCAJKUFNQHMCRMMXZBLJPLVPXJGEXDFZLLNNBUGBMCTHSPXENWOVYWDFCHIDWCSTLBOCFZZYOCNMGAAUJTRLQSNIFLVEHWYIPPBXHVUIFUJIFKWLTVJBKGQPOOPTXEMXKRXOIHBOKYPCIZINRXTBRAXNMHKCSSHGUUATPPFHDHNWPZUKJYBKKVRMMPUEEHKJYRCRKPKHTBFQPYVRCFQALHOIKWFSQFSTYFPRAAHXHJXVSSCNGGGKGNHWHEPGUYAVZCFDKQBCMGROIDXRZYYNHWCDIUSRIQSAOWCZWUUYELCXEPXLWDCKNMDXAUTBDNRAHITQISZNXNISYOORKEPOPRZKLKGKHESPPLQSSAIMTLLTGAFHVLCCIZTDIDXPWHDGHOSCIGPPTAURARUEIHXOOOTZELVQBHVOQIOZHSTFXPWBFMGLKICKRGWOLHOAKATSSJLITQZJFHDFZLMDADKYPRFJSITGVQAIOFZWNKPRYCKXSJOZUINKHUFNWHJCYANIRDGWLFWUJGZCFGRLNKVYFOPQZTSUQSHDTKDGBRRKXWQPGLIPCAASJHKLYPYUURVGZBFAGBNQJWKSDMGDPFKDGQYGSEMVFITDEILCYDJNHUPZVEASVKJXGAMXNTQFZNQKMSOAREINWJEIKYORROZGFZHOYHMKUPVGURWSLCQSZRMOAORLUILDOYUBSXOYQZHCBRGIFOQRGXBYCQOOQDZMLTUWIQGFULDUPXAVNNJTRELAQIKMVGRPYSHCSTAHTZDBRVCHPTOADVZUAIKCSZEGAROQJNJHMJCUMBXGSZKTQFRUOSTVEVHHHECIOMZZKFFNHMLKYETBKVNVDOIMAKKOLLYUNRCNQUDGAZMEJGOAHKJAFILHXVQYSSVATIGCJZXIBTIRITDILDTFGGBYZOBBMXTWDAJAWQDYWNPPFLKKMTXZJVXOPQVLIWDWHZEPCUIWELHBUOTLKVESEXNWKYTONFRPQCXZZQZDVSMBSJCXXEUGAVEKOZFJLOLRTQGWZQXSFGRNVRGFRQPIXHSSKBPZGHNDESVWPTPVVKASFALZSETOPERVPWZMKGPCEXQNVTNOULPRWNOWMSORSCECVVVRJFWUMCJQYROUNQSGDRUXTTVTMRKIVTXAUHOSOKDIAHSYRFTZSGVGYVEQWKZHQSTBGYWRVMSGFCFYUXPPHVMYYDZPOHGDICOXBTJNSBYHOIDNKRIALOWVLVMJPXCFEYGQZPHMBCJKUPOJSMMUQLYDIXBALUWEZVNFASJFXILBYLLWYIPSMOVDZOSUWOTCXERZCFUVXPRTZISESHJFCOSALYQGLPOTXVXAANPOCYPSIYAZSEJJOXIMNBVQUCFTUVDKSAXUTVJEUNODBIPSUMLAYMJNZLJUREFJGUTAQNROMYMIKEFRFROXCSXRKXPICTXGVLERNYTEFLNCIJHMLISLUNMAOSOMKSNMTTOFLZQLXDDZBFFTUMVXLTYDLONVAOCDEZWTPJOZMOWKQWCVFTEJHXUTNHJRGWSNBYTSGTIGOMKNGTMNAYTTZNCQDEWYZXWSOIESHPDAWCRZHBLLHLXLIXGIHZTEYFAXZICQWHABLKKHCLXHFOQBPCXWXPBVPAWLNFNATOFEKRBXSFGEJTCDQKZEUJUNFCUWEVYAJBJARUPRXSYKONESFURJQFGBXHTYMDQQICWECDLCSREWZIYNZUWNDNATNSWIGTQWMPLHTCQLCXSUNZWYACZGWVUEMAZDGDRCFPXNLVDZVAUUZVTXAHLRXDBZZGORUGJVMXEUGMYCUBKTUMWGRRWQILYUBVJIBGHOGAZNUBGQSEYSWUNVEWTCRHNIKGEGLIYJICZSEKYMTQZTHXQCEHSEZBHKUFQGMGROGEWPMRXLQWNINOGKYZXNIRLEGLHRKAFLJAKMKUYDGLAMGUXUCRWSYCUUOIVHYWYICDQUZGHGCYSDXMFADGFYWRJJSQMYCSDXPRNURIZKJVVRHPMCMODFSEJOEETZKKJFTDDMYSVXJXCTTLZSRQKRCUHLIUMYXZXMPKVFHTGTUIRIPAQWZKCEBKTAEUIJBTANRFTVKPNRNXCMFUMOTRNENQIWSVGJOBTBKHKATMITBNXTNSKLVILZIXLGMUFFLRQGFTANEXECPTWYGAHZICXTTRJWIYKLIRGHYQMLWYJDAVEXJHVZHRLPKWFHSQZPRGIRCVVSHSDMQYCWHJZANIHPDSVMWVJQTSLQELNWXTOQFVIVIRNIAKTVZBMVEWGHUACGVBGSHVKWGVRKEDNGMADOCZXKUPWSSPBCHWLGFMUEYTURFHBHZDUAYMBAWLRFJDFHMMOCROUSWMPYXFPXWWYXYKJUVOCTGKZZIIUNYTVXHKJRFDSQNTSJUDLMXJLKWIAQEOJUEFCCNPJYIXMZSMHQQJOTEODIATBBSRVBBVLTH";

            //string result = morganAndString(a, b);

            // var ans = "FGAKMWMOAWLZBMWEYYDIADTLCOUEGMDBYFWURPWBPUVHIFNUAPWYNDMHTQVKGKBHTYTSZOTWFLEGSJZQJYPMHLLBBUUHBPRIQSNIBYWLGJLXOWYZAGRFNQAFVCQWKTKCJWEJEVZBNXHSFMWOJSHCDYPNVBUHHUZQMGOVMVGWIIZATOXGBLYUDIPAHFBKEWMUNEOQHJMBPDTWNZNBLWVTJRNIWLBYBLHPPNDSPOJROUFFAZPOXTQDFPJUHITVIJROHAVPQATOFXWMKSVJCVHDECXWWMOSQICZJPKFAFQLBOXOSNJGZGDRAEHZDLTTHEMEUSXHIIIMRDRUGABNXWSYGSKTKCSLHJEBFEXUCSYVLWRPTEBKJHEFSVFRMCQQDLANBETRGZWYLIZMRYSTVPGRKHLICFADCOGTNIGDRXASLQUOLBTOMEFRTOCGSYYXMMSOESSJMKVHSKPLOEETLFVCJLILCEMZWTVJILGDVBVAFAEQQOJYPXJDYXDZXBTKCCESYMPAXXHZCAQJDOIXJIIVINPIDPFJHVAVBWPCKQNCJWYGBBDWBQJVDEHKEVSNTANOWLERSAPPRUOKYWNEGNCMJVJXCSALRMIUSZJMKAPBWDVDNJXNXRNLMIRLMEHSAYUHJPAJKUXSYRIRKPMGZCYUPOIGWSDQSUXMAIXWSQGVLRJZFCQRPHSBGRSFNEAIJELHYRUMKQPKQKLSACNHPZNPXZSFGMCOUBKPCWZMKMAXJYPVSWRIGSVQGOGOQCIVAZSINDEHAOZDDWXTTFFSHOVPVPOLDLONLKEGGVXCYQKABPWNRZEJFDOPDHXKOQSPEVRRJEOCHBDFQBVCOYVFFVZAUUFRROHJTXNJZPMKDKJBFQFLIVIGIWZTGBYBUGIFDYHOJTJKOAQIEHKJMATGYHGKJUMWVALSQMCOIIJVWCHNENIKRLIZWKHKTDXTQVXIBCTBNBXFUDIVICNLJLNZPGHKVJCOSVFNRYIPIIYLOTXANMKCLJVYYCMRTSCNDZIVGHXAIGWXSKRKSQJOKVNCECTSFXPGYORKUFSAACIQGNCVXTGHWTPBNFSKRMPZCYMXUGWJDILCORKRZPUEWAHXYLCGNZKSUSRAUPTYMACGTSTKDXWYGKDRGGMQKOMLRWRROQFNZPVWOCUAGGXCVBFLAUQXQBWTFYHPEYFDPYDBFANCNKGTYOMYHDODVBIQNEQFWSVYFRPIJYGJDUHWAGGCWZIDPHKRWYJCQGZPSRLCJUYBMGAORPPYFFUNUONATQSEYSOUBMIAFJBZXUIWSZUOVQEWCOLEJFLIVCKBBWDJGMZVFKXZXFDCXBAYMMNTIELKJNZKODDCPFEPDQHGYRAWGYMAMLJWNBIEAWIUFAEPOCJMCSOYNMIUPLAEKAXEXIYJFHHGXEQPXSVIEVROOOPKWNVXQAZPXLDLYEQWDUIQURNWSMXXARZOAMPOQOXCMQGAMIHMSRJNRLNIJTNZXCDYCZMYFRUWSFKVXVLJUPORLHZEQQZRLYDQLXTGJMXDSTCRABJCOPYBQYBAALILYZHYSADROQIJFHYVGZUFDLRZGECMEQTGKFGIFPYIEHMCGRPOPMOZMAECXFPKWZEUALGFDMDEXMKSIPYMEGERUXGTGANELJAMWVTXFQFCEHNCNHXAYVDRKWPPXISCAYKVMKYJKJJGZIDBATJUJGDCSOQNLXGXXDEYEWHVTNCVPUSJINBRRJCWFXCAFBXPYTBEYPCOSWMPDCBDCMJSFZYOOHDZYUDJOUKIOWFCMHPLICCYHIIGRNJMXYAFNXNFZVNBNSXBKAMPSWFMOOFLQWWDNSAJUZISGRZOZDGNHHUAIBGYCTPYQHCXCHHYGIHQAERMSPSGOMQKYLTMRFGQBDHILOYXFITYHEWGMVCAKCXUNUXOGDVURUMQOGWLJLFHYSYJVVEFPKBYIBZEQFJHZYMHDKDZUEQDHNYVQTUNONRXJNFBRUKWLFITFMOVPQNROHZNPYFCOZUGJYBLUVNIQUKMSWCWSRIWFQNHOTBAYAEQVYPHRKWUTQICJOWQMQNEITNCVUAZZNJOJVLTIJKFXGMUUXQAYPFTSRHSIFDBPPEVHQEDZPWOMZRSDEJWFSUUXEWAUMEYNNLQRKNKOTNCFKNVZSGBKEECUVNQPEFKGBIDLRSKWXIOCWGRAIDGDLEDUTXCLALKBNJNWMGSBOTNPGRVZQRGJKWPKADHCSCCXYCUKRESWGWZYJORWCBOKBMKPFTUCREJBRLPNQHMCCQJNYVEGKVPEATDZWCWABGKZEKKDYFGUBJDFDJNILUMMWXGVHHCFGRZINRODTIDTVLUOBAWQMXEAMUMKSCVLHMIVFUBJCMBLWKOXSKIRGQGNILLTZTIEAIPFRRSHTQLHXXIBAQMQHMBKAIMRKZVGEWNJPEVFQGYWZPPBIEIGZKKMPPLSYWCOFXBLCYJVESUHOVQVUYGOLNPQFPYRWYIUBIWQJDJHVJNTTZFNJIMRYVPYHOFLQTFRRTLDUJWPINXMJMCMWZMDLUUBVWSPACMHCWANDVPQYIQTOZIPDDJLATRPRDNYGMBAYNLFZMBMTRYTSQSXSUEJLGOOQEYUCQVJFSMHXMHXBCBDQSKZNXNNPHSOQJFMAQKLCMCKFGIESZPIRGOTZGVLHINLOGMTFNRQNXOBYLZDDFYFPYTCDEZITDUQHOZQXQXXTXGPZKKBXMKUHDOMJNRFTOJTRFYUPNVUOJDBUYCZOAHWVUUVVZAPUNXUYPBQQXRYAHDFHFRJSXYUKJFMRUWPJAJJCVJBKXPTGQCYXDCVAAJMDHKBAAXQVZIGYBWNIUFUCUCBZTNISVHQSZVKTILNAGLUPTRWDGTCDZJJXCNWESQXFFBXYUQMQVYDZSRUHXEVQYMJURMJNILNRKEEPDSYYSVBAEKSOZXFNZXEWJRVCBOXLJNXJDXGFHTGRDXOHNJTIYNSPKWGTNXSXJRIJYTXLCASQPDLJZLNXVPSBJQEKRUNUEHMHNGYUMGJHBOEOBQNLIFESKIVABBAEPUTXUURWPOWHFUSACEJXOMOSQBOMLEUGDHZLVTZVJKZPFZYCZIVPIOARKAXAWRPXYZOSGLXXLPWNWNLZFJDLDRFFUDMYWWPJTLKXMOIRWVOLEKXPMYHDYJAEQWKNFPAPUEGIRCDOWKUSEYBNBRCWSCMLUGZFKOVXYSYPZEKEEDCEMNKIHRYLIZMAKZWCDHQDXFKRVSQFHCLIUBNUWCJKDGPOYNPPAGPZHMMOVFURADZEMPDWJFVVTGMSALSWWBVJAHWERCTOEZQYYZOSXHIJGKZKSPPPVVLJVEDHURQYXRLHTEZGPHNBPUHGKMRCLIVKHNZTOXSEJNOEPWPAJUQRWZXNOWQXQPJBXZSYBTYAFRQTLECKZUXDLWOUWIJCGHHGNSOWIJQPHEMOJMZAIEORVNBNSWIUUYYTMUTIVRDUPCGUVSGNGMQWWSKXGLDLVDRMMAQHCZCTLDSRYAYGNNDFGJGNUALNZRULIRVGRHHPSOZMSTVDJCSMAACHWIGJSCNAPSUMXPZLLLVJJFOAMEMXUUTILACVKECCFEZYWBFTNBWYJTYBGRJTQCKYTLHDZZSZFWTZFPNSCGUEMWRCZQXYCIVDQNKYPNXNNPMUDUHZNOAQUUDHAVRNCWFWUJPCMIGGJMCMKKBNJFEODXKGJGWXTRXINGIQQUHUWQHDSWXXRXUZZFHKPLWUNFAGPPCOILDAGKTGDARVEUSJUQFISTULGBGLWMFGZRNYXRYETWZHLNFEWCZMNOOZLQATUGMDJWGZCFABBKOXYJXKATJMPPRSWKDKOBDAGWDWXSUFEESRVNCBSZCEPIGPBZUZOOOTORZFSKCWBQORVWDRMKLFDCZATFARQDKELALXZXILLKFDVPFPXABQLNGDSCRENTZAMZTVVCVRTCMBQLIZIJDWTUYFRXOLSYSXLFEBPOLCMQSPPMRFKYUNYDTMWBEXSNGXHWVROANDFQJAMZKPTTSLILDLRKJOYRPXUGICEAHGIAKEVSJOADMKFNKSWRAWKJXWCMCCIABZBRSKZAZJQTLKIQYDPTPKCSDGCQJSHZNDPVANNRYWFRNRGHLJJQRXPXNLKCWDPDKSWVTXGANWWYOOSXTNEXEEZJXOUYFJHNWPQFXEXZXFOLPCFBLPNCETYHTRWXKBOSCCSKXBUVCROSAVNPXZOEOYYGHBBQKFLSUTPWMHQWKVIRMLFCPIDLQYIKZMNTTAIFCBOPNWEZESOMKXHAIAFMVKBJAISYRBTULTPNXBCJMORNQUMATSERHIEQGGRIVOUWFNBNGHDFALLCPRVNGIKCAMVPRZAEAPQMILWKBKGOGOCNIAAISORFQXZJZTVCGVZLCEDWNEZBWXMPOBMRVXASKWVVWQUUDRNWHMMZHEQXIWHFUXAVLWFTGYXXHPYGSPVWDNVMGNWNPKDRNZNZVRKMJJMWISYRDKODOAFWSJFUVMEEWPDWPIYMWBHOXEBJIBXPHIEFGTSAWCDIVTLTRSHJQNKKMDTJGSCNOZMOJNHIGIPPJEMZZUWQKCGESMFUCYQPJLQXSJRJSNFUWBDCDQSAJDIMLRCVTJCXOETTGXXJJBCNWUNUUYERUOTKWXKXCTOVEUNECFRCWVYTIYTUIWSVWQWPIJISKVOQGYEYORJHDSKBCATYUPYQPBXPVTLTUDZMIVFLMFCERJOPFQFWTJCYAZCGRMFDLVLBAXDNNBXTAOSQRGJERNPPFRMAXZJQCPQMQHMSIRUQEUXXVEVDTKBGHFVPNIPVGLDDRRZQWOHCPYAKJCXKBOPXMXJKIAWLYIBCDHBXEUNRSVHWSVEYYWAWNFPJKPBCPSSADRKYQVSJRQBYEBEBCBAAEJCJNOYVYRCJUNQYAGAZPGLNZYRZWMOUNBIIVRLFALQDKMIVHIXJQODZCMCGUQQYXTNOUARYQCMAEIDIQVRDUELOHDQBAGTNMIWEUGTLGUGDBGXRIKEWSVURSYBMOTAOOCREFBNBLEVNTPELPJKUOYHWQJJRIVBQWZVUZWOUBMQBOMBBGQBFXHWHIYBFKVURXXGKONDDFORJOJTUTTNSDRLICJRQSSAAPOWJZUIFXQMSVXQJNNOXIJPWCMHGCBIGWDADEARLEAYZOCHOCEGGMOPMXQSZWGEVPGJISNXEPRDYQQDFFIOAGLKBVXVMQOBEAXNFVERARXQLPTSVRNETGHETGLSKMDXUVOOCGPXLDYKTWUJXBBUVLNFBDCFCXDVGXVBVLXCQKCODATAEUHVSKLCGCWHSJWWGAZCZVZNYZRVHXETFZZAWPKYIGZATNXIAVEVWFJUONOQDSKGSNDFXRPDSNGZOFADTEIZSBIBRRVUBFANKRBKPXNJXQPIJMKSNJRTYFLTREYENPGSAITRJDLEYPOTIMVWOXNVOJZXBBNTNUMOMGZLIJHAFVZRODTNWETXETDNXQQRNNNGQITRTFQTUVMHUDFEUQPWCTKVQAUTEAZSJUCFGPLKPGEZVDHWVUZKBHBIDBTNSHGWPFSLNWJGPBPTAQYLIBHZFYWZUSZPACXUKBZWOPDRKTPYWOIRJWFEKXONWBYKSTQUKZAJLUJJULEQORUFTAFGNKISKXKTSASSJRRWPOCEGOWQKSBSZLSVSYGALCPESNTLDJGRAKLQZNGIQYNIFOWBGCTQVAZPKUULWUZYIMDLSGKONXBYYTNTZKXFTIJJRWCRSEKWATROTURZPNOSLDLWPBOGGNJCWTFOPDHQGLLWXRYDXERNSFECYJIXGWVETICATGAIJQIZLKGVHLHWSGLHEGZIYUOEQDOKCGBQFVBRNHHSBEPDYKKYYGEUTUIFLJAZBCNXISFCODIQOJDENGXJQFLODZVNEENRGLAVZYNYHSXRGDIQPNUSNCPYDZJQKTYELPGMSBKLVMNLPGXCIENKRBJUWCMLLBKPRLUFJLJOKYNPPXBKYISXMMANLXUYEIDFZVEFWWCDKRPIIUTRWMINFZXGETXTTSIGFKGOFEKPIUWYZFLPKLBIMTOFJPXQKDQYAOIWLWMJAKZVHICDMYHCXGERYPPFGVHEPIMGRQOLQYIBJPHSJKMDKAQBKYWTBQEHRMYBEVNQUTDLYQPOGEMUUDZXBHJLBGVDNZUNUBUEPBCSJBPCYDEHBRGJPPIQEBGXHDTQXWIZICHYTSCEWAOUDJZEVUODGDGQFDZVRBOXOPVFDBOYSKOLRVDFOIRKQPIWOWGYPYBCHBMWTBEAOLSRXQCOXWNTBYIMAJFPAUYMWJWIBOTKZIUTTJQCNHUDHYLQBXRBXKVMUDTHUTQQENFNCSHTAQSWMQUCJVUZCETVNQQJSSEBSLRICSVMWQAKEZGIRYRHLXPEUGVSBIPCSMYMHULYKRIYHDMASFCJUIGRWJCHMJSLMPYNEWNZPPHMUDZCBXZDEXJUHKTDTCOIBZVEVSMWAXAKRTDFOIVKVOOOYPYEMIIDADQUQEPXWQKESDNAKXKBZRCJKGVWWXTQXVFPXCWITLJYEHLDGSJYTMEKIMKKNDJVNZQTJYKIYMKMDZPWAKXDTKZCQCATLEVPPGFHYYKGMIPUODJRNFJZHCMJDBZVHYWPRBWDCFXIFFPZBJBMBYIJKQNOSSLQBFVVICXVOEUZRURAETGLTHGOURZHFPNUBZVBLFZMMBGEPJJYSHCHTHULXARZHIZEIOEPWBIZHZKBDLUYTBVWVQIPIZQCWCAJKUFNQHMCRMMXZBLJPLVPXJGEXDFZLLNNBUGBMCTHSPXENWOVYWDFCHIDWCSTLBOCFZZYOCNMGAAUJTRLQSNIFLVEHWYIPPBXHVUIFUJIFKWLTVJBKGQPOOPTXEMXKRXOIHBOKYPCIZINRXTBRAXNMHKCSSHGUUATPPFHDHNWPZUKJYBKKVRMMPUEEHKJYRCRKPKHTBFQPYVRCFQALHOIKWFSQFSTYFPRAAHXHJXVSSCNGGGKGNHWHEPGUYAVZCFDKQBCMGROIDXRZYYNHWCDIUSRIQSAOWCZWUUYELCXEPXLWDCKNMDXAUTBDNRAHITQISZNXNISYOORKEPOPRZKLKGKHESPPLQSSAIMTLLTGAFHVLCCIZTDIDXPWHDGHOSCIGPPTAURARUEIHXOOOTZELVQBHVOQIOZHSTFXPWBFMGLKICKRGWOLHOAKATSSJLITQZJFHDFZLMDADKYPRFJSITGVQAIOFZWNKPRYCKXSJOZUINKHUFNWHJCYANIRDGWLFWUJGZCFGRLNKVYFOPQZTSUQSHDTKDGBRRKXWQPGLIPCAASJHKLYPYUURVGZBFAGBNQJWKSDMGDPFKDGQYGSEMVFITDEILCYDJNHUPZVEASVKJXGAMXNTQFZNQKMSOAREINWJEIKYORROZGFZHOYHMKUPVGURWSLCQSZRMOAORLUILDOYUBSXOYQZHCBRGIFOQRGXBYCQOOQDZMLTUWIQGFULDUPXAVNNJTRELAQIKMVGRPYSHCSTAHTZDBRVCHPTOADVZUAIKCSZEGAROQJNJHMJCUMBXGSZKTQFRUOSTVEVHHHECIOMZZKFFNHMLKYETBKVNVDOIMAKKOLLYUNRCNQUDGAZMEJGOAHKJAFILHXVQYSSVATIGCJZXIBTIRITDILDTFGGBYZOBBMXTWDAJAWQDYWNPPFLKKMTXZJVXOPQVLIWDWHZEPCUIWELHBUOTLKVESEXNWKYTONFRPQCXZZQZDVSMBSJCXXEUGAVEKOZFJLOLRTQGWZQXSFGRNVRGFRQPIXHSSKBPZGHNDESVWPTPVVKASFALZSETOPERVPWZMKGPCEXQNVTNOULPRWNOWMSORSCECVVVRJFWUMCJQYROUNQSGDRUXTTVTMRKIVTXAUHOSOKDIAHSYRFTZSGVGYVEQWKZHQSTBGYWRVMSGFCFYUXPPHVMYYDZPOHGDICOXBTJNSBYHOIDNKRIALOWVLVMJPXCFEYGQZPHMBCJKUPOJSMMUQLYDIXBALUWEZVNFASJFXILBYLLWYIPSMOVDZOSUWOTCXERZCFUVXPRTZISESHJFCOSALYQGLPOTXVXAANPOCYPSIYAZSEJJOXIMNBVQUCFTUVDKSAXUTVJEUNODBIPSUMLAYMJNZLJUREFJGUTAQNROMYMIKEFRFROXCSXRKXPICTXGVLERNYTEFLNCIJHMLISLUNMAOSOMKSNMTTOFLZQLXDDZBFFTUMVXLTYDLONVAOCDEZWTPJOZMOWKQWCVFTEJHXUTNHJRGWSNBYTSGTIGOMKNGTMNAYTTZNCQDEWYZXWSOIESHPDAWCRZHBLLHLXLIXGIHZTEYFAXZICQWHABLKKHCLXHFOQBPCXWXPBVPAWLNFNATOFEKRBXSFGEJTCDQKZEUJUNFCUWEVYAJBJARUPRXSYKONESFURJQFGBXHTYMDQQICWECDLCSREWZIYNZUWNDNATNSWIGTQWMPLHTCQLCXSUNZWYACZGWVUEMAZDGDRCFPXNLVDZVAUUZVTXAHLRXDBZZGORUGJVMXEUGMYCUBKTUMWGRRWQILYUBVJIBGHOGAZNUBGQSEYSWUNVEWTCRHNIKGEGLIYJICZSEKYMTQZTHXQCEHSEZBHKUFQGMGROGEWPMRXLQWNINOGKYZXNIRLEGLHRKAFLJAKMKUYDGLAMGUXUCRWSYCUUOIVHYWYICDQUZGHGCYSDXMFADGFYWRJJSQMYCSDXPRNURIZKJVVRHPMCMODFSEJOEETZKKJFTDDMYSVXJXCTTLZSRQKRCUHLIUMYXZXMPKVFHTGTUIRIPAQWZKCEBKTAEUIJBTANRFTVKPNRNXCMFUMOTRNENQIWSVGJOBTBKHKATMITBNXTNSKLVILZIXLGMUFFLRQGFTANEXECPTWYGAHZICXTTRJWIYKLIRGHYQMLWYJDAVEXJHVZHRLPKWFHSQZPRGIRCVVSHSDMQYCWHJZANIHPDSVMWVJQTSLQELNWXTOQFVIVIRNIAKTVZBMVEWGHUACGVBGSHVKWGVRKEDNGMADOCZXKUPWSSPBCHWLGFMUEYTURFHBHZDUAYMBAWLRFJDFHMMOCROUSWMPYXFPXWWYXYKJUVOCTGKZZIIUNYTVXHKJRFDSQNTSJUDLMXJLKWIAQEOJUEFCCNPJYIXMZSMHQQJOTEODIATBBSRVBBVLTHZZZBCVOYPLXENFFMFDZDIOJUODGBULVIVHTBHAYEEEBIACTYAOVQBIVUDYDGXWSGMHLRACAAYIPSOJLEQHPYGSHCVXWWLNEBLFMNQGDDQPCJXZFTWRLGPTRKBKRLWGSNLCAUDZDUJBBQLFZIKGXOHVHTUVCJMMWVHKXCGYEKJKKLCJQONEPPYDPSPIWQBKPSUNEDQIXLSIFCOKFRCVRSZCVDYFWUHTZPTBBNXBHQJOMXRBHJQXVDASERFFCVKECQYLQPRAWYQUEVHVUZCVFMBEWPXICSKPMZSBSUSMADDQKWGFIRLZZBCZEGHMUHXNXEJRSPCVQEJWOWQSFHOVHCTWNHUUVEPRRIYFWSTSJDECYYFJBJSDLEGQLKLXIYRWVLPPOMDFDTVTKWOKIWWPEJXIBDKNPONPSXRYTOQGJRTJPATMDLHMQEGVJHVLEHSYKRLVVSSMAMBZUSXUSZYYBDRDVZDBEXSGLYOKVMYKIFWGFNCSACJLKATHFMNLCTSQEJFOXYVMTOTTLHRLYPBZISUCLLQGAAITMXPMFINSOWJAAWSNMLUIZVPJBEWQCIPCQWVSQFBEUTDCSDRVIOZOBDYTWSIMSEETQCKLNKXTAWOXIYSVZRAKQEISPNDDXTNFQALSWXSMKSFOOIWXYNAMDJXNSMKIEWKWDPZJPKIBCBBMZBIWPMJCZCEHTCZQJZLKGYVSZPUUVETDFLUUHXPEOPUXMDYLAYSTTENJMCEDCUMOEEICJTXKKVXCXJOWRCVLTTSQHWKBBMIGTQLOVJGVIYZGCQJVPVOTWUCSETIDICYHTCMAJPHXYYOOEOVUXVUPLOKLPBOVQDWDYPBXGAJUQWADGEEDJKGURHSXDVYLMYFJQLWZLDROUYLQOBSGEMWDOIBQVCYEDFVQOPFHKQMHUSXQACOOGJXCOXBFZLWCXFVQAAVFEGKCIRQQGDYHLJMAQZQIFUAOUBUKYPAVEBVDUJGSULAHKPRFPNZQAQGVFDXWTQFLCEILPMSZIZFWBONXPLCYQITTPKPBCFSESGFBIQNIPOLEFRELPHJTHQRZSPHBNUMGRIFMWIZTFUHQIBGAXDVYSYVGXLSPMINYKBYUMEPUBRXUOAVYOVDBIELZDOBGQCJZNJBEXALKGHYWIOXZBVXZFCSHCOZMEFWCRVYIBJDFQVQMHXDPCCJODLGVKPLRFDEDPZOPRFEECHWSZHVCDOOEJLCHCWCEKTFRDMOWHSUEAVBRAWMIHZSNFHRAFBQEAWDIXZNPPFWIEAIVTMPQZQTSVNVWJMGVHUESSSAXGMOYWDGVWIOUZUQDEBIJCQYCFTAFTUWTGXAVEMCIUQMXENPRPMYZREXSHNVTESSTWHYTMATXBUZXPSTPYGFXPHPFCKJDBFBXIMEESWYNDFHOMCNWJTFRUVZWBHLZBVEBYEUCEPGCDPMGHCIBFXGRVNACXWLOPXSVZCLWYMWDMOLJTAGUWUVHXIFDJQSHLQAUEGLQRBXUWPOZFVEGDPVNWMEDXBMXAGIMXMXGJLNNFKWBRQSHXFCANWPOFLQEJAFDKTNLPGVLEXCYGLRZBKHCMXVUOBYXCXZXQMLSWVLMBVCSDTEFCQTMLILWZTBSCFHJTCYTONMLIIVRKBBLVNMHIPRGERYRPJPJYKCHNEYFYMIEFYMAJRNWJSLYTBXMDUWTFZAFKXYFMCNLJSEBZLEYGEGUUJMKYYLFMMVVILJWGCYHRDLDKZFZGTVMOWLBEQTJSODVHBUUMEXPPCDXQHCEQLDFAVGQLVITUZZNGJEOTBKJZCRTGGLUIAMNCORBKIWDOZITQGQIPHVWUIJWHSMGOGXOMLUQURCWOGGHHJJCEKGGLLAMQGXHCFCMRAKGROJGXIZWXASCASINZXCDXEWCULOFITYLHXHZXMJDLISUPDYLSHAHCIPZOPTULLYISXSCZJQAWAGNNGCGGIWKHNARJISVCDPZGGTLLUDVCSJXEUBFGYJDIMTPFTGYTKFNTYLNFLBFUTSYOVXMLIGOAIQZLXWFRSLJUCDXSSAMGCIFDLJASHCJJWHLKQNIPXZJGLPTEDZXMTHVZGRUHHCKUFDECAKRRZOQFQCDUZHJSDASKQGLQLNNBKUUYTQTHFCJRAAWTBCCURPZPUMCSMQHEBHQRFIGAMBLZXYCVEVLUZCUQXVRJGEKYAOFVRVCOHLDAVKJIYKHCCMNJPDHKKIMPSMVCYQXLGWLBHLDKJLZWTHKFNIZEBVLGOZRNWWVXDCKGNCKQTKQIDHOOCIWRPKXESLDTGXTAURGLBGMPYQLPZBNSBZHANBIYPUZIQURWRBRBXMHBRDPDRERBOBAJULDLWRPKRTFBLSPNKXYITIOHLPGJLCKTLAQSALNOIPHBTUYRRGHSEZNKMZUKAIIHATZTTIYLACTADTNINWCSUFBYNJKXAAJNAGFEVSCFUHOAJUQMISGBBSXQBYLMRASZACPLIUGLQYUZBNIZXXJXNNTSCKJZJZJMMYFMVXJAOPVEFHWHBYOAPKQEDYDDTRPBLPORURSKNPBTAMZKKZRRDDCMRAYGLNJUIKQYNJAUCAQEKHCWXDQPDOHYCVAEXJYULGVWTOVQGSFIVKVUNQDEKHNGXJYYCSPVZULHKYWGQJGAQCLPSXNSERDNRJXROZMXTJTVOSSYQPVOTKHMBQAXIQXUXZLZTKSOHUJRTAIMPDESFQJBJIFGYBEBNUIICFJTEQFVSYRWWJZISSAIMGCUSLEIACQXJIPDTILJQRBLDLIRSIEWJPLNAIDVVIXJQTQJDOZLDBBEEMVMVEQLHJZTCOUOSTCGROMEKRINQBGVGLJHVEAONQKRTJJTLGBKRNYOIXIRSLFSZFQIVGKAFLGKCTVBVKSIPWOMQXLYQXHLBCEUHBJBFNHOFCGPGWDSEFFYCTHMLPCQEJGSKWJKBKBBMIFNURNWYHEVSOQZMTVZGFIQAJFRGYUZXNRTXECTCNLYOISBGLPDBJBSLXLPOYMRCXMDTQHCNLVTQDWFTUZGBDXSYSCWBRGUOSTBELNVTAQDMKMIHMOXQTQLXVLSSSISVQVVZOTOYQRYUYQWOKNNQCQGGYSRQPKRCCVYHXSJMHOQOYOCWCRIPLARJOYIQRMMPMUEQBSBLJDDWRUMAUCZFZIODPUDHEEXALBWPIYPMDJLMWTGDRZHPXNEOFHQZJDMURGVMRWDOTUWYKNLRBVUVTNHIOUVQITGYFGFIEONBAAPYHWPCRMEHXCPKIJZFIAYFVOXKPASYIWXMRAHUWLAOOVREJHPBIIQMDPTEFNNGFZTQHHIFMTHLXKQBHISDXBGOTYSPNVUSLDLFCNOGNDBCJXQDUSSOEGPWPRFUSSJQHKHBHPHTJKYWSEBAAVJAUPVDBXFITSYOJEVYCPXWYXFKZDESBNOACIXWTRHQHFIMUKKDINHWYXNJKMOPBHOPLFMPLQJYFIAZKXXDMZBNDUOAXJDAEVIBEQACBDXWRGSFVPLKHFPNLPFLZNDTLUWRIGJJTTHZHPOWRYLZZYVNATBAWWXBYDUUSBDHBGGAWQVLRBMPGKNZVLKEEAVEKLVQUTZZDRQONOWWVWJFXXLTXMXKKPZKYFZSVYVKVNYCVPNPQBRIBPEMMAYFPNIWAZHBJEZMENVESSYPPASIFGSSFWVEUXASVKMPXZVZOOPTVOZCYQPXANFTSVGLUXXMWTERTADXMAMTXRDQNPLOAGMMGETHVBNEXECQIDNZPSZHLHPSOEMJFRDPFAWNFHYQUWIWNUQZTLHKLUBMJMQIMOYUMBUPRIGZZXVKJJOXHYUSUKLAIYMPOPZYVEWMVQMSOISXZUHSQAZGGGNMRUXDKVGPUCMTZOSJLRPDWAEKOXTRAWMHIJIZUQRLNKIEYLAIIYMTDFTXJUUCJIPOZZHGBIZWMNCRCABVMQWAFVMUXYYBVCIURGYAPTMPVLCNYUHAYTABVKSPWISDSDSPXYSOPDEMQDGQAXUOOOMPKYSOKVZZHDPMVNURNAULFUTCUKWGTXNQXMUKBXNLIDVYSEWBWMSNSRFPXXFTMJUEDKSDMNBKLSRNJPWVPQWMXXTFFGTBDBJIFNRVWZTBDJRBAZXOTGFQVYQPGRDOJJGJVQIWLDVJINOEEBSCJCISYVUTVHVMIYCOYSZFEXXAFMKAXSXWKTFCFAILJABWUNYLERKSNHSAQNHOVLTHJVSUMBZQSJHRLLOVOYUBXMXBYUNVAADRVBEJOORBYHWUNRHNIXRHWODLXNGPQURFPIQDFTESWNRNYFNRLLTCTMJVSJXPFQSGPZEQQTREWWSCEICEANFVODTIOKDWTZOQOBOIIOXGOMODFASZWZGUZZYQITDDCINEMYPCBFELHMHYPBTBWMCHQHYGFTVAOFPXWMPMFBCFNCLQEXJGVZPQBXCQOSKJDXWHIMEUWXOPZAFASCSXAWAROBLPMAMKLRWLZNPLGSPUZVNUBPUDIBPTDSLAAGXAAACQRSFVHCLAEDSMLKJAQSOQGFPOVIGXFVHLTPWPTOJSARDOZOGRLTULBERIYWIREEBJDDKDHPYLEYPYLEVVGLKCKUBMYGXZQMEEYEHJEHKNBKPRSVDGJOIZZGJSZEBTAQQGZWYFGDCBKDGXZURJPOAHRHDPQEXZSRPGVDUTABOGKWKUEHFZWHVAMSNTZUVCRQZPLXHYKIAOAPJZKZNMLSNEZSSKDLOSIYFAWAZNBUWENOVCSFKFUHNTGLVESXSRRNZKBHZKHZMVKJEVSRBDICLCKMSGPGNGYCKZVGYSVWCGWAYJOKQACTFXTIVFBDWPRUFIVTGGZHBPVLXFKISDNEOGDSEENJLEWROBJHPPPJCZYXEAIQANAZTKSNPFWYHDJVIPGWZZNMNNXWRAIIEICSCDHRYZVRHTOPRRATXUFCITHOKIOGUDGGZPVJCTBAHNZDWTOKIATSRIQZWEDRRFZBRKGVYNBBFOMOIAWWMMJIQVHDLNSVWNWBKTEHYKEVHACVDFLMNKRLJMIJVFXDVDYDMVKJSBPMCGMNFTSEUMHBDIOHZCJVPAYXQWDPYCHQCTUDLKEDTBJDUQBZWXVOXJLAJSTAOQNRRRPXCNDMWHLWDYGNNORDXMUJNZLKEAMDXANOKVBVPLRWXZIJPJKULODEULUEPKSLYIUZYWPYYFOCICAZYEWQYULJLFMTHLIEOLXUYPKQPEMFJJPSWULKNGYTFFIXVOIYUUSYBDMYGPUGZHUERHLFELEMNNAVEFSUQIKNYEDQTXYEKPWPDPCUUIMOSYTASPBMINXPVBCBQOLOSVBRPPGPYVIXLSXHQDRPHMJPIHERRWHDWOSAPJFTERGJSZLZWCIHWCUEGFCPSAQJNNFFMVVEUPTMNEFBHOHJBCAOCDWJYAYLNVZECIUCLQUQEDNWKYFYMGRFMZXQPEJCIXXPPQGVUAWUTGRMEZJKTEOFJBNRVZZKVJTACFXJJOKISAVSGRSLRYXFQGRMDSQWPTAJBQZVETHULJBDATXGHFZQRW";

            string tempA = "MZBMWEYYDIADTLCOUEGMDBYFWURPWBPUVHIFNUAPWYNDMHTQVKGKBHTYTSZOTWFLEGSJZZSZFWTZFPNSCGUEMWRCZQXYCIVDQNK";
            string tempB = "FGAKWMOAWLZQJYPMHLLBBUUHBPRIQSNIBYWLGJLXOWYZAGRFNQAFVCQWKTKCJWEJEVZBNXHSFMWOJSHCDYPNVBUHHUZQMGOVMVGW";
            var tempAns = "FGAKMWMOAWLZBMWEYYDIADTLCOUEGMDBYFWURPWBPUVHIFNUAPWYNDMHTQVKGKBHTYTSZOTWFLEGSJZQJYPMHLLBBUUHBPRIQSNI";
            
            string tempResult = morganAndString(tempA, tempB);

            Console.WriteLine(tempAns.Length);
            Console.WriteLine(tempResult.Length);

            for(var i = 0; i < tempAns.Length; i++)
            {
                if (tempResult[i] != tempAns[i])
                {
                    Console.Write($"{tempResult[i]} : {tempAns[i]} => {i} ;;;; ");
                }
            }

            //string c = "ABACABA";
            //string d = "ABACABA";

            //string result2 = morganAndString(c, d);

            //Console.WriteLine(result2);

            //Console.WriteLine(morganAndString("JACK", "DANIEL"));
        }
    }
}
