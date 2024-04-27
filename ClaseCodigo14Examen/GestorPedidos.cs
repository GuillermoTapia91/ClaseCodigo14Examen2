using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCodigo14Examen
{
    public class GestorPedidos
    {
        private readonly Pedido _pedido;
        private readonly IProveedor _proveedor;
        public  GestorPedidos(Pedido pedido,IProveedor proveedor)
        {
            _pedido = pedido;
            _proveedor = proveedor;
        }

        public string MandarPedido()
        {
            return _proveedor.EnviarPedido(_pedido);  
        }
    }
        
    
}
