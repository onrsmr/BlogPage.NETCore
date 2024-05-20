namespace Blog.Web.UI.Models.ViewModels
{
    public class SubscriberVM
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
