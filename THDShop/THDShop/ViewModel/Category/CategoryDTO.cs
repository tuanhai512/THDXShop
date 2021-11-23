﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THDShop.ViewModel.Category
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        [NotMapped]
        public List<CategoryDTO> listLoai { get; internal set; }
    }
}