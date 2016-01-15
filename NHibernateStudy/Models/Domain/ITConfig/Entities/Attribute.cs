using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Атрибуты (параметры) объектов
    /// </summary>
    [DataContract]
    public class Attribute
    {
        [DataMember]
        public virtual int AttributeId { get; set; }
        [DataMember]
        public virtual string AttributeCode { get; set; }
        [DataMember]
        public virtual string AttributeName { get; set; }
        [DataMember]
        public virtual string Comment { get; set; }
        [DataMember]
        public virtual string CheckMask { get; set; }
        [DataMember]
        public virtual DateInfo DateInfo { get; set; }
        [DataMember]
        public virtual UpdateInfo UpdateInfo { get; set; }

        /// <summary>
        /// Маска ввода значения параметра
        /// </summary>
        public virtual AttributeMask AttributeMask
        {
            get { return AttributeMask.AvailableMasksList.FirstOrDefault(a => a.Id == (CheckMask ?? "")) ?? new AttributeMask{ Pattern = ".*", Mask = CheckMask}; }
        }
        /// <summary>
        /// Типы сущностей, использующие атрибут
        /// </summary>
        public virtual IList<EssenceType> UsingEssenceTypes { get; set; }

        /// <summary>
        /// Типы сущностей, использующие атрибут, в виде строки значений, разделенных ';'
        /// </summary>
        public virtual string UsingEssenceTypesInfo
        {
            get
            {
                return UsingEssenceTypes == null ? "" : UsingEssenceTypes.Aggregate("", (s, value) => s + string.Format("{0}; ", value.EssenceTypeName));
            }
        }

        /// <summary>
        /// Имя атрибута, используемое для сортировки. Содержит выравненный по правому краю код в начале.
        /// </summary>
        public virtual string NameForOrdering
        {
            get { return string.Format("{0}{1}", (AttributeCode ?? "").TrimStart('0').PadLeft(20, ' '), AttributeName); }
        }
    }

    /// <summary>
    /// Comparer для параметров
    /// </summary>
    public class AttributeEqualityComparer : IEqualityComparer<Attribute>
    {
        public bool Equals(Attribute attribute1, Attribute attribute2)
        {
            return attribute1.AttributeName == attribute2.AttributeName;
        }

        public int GetHashCode(Attribute attribute)
        {
            return attribute.AttributeId;
        }
    }
}