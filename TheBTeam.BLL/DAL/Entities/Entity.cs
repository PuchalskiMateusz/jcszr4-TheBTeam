﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBTeam.BLL.DAL.Entities
{
    public abstract class Entity
    {
        [Key/* DatabaseGenerated(DatabaseGeneratedOption.Identity)*/]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }// = DateTime.Now;
    }
}
