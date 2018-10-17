using ProjetoSage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoSage.ORM
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("PRODUTOS");
            HasKey(a => a.Id);
            Property(a => a.Id).HasColumnName("ID_PROD").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Nome).HasColumnName("NOM_PROD").IsRequired();
            Property(a => a.Preco).HasColumnName("PREC_PROD").IsRequired();
            Property(a => a.Categoria).HasColumnName("CAT_PROD").IsRequired();
            Property(a => a.Descricao).HasColumnName("DESC_PROD").IsRequired();
        }
    }
}