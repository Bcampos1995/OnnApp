using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnnApp
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Certifique-se de ter essa propriedade
        public decimal Balance { get; set; }
        public string CPF { get; set; }
    }

}
