namespace ExampleASP.NET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Display(Name = "Exam Subject")]
        public int ExamSubject { get; set; }
        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng � n�y")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }
        [Display(Name = "Exam Date")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng � n�y")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime ExamDate { get; set; }
        [Display(Name = "Exam Duration")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng � n�y")]
        public int Duration { get; set; }
        [Display(Name ="ClassRoom")]
        public int ClassRoom { get; set; }
        [Display(Name ="Faculty")]
        public int Faculty { get; set; }
        
        public int Status { get; set; }
    }
}
