using System.Collections.Generic;
using System.Linq;

namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class Manager: ManagerBase
    {
        private IList<Role> _rolesForManager;
        /// <summary>
        /// Роли, заданные для пользователя
        /// </summary>
        public virtual IList<Role> RolesForManager {
            get
            {
                return _rolesForManager ?? new List<Role>();
            }
            set
            {
                _rolesForManager = value;
            } 
        }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public virtual string LoginName { get; set; }

        /// <summary>
        /// Строка списка пользователей
        /// </summary>
        public virtual string RolesForView
        {
            get { return RolesForManager.Aggregate("", (s, role) => s + role.RoleName + ",").TrimEnd(','); }
        }
    }
}