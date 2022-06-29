using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosSerializacao
{
    [Serializable]
    public class Paciente
    {
        public string nome;
        public string data_nascimento;
        public string cpf;
    }
}
