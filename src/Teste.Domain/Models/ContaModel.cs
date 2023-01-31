﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Domain.Models
{
    public class ContaModel : Entity
    {

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }

        public string UF { get; set; }

        public string Ibge { get; set; }

        public string Gia { get; set; }

        public string DDD { get; set; }

        public string Siafi { get; set; }
    }
}
