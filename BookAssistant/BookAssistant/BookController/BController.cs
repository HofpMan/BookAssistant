using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms.PlatformConfiguration;

namespace BookAssistant.BookController
{
    internal class BController
    {
        public static GetListBooks GetListBooks()
        {
            string jsonData = @"{""Library"":""BookAssistent"",""ListBooks"":[{""CategoriBooks"":""Прокрастинація"",""Books"":[{""id"":0,""NameBook"":""Победи прокрастинацию!Как перестать откладывать дела на завтра"",""Author"":""Петр Людвиг"",""YearOfPublication"":2014,""Genre"":""Прокрастинація""},{""id"":1,""NameBook"":""Прокрастинация и самосаботаж"",""Author"":""Эйлин Леви"",""YearOfPublication"":2016,""Genre"":""Прокрастинація""},{""id"":2,""NameBook"":""Прокрастинация.Первая помощь"",""Author"":""Таня ван Эссен, Хенри Шувенбург"",""YearOfPublication"":2019,""Genre"":""Прокрастинація""},{""id"":3,""NameBook"":""Прокрастинация: привет от внутреннего хомячка"",""Author"":""Евгения Тимонова"",""YearOfPublication"":2016,""Genre"":""Прокрастинація""},{""id"":4,""NameBook"":""Искусство прокрастинации"",""Author"":""Джон Перри"",""YearOfPublication"":2016,""Genre"":""Прокрастинація""}]},{""CategoriBooks"":""Проблеми у комунікації"",""Books"":[{""id"":0,""NameBook"":""Складні розмови. Як обговорювати те, що хвилює найбільше"",""Author"":""Брюс Петтон, Дуглас Стоун, Шейла Хін"",""YearOfPublication"":2015,""Genre"":""Проблеми у комунікації""},{""id"":1,""NameBook"":""Як насолоджуватися життям і отримувати задоволення від роботи"",""Author"":""Дейл Карнегі"",""YearOfPublication"":1985,""Genre"":""Проблеми у комунікації""},{""id"":2,""NameBook"":""Нетворкінг для інтровертів.Поради для комфортної та ефективної комунікації"",""Author"":""Карен Вікрі"",""YearOfPublication"":2019,""Genre"":""Проблеми у комунікації""},{""id"":3,""NameBook"":""Усе замахало. Але надія є"",""Author"":""Марк Менсон"",""YearOfPublication"":2016,""Genre"":""Проблеми у комунікації""},{""id"":4,""NameBook"":""13 ключів до розуміння себе, свого оточення та своїх стосунків"",""Author"":""Анна Просвєтова"",""YearOfPublication"":2016,""Genre"":""Проблеми у комунікації""}]},{""CategoriBooks"":""Тривожність"",""Books"":[{""id"":0,""NameBook"":""Свобода от тревоги"",""Author"":""Роберта Лихи"",""YearOfPublication"":2015,""Genre"":""Тривожність""},{""id"":1,""NameBook"":""Человек в поисках смысла"",""Author"":""Виктора Франкла"",""YearOfPublication"":1985,""Genre"":""Тривожність""},{""id"":2,""NameBook"":""Смысл тревоги"",""Author"":""Ролло Мэя"",""YearOfPublication"":2019,""Genre"":""Тривожність""},{""id"":3,""NameBook"":""Сначала мы делаем чудовище красивым: новое путешествие через беспокойство"",""Author"":""Сары Уилсон"",""YearOfPublication"":2016,""Genre"":""Тривожність""},{""id"":4,""NameBook"":""Десять минут до дзена"",""Author"":""Оуэна О’Кейна"",""YearOfPublication"":2016,""Genre"":""Тривожність""}]},{""CategoriBooks"":""Відсутність турботи про себе"",""Books"":[{""id"":0,""NameBook"":""Турбота про себе для сучасної відьми. Магічні способи побалувати себе, живильні та зміцнюючі тіло та дух"",""Author"":""Мёрфі - Хіскок Е."",""YearOfPublication"":2015,""Genre"":""Відсутність турботи про себе""},{""id"":1,""NameBook"":""Дофамінове покоління"",""Author"":""Анна Лембке"",""YearOfPublication"":1985,""Genre"":""Відсутність турботи про себе""},{""id"":2,""NameBook"":""Бути окей. Що важливо знати про психічне здоров’я"",""Author"":""Дарка Озерна"",""YearOfPublication"":2019,""Genre"":""Відсутність турботи про себе""},{""id"":3,""NameBook"":""12 правил життя. Як перемогти хаос"",""Author"":""Марк Менсон"",""YearOfPublication"":2022,""Genre"":""Відсутність турботи про себе""}]},{""CategoriBooks"":""Відсутність ворк-лайф балансу"",""Books"":[{""id"":0,""NameBook"":""Как работать по 4 часа в неделю и при этом не торчать в офисе «от звонка до звонка», жить где угодно и богатеть"",""Author"":""Тимоти Феррис"",""YearOfPublication"":2007,""Genre"":""Відсутність ворк-лайф балансу""},{""id"":1,""NameBook"":""HBR Guide. Жизненный баланс"",""Author"":""Манн, Иванов, Фабер"",""YearOfPublication"":1985,""Genre"":""Відсутність ворк-лайф балансу""},{""id"":2,""NameBook"":""Жизнь на полной мощности"",""Author"":""Джим Лоэр"",""YearOfPublication"":1999,""Genre"":""Відсутність ворк-лайф балансу""},{""id"":3,""NameBook"":""Одноминутный менеджер и жизненное равновесие"",""Author"":""Бланшар Марджори, Эдигтон Д.У., Бланшар Кеннет"",""YearOfPublication"":2014,""Genre"":""Відсутність ворк-лайф балансу""},{""id"":4,""NameBook"":""Жить на полную.Выбери лучший сценарий своего будущего"",""Author"":""Майкл Хайятт"",""YearOfPublication"":2016,""Genre"":""Відсутність ворк-лайф балансу""}]},{""CategoriBooks"":""Інше"",""Books"":[{""id"":0,""NameBook"":""Свобода от тревоги"",""Author"":""Роберта Лихи"",""YearOfPublication"":2015,""Genre"":""Інше""},{""id"":1,""NameBook"":""Человек в поисках смысла"",""Author"":""Виктора Франкла"",""YearOfPublication"":1985,""Genre"":""Інше""},{""id"":2,""NameBook"":""Смысл тревоги"",""Author"":""Ролло Мэя"",""YearOfPublication"":2019,""Genre"":""Інше""},{""id"":3,""NameBook"":""Сначала мы делаем чудовище красивым: новое путешествие через беспокойство"",""Author"":""Сары Уилсон"",""YearOfPublication"":2016,""Genre"":""Інше""},{""id"":4,""NameBook"":""Десять минут до дзена"",""Author"":""Оуэна О’Кейна"",""YearOfPublication"":2016,""Genre"":""Інше""}]}]}";
            GetListBooks getListBooks = JsonConvert.DeserializeObject<GetListBooks>(jsonData);

            return getListBooks;
        }
        public static List<ListBock> GetBook(GetListBooks ListBooks, string message)
        {
            List<ListBock> books = new List<ListBock>();
            foreach (var item in ListBooks.ListBooks)
            {
                if (item.CategoriBooks.ToLower() == message.ToLower())
                {
                    int x, y, z;
                    Random r = new Random();
                    x = r.Next(0, item.Books.Count);
                    y = RandomFromRangeWithExceptions(0, item.Books.Count, x);
                    z = RandomFromRangeWithExceptions(0, item.Books.Count, x, y);
                    books.Add(item.Books[x]);
                    books.Add(item.Books[y]);
                    books.Add(item.Books[z]);
                    return books;
                }
            }
            return null;
        }
        public static int RandomFromRangeWithExceptions(int rangeMin, int rangeMax, params int[] exclude)
        {
            var _rand = new System.Random();
            var range = Enumerable.Range(rangeMin, rangeMax).Where(i => !exclude.Contains(i));
            int k = exclude.Length;
            int index = _rand.Next(rangeMin, rangeMax - k);
            return range.ElementAt(index);
        }
    }
}
