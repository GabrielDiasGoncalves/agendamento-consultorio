using AgendamentoConsultorio.Domain.Models;
using AgendamentoConsultorio.Services.Interfaces;

using System;

namespace AgendamentoConsultorio.Services
{
    public class DoctorService
    {
        private readonly IRepository<Doctor> _repository;

        public DoctorService(IRepository<Doctor> repository)
        {
            _repository = repository;
        }

        public void CreateNewDoctor(Doctor doctor)
        {
            // validations

            // insert
            _repository.Add(doctor);
        }
    }
}