using AptekaInternetowa.Models.ProduktM;
using System.Linq;

namespace AptekaInternetowa.Models
{
    static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Produkty.Any())
            {
                context.Produkty.AddRange(
                    new Produkt
                    {
                        Nazwa = "Traumon 100 mg/g, żel, 100g",
                        Producent = "MYLAN",
                        Cena = 19.99,
                        ZdjecieUrl = "images/1.jpg",
                        LiczbaDostępnychSztuk = 5,
                        Sklad = "Lek zawiera: substancję czynną: etofenamat 100mg/g oraz substancje pomocnicze: karbomer 940, eter makrogolu oleinocetylowy (Emulgin M8 Deo), sodu wodorotlenek, alkohol izopropylowy, makrogol 400, glikol propylenowy, woda oczyszczona.",
                        Dzialanie = "Przeciwzapalne, przeciwbólowe.",
                        Przeciwwskazania = "Uczulenie na którykolwiek ze składników leku, ciąża, nie stosować u dzieci i młodzieży, nie stosować do oczu i na błony śluzowe, podczas leczenia oraz w okresie 2 tygodni po leczeniu należy unikać ekspozycji leczonych miejsc na słońce, astma, laktacja.",
                        Wskazania = "Tępe urazy, takie jak: stłuczenia, skręcenia, naciągnięcia mięśni, ścięgien i stawów; choroba zwyrodnieniowa stawów kręgosłupa, kolanowych, barkowych; reumatyzm pozastawowy: bóle okolicy krzyżowo-lędźwiowej; zmiany chorobowe w obrębie tkanek miękkich okołostawowych, tj. zapalenie kaletki maziowej, ścięgien, pochewek ścięgnistych, torebek stawowych; zapalenie nadkłykci.",
                        Dawkowanie = "Nałożyć pasek długości 5-10cm leku Traumon żel na skórę w okolicy objętej bólem, pokrywając nim powierzchnię nieco większą niż obszar objęty bólem i wcierać aż do całkowitego wchłonięcia się leku.Powtarzać 3-4 razy na dobę.",
                        DodatkoweInformacje = "Przed użyciem zapoznaj się z ulotką, która zawiera wskazania, przeciwwskazania, dane dotyczące działań niepożądanych, dawkowanie oraz informacje dotyczące stosowania produktu leczniczego bądź skonsultuj się z lekarzem lub farmaceutą, gdyż każdy lek niewłaściwie stosowany zagraża Twojemu życiu lub zdrowiu."
                    },

                    new Produkt
                    {
                        Nazwa = "Nurofen Forte 400 mg, 48 tabletek powlekanych",
                        Producent = "RECKITT BENCKISER",
                        Cena = 24.99,
                        ZdjecieUrl = "images/2.jpg",
                        LiczbaDostępnychSztuk = 5,
                        Sklad = "1 tabletka zawiera: substancję czynną: ibuprofen 400mg oraz substancje pomocnicze: rdzęń tabletki: kroskarmeloza sodowa, sodu laurylosiarczan, sodu cytrynian, kwas stearynowy, krzemionka koloidalna bezwodna; otoczka cukrowa: karmeloza sodowa, talk, guma arabska suszona rozpyłowo, sacharoza, tytanu dwutlenek (E171), makrogol 6000 tusz do nadruku: Opacode S-1-15094 (szelak, żelaza tlenek czerwony (E172), glikol propylenowy, simeticon).",
                        Dzialanie = "Przeciwzapalne, przeciwbólowe.",
                        Przeciwwskazania = "Uczulenie na którykolwiek ze składników leku, ciąża, nie stosować u dzieci i młodzieży, nie stosować do oczu i na błony śluzowe, podczas leczenia oraz w okresie 2 tygodni po leczeniu należy unikać ekspozycji leczonych miejsc na słońce, astma, laktacja.",
                        Wskazania = "Tępe urazy, takie jak: stłuczenia, skręcenia, naciągnięcia mięśni, ścięgien i stawów; choroba zwyrodnieniowa stawów kręgosłupa, kolanowych, barkowych; reumatyzm pozastawowy: bóle okolicy krzyżowo-lędźwiowej; zmiany chorobowe w obrębie tkanek miękkich okołostawowych, tj. zapalenie kaletki maziowej, ścięgien, pochewek ścięgnistych, torebek stawowych; zapalenie nadkłykci.",
                        Dawkowanie = "Nałożyć pasek długości 5-10cm leku Traumon żel na skórę w okolicy objętej bólem, pokrywając nim powierzchnię nieco większą niż obszar objęty bólem i wcierać aż do całkowitego wchłonięcia się leku.Powtarzać 3-4 razy na dobę.",
                        DodatkoweInformacje = "Przed użyciem zapoznaj się z ulotką, która zawiera wskazania, przeciwwskazania, dane dotyczące działań niepożądanych, dawkowanie oraz informacje dotyczące stosowania produktu leczniczego bądź skonsultuj się z lekarzem lub farmaceutą, gdyż każdy lek niewłaściwie stosowany zagraża Twojemu życiu lub zdrowiu."
                    },

                    new Produkt
                    {
                        Nazwa = "Otrivin 1mg/ 1ml, areozol do nosa, 10ml",
                        Producent = "GLAXOSMITHKLINE",
                        Cena = 13.99,
                        ZdjecieUrl = "images/3.jpg",
                        LiczbaDostępnychSztuk = 14,
                        Sklad = "1ml roztworu zawiera 1 mg ksylometazoliny chlorowodowrku oraz substancje pomocnicze: benzalkoniowy chlorek, disodu edetynian, sodu diwodorofosforan dwuwodny, disodu fosforan dwunastowodny, sodu chlorek, sorbitol 70%, hypromeloza 4000, woda oczyszczona.",
                        Dzialanie = "Zmniejsza przekrwienie i obrzęk błony śluzowej nosa oraz ilość wydzieliny. Pacjentom z uczuciem zatkanego nosa, ułatwia oddychanie przez nos.",
                        Przeciwwskazania = "Nadwrażliwość na składniki leku, jeśli pacjent przebył operację wykonywaną przez nos, np. usunięcie przysadki lub operację przebiegającą z odsłonięciem opony twardej, jeśli pacjent ma jaskrę z wąskim kątem przesączenia.",
                        Wskazania = "Nadmierne przekrwienie błony śluzowej nosa występujące w przebiegu przeziębienia, kataru siennego, alergicznego zapalenia błony śluzowej nosa, zapalenia zatok. Wspomagająco w zapaleniu ucha środkowego.",
                        Dawkowanie = "Dorośli i młodzież w wieku powyżej 12 lat: 1 dawka aerozolu Otrivin do każdego otworu nosowego 3 razy na dobę. Nie stosować więcej niż 3 razy na dobę. Stosowanie leku przez długi okres czasu może skutkować nasileniem objawów blokady nosa. Nie stosować dłużej niż przez 5-7 dni. W celu uniknięcia szerzenia się zakażenie jedno opakowanie leku powinno być stosowane tylko przez jednego pacjenta.",
                        DodatkoweInformacje = "Przed użyciem zapoznaj się z ulotką, która zawiera wskazania, przeciwwskazania, dane dotyczące działań niepożądanych, dawkowanie oraz informacje dotyczące stosowania produktu leczniczego bądź skonsultuj się z lekarzem lub farmaceutą, gdyż każdy lek niewłaściwie stosowany zagraża Twojemu życiu lub zdrowiu."
                    },

                    new Produkt
                    {
                        Nazwa = "SEMA Herba Na odporność Fix, 2 g x 30 saszetek",
                        Producent = "LABOLAROTIA GEMINI",
                        Cena = 6.49,
                        ZdjecieUrl = "images/4.jpg",
                        LiczbaDostępnychSztuk = 9,
                        Sklad = "Kwiat czarnego bzu (Sambucus nigra L., flos), owoc dzikiej róży (Rosa canina L., pseudo-fructus), ziele jeżówki purpurowej (Echinacea purpurea (L.) Moench. herba), ziele czystka szarego (Cistus incanus L., herba),  kwiat hibiskusa (Hibiscus sabdariffa L., flos).",
                        Dzialanie = "Przeciwzapalne, przeciwbólowe.",
                        Przeciwwskazania = "Uczulenie na którykolwiek ze składników leku, ciąża, nie stosować u dzieci i młodzieży, nie stosować do oczu i na błony śluzowe, podczas leczenia oraz w okresie 2 tygodni po leczeniu należy unikać ekspozycji leczonych miejsc na słońce, astma, laktacja.",
                        Wskazania = "Tępe urazy, takie jak: stłuczenia, skręcenia, naciągnięcia mięśni, ścięgien i stawów; choroba zwyrodnieniowa stawów kręgosłupa, kolanowych, barkowych; reumatyzm pozastawowy: bóle okolicy krzyżowo-lędźwiowej; zmiany chorobowe w obrębie tkanek miękkich okołostawowych, tj. zapalenie kaletki maziowej, ścięgien, pochewek ścięgnistych, torebek stawowych; zapalenie nadkłykci.",
                        Dawkowanie = "Nałożyć pasek długości 5-10cm leku Traumon żel na skórę w okolicy objętej bólem, pokrywając nim powierzchnię nieco większą niż obszar objęty bólem i wcierać aż do całkowitego wchłonięcia się leku.Powtarzać 3-4 razy na dobę.",
                        DodatkoweInformacje = "Przed użyciem zapoznaj się z ulotką, która zawiera wskazania, przeciwwskazania, dane dotyczące działań niepożądanych, dawkowanie oraz informacje dotyczące stosowania produktu leczniczego bądź skonsultuj się z lekarzem lub farmaceutą, gdyż każdy lek niewłaściwie stosowany zagraża Twojemu życiu lub zdrowiu."
                    },

                    new Produkt
                    {
                        Nazwa = "Syrop prawoślazowy 35,9 g/ 100 g, 125 g",
                        Producent = "AMARA",
                        Cena = 2.79,
                        ZdjecieUrl = "images/5.jpg",
                        LiczbaDostępnychSztuk = 11,
                        Sklad = "100 g syropu zawiera: substancje aktywne: macerat z korzenia prawoślazu(Althaea officinalis L., radix) 32, 9 g(32, 9 g maceratu z korzenia prawoślazu odpowiada 5 g korzenia prawoślazu), ekstrahent – mieszanina wody i etanolu(40:1), substancje pomocnicze: sacharoza, kwas benzoesowy, woda oczyszczona.",
                        Dzialanie = "Działanie syropu oparte jest na występujących w korzeniu prawoślazu związkach śluzowych, które mają właściwości powlekające, łagodzące i osłaniające.",
                        Przeciwwskazania = "Nie należy stosować leku u pacjentów z nadwrażliwością na którykolwiek ze składników preparatu lub uczuleniem na kwas benzoesowy. Nie stosować u osób z astmą oskrzelową. Stosować ostrożnie u chorych na cukrzycę.",
                        Wskazania = "Kaszel, w przebiegu stanów zapalnych górnych dróg oddechowych spowodowanych podrażnieniem błony śluzowej gardła.",
                        Dawkowanie = "Syrop przyjmuje się doustnie. Zalecana dawka to: Dzieci 3 - 6 lat: doraźnie, ½ -1 łyżeczka(2, 5 - 5 ml) syropu 3 - 4 razy dziennie. Dzieci od 6 - 12 lat: doraźnie, 1 łyżeczka(około 5 ml) syropu 3 - 4 razy dziennie. Dorośli i młodzież powyżej 12 roku życia: doraźnie, 1 łyżka stołowa(około 15 ml) syropu 3 - 4 razy dziennie. Dzieci poniżej 3 lat: nie zaleca się stosowania. Ten lek należy przyjmować zawsze zgodnie z zaleceniami lekarza lub farmaceuty.W razie wątpliwości należy zwrócić się do lekarza lub farmaceuty.Maksymalna dawka dobowa: 5 razy dziennie. Jeżeli podczas stosowania produktu objawy utrzymują się powyżej 7 dni, należy skonsultować się z lekarzem lub farmaceutą.",
                        DodatkoweInformacje = "Przed użyciem zapoznaj się z ulotką, która zawiera wskazania, przeciwwskazania, dane dotyczące działań niepożądanych, dawkowanie oraz informacje dotyczące stosowania produktu leczniczego bądź skonsultuj się z lekarzem lub farmaceutą, gdyż każdy lek niewłaściwie stosowany zagraża Twojemu życiu lub zdrowiu."
                    },

                    new Produkt
                    {
                        Nazwa = "Systane Ultra, nawilżające krople do oczu, 10 ml",
                        Producent = "ALCON",
                        Cena = 32.92,
                        ZdjecieUrl = "images/6.jpg",
                        LiczbaDostępnychSztuk = 13,
                        Sklad = "Glikol polietylenowy 400, glikol propylenowy, guar hydroksypropylowy, sorbitol, aminometylopropanol, kwas borowy, chlorek potasu, chlorek sodu i środek konserwujący POLQUAD (chlorek polidronium) 0,001%.",
                        Dzialanie = "Łagodzące.",
                        Przeciwwskazania = "Uczulenie na którykolwiek składnik preparatu",
                        Wskazania = "Suche oczy :D",
                        Dawkowanie = "Stosowań 1-2 razy na dobę.",
                        DodatkoweInformacje = "Przed użyciem zapoznaj się z ulotką, która zawiera wskazania, przeciwwskazania, dane dotyczące działań niepożądanych, dawkowanie oraz informacje dotyczące stosowania produktu leczniczego bądź skonsultuj się z lekarzem lub farmaceutą, gdyż każdy lek niewłaściwie stosowany zagraża Twojemu życiu lub zdrowiu."
                    }
                );
            }
            context.SaveChanges();
        }
    }
}
