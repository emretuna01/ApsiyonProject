using PaymentService.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Entities
{
    public class Payment : BaseEntity
    {
        public double Dues { get; set; }
        public double ElectricityBill { get; set; }
        public double WaterBill { get; set; }
        public double GasBill { get; set; }
        public double PhoneBill { get; set; }
        public double DepositMoney { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid HouseOwnerId { get; set; }
        public Guid FlatId { get; set; }
        public double Balance { get; set; }
    }
}
