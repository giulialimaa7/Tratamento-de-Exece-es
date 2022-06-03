using System;


namespace Tratamento_de_exeções.Entidades.DominExeções
{
    class DominExeções: ApplicationException 
    { 
        public DominExeções(string message) : base(message)
        {
        }
    }
}

