namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Право доступа для пользователя
    /// </summary>
    public class ManagerAccess : AccessBase
    {
        /// <summary>
        /// Роль
        /// </summary>
        public virtual Manager Manager { get; set; }
    }
}