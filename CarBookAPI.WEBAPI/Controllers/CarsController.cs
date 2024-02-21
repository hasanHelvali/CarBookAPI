using CarBookAPI.Application.Features.CQRS.Commands.Car.CreateCar;
using CarBookAPI.Application.Features.CQRS.Commands.Car.RemoveCar;
using CarBookAPI.Application.Features.CQRS.Commands.Car.UpdateCar;
using CarBookAPI.Application.Features.CQRS.Queries.Car.GetCar;
using CarBookAPI.Application.Features.CQRS.Queries.Car.GetCarById;
using CarBookAPI.Application.Features.CQRS.Queries.GetCarWithBrand;
using CarBookAPI.Application.Features.Mediator.Queries.Car.Get5LastCarsWithBrand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly IMediator _mediator;
        public CarsController(GetCarQueryHandler getCarQueryHandler,
            GetCarByIdQueryHandler getCarByIdQueryHandler,

            CreateCarCommandHandler createCarCommandHandler,
            UpdateCarCommandHandler updateCarCommandHandler,
            RemoveCarCommandHandler removeCarCommandHandler,
            GetCarWithBrandQueryHandler getCarWithBrandQueryHandler,
            IMediator mediator)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Carlist()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommandRequest createCarCommandRequest)
        {
            await _createCarCommandHandler.Handle(createCarCommandRequest);
            return Ok("Araba Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommandRequest updateCarCommandRequest)
        {
            await _updateCarCommandHandler.Handle(updateCarCommandRequest);
            return Ok("Araba Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommandRequest(id));
            return Ok("Araba Bilgisi Silindi.");
        }

        [HttpGet("GetCarWithBrand")]
        public async Task<IActionResult> GetCarWithBrand()
        {
            var values=await _getCarWithBrandQueryHandler.Handle(); 
            return Ok(values);
        }

        [HttpGet("GetLast5CarsWithBrand")]
        public async Task<IActionResult> GetLast5CarsWithBrand()
        {
            List<GetLast5CarsWithBrandQueryResponse>getLast5CarsWithBrandQueryResponse  = await _mediator.Send(new GetLast5CarsWithBrandQueryRequest());
            return Ok(getLast5CarsWithBrandQueryResponse);
        }
    }
}

