using System.ComponentModel.DataAnnotations;

namespace SimpApi.Models
{
    public class Staff:IValidatableObject
    {
        [Required]
        [StringLength(maximumLength: 50,MinimumLength =10,ErrorMessage ="Invalid name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invaild email")]
        [StringLength(maximumLength:100,MinimumLength =5,ErrorMessage ="Invalid email lenght")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Invalid phone")]
        [StringLength(maximumLength:10,MinimumLength =10,ErrorMessage ="Invalid phone")]
        public string Phone { get; set; }
        [Required]
        //[MinSalary(10,20)]
        public double HourlySalary { get; set; }
       
        //[DOBAttribute]
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateTime.Today.AddYears(-10)>DateOfBirth)
            {
                yield return new ValidationResult("Invalid DOB");

            }
        }
    }
}
