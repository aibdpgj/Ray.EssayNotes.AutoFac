﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.EssayNotes.AutoFac.Service.IService
{
    public interface ITeacherService
    {
        string GetTeacherName(long id);
    }
}