namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Право доступа для роли
    /// </summary>
    public class RoleAccess: AccessBase
    {
        /// <summary>
        /// Роль
        /// </summary>
        public virtual Role Role { get; set; }
    }
}