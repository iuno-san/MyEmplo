﻿using AutoMapper;
using MyEmplo.Application.MyEmplo;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.Services
{
    public class MyEmploService : IMyEmploService
    {
        private readonly IMyEmploRepository _myEmploRepository;
        private readonly IMapper _mapper;

        public MyEmploService(IMyEmploRepository myEmploRepository, Mapper mapper)
        {
            _myEmploRepository = myEmploRepository;
            _mapper = mapper;
        }

        public async Task Create(MyEmploDto myEmploDto)
        {
            var myEmplo = _mapper.Map<Domain.Entities.MyEmplo>(myEmploDto);

            await _myEmploRepository.Create(myEmplo);
        }
    }
}
