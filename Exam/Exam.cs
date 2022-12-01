using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Exam
    {
        public string Intitule { get; set; }  //l'exam doit avoir un nom 
        public float Duree { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }

        public List<question> Question = new List<question>();   //Un examen contient des Qsts
        public List<etudient> Etu = new List<etudient>();  // l'exam a un liste des etidient qui le passe 
        Exam(string Intitule, float Duree, DateTime Date_debut, DateTime Date_fin)
        {
            this.Duree = Duree;
            this.Date_debut = Date_debut;
            this.Date_fin = Date_fin;
            this.Intitule = Intitule;

        }

        public List<question> GetQuestionsList()
        {
            return Question;
        }

        public List<etudient> GetEtudient()
        {
            return Etu;
        }



    }
}
