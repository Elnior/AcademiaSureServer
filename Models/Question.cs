using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaSureServer.Models
{
    public class Question
    {
        public Guid Id { get; set; }

        [Required]
        public string Content { get; set; } = default!;

        public string? ImageUrl { get; set; }
        public string? AudioUrl { get; set; }

        [Required]
        public QuestionType Type { get; set; } // Enum: Objective, Descriptive

        public string? OptionsJson { get; set; } // for objective (store options as JSON)
        public string? CorrectAnswer { get; set; }

        public string Subject { get; set; } = default!;
        public string Category { get; set; } = default!;

        public ICollection<ExamQuestion> ExamQuestions { get; set; } = default!;
    }

    public enum QuestionType
    {
        Objective,
        Descriptive
    }
}