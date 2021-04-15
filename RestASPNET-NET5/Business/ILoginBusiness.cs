﻿using RestASPNET_NET5.Data.VO;

namespace RestASPNET_NET5.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string userName);
    }
}
