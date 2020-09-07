using SmartPole.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPole.ViewModel
{
    public class DetalheViewModel
    {
        public List<PosteModel> Postes { get; set; }
        public DetalheViewModel()
        {
            Postes = new List<PosteModel>()
            {
                new PosteModel(){ Id="Poste1", Descricao="Poste1", Status="Ok"},
                new PosteModel(){ Id="Poste2", Descricao="Poste2", Status="Ok"},
                new PosteModel(){ Id="Poste3", Descricao="Poste3", Status="Ok"},
                new PosteModel(){ Id="Poste4", Descricao="Poste4", Status="Ok"},
                new PosteModel(){ Id="Poste5", Descricao="Poste5", Status="Ok"},
                new PosteModel(){ Id="Poste6", Descricao="Poste6", Status="Ok"},
                new PosteModel(){ Id="Poste7", Descricao="Poste7", Status="Ok"},
                new PosteModel(){ Id="Poste8", Descricao="Poste8", Status="Ok"},
                new PosteModel(){ Id="Poste9", Descricao="Poste9", Status="Ok"},
                new PosteModel(){ Id="Poste10", Descricao="Poste10", Status="Ok"}
            };
        }
    }
}
