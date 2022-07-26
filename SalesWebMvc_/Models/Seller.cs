using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc_.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "{0} required")] //indico que o campo é obrigatório
        [StringLength(60, MinimumLength =3, ErrorMessage = "{0} Name size should be between {2} and {1}")] //indico o tamanho máximo e mínimo da string 
        //o {0} na frente da mensagem de erro indica o campo para o qual a mensagem se refere
        //{2} valor mínino do campo, {1} valor máximo - caracteres string
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress (ErrorMessage ="Enter a valid email")]
        [DataType(DataType.EmailAddress)] //transforma o email num link, para acionar o app de email padrão
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display (Name = "Birth Date")] //descrição do campo
        [DataType(DataType.Date)] //para que a data não exija hora
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] //formatar campo de data
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")] // formata o valor com 2 casas decimais depois do ponto
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")] //indico valor mínino e máximo para o salário
        public double BaseSalary { get; set; }

        //não precisa usar required para o departament, pois como uou o int ID   vai ser naturalmente obrigatório
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; } //indicado que esse valor precisa existir e o departamento não pode ser nulo
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
