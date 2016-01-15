using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Свойства аттрибута для соответствующего типа сущности
    /// </summary>
    [DataContract]
    public class EssenceTypeAttribute
    {
        [DataMember]
        public virtual long EssenceTypeAttributeId { get; set; }
        [DataMember]
        public virtual EssenceType EssenceType { get; set; }
        [DataMember]
        public virtual Attribute Attribute { get; set; }
        [DataMember]
        public virtual string Comment { get; set; }
        [DataMember]
        [Display(Name = "Обязательный")]
        public virtual bool IsMandatory { get; set; }
        [DataMember]
        public virtual UpdateInfo UpdateInfo { get; set; }

        public EssenceTypeAttribute()
        {
            UpdateInfo = new UpdateInfo();
        }

        /// <summary>
        /// Клонировать объект с удалением связи на тип Элемента
        /// </summary>
        /// <returns></returns>
        public virtual EssenceTypeAttribute CloneWithoutEssenceType()
        {
            return new EssenceTypeAttribute
            {
                EssenceTypeAttributeId = EssenceTypeAttributeId,
                EssenceType = new EssenceType(),
                Attribute = Attribute,
                Comment = Comment,
                IsMandatory = IsMandatory,
                UpdateInfo = UpdateInfo
            };
        }
    }
}