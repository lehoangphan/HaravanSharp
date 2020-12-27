namespace HaravanData.Repositories
{
    public abstract class BaseHaravanRepository
    {
       protected virtual string JWToken { get; set; }
       protected virtual string BaseApiUrl { get; set; }
    }
}
