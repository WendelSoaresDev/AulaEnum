using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEnum.Entities.Enums
{
    enum OrderStatus : int  //sintaxe do enum => tipo enum + Nome + : + tipo
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
