﻿using System;
using System.Collections.Generic;

namespace PR2PS.DataAccess.Entities
{
    public class Level : BaseEntity
    {
        public Int64 AuthorId { get; set; }

        public Boolean IsDeleted { get; set; }

        public Boolean IsPublished { get; set; }

        public virtual ICollection<LevelVersion> Versions { get; set; }
    }
}
