
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THDShop.ViewModel.Product
{
    public class CreateProductInput
    {
        public CreateProductInput()
        {
            IMAGE = "~/Assets/Images/hp1.jpg";
        }
        public int ID { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên ")]
        [Display(Name = "Tên sản phẩm")]
        public string NAME { get; set; }

        [Required(ErrorMessage = "Bạn chưa chọn loại sản phẩm")]
        [Display(Name = "Loại sản phẩm")]
        public int? IDCATEGORY { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số lượng không được âm")]
        [Required(ErrorMessage = "Bạn chưa nhập số lượng")]
        [Display(Name = "Số lượng")]
        public int? QUANTITY { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Giá không được âm")]
        [Required(ErrorMessage = "Bạn chưa nhập giá bán")]
        [Display(Name = "Giá Bán")]
        public double? PRICE { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Giá không được âm")]
        [Required(ErrorMessage = "Bạn chưa nhập giá gốc")]
        [Display(Name = "Giá Gốc")]
        public double? ORI_PRICE { get; set; }


        [Required(ErrorMessage = "Bạn chưa nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string DESCRIPTION { get; set; }


        public string IMAGE { get; set; }


        [NotMapped]
        public HttpPostedFileBase UploadImage { get; set; }
    }
    public class UpdateProductInput : CreateProductInput
    {

    }
}