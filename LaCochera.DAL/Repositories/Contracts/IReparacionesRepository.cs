﻿using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Contracts
{
    public interface IReparacionesRepository
    {
        ICollection<ReparacionDTO> Read();
        ReparacionDTO Read(int id);
    }
}
