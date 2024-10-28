using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizz.API.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Tittle { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string?  ImageName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option1 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Option2 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Option3 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Option4 { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Answer { get; set; } = "";

    }
}
