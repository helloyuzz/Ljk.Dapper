﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisher.Core {
    public class PrimaryKeyIllegalTypeException:Exception {
        public PrimaryKeyIllegalTypeException(string message) : base(message) {
            
        }
    }
}