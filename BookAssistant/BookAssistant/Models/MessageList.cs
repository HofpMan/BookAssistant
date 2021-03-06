using System;
using System.Collections.Generic;
using System.Text;

namespace BookAssistant.Models
{
    public static class MessageList
    {
        public static List<Message> listMessage = new List<Message>() { 
        
            new Message(){
                Text = "\t Привіт, Я твій вірутальний експерт в світі книг, Я спробую підібрати щось цікавеньке для тебе."
            },

            new Message(){
                Text = "\tДавай Я тобі допоможу розібратись з керуванням додатком, ось перелік команд з якими Я вмію працювати: \n" +
                "\t - Категорії - буде виведено список категорій книг з яких я тобі можу щось запропонувати;\n" +
                "\t - Команди - я виведу список команд з якими я вмію працювати; \n" +
                "\t - Розробники - виведу інформацію про розробників, та деякі цікавинки про них\n" +
                "\t - Пака - я закрию додаток."
            },

            new Message() {
                Text = "Ось тобі список категорій по яким ти можеш провести пошук: \n" +
                "\t - Проскратинація; \n" +
                "\t - Проблеми в комунікації; \n" +
                "\t - Тривожність; \n" +
                "\t - Відсутність турботи про себе; \n" +
                "\t - Відсутність ворк-лайф балансу; \n" +
                "\t - Інше. \n" +
                "\t Вибачте, це поки всі категорії, з якими я вмію працювати. Надалі список категорій буде розширюватися :)" +
                "\t Просто введи одну із категорій і отримаєш рекомендації по книгам"
            },

            new Message()
            {
                Text = "Ось перелік команд з якими Я вмію працювати: \n" +
                "\t - Категорії - буде виведено список категорій книг з яких я тобі можу щось запропонувати;\n" +
                "\t - Команди - я виведу список команд з якими я вмію працювати; \n" +
                "\t - Розробники - виведу інформацію про розробників, та деякі цікавинки про них\n" +
                "\t - Пака - я закрию додаток."
            },

            new Message()
            {
                Text = "Над проектом працювали: \n" +
                "\t Белак Артур - лідер команди, який збирав команду з прохожих біля метро \n" +
                "\t Мельник Андрій - провідний розробник \n" +
                "\t Хілик Денис - чувак з бородою \n" +
                "\t Бондар Максим - просто проходив мимо \n"
            },

            new Message()
            {
                Text = "Приємно було з тобою працювати. Сподіваюсь тобі все сподобалося. На все добре, чекаємо тебе знову! :)"
            },
            
            new Message()
            {
                Text = "Вибачте, я поки такого не вмію :("
            }

        };
    }
}