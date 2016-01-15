using System.Collections.Generic;
using System.Linq;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Тип элементов со списками доступа
    /// </summary>
    public class EssenceTypeWithAccessesLists: EssenceType
    {
        /// <summary>
        /// Список доступа по ролям
        /// </summary>
        public virtual IList<RoleAccess> RolesAccesses
        {
            get
            {
                return _rolesAccesses ?? new List<RoleAccess>(); 
            }
            set { _rolesAccesses = value; }
        }

        private IList<RoleAccess> _rolesAccesses;

        /// <summary>
        /// Список доступа по пользователям
        /// </summary>
        public virtual IList<ManagerAccess> ManagersAccesses
        {
            get
            {
                return _managersAccesses ?? new List<ManagerAccess>();
            }
            set { _managersAccesses = value; }
        }

        private IList<ManagerAccess> _managersAccesses;

        /// <summary>
        /// Список атрибутов, для которых заданы ограничения доступа
        /// </summary>
        public IList<Attribute> AttributesWithPermissions 
        {
            get { return _attributesWithPermissions ?? new List<Attribute>(); }
            set { _attributesWithPermissions = value; } 
        }

        private IList<Attribute> _attributesWithPermissions; 

        /// <summary>
        /// Строка списка объектов, которым назначены права
        /// </summary>
        public virtual string SubjectsList
        {
            get
            {
                return (
                    (RolesAccesses.Aggregate("", (s, r) => s + r.Role.RoleName + string.Format((string) "({0})", (object) r.Permission) + ",").TrimEnd(','))
                    + ";"
                    + (ManagersAccesses.Aggregate("", (s, r) => s + r.Manager.RealName + string.Format("({0})", r.Permission) + ","))
                    + " :"
                    + AttributesWithPermissions.Aggregate("", (s, attribute) => s + attribute.AttributeName + ",")
                    )
                    .TrimEnd(',', ';', ':')
                    .TrimStart(';', ':');
            }
        }
    }
}