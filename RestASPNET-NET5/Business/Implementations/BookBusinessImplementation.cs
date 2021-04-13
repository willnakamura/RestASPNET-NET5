using RestASPNET_NET5.Repository;
using System.Collections.Generic;
using RestASPNET_NET5.Data.VO;
using RestASPNET_NET5.Data.Converter.Implementations;
using RestASPNET_NET5.Model;

namespace RestASPNET_NET5.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {

        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;


        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        // Method responsible for returning all people,
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one BookVO by ID
        public BookVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new book
        public BookVO Create(BookVO bookVO)
        {
            var personEntity = _converter.Parse(bookVO);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for updating one book
        public BookVO Update(BookVO bookVO)
        {
            var personEntity = _converter.Parse(bookVO);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for deleting a BookVO from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}