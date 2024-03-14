﻿using System;

namespace AdminApi.Models.App.Categories
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
