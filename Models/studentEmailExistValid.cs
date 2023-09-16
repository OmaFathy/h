using ExamProject.Context;
using ExamProject.Context;
using System.ComponentModel.DataAnnotations;

namespace ExamProject.Models
{
    public class studentEmailExistValid : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool isEmailUnique = CheckEmailUniqueness(value.ToString());

            if (!isEmailUnique)
            {
                return new ValidationResult("البريد الإلكتروني مستخدم بالفعل.");
            }

            return ValidationResult.Success;
        }

        private bool CheckEmailUniqueness(string email)
        {
            ExamContext context = new ExamContext();
            bool isEmailExists = context.Students.Any(student => student.Email == email);

            if (isEmailExists)
            {
                // Email already exists in the database

                return false;
            }
            else
            {
                return true;

            }
        }
    }
}