﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Entity
{
    public class Autor
    {
        [Key]
        public string Id { get; set; }
        public string Nome { get; set; }
        
        public string Email { get; set; }
        public string Senha { get; set; }

        public Autor()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
