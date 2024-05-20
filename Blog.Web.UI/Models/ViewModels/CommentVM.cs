namespace Blog.Web.UI.Models.ViewModels
{
    public class CommentVM
    {
        public Guid Id { get; set; }
        public Guid ArticleID { get; set; }
        public Guid SubscriberId { get; set; }
        public string CommentContent { get; set; }
    }
}
