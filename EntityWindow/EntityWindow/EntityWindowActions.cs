using Mafi;
using Mafi.Collections.ImmutableCollections;
using Mafi.Core.Entities;
using Mafi.Core.Input;
using Mafi.Core.Prototypes;
using Mafi.Core.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWindowMod
{

    [GlobalDependency(RegistrationMode.AsSelf)]
    public class EntityWindowActions
    {
        private readonly ProtosDb _protosDb;
        private readonly UnlockedProtosDb _unlockedProtosDb;

        public EntityWindowActions(
            ProtosDb protosDb,
            UnlockedProtosDb unlockedProtosDb
        )
        {
            unlockedProtosDb.Unlock(ImmutableArray.Create(protosDb.Get(PrototypeIDs.LocalEntities.EntityWindowID).Value));
        }
    }
}
