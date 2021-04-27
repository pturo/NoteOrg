using NoteOrg.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOrg.Infrastructure.Services
{
    public interface INoteService
    {
        NoteDto Get(Guid id);
        IEnumerable<NoteDto> GetAll();
        NoteDto Create(Guid id, string title, string content);
        void Update(Guid id, string title, string content);
        void Delete(Guid id);
    }
}
