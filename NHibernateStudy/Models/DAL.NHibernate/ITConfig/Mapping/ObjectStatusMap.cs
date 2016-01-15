using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class ObjectStatusMap: ClassMapping<ObjectStatus>
    {
        public ObjectStatusMap()
        {
            Table("Object_Status");
            Id(a => a.ObjectStatusId, m => m.Column("Object_Status_Id"));
            Lazy(false);
            BatchSize(50);
            Property(a => a.ObjectStatusCode, m => m.Column("Object_Status_Code"));
            Property(a => a.ObjectStatusName, m => m.Column("Object_Status_Name"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
        }
    }
}