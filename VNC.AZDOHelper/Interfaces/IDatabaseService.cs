﻿using System.Data.Entity;

namespace VNC.AZDOHelper.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<> { get; set; }

        void Save();

    }
}