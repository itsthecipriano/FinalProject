﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity 
    {
        public int CatrgoryId { get; set; }
        public string CategoryName { get; set; }
    }
}