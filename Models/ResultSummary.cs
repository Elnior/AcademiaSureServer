using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaSureServer.Models
{
    public class ResultSummary
{
    public Guid Id { get; set; }

    public int StudentId { get; set; }
        public User Student { get; set; } = default!;

    public int ExamId { get; set; }
    public Exam Exam { get; set; } = default!;

    public double Score { get; set; }
    public bool Passed { get; set; }

    public string Feedback { get; set; } = default!;
}

}