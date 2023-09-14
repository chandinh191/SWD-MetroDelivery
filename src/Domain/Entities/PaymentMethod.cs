using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class PaymentMethod : BaseAuditableEntity
{
    public String Name { get; set; }
    public PaymentMethodStatus Status { get; set; }
}
