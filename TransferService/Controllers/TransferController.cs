using AutoMapper;
using Core.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using TransferServiceWebAPI.Models;
using ShareModels;

namespace TransferServiceWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : Controller
    {
        private readonly CreateTransfer _createTransfer;
        private readonly IMapper _mapper;

        public TransferController(CreateTransfer createTransfer, IMapper mapper)
        {
            _createTransfer = createTransfer;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransfer([FromBody] CreateTransferDto createTransferDto)
        {

            var transfer = _mapper.Map<Transfer>(createTransferDto);
            await _createTransfer.ExecuteAsync(transfer);
            return Ok(transfer);
        }


    }
}
