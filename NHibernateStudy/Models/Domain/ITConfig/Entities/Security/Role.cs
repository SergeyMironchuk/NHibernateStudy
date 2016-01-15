using System.Collections.Generic;
using System.Linq;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Роль
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Идентификатор роли
        /// </summary>
        public virtual int RoleId { get; set; }
        /// <summary>
        /// Наименование роли
        /// </summary>
        public virtual string RoleName { get; set; }

        private IList<Manager> _managersInRole;
        /// <summary>
        /// Список пользователей, входящих в роль
        /// </summary>
        public virtual IList<Manager> ManagersInRole {
            get
            {
                return _managersInRole ?? new List<Manager>(); 
            }
            set
            {
                _managersInRole = value;
            } 
        }

        /// <summary>
        /// Строка списка пользователей
        /// </summary>
        public virtual string ManagersForView
        {
            get { return ManagersInRole.Aggregate("", (s, manager) => s + manager.RealName + ",").TrimEnd(','); }
        }
    }
}