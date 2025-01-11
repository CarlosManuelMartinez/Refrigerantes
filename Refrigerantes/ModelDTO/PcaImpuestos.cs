using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.ModelDTO
{
    public class PcaImpuestos
    {
        private int id;
        private string nombre;
        private decimal pca;
        private decimal impuesto;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }  
            set { nombre = value; } 
        }

        public decimal Pca
        {
            get { return pca; }
            set { pca = value; }
        }
        public decimal Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public PcaImpuestos(int id, string nombre, decimal pca, decimal impuesto)
        {
            this.id = id;
            this.nombre = nombre;
            this.pca = pca;
            this.impuesto = impuesto;
        }

    }
}
