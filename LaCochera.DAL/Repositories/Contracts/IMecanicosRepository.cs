﻿using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories
{
    public interface IMecanicosRepository
    {
        ICollection<MecanicoDTO> Read();
        MecanicoDTO Read(int id);
    }
}
