using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class EssenceTypeReferenceTypeMap: ClassMapping<EssenceTypeReferenceType>
    {
        public EssenceTypeReferenceTypeMap()
        {
            Table("Essence_Type_Reference_Type");
            ComposedId(mapper =>
            {
                mapper.ManyToOne(a => a.EssenceType, m => m.Column("Essence_Type_Id"));
                mapper.ManyToOne(a => a.ReferenceType, m => m.Column("Reference_Type_Id"));
                mapper.Property(essenceTypeReferenceType => essenceTypeReferenceType.Direction, m => m.Column("Reference_Direction"));
            });
        }
    }
}