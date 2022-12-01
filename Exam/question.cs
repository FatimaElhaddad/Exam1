using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam;

public class question
{
    public int NbrQues { get; set; }
    public float Note { get; set; } // La note attribue a chaque question 

    public question(int NbrQues, float Note)
    {
        this.NbrQues = NbrQues;
        this.Note = Note;

    }
}