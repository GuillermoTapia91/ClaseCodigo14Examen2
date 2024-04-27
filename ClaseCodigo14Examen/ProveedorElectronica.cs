using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCodigo14Examen
{
    public class ProveedorElectronica : IProveedor
    {
        public string pedidosElectronicos { get; set; }
        

        public string EnviarPedido(Pedido pedido)
        {
            return pedidosElectronicos;
        }
    }
}
