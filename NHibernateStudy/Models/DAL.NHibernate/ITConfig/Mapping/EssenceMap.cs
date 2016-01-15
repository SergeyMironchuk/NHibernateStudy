using ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig.Mapping
{
    public class EssenceMap: ClassMapping<Essence>
    {
        public EssenceMap()
        {
            Table("Essence");
            Id(a => a.EssenceId, m => m.Column("Essence_Id"));
            Property(a => a.EssenceCode, m => m.Column("Essence_Code"));
            Property(a => a.EssenceName, m => m.Column("Essence_Name"));
            Property(a => a.Comment, m => m.Column("Comment"));
            Component(a => a.UpdateInfo, mapper =>
            {
                mapper.Property(info => info.UpdatedDate, m => m.Column("Updated_Date"));
                mapper.Property(info => info.UpdatedUserName, m => m.Column("Updated_User_Name"));
            });
            Component(a => a.DateInfo, mapper =>
            {
                mapper.Property(info => info.DateBeg, m => m.Column("Date_Beg"));
                mapper.Property(info => info.DateEnd, m => m.Column("Date_End"));
            });
            ManyToOne(a => a.Status, m =>
            {
                m.Column("Object_Status_Id");
                //m.Lazy(LazyRelation.NoLazy);
                //m.Fetch(FetchKind.Select);
            });
            ManyToOne(a => a.Type, m => m.Column("Essence_Type_Id"));
            Bag(a => a.Values, m =>
            {
                m.Key(k => k.Column("Essence_Id"));
                m.Lazy(CollectionLazy.NoLazy);
                //Lazy(true);
                m.BatchSize(200);
                //m.Fetch(CollectionFetchMode.Subselect);
            }, rel => rel.OneToMany());
            Bag(a => a.ReferencesToChilds, m => m.Key(k => k.Column("Essence_Owner_Id")), rel => rel.OneToMany());
            Bag(a => a.ReferencesToOwners, m => m.Key(k => k.Column("Essence_Child_Id")), rel => rel.OneToMany());
        }
    }
}