using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificações
{


    public class Notifica
    {

        public Notifica()
        {
            notificações = new List<Notifica>();
        }

        public string NomePropriedade { get; set; }

        public string mensagem { get; set; }

        public List<Notifica> notificações;


        public bool ValidarPropriedadeString( string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificações.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade,
                });
                return false;
            }
            
            return true;
        }


        public bool ValidarPropriedadeInt(int Valor, string nomePropriedade) 
        {
            if (Valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificações.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade,
                });
                return false;
            }
            return true;
        
        }
    }
}

