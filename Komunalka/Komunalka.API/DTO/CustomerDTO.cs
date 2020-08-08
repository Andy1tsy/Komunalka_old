using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Komunalka.API.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public  ObservableCollection<PaymentDTO> PaymentsDTO { get; set; }
    }
}
