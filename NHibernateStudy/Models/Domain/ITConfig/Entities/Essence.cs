using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

#pragma warning disable 1591

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Сущности учета
    /// </summary>
    [DataContract]
    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global
    public class Essence
    {
        [DataMember]
        [Display(Name = "ID")]
        public virtual long EssenceId { get; set; }
        [DataMember]
        [Display(Name = "Код")]
        public virtual string EssenceCode { get; set; }
        [DataMember]
        [Display(Name = "Наименование")]
        public virtual string EssenceName { get; set; }
        [DataMember]
        [Display(Name = "Комментарий")]
        public virtual string Comment { get; set; }
        [DataMember]
        [Display(Name = "Статус")]
        public virtual ObjectStatus Status { get; set; }
        [DataMember]
        [Display(Name = "Даты")]
        public virtual DateInfo DateInfo { get; set; }
        [DataMember]
        [Display(Name = "Справочник")]
        public virtual EssenceType Type { get; set; }
        [DataMember]
        [Display(Name = "Создано")]
        public virtual UpdateInfo UpdateInfo { get; set; }

        [DataMember]
        [Display(Name = "Значения параметров")]
        public virtual IList<EssenceAttributeValue> Values { get; set; }

        //public virtual string ValuesInfo
        //{
        //    get
        //    {
        //        return Values.Aggregate("", (s, value) => s + string.Format("&nbsp;<b>{0}</b>:&nbsp;<u>{1}</u>;", value.Attribute.AttributeName, value.Value));
        //    }
        //}

        /// <summary>
        /// Связанные подчиненные объекты
        /// </summary>
        [DataMember]
        public virtual IList<Reference> ReferencesToChilds { get; set; }
        /// <summary>
        /// Связанные родительские объекты
        /// </summary>
        [DataMember]
        public virtual IList<Reference> ReferencesToOwners { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Essence()
        {
            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            DateInfo = new DateInfo();
            UpdateInfo = new UpdateInfo();
            Values = new List<EssenceAttributeValue>();
            // ReSharper restore DoNotCallOverridableMethodsInConstructor
        }

        /// <summary>
        /// Клонировать элемент с обнулением списков связанных элементов
        /// </summary>
        /// <returns></returns>
        public virtual Essence CloneWithoutReferences()
        {
            return new Essence
            {
                Comment = Comment,
                DateInfo = DateInfo,
                EssenceCode = EssenceCode,
                EssenceId = EssenceId,
                EssenceName = EssenceName,
                Status = Status,
                Type = Type.CloneWithoutLists(),
                UpdateInfo = UpdateInfo,
                Values = Values,
                ReferencesToChilds = new List<Reference>(),
                ReferencesToOwners = new List<Reference>()
            };
        }

        /// <summary>
        /// Клонировать элемент с обнулением списков связанных элементов и параметров
        /// </summary>
        /// <returns></returns>
        public virtual Essence CloneWithoutAllLists()
        {
            return new Essence
            {
                Comment = Comment,
                DateInfo = DateInfo,
                EssenceCode = EssenceCode,
                EssenceId = EssenceId,
                EssenceName = EssenceName,
                Status = Status,
                Type = Type.CloneWithoutLists(),
                UpdateInfo = UpdateInfo,
                ReferencesToChilds = new List<Reference>(),
                ReferencesToOwners = new List<Reference>(),
                Values = new List<EssenceAttributeValue>()
            };
        }

        /// <summary>
        /// Найти значение параметра элемента
        /// </summary>
        /// <returns></returns>
        public virtual EssenceAttributeValue GetEssenceAttributeValue(int findAttributeId)
        {
            return Values.FirstOrDefault(v => v.Attribute.AttributeId==findAttributeId);
        }
    }
}