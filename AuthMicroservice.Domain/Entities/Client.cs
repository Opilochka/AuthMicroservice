namespace AuthMicroservice.Domain.Entities
{
    /// <summary>
    /// Зарегистрированное клиентское приложение
    /// имеющие право запрашивать токены у этого авторизованного сервера
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Уникальный клиентский идентификатор (публичный)
        /// </summary>
        public string ClientId { get; set; } = string.Empty;

        /// <summary>
        /// Секретный ключ клиента. Может быть null, для public клиентов
        /// </summary>
        public string? ClientSecretHash { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string ClientName { get; set; } = string.Empty;

        /// <summary>
        /// Разрешенные способы получения токена для этого клиента
        /// </summary>
        public List<string> AllowedGrantTypes { get; set; } = [];

        /// <summary>
        /// Адреса, на которые можно перенаправлять пользователя после входа
        /// </summary>
        public List<string> RedirectUris { get; set; } = [];

        /// <summary>
        /// Домены, с которых разрешено делать запросы к API авторизации
        /// </summary>
        public List<string> AllowedCorsOrigins { get; set; } = [];

        /// <summary>
        /// Права, которые может запросить клиент
        /// </summary>
        public List<string> AllwedScopes { get; set; } = [];

        /// <summary>
        /// Является ли клиент конфиденциальным
        /// </summary>
        public bool RequireClientSecret => !string.IsNullOrEmpty(ClientSecretHash);

        /// <summary>
        /// Активен ли клиент
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
