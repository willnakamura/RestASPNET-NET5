using RestASPNET_NET5.Data.VO;
using RestASPNET_NET5.Model;

namespace RestASPNET_NET5.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
