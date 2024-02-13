using Microsoft.AspNetCore.Http;
using System;

namespace AdminClient.DTO
{
    public class LiveTestDTO
    {
        public int PanditId { get; set; }
        public int QuestionId { get; set; }
        public string LiveTestAnswer { get; set; }
        public int CreatedBy { get; set; }

        public IFormFile file { get; set; }
    }
    public class LiveTestViewModel
    {
        public int LiveTestId { get; set; }
        public int PanditId { get; set; }
        public int QuestionId { get; set; }
        public string LiveTestAnswer { get; set; }

        public int CreatedBy { get; set; }
    }

    public class LiveTestNewDTO
    {
        public int PanditId { get; set; }
        public int QuestionId { get; set; }
        public string LiveTestAnswer { get; set; }

        public int CreatedBy { get; set; }
    }

}
