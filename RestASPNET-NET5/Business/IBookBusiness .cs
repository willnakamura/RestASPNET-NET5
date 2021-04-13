using RestASPNET_NET5.Data.VO;
using System.Collections.Generic;

namespace RestASPNET_NET5.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO bookVO);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO bookVO);
        void Delete(long id);
    }
}
