using System;
using System.Collections.Generic;

namespace DACS_BlogCaNhan.Models;

public partial class Comment
{
    public string ContentComment { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public int? ParentComment { get; set; }

    public long IdPost { get; set; }

    public long IdUser { get; set; }

    public virtual Post IdPostNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
