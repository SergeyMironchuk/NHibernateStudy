using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Направление связи
    /// </summary>
    [DataContract]
    public enum ReferenceDirection
    {
        /// <summary>
        /// Связь со стороны подчиненного
        /// </summary>
        [EnumMember]
        AsChild = 1,
        /// <summary>
        /// Связь со стороны владельца
        /// </summary>
        [EnumMember]
        AsOwner = 0,
        /// <summary>
        /// Неопределенная связь
        /// </summary>
        [EnumMember]
        Unknown = 2
    }
}