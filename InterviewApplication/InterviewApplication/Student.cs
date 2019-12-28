using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApplication
{
    public delegate void InterviewDelegate();
    class Student
    {
        private int m_StudentId, m_TotalMarks;
        public event InterviewDelegate Selected;
        public event InterviewDelegate Rejected;
        public int StudentId
        {
            get { return m_StudentId; }
            set
            {
                if (value > 0)
                {
                    m_StudentId = value;
                }
                else
                {
                    throw new Exception("Please enter valid student Id");
                }

            }
        }

        public int TotalMarks { get => m_TotalMarks; set => m_TotalMarks = value; }
        //Auto Implemented Properties
        public string City { get; set; }
        public string Phone { get; set; }
        public string StudentName { get; set; }

        public string CalculateResult(int totalMarks,ref bool yes)
        {
            if (totalMarks>=70)
            {
                if (Selected!=null)
                {
                    Selected();
                }
                yes = true;
                return string.Format("Congrats! {0}! You have been selected for next round!", StudentName);
            }
            else
            {
                if (Rejected!=null)
                {
                    Rejected();
                }
                return string.Format("Sorry! {0}! You have been rejected for next round!", StudentName);
            }
        }
    }
}
