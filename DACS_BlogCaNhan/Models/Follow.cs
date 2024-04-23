using System;
using System.Collections.Generic;

namespace DACS_BlogCaNhan.Models;

public partial class Follow
{
    public long IdFollower { get; set; }

    public long IdFollowing { get; set; }

    public string? ExistenceStatus { get; set; }

    public virtual User IdFollowerNavigation { get; set; } = null!;

    public virtual User IdFollowingNavigation { get; set; } = null!;
}
