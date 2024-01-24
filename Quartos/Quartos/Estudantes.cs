using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quartos {
    internal class Estudantes {

        public string Nome { get; set; }
        public string Email { get; set; }
        public Estudantes(string nome, string email) {
            Nome = nome;
            Email = email;
        }
        public override string ToString() {
            return Nome + ", " + Email;
        }
    }

}
