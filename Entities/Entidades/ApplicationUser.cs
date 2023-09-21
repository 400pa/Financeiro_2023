using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CLASSE RESPONSÁVEL PARA CUSTOMIZAÇÃO DO IDENTITY //
namespace Entities.Entidades
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_CPF")]
        public string CPF { get; set; }
    }
}
