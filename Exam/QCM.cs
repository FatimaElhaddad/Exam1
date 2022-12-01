using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class QCM : question
    {
        protected String question;
         protected int nbrQstVrai;
        protected String[] Reponse;
       

        public QCM(String question, int nbrQstVrai, String[] Reponse)
        {
            this.question = question;
            this.nbrQstVrai = nbrQstVrai;
            this.Reponse = Reponse;
        }

        public reponse Reponse
        {
               return new QcmReponse();
        }

    }
}
