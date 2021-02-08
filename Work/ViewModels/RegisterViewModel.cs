using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Work.ViewModels
{
    public class RegisterViewModel
    {
         
                    [Required(ErrorMessage = "Это обязательное поле :")]
                    [DataType(DataType.EmailAddress)]
                    [Display(Name = "Email")]
                    [Remote(action: "CheckEmail", controller: "Validation", ErrorMessage = "Ранее использован :")]
                    public string Email { get; set; }
        
                    [DataType(DataType.Password)]
                    [Display(Name = "Пароль")]
                    public string Password { get; set; }
        
                    [Required(ErrorMessage = "Это обязательное поле :")]
                    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
                    [DataType(DataType.Password)]
                    [Display(Name = "Подтвердить пароль")]
                    public string PasswordConfirm { get; set; }
    }
}