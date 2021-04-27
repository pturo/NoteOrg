using NoteOrg.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOrg.Core.Repositories
{
    public interface INoteRepository
    {
        Note Get(Guid id);
        IEnumerable<Note> GetAll();
        Note Add(Note note);
        void Update(Note note);
        void Delete(Note note);
    }
}
