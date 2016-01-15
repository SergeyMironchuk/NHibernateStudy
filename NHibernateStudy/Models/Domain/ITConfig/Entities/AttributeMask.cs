using System.Collections.Generic;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Маска для ввода значения параметра
    /// </summary>
    public class AttributeMask
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Строка подсказки для ввода
        /// </summary>
        public string PlaceHolder { get; set; }
        /// <summary>
        /// Сообщение об ошибке проверки
        /// </summary>
        public string ValidationMessage { get; set; }
        /// <summary>
        /// Регулярное выражение для проверки
        /// </summary>
        public string Pattern { get; set; }
        /// <summary>
        /// Маска для ввода
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// Список масок, допустимый для использования
        /// </summary>
        public static List<AttributeMask> AvailableMasksList
        {
            get
            {
                return new List<AttributeMask>
                {
                    new AttributeMask {Id="EMail", Pattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", PlaceHolder = "Пример email@address.com", ValidationMessage = "Введено с ошибкой"},
                    new AttributeMask {Id="IP Address", Pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b", PlaceHolder = "Пример 192.168.100.25", ValidationMessage = "Введено с ошибкой"},
                    new AttributeMask {Id="Табельный номер", Pattern = @"\d{1,10}", PlaceHolder = "от одной до 10 цифр", ValidationMessage = "Введено с ошибкой"},
                    new AttributeMask {Id="Дата", 
                        Pattern = @"^(?:(?:31(\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", 
                        PlaceHolder = "дд.мм.гггг", ValidationMessage = "Введено с ошибкой"},
                };
            }
        } 
    }
}