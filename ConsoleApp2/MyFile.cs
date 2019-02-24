﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyFile
    {
        public int Id { get; set; }
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public int? Id_folder { get; set; }
        public int? Id_type { get; set; } 
    }
}