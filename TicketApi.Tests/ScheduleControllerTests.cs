using AutoFixture;
using Azure;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net;
using TicketApi.Controllers;
using TicketApi.Data;
using TicketApi.Models;
using TicketApi.ModelsDTO;

namespace TicketApi.Tests
{
    public class ScheduleControllerTests
    {
        private readonly IFixture _fixture;
        private ScheduleController _controller;
        private Mock<IRepository<Schedule>> _repository;
        public ScheduleControllerTests()
        {
            _fixture = new Fixture();
            _repository = new Mock<IRepository<Schedule>>();
        }


        [Fact]
        public async Task GetAllSchedules_ShouldReturnOk_WhenDataFound()
        {
            //Arrange
            var schedules = _fixture.CreateMany<Schedule>(3).ToList();
            _repository.Setup(x => x.GetAllAsync()).ReturnsAsync(schedules);
            _controller = new ScheduleController(_repository.Object, AutomapperSingleton.Mapper);

            //Act
            var response = await _controller.GetAll();

            //Assert
            var actionResult = Assert.IsType<ActionResult<APIResponse>>(response);
            Assert.IsType<OkObjectResult>(actionResult.Result);
        }



        [Fact]
        public async Task CreateSchedule_ShouldReturnOk_WhenCreateIsOk()
        {
            //Arrange
            var schedule = _fixture.Create<ScheduleDTO>();
            Schedule model = AutomapperSingleton.Mapper.Map<Schedule>(schedule);
            _repository.Setup(x => x.CreateAsync(model));
            _controller = new ScheduleController(_repository.Object, AutomapperSingleton.Mapper);
            //Act
            var result = await _controller.Create(schedule);

            //Assert
            var actionResult = Assert.IsType<ActionResult<APIResponse>>(result);
            Assert.IsType<OkObjectResult>(actionResult.Result);
        }


        [Fact]
        public async Task UpdateSchedule_ShouldReturnOk_WhenUpdateIsOk()
        {
            //Arrange
            int id = 1;
            ScheduleDTO scheduleDTO = new ScheduleDTO {Id=1, Departure = DateTime.Now, Arrival = DateTime.Now.AddHours(5) };

            Schedule model = AutomapperSingleton.Mapper.Map<Schedule>(scheduleDTO);
            _repository.Setup(x => x.UpdateAsync(model));
            _controller = new ScheduleController(_repository.Object, AutomapperSingleton.Mapper);
            //Act
            var result = await _controller.Update(id, scheduleDTO);

            //Assert
            var actionResult = Assert.IsType<ActionResult<APIResponse>>(result);
            Assert.IsType<OkObjectResult>(actionResult.Result);
        }


        [Fact]
        public async Task DeleteSchedule_ShouldReturnBadRequest_WhenDeleteIs400()
        {
            //Arrange
            int id = 0;
            _repository.Setup(x => x.GetAsync(id));
            _controller = new ScheduleController(_repository.Object, AutomapperSingleton.Mapper);

            //Act
            var result = await _controller.Delete(id);

            //Assert
            //result?.Should().NotBeNull();
            var actionResult = Assert.IsType<ActionResult<APIResponse>>(result);
            Assert.IsType<BadRequestObjectResult>(actionResult.Result);      
        }
    }
}