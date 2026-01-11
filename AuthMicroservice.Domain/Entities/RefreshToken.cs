namespace AuthMicroservice.Domain.Entities
{
    /// <summary>
    /// Токен обновления доступа
    /// </summary>
    public class RefreshToken
    {
        /// <summary>
        /// Уникальный идентификатор записи
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Ссылка на пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Сгенерированный токен
        /// </summary>
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// Время истечения срока действия токена
        /// </summary>
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Был ли токен отозван
        /// </summary>
        public bool IsRevoked { get; set; }
        
        /// <summary>
        /// Время создания записи
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Навигационное свойство: владелец токена
        /// </summary>
        public User User { get; set; } = null!;
    }
}
