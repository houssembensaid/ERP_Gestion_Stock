public sealed record UpdateArticleCommand(ArticleDto articleDto):ICommand<bool>;