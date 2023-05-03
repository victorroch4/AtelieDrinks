using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtelieDrinks.Models
{
    [Table("Base_alcoolica")]
    public class Base_alcoolica
    {
        [Key]
        [Column("id_base_alcoolica")]
        [Display(Name = "id_base_alcoolica")]
        public int id_base_alcoolica { get; set; }

        [Column("quantidade")]
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }

        [Column("nome_bebida")]
        [Display(Name = "Nome da bebida")]
        public string nome_bebida { get; set; }

        [Column("nome_marca")]
        [Display(Name = "Nome da marca")]
        public string nome_marca { get; set; }

        [Column("custo_garrafa")]
        [Display(Name = "Custo garrafa")]
        public decimal custo_garrafa { get; set; }

        [Column("custo_total")]
        [Display(Name = "Custo total")]
        public decimal custo_total { get; set; }

        [Column("id_bebida")]
        [Display(Name = "id_bebida")]
        public List<Marca>? id_bebida { get; set; }

        [Column("id_marca")]
        [Display(Name = "id_marca")]
        public List<Marca>? id_marca { get; set; }


    /*id_base_alcoolica SERIAL NOT NULL PRIMARY KEY,
    quantidade INTEGER,
    nome_bebida VARCHAR(30) NOT NULL,
    nome_marca VARCHAR(30) NOT NULL,
    custo_garrafa NUMERIC NOT NULL,
    custo_total NUMERIC NOT NULL,
    id_bebida INTEGER NOT NULL,
    id_marca INTEGER NOT NULL,

    FOREIGN KEY(id_bebida) REFERENCES Drinks(id_drink),
    FOREIGN KEY(id_marca) REFERENCES Marca(id_marca)*/

    }
}
