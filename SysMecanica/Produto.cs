using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace SysMecanica
{
    [DataContract]
    public class Produto
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string descricao { get; set; }
        [DataMember]
        public double preco { get; set; }
    }
}
