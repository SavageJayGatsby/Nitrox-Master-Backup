using NitroxModel.DataStructures.GameLogic;

namespace NitroxServer.GameLogic.Entities.Spawning
{
    public interface IEntityBootstrapper
    {
        void Prepare(Entity spawnedEntity, Entity parentEntity, DeterministicBatchGenerator idGenerator);
    }
}
