using System;
using System.Collections.Generic;

namespace backend.Models;

public partial class TbProduct
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateBy { get; set; }
}
