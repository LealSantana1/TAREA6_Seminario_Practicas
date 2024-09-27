﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Models
{
    public class Categoria
    {
       

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Departamento_ventasId { get; set; }
    }

}
