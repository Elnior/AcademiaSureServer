using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaSureServer.Models
{
    public class Submission
    {
        public Guid Id { get; set; }

        [Required]
        public int ExamId { get; set; }
        public Exam Exam { get; set; } = default!;

        [Required]
        public int StudentId { get; set; }
        public User Student { get; set; } = default!;

        public DateTime SubmittedAt { get; set; }

        public bool IsCompleted { get; set; }

        public ICollection<Answer> Answers { get; set; } = default!;

        public double TotalScore { get; set; }
    }

    public class Answer
    {
        public int Id { get; set; }

        public int SubmissionId { get; set; }
        public Submission Submission { get; set; } = default!;

        public int QuestionId { get; set; }
        public Question Question { get; set; } = default!;

        public string StudentAnswer { get; set; } = default!;

        public double? Score { get; set; }
    }
}
