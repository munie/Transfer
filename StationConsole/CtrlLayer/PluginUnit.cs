﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StationConsole.CtrlLayer
{
    public class PluginUnit : Mnn.MnnUnit.Unit
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public Mnn.MnnPlugin.PluginItem Plugin { get; set; }
    }
}