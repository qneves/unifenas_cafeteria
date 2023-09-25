using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCafeteria
{
    [Table("Pedido")]
    public class PedidoModel
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }
        public double precoTotal { get; set; }
        public DateTime data { get; set; }
        public string fPagamento { get; set; }
        public string acucar { get; set; }
        public string msgPedido { get; set; }

        public bool Insert(PedidoModel entity, string Banco)
        {
            try
            {
                if (entity.id == 0)
                {
                    using (SqlConnection connection = new SqlConnection(Banco))
                    {
                        var Result = connection.Insert(entity);
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(Banco))
                    {
                        var Result = connection.Update(entity);
                    }
                }

                return true;
            }
            catch (Exception X)
            {
                return false;
            }
        }

        public bool Delete(int id, string Banco)
        {
            var Sucesso = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(Banco))
                {
                    var Result = connection.Delete(new PedidoModel() { id = id });
                    Sucesso = Result;
                }
            }
            catch (Exception)
            {
                return Sucesso;

            }
            return Sucesso;
        }

        public List<PedidoModel> GetAll(string Banco)
        {
            using (SqlConnection connection = new SqlConnection(Banco))
            {
                return connection.GetAll<PedidoModel>().ToList();
            }
        }
    }
}
