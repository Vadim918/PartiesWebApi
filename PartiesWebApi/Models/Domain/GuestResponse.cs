using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartiesWebApi.Models.Domain
{
    public class GuestResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool WillAttend { get; set; }
        public string PartiesName { get; set; }
    }
}
