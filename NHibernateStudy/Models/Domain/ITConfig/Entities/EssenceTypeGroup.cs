using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Группа типов элементов
    /// </summary>
    [DataContract]
    public class EssenceTypeGroup
    {
        [DataMember]
        public virtual int GroupId { get; set; }
        [DataMember]
        [Display(Name = "Код")]
        public virtual string GroupCode { get; set; }
        [DataMember]
        [Display(Name = "Наименование группы")]
        public virtual string GroupName { get; set; }
        [DataMember]
        [Display(Name = "Описание")]
        public virtual string Comment { get; set; }
        [DataMember]
        [Display(Name = "Обновлено")]
        public virtual UpdateInfo UpdateInfo { get; set; }
    }
}