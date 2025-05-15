using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks_ProjetoDA
{
    public class Tarefa : Utilizador
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public EstadoAtual EstadoAtual { get; set; }
        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaFim { get; set; }
        public DateTime? DataRealInicio { get; set; }
        public DateTime? DataRealFim { get; set; }
        public int Ordem { get; set; }
        public int ProgramadorId { get; set; }
        public Utilizador Programador { get; set; }
        public int GestorId { get; set; }
        public Utilizador Gestor { get; set; }
        public int TipoTarefaId { get; set; }
        public TipoTarefa TipoTarefa { get; set; }
    }
}
