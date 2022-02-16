﻿using AutoMapper;
using BankApi.Dtos;
using BankApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserService _service;

        public UsersController(UserService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result.Select(model => _mapper.Map<UserDto>(model)));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var result = _service.GetById(id);
            return Ok(_mapper.Map<UserDto>(result));
        }

        [HttpPost]
        public IActionResult AddUser(UserDto userDto)
        {
            _service.AddUser(userDto);
            return new ObjectResult(null) { StatusCode = StatusCodes.Status201Created };
        }

    }
}
