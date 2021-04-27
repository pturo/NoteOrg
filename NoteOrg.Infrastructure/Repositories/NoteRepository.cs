using NoteOrg.Core.Domain;
using NoteOrg.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOrg.Infrastructure.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private static readonly ISet<Note> _notes = new HashSet<Note>()
        {
            new Note(Guid.NewGuid(), "Tytuł Notatki 1", "Treść Notatki 1"),
            new Note(Guid.NewGuid(), "Tytuł Notatki 2", "Treść Notatki 2")
        };

        public Note Get(Guid id)
        {
            return _notes.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Note> GetAll()
        {
            return _notes;
        }

        public Note Add(Note note)
        {
            _notes.Add(note);
            return note;
        }

        public void Update(Note note)
        {
            // Do nothing -> data access from memory
        }

        public void Delete(Note note)
        {
            _notes.Remove(note);
        }
    }
}
