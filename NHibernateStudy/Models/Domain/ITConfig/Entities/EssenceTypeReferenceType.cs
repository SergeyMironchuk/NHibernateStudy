using System;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities
{
    /// <summary>
    /// Допустимое отношение между между типом сущности и типом связи
    /// </summary>
    public class EssenceTypeReferenceType
    {
        public virtual EssenceType EssenceType { get; set; }
        public virtual ReferenceType ReferenceType { get; set; }
        public virtual ReferenceDirection Direction { get; set; }
        public override bool Equals(object obj)
        {
            var essenceTypeReferenceType = obj as EssenceTypeReferenceType;
            if (essenceTypeReferenceType == null) return false;
            return EssenceType.EssenceTypeId == essenceTypeReferenceType.EssenceType.EssenceTypeId
                && ReferenceType.ReferenceTypeId == essenceTypeReferenceType.ReferenceType.ReferenceTypeId
                && Direction == essenceTypeReferenceType.Direction
                ;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(EssenceType.EssenceTypeId, ReferenceType.ReferenceTypeId, Direction).GetHashCode();
        }
    }
}