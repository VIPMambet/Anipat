using System.ComponentModel.DataAnnotations;    

namespace Anipat.Models {
    public class Message {

        [Required(ErrorMessage = "Поле name обязательно для заполнение")]
        public string name { get; set; }

        [Required(ErrorMessage = "Поле emial обязательно для заполнение")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }


    }
}
