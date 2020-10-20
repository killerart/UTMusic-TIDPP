﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UTMusic.DataAccess.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public virtual ICollection<IdNumber> IdNumbers { get; set; }
        public Song()
        {
            IdNumbers = new HashSet<IdNumber>(); 
        }
    }
}