using Industrial.Client.Models.Article;

namespace Industrial.Client.Services;

public interface IArticlesService
{
    Task<IEnumerable<ArticlePreviewModel>> GetArticles();
}