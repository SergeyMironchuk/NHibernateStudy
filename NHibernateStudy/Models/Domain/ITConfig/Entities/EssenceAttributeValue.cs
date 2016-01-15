using System;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Величина атрибута сущности
    /// </summary>
    [DataContract]
    public class EssenceAttributeValue
    {
        public EssenceAttributeValue()
        {
            DateInfo = new DateInfo();
            Attribute=new Attribute();
        }
        [DataMember]
        public virtual long EssenceAttributeValueId { get; set; }
        [DataMember]
        public virtual string Code { get; set; }
        [DataMember]
        public virtual string Value { get; set; }
        [DataMember]
        [Obsolete("Кандидат на удаление. Избыточная связь")]
        public virtual Essence Essence { get; set; }
        [DataMember]
        public virtual Attribute Attribute { get; set; }
        [DataMember]
        public virtual string Comment { get; set; }
        [DataMember]
        public virtual DateInfo DateInfo { get; set; }
        [DataMember]
        public virtual UpdateInfo UpdateInfo { get; set; }

    }
}