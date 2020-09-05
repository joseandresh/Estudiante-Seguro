namespace admStudentSecurity
{
	using System;
	using System.ComponentModel.DataAnnotations;
	public class Student
	{
		[Key]
		public int StudentId { get; set; }

		[StringLength(30)]
		[Required(ErrorMessage = "You must enter the field {0}")]
		public string LastName { get; set; }

		[StringLength(30, ErrorMessage = "The field {0} must between {2} and {1} characters", MinimumLength = 2)]
		[Required(ErrorMessage = "You must enter the field {0}")]
		public string FirstName { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyyy}", ApplyFormatInEditMode = true)]
		public DateTime EnrollmentDate { get; set; }
	}
}