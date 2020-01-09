using ConferenceTracker.Entities;
using System.Collections.Generic;

namespace ConferenceTracker.Repositories
{
    public interface IPresentationRepository
    {
        void Create(Presentation presentation);
        void Delete(Presentation presentation);
        Presentation GetPresentation(int id);
        List<Presentation> GetAllPresentations();
        void Update(Presentation presentation);
    }
}
