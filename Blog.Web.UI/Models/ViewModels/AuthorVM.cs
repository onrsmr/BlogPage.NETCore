namespace Blog.Web.UI.Models.ViewModels
{
    public class AuthorVM
    {
        public Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}
