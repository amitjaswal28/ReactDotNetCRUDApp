using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Model
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName ="NVARCHAR (100)")]
        public string Name { get; set; }
        [Column(TypeName = "NVARCHAR (10)")]
        public string mobile { get; set; }
        [Column(TypeName = "NVARCHAR (100)")]
        public string email {  get; set; }
        public int age { get; set; }
        [Column(TypeName = "NVARCHAR (4)")]
        public string bloodGroup { get; set; }
        [Column(TypeName = "NVARCHAR (100)")]
        public string address { get; set; }
    }
}
