using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Тип связи
    /// </summary>
    [DataContract]
    public class ReferenceType
    {
        [DataMember]
        public virtual int ReferenceTypeId { get; set; }
        [DataMember]
        public virtual string ReferenceTypeCode { get; set; }
        [DataMember]
        public virtual string ReferenceTypeNameLine { get; set; }
        [DataMember]
        public virtual string ReferenceTypeNameReverse { get; set; }
        /// <summary>
        /// Признак того, что количество связанных элементов в прямом направлении ограничено одним.
        /// </summary>
        [DataMember]
        public virtual bool OnlyOneLimitLine { get; set; }
        /// <summary>
        /// Признак того, что количество связанных элементов в обратном направлении ограничено одним.
        /// </summary>
        [DataMember]
        public virtual bool OnlyOneLimitReverse { get; set; }
        [DataMember]
        public virtual string Comment { get; set; }
        [DataMember]
        public virtual UpdateInfo UpdateInfo { get; set; }
        /// <summary>
        /// Список типов сущностей, использующих связь в качестве владельца
        /// </summary>
        public virtual IList<EssenceType> UsingEssenceTypesAsOwner { protected get; set; }
        /// <summary>
        /// Список типов сущностей, использующих связь в качестве подчиненного
        /// </summary>
        public virtual IList<EssenceType> UsingEssenceTypesAsChild { protected get; set; }

        public virtual string UsingEssenceTypesAsOwnerInfo
        {
            get
            {
                return UsingEssenceTypesAsOwner == null ? "" : UsingEssenceTypesAsOwner.Aggregate("", (s, value) => s + string.Format((string) "{0};<br/>", (object) value.EssenceTypeName));
            }
            set { var info = value; }
        }
        public virtual string UsingEssenceTypesAsChildInfo
        {
            get
            {
                return UsingEssenceTypesAsChild == null ? "" : UsingEssenceTypesAsChild.Aggregate("", (s, value) => s + string.Format("{0};<br/>", value.EssenceTypeName));
            }
            set { var info = value; }
        }


        public override bool Equals(object obj)
        {
            var referenceType = obj as ReferenceType;
            if (referenceType == null) return false;
            return ReferenceTypeId == referenceType.ReferenceTypeId;
        }

        public override int GetHashCode()
        {
            return ReferenceTypeId;
        }

        /// <summary>
        /// Идентификатор типа связи с направлением для подчиненного элемента
        /// </summary>
        public virtual string ReferenceTypeIdForChild
        {
            get { return string.Format("{0}_{1}", ReferenceTypeId, (int)ReferenceDirection.AsChild); }
        }

        /// <summary>
        /// Идентификатор типа связи с направлением для владеющего элемента
        /// </summary>
        public virtual string ReferenceTypeIdForOwner
        {
            get { return string.Format("{0}_{1}", ReferenceTypeId, (int)ReferenceDirection.AsOwner); }
        }
    }
}