using System;
using AulaEnum.Entities.Enums; // importei de outro namespace para ser enxergado neste

namespace AulaEnum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                +", "
                +Moment
                +", "
                +Status;
        }


    }
}
