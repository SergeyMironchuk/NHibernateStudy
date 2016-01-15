using System;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Информация о создании
    /// </summary>
    [DataContract]
    public class UpdateInfo
    {
        [DataMember]
        public virtual string UpdatedUserName { get; set; }
        [DataMember]
        public virtual DateTime UpdatedDate { get; set; }
    }
}