using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtelieDrinks.Models
{
    [Table("Insumos")]
    public class Insumos
    {
        [Column("id_insumo")]
        [Display(Name = "id_insumo")]
        public int id_insumo { get; set; }

        [Column("nome_insumo")]
        [Display(Name = "Nome do insumo")]
        public string nome_insumo { get; set; }

        [Column("quantidade")]
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }

        [Column("custo_insumo")]
        [Display(Name = "Custo insumo")]
        public decimal custo_insumo { get; set; }

        [Column("id_item")]
        [Display(Name = "id_item")]
        public List<Deposito>? id_item { get; set; }



        /*id_insumo SERIAL NOT NULL PRIMARY KEY,
    nome_insumo VARCHAR(30) NOT NULL,
    quantidade INTEGER NOT NULL,
    custo_insumo NUMERIC NOT NULL,
    id_item INTEGER NOT NULL, 
    
    FOREIGN KEY(id_item) REFERENCES Deposito(id_item)  */



    }
}
