using BigAttractions.Data.interfaces;
using BigAttractions.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigAttractions.Data.Mocks
{
    public class MockAttraction : IAttractions
    {
        private readonly ICities _citiesAttractions = new MockCity();

        public IEnumerable<Attraction> Attractions{ 
            get
            {
                return new List<Attraction>
                {
                    new Attraction
                    {
                        city = _citiesAttractions.AllCities.First(),
                        name = "Красная Площадь",
                        shortDesc = "Красная Площадь - главная площадь Москвы, расположена между Московским Кремлём (к западу) и Китай-городом (на восток).",
                        longDesc = "Главная площадь Москвы, расположена между Московским Кремлём и Китай-городом. " +
                        "Выходит к берегу Москвы-реки через пологий Васильевский спуск. Площадь тянется вдоль северо-восточной стены Кремля," +
                        " от Кремлёвского проезда и проезда Воскресенские Ворота до Васильевского спуска, выходящего к Кремлёвской набережной. " +
                        "На восток от Красной площади отходят Никольская улица, Ильинка и Варварка. Вдоль западной стороны площади расположен Московский Кремль," +
                        " вдоль восточной - Верхние торговые ряды и Средние торговые ряды. Входит в единый ансамбль с Московским Кремлём, однако исторически является частью Китай-города.",
                        linkGoogle = "https://yandex.ru/maps/?source=entity_search&pt=37.621085%2C55.753564&ll=37.621085%2C55.753564&oid=10661349235&ol=biz&spn=0.006%2C0.003",
                        img = "https://globusmira.ru/wp-content/uploads/2019/07/s1200-1-1.jpg",
                        isFavourite = true
                    },
                    new Attraction
                    {
                        city = _citiesAttractions.AllCities.First(),
                        name = "Петергоф",
                        shortDesc = "Петерго́ф — внутригородское муниципальное образование в составе Петродворцового района города федерального значения Санкт-Петербурга.",
                        longDesc = "Внутригородское муниципальное образование в составе Петродворцового района города федерального значения Санкт-Петербурга. " +
                        "Расположен на южном берегу Финского залива к западу от Санкт-Петербурга, в 29 км по железной дороге. Крупный туристский, научный и учебный центр.",
                        linkGoogle = "https://yandex.ru/maps/?source=entity_search&pt=29.905877%2C59.879696&ll=29.905877%2C59.879696&spn=0.222%2C0.073",
                        img = "https://photocentra.ru/images/main52/528348_main.jpg",
                        isFavourite = false
                    },
                    new Attraction
                    {
                        city = _citiesAttractions.AllCities.First(),
                        name = "Озеро Байкал",
                        shortDesc = "Байкал — самое большое пресноводное озеро в мире и самое глубокое. Его площадь — 31,7 тысяч кв. км, что чуть больше Бельгии.",
                        longDesc = "Озеро тектонического происхождения в южной части Восточной Сибири, самое глубокое озеро на планете, " +
                        "крупнейший природный резервуар пресной воды и самое большое по площади пресноводное озеро на континенте.",
                        linkGoogle = "https://yandex.ru/maps/?source=entity_search&pt=107.672986%2C53.405214&ll=107.672986%2C53.405214&spn=6.264%2C4.393",
                        img = "https://354651-cf73031.tmweb.ru/wp-content/uploads/2018/11/13-tajny-bajkala.jpg",
                        isFavourite = false
                    },
                    new Attraction
                    {
                        city = _citiesAttractions.AllCities.Last(),
                        name = "Мирский замок",
                        shortDesc = "Мирский замок, заложенный на рубеже XV-XVI столетий, находится в небольшом белорусском городе Мир, в Кореличском районе Гродненской области.",
                        longDesc = "Оборонительное укрепление и резиденция в городском посёлке Мир Кореличского района Гродненской области Белоруссии. Памятник архитектуры, внесён в список Всемирного наследия ЮНЕСКО." +
                        " Архитектурный комплекс включает в себя замок XVI-XX веков, валы XVII-XVIII веков, пруд 1896-1898 годов," +
                        " часовню-усыпальницу Святополк-Мирских с домом сторожа и воротами, пейзажный и регулярный парки, дом управляющего. " +
                        "Находится в пгт Мир, на правом берегу реки Миранки.",
                        linkGoogle = "https://yandex.ru/maps/?source=entity_search&pt=26.473257%2C53.451295&ll=26.473257%2C53.451295&oid=1036939684&ol=biz&z=14",
                        img = "https://i.artfile.ru/2000x1309_1475767_[www.ArtFile.ru].jpg",
                        isFavourite = false
                    },
                    new Attraction
                    {
                        city = _citiesAttractions.AllCities.Last(),
                        name = "Несвижский замок",
                        shortDesc = "Несвижский замок — Национальный историко-культурный музей-заповедник. Национальный историко-культурный музей-заповедник «Несвиж».",
                        longDesc = "Не́свижский за́мок (белор. Нясві́жскі замак) — дворцово-замковый комплекс, находящийся в северо-восточной части города Несвижа в Минской области Белоруссии, " +
                        "памятник архитектуры XVI—XVIII веков. Заложен князем Н. Х. Радзивиллом Сироткой в 1583 году, на месте деревянного замка (1533). Вначале (до 1599 г.) " +
                        "в строительстве замка участвовал итальянский архитектор Джованни Бернардони. В XVI—XX вв. — резиденция князей Радзивиллов.",
                        linkGoogle = "https://yandex.ru/maps/org/gosudarstvennoye_uchrezhdeniye_natsionalny_istoriko_kulturny_muzey_zapovednik_nesvizh/213718753726/",
                        img = "https://zhitanska.com/wp-content/uploads/2020/01/Nesvij-6-1.jpg",
                        isFavourite = false
                    },
                    new Attraction
                    {
                        city = _citiesAttractions.AllCities.Last(),
                        name = "Костел святых Симеона и Елены",
                        shortDesc = "Костёл святого Симеона и святой Елены (белор. Касцёл святога Сымона і святой Алены, польск. Kościół św. Szymona i Heleny), " +
                        "часто называемый также Красным костёлом — наиболее известный католический храм Минска.",
                        longDesc = "Дворянин Эдвард Войнилович построил костел в память о своих детях, умерших в раннем детстве. " +
                        "Собственно, официально храм так и называется - Костел Святого Симеона и Святой Елены, но в народе больше в ходу название Красный костел. " +
                        "Год постройки 1905-й. Расположен костел на Площади Независимости. Судьба была довольна благосклонна к Красному Костелу. " +
                        "В годы Советской власти храм не функционировал. Сначала здание выполняло функции Государственного польского театра БССР, затем стало киностудией. " +
                        "В годы фашистской оккупации костел действовал. После войны костел закрывают и открывают в нем Дом Кино.",
                        linkGoogle = "https://yandex.ru/profile/1013424966?no-distribution=1&source=wizbiz_new_map_single",
                        img = "https://i1.wp.com/ic.pics.livejournal.com/minskblog1/81937060/41642/41642_original.jpg",
                        isFavourite = false
                    }
                };
            }
        }
        public IEnumerable<Attraction> getFavouriteAttraction { get; set; }

        public Attraction getObjectAttraction(int attractionId)
        {
            throw new NotImplementedException();
        }
    }
}
