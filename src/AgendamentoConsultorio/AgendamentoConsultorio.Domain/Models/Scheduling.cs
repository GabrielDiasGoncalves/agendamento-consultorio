using System;
using System.Collections.Generic;
using System.Text;

namespace AgendamentoConsultorio.Domain.Models
{
    public class Scheduling
    {
        public DateTime DayOfConsult { get; set; }
        public int IDDoctor { get; set; }
        public Doctor Doctor { get; set; }
        public int IdPatient { get; set; }
        public Patient Patient { get; set; }
    }
}