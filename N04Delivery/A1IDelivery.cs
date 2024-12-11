using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N01RawData;

namespace M07FinalTask.N04Delivery;

// An attempt to use an interface, although we have not yet studied interfaces in the course materials:

/// <summary>
/// Interface for store delivery
/// </summary>
public interface IDelivery
{
    // PROPERTIES

    public string Type { get; }
    public DateTime? SendingDate { get; set; }
    public DateTime? FinishDate { get; set; }

    // METHODS

    string InfoToString();
}
