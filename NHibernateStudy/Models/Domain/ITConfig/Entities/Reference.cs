using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Связь между объектами
    /// </summary>
    [DataContract]
    public class Reference
    {
        [DataMember]
        public virtual long ReferenceId { get; set; }
        [DataMember]
        public virtual string Comment { get; set; }
        [DataMember]
        public virtual ObjectStatus Status { get; set; }
        [DataMember]
        public virtual DateInfo DateInfo { get; set; }
        [DataMember]
        public virtual ReferenceType ReferenceType { get; set; }
        [DataMember]
        public virtual Essence EssenceOwner { get; set; }
        [DataMember]
        public virtual Essence EssenceChild { get; set; }
        [DataMember]
        public virtual UpdateInfo UpdateInfo { get; set; }
    }
}