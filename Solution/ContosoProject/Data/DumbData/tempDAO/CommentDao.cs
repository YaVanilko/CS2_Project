﻿using Domain.Entities;
using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DumbData
{
    public class CommentDao : BaseDao<Comment>, ICommentRepository
    {
    }
}
