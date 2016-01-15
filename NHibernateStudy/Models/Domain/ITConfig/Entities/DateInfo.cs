using System;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Информация по датам жизненного цикла
    /// </summary>
    [DataContract]
    public class DateInfo
    {
        [DataMember]
        public DateTime DateBeg { get; set; }
        [DataMember]
        public DateTime DateEnd { get; set; }

        public DateInfo()
        {
            DateBeg = DateTime.MinValue;
            DateEnd = DateTime.MaxValue;
        }
    }
}