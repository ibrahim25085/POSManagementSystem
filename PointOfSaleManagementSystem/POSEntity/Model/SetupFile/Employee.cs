using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEntity.Model.SetupFile
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Filed Is Must Be Provided")]
        public string Name { get; set; }
        public string Code { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string Outlet { get; set; }
        [Required(ErrorMessage = "Filed Is Must Be Provided")]
        public DateTime JoiningDate { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string Reference { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string EmargencyContactNo { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string NID { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string MotherName { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string PresentAddress { get; set; }

        [Required(ErrorMessage = " Filed Is Must Be Provided")]
        public string PermanentAddress { get; set; }

      
        public byte Image { get; set; }


        public int outletID { get; set; }
        public virtual Outlet outlet { get; set; }
    }
}
