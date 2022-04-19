using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public partial class Exam01
    {
        public string Img
        {
            get
            {
                if (Art != null)
                {
                    return Art;
                }
                else
                {
                    return "Image/picture.png";
                }
            }
        }
    }
}
