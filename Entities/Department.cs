using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace demo.dal.Entities
{
	public class Department: BaseEntity
    {
		public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }
        
        public DateTime CreateAt {  get; set; }=DateTime.Now;
	}
}
