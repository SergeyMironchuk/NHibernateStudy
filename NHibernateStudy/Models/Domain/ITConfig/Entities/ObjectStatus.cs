using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Состояние объекта
    /// </summary>
    [DataContract]
    public class ObjectStatus
    {
        [DataMember]
        public virtual int ObjectStatusId { get; set; }
        [DataMember]
        public virtual string ObjectStatusCode { get; set; }
        [DataMember]
        public virtual string ObjectStatusName { get; set; }
        [DataMember]
        public virtual string Comment { get; set; }
        [DataMember]
        public virtual UpdateInfo UpdateInfo { get; set; }
        [DataMember]
        public virtual string ObjectColor { get; set; }
    }
}