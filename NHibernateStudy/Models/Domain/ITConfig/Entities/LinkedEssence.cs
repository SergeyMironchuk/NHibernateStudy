using System;
using System.Runtime.Serialization;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Связанная сущность
    /// </summary>
    public class LinkedEssence
    {
        /// <summary>
        /// Связанный элемент
        /// </summary>
        [DataMember]
        public Essence Essence { get; set; }
        /// <summary>
        /// Наименование связи
        /// </summary>
        [DataMember]
        public string ReferenceName { get; set; }
        /// <summary>
        /// Тип связи
        /// </summary>
        [DataMember]
        public ReferenceType ReferenceType { get; set; }
        /// <summary>
        /// Идентификатор типа связи
        /// </summary>
        [DataMember]
        [Obsolete("Кандидат на удаление")]
        public int ReferenceTypeId { get; set; }
        /// <summary>
        /// Код типа связи
        /// </summary>
        [DataMember]
        [Obsolete("Кандидат на удаление")]
        public string ReferenceTypeCode { get; set; }
        /// <summary>
        /// Направления связи
        /// </summary>
        [DataMember]
        public ReferenceDirection LinkDirection { get; set; }

        /// <summary>
        /// Имя типа связи с учетом направления, содержащее в том числе код
        /// </summary>
        public string ReferenceNameWithCode
        {
            get
            {
                return string.Format("{1} ({2}{0})"
                    , (int)LinkDirection == 0 ? "a" : "b"
                    , ReferenceName, ReferenceType.ReferenceTypeCode);
            }
        }

        /// <summary>
        /// Имя типа связи для выполнения сортировки. Учитывает значение кода
        /// </summary>
        public string ReferenceNameForOrdering
        {
            get
            {
                return string.Format("{0}{1})"
                    , ReferenceType.ReferenceTypeCode.TrimStart('0').PadLeft(20,' '), ReferenceName);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public LinkedEssence() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="essence"></param>
        /// <param name="referenceType"></param>
        /// <param name="referenceDirection"></param>
        public LinkedEssence(Essence essence, ReferenceType referenceType, ReferenceDirection referenceDirection)
        {
            Essence = essence;
            ReferenceType = referenceType;
            LinkDirection = referenceDirection;
            ReferenceName = referenceDirection == ReferenceDirection.AsOwner
                ? referenceType.ReferenceTypeNameLine
                : referenceType.ReferenceTypeNameReverse;
        }
     }
}