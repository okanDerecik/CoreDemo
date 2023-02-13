using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        // void CommentDelete(Category category);
        // void CommentUpdate(Category category);
        List<Comment> GetList(int id);
        // Comment GetByID(int id);
    }
}
