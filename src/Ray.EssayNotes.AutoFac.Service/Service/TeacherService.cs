﻿//本地项目包
using Ray.EssayNotes.AutoFac.Domain.IRepository;
using Ray.EssayNotes.AutoFac.Service.IService;

namespace Ray.EssayNotes.AutoFac.Service.Service
{
    /// <summary>
    /// 教师逻辑处理
    /// </summary>
    public class TeacherService : ITeacherService
    {
        /// <summary>
        /// 用于属性注入
        /// </summary>
        public ITeacherRepository TeacherRepository { get; set; }

        public string GetTeacherName(long id)
        {
            return TeacherRepository?.Get(111).Name;
        }
    }
}
