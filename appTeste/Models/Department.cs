using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appTeste.Models
{
    public class Department
    {
        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        /*Propriedades para associação*/
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public void AddSeller(Seller Seller)
        {
            Sellers.Add(Seller);
        }

        //add using system e system.linq
        public double TotalSales(DateTime initial, DateTime final)
        {
            //Vamos usar o linq -> using System.linq
            //Filtrar lista de vendas com lambda
            //chama o método da soma do vendedor de um departamento e depois soma tudo
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
