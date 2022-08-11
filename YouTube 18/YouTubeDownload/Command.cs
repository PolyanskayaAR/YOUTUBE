﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    public abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
