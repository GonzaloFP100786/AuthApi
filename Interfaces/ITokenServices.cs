using WebApiIndentity.Models;

namespace WebApiIndentity.Interfaces
{
    public interface ITokenServices
    {
        public string Createtoken(AppUser user);
    }
}
