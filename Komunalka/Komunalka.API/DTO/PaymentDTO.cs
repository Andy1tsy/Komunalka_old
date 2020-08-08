using System;
using System.Collections.ObjectModel;

namespace Komunalka.API.DTO
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public DateTime Timestamp { get; set; }

        public ObservableCollection<PayingByCounterDTO> PayingsByCounterDTO { get; set; }
        public ObservableCollection<PayingFixedSummaDTO> PayingsFixedSummaDTO { get; set; }
    }
}