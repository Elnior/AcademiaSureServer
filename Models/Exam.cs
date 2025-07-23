using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaSureServer.Models
{
    public class Exam
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = default!;

        public string Subject { get; set; } = default!;

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public int TimeLimitMinutes { get; set; }

        public string GradingRules { get; set; } = default!;

        public ICollection<ExamQuestion> ExamQuestions { get; set; } = default!;
        public ICollection<Submission> Submissions { get; set; } = default!;
    }

    // Join Table for Many-to-Many
    public class ExamQuestion
    {
        public int ExamId { get; set; }
        public Exam Exam { get; set; } = default!;

        public int QuestionId { get; set; }
        public Question Question { get; set; } = default!;
    }
}
