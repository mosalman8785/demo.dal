using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.dal.Entities
{
	public class Employee: BaseEntity
    {
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		[DisplayName("Employee Name")]
		public string Name { get; set; }
		public string address { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[Column(TypeName ="money")]
		public double salary { get; set; }

		public bool IsActive { get; set; }

		public DateTime HireDate { get; set; }=DateTime.Now;//default value
		
		public Department department { get; set; }

		public int departmentId { get; set; }
        

        public string ImageUrl { get; set; }
    }
	//there is a point you should take care of it .the properties in the entity should be the same order in ViewModel
}
