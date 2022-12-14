using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiostation.DAL.Entities
{
    public class Performer
    {
        [DisplayName("#")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }

        [DisplayName("Группа")]
        [Required(ErrorMessage = "Обязательное поле")]
        public bool IsGroup { get; set; }

        [DisplayName("Состав группы")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string GroupList { get; set; }

        [DisplayName("Описание")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Description { get; set; }


        public List<Track> Tracks { get; set; }
    }
}
