using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set; }
        private string Titulo {get; set; }
        private string Description {get; set; }
        private int Ano{get; set;}
        private bool Excluido {get; set; }

        //Metodos
        public Serie(int id, Genero genero, string titulo, string description, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Description = description;
            this.Ano = ano;
            this.Excluido = false;
        }

        public void Excluir(){
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }


        //WriteLine
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Description + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

    }
}