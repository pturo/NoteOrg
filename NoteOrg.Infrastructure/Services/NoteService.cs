using AutoMapper;
using NoteOrg.Core.Domain;
using NoteOrg.Core.Repositories;
using NoteOrg.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOrg.Infrastructure.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IMapper _mapper;

        public NoteService(INoteRepository noteRepository, IMapper mapper)
        {
            _noteRepository = noteRepository;
            _mapper = mapper;
        }

        public NoteDto Get(Guid id)
        {
            var note = _noteRepository.Get(id);

            return _mapper.Map<NoteDto>(note);
        }

        public IEnumerable<NoteDto> GetAll()
        {
            var notes = _noteRepository.GetAll();

            return _mapper.Map<IEnumerable<NoteDto>>(notes);
        }

        public NoteDto Create(Guid id, string title, string content)
        {
            var note = new Note(id, title, content);
            _noteRepository.Add(note);
            return _mapper.Map<NoteDto>(note);
        }

        public void Update(Guid id, string title, string content)
        {
            var note = _noteRepository.Get(id);
            note.SetTitle(title);
            note.SetContent(content);
            _noteRepository.Update(note);
        }

        public void Delete(Guid id)
        {
            var note = _noteRepository.Get(id);
            _noteRepository.Delete(note);
        }
    }
}
