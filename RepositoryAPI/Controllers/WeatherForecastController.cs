using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

    public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseController(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        // Return OkObjectResult(IEnumerable<WarehouseEntry>)
        public IActionResult GetProducts()
        {
            List<WarehouseEntry> entries = new List<WarehouseEntry>();
            foreach (var item in _warehouseRepository.GetProductRecords().Where(x => x.Quantity > 0))
            {
                entries.Add(new WarehouseEntry() { ProductId = item.ProductId, Quantity = item.Quantity } );
            }
            return new OkObjectResult(entries);
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooLowMessage)
        public IActionResult SetProductCapacity(int productId, int capacity)
        {
            if (capacity <= 0)
            {
                return new BadRequestObjectResult(new NotPositiveQuantityMessage());
            }

            var item = _warehouseRepository.GetCapacityRecords().Where(x => x.ProductId == productId).FirstOrDefault();
            if (capacity < item.Capacity )
            {
                return new BadRequestObjectResult(new QuantityTooLowMessage());
            }
            _warehouseRepository.SetCapacityRecord(productId, capacity);
            return new OkResult();

        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        public IActionResult ReceiveProduct(int productId, int qty)
        {
            if (qty <= 0)
            {
                return new BadRequestObjectResult(new NotPositiveQuantityMessage());
            }
            throw new NotImplementedException();
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        public IActionResult DispatchProduct(int productId, int qty)
        {
            if (qty <= 0)
            {
                return new BadRequestObjectResult(new NotPositiveQuantityMessage());
            }
            throw new NotImplementedException();
        }
    }

    public interface IWarehouseRepository
    {
        void SetCapacityRecord(int productId, int capacity);
        IEnumerable<CapacityRecord> GetCapacityRecords();
        IEnumerable<CapacityRecord> GetCapacityRecords(Func<CapacityRecord, bool> filter);

        void SetProductRecord(int productId, int quantity);
        IEnumerable<ProductRecord> GetProductRecords();
        IEnumerable<ProductRecord> GetProductRecords(Func<ProductRecord, bool> filter);
    }

    public class CapacityRecord
    {
        public int ProductId { get; set; }
        public int Capacity { get; set; }
    }

    public class ProductRecord
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    // IEnumerable<WarehouseEntry> should be returned by GetProducts method.
    // It can be mapped from ProductRecord
    public class WarehouseEntry
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    // NotPositiveQuantityMessage should be returned by
    // SetProductCapacity, ReceiveProduct and DispatchProduct methods
    public class NotPositiveQuantityMessage
    {
        public string Message => "A positive quantity was not provided";
    }

    // QuantityTooLowMessage should be returned by
    // SetProductCapacity, ReceiveProduct and DispatchProduct methods
    public class QuantityTooLowMessage
    {
        public string Message => "Too low a quantity was provided";
    }

    // QuantityTooHighMessage should be returned by
    // SetProductCapacity, ReceiveProduct and DispatchProduct methods
    public class QuantityTooHighMessage
    {
        public string Message => "Too high a quantity was provided";
    }
}
