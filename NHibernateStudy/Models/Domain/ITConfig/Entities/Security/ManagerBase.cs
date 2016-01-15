namespace ATB.RPO.NHibernateStudy.Models.Domain.ITConfig.Entities.Security
{
    /// <summary>
    /// Базовые данные по пользователю
    /// </summary>
    public class ManagerBase
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public virtual int ManagerId { get; set; }
        /// <summary>
        /// Полное имея пользователя
        /// </summary>
        public virtual string RealName { get; set; }

    }
}