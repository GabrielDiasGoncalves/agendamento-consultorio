using System;
using System.Collections.Generic;
using System.Text;

namespace AgendamentoConsultorio.Domain.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string CPF { get; set; }
        public string Address { get; set; }
        public string CEP { get; set; }
    }
}