﻿//本地项目包
using Ray.EssayNotes.AutoFac.Domain.Entity;
using Ray.EssayNotes.AutoFac.Domain.IRepository;
using Ray.EssayNotes.AutoFac.Service.IService;

namespace Ray.EssayNotes.AutoFac.Service.Service
{
    /// <summary>
    /// 书籍逻辑处理
    /// </summary>
    public class BookService : IBookService
    {
        IBaseRepository<BookEntity> _bookRepository;
        public BookService(IBaseRepository<BookEntity> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public string GetTitle(long id)
        {
            return _bookRepository.Get(id).Title;
        }
    }
}
