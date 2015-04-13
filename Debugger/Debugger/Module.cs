﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger.Debug {

    /// <summary>
    /// Module information from asPEEK
    /// </summary>
    public class Module : BaseClass {
        string name_;

        public string Name {
            get { return name_; }
            set { name_ = value; OnPropertyChanged("Name"); }
        }
    }
}
