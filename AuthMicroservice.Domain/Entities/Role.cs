namespace AuthMicroservice.Domain.Entities
{
    /// <summary>
    /// Роль в системе
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Уникальный идентификатор роли
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название роли (например, "admin")
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание роли
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Связь: пользователи с этой ролью
        /// </summary>
        public ICollection<User> Users { get; set; } = [];
    }
}
