namespace AuthMicroservice.Domain.Entities
{
    /// <summary>
    /// Зарегистрированный пользователь в системе
    /// </summary>
    public class User
    {
        /// <summary>
        /// Уникальный идентифиатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Уникальный email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Хэш пароля. Null, если аккаунт через внешнего провайдера
        /// </summary>
        public string? PasswordHash { get; set; }

        /// <summary>
        /// Подтвержден ли email
        /// </summary>
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Время создания аккаунта
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Последние обновление аккаунта
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Признак блокировки аккаунта
        /// </summary>
        public bool IsLocked { get; set; }
    }
}
