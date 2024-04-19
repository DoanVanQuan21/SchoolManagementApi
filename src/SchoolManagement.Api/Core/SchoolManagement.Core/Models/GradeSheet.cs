using System;
using System.Collections.Generic;

namespace SchoolManagement.Core.Models;

public partial class GradeSheet
{
    public int GradeSheetId { get; set; }

    public int ClassId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public double? FirstRegularScore { get; set; }

    public double? SecondRegularScore { get; set; }

    public double? ThirdRegularScore { get; set; }

    public double? FourRegularScore { get; set; }

    public double? MidtermScore { get; set; }

    public double? FinalScore { get; set; }

    public double? SemesterAverage { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
