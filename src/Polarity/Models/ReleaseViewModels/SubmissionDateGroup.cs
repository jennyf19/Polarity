using System;
using System.ComponentModel.DataAnnotations;

namespace Polarity.Models.ReleaseViewModels
{
    public class SubmissionDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? SubmissionDate { get; set; }

        public int ReleaseCount { get; set; }
    }
}
