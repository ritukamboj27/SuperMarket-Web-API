using System.ComponentModel;

namespace Supermarket.API.Domain.Models
{
    public enum EunitOfMeasurement : byte
    {
        [Description("UN")]
        Unity = 1,
        [Description("MG")]
        Miligram = 2,
        [Description("KG")]
        Kilogram = 3,
        [Description("G")]
        Gram = 4,
        [Description("L")]
        Liter = 5
    }
    
}