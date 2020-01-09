using ConferenceTracker.Entities;
using System.Collections.Generic;

namespace ConferenceTracker.Repositories
{
    public interface ISpeakerRepository
    {
        void Create(Speaker speaker);
        void Delete(Speaker speaker);
        Speaker GetSpeaker(int id);
        List<Speaker> GetAllSpeakers();
        void Update(Speaker speaker);
    }
}
