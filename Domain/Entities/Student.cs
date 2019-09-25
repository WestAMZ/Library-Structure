﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Student : Entity 
    {
        public string CI { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Career { get; set; }
        public int Age { get; set; }
    }
}
