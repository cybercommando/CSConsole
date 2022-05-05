using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IoTDevice.Models
{
    [Table("Device")]
    public class Device
    {
        [Key]
        [Required]
        public int SerialNumber { get; set; }

        [StringLength(50)]
        public string DeviceName { get; set; }
    }
}
