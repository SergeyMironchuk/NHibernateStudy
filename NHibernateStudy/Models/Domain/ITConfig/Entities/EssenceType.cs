using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Тип сущности
    /// </summary>
    [DataContract]
    public class EssenceType
    {
        [DataMember]
        [Display(Name = "Группа справочников")]
        public virtual EssenceTypeGroup EssenceTypeGroup { get; set; }
        [DataMember]
        public virtual int EssenceTypeId { get; set; }
        [DataMember]
        [Display(Name = "Код")]
        public virtual string EssenceTypeCode { get; set; }
        [DataMember]
        [Display(Name = "Наименование справочника")]
        public virtual string EssenceTypeName { get; set; }
        [DataMember]
        [Display(Name = "Описание")]
        public virtual string Comment { get; set; }
        [DataMember]
        [Display(Name = "Статус")]
        public virtual ObjectStatus Status { get; set; }
        [DataMember]
        [Display(Name = "Обновлено")]
        public virtual UpdateInfo UpdateInfo { get; set; }
        [DataMember]
        [Display(Name = "Допустимые параметры")]
        public virtual IList<EssenceTypeAttribute> Attributes { get; set; }
        [DataMember]
        [Display(Name = "Допустимые связанные параметры")]
        public virtual IList<ReferenceTypeWithDirection> AllowReferences { get; set; }

        //public virtual string AttributesInfo
        //{
        //    get
        //    {
        //        return Attributes==null ? "" : Attributes.Aggregate("", (s, value) => s + string.Format((string) "{0}; ", (object) value.Attribute.AttributeName));
        //    }
        //}

        //public virtual string AllowReferencesInfo
        //{
        //    get
        //    {
        //        return AllowReferences == null ? "" : AllowReferences.Aggregate("", (s, value) => s + string.Format("{0}; ", value.ReferenceTypeName));
        //    }
        //}

        public EssenceType()
        {
            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            Attributes = new List<EssenceTypeAttribute>();
            AllowReferences = new List<ReferenceTypeWithDirection>();
            UpdateInfo = new UpdateInfo {UpdatedDate = DateTime.Now};
            // ReSharper restore DoNotCallOverridableMethodsInConstructor
        }

        //public override bool Equals(object obj)
        //{
        //    var essenceType = obj as EssenceType;
        //    if (essenceType == null) return false;
        //    return EssenceTypeId == essenceType.EssenceTypeId;
        //}

        //public override int GetHashCode()
        //{
        //    return EssenceTypeId;
        //}

        public virtual EssenceType CloneWithoutLists()
        {
            return new EssenceType
            {
                Comment = Comment,
                Status = Status,
                AllowReferences = new List<ReferenceTypeWithDirection>(),
                Attributes = new List<EssenceTypeAttribute>(),
                EssenceTypeCode = EssenceTypeCode,
                EssenceTypeGroup = EssenceTypeGroup,
                EssenceTypeId = EssenceTypeId,
                EssenceTypeName = EssenceTypeName,
                UpdateInfo = UpdateInfo
            };
        }
    }
}