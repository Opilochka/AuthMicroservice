# Auth Microservice

Надёжный, гибкий и безопасный микросервис аутентификации и авторизации на основе **OAuth 2.1** и **OpenID Connect**.  
Предназначен для централизованного управления пользователями, ролями и сессиями в распределённой системе.

> ✨ Проект разрабатывается как часть дипломной работы и личного портфолио.  
> 🔒 Соответствует современным стандартам безопасности: хэширование паролей (Argon2), JWT с RS256, refresh-токены в БД, аудит входов.

---

## 🚀 Быстрый старт (локальная разработка)

### Требования
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/) и [Docker Compose](https://docs.docker.com/compose/)

### Запуск
```bash
git clone <ваш-репозиторий>
cd AuthMicroservice
docker-compose up --build