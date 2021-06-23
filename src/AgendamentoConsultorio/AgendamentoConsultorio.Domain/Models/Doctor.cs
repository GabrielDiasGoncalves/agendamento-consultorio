using System;
using System.Collections.Generic;
using System.Text;

namespace AgendamentoConsultorio.Domain.Models
{
    public class Doctor
    {
        public Doctor()
        {

        }

        public Doctor(string name, string specialty, string cPF, decimal salary, string address, string cep)
        {
            Name = name;
            Specialty = specialty;
            CPF = cPF;
            Salary = salary;
            Address = address;
            CEP = cep;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string CPF { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string CEP { get; set; }
    }
}