namespace AuthMicroservice.Domain.Entities
{
    /// <summary>
    /// Запись об аутентификации пользователя
    /// </summary>
    public class UserLogin
    {
        /// <summary>
        /// Уникальный идентификатор записи 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор пользователя 
        /// Может быть null при неудачном входе
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Email, по которому пытались войти
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Успешна ли попытка входа
        /// </summary>
        public bool IsSucces { get; set; }

        /// <summary>
        /// IP-адрес клиента
        /// </summary>
        public string? ClientIp { get; set; }

        /// <summary>
        /// User-Agent
        /// </summary>
        public string? UserAgent { get; set; }

        /// <summary>
        /// Время события
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
