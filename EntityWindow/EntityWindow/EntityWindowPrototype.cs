using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Prototypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mafi.Core.Prototypes.Proto;

namespace EntityWindowMod
{
    public class PrototypeIDs
    {
        public partial class LocalEntities
        {
            public static readonly EntityWindowPrototype.ID EntityWindowID = new EntityWindowPrototype.ID("EntityWindow");
        }
    }

    public class EntityWindowPrototype : LayoutEntityProto, IProto
    {
        public EntityWindowPrototype(ID id, Str strings, EntityLayout layout, EntityCosts costs, Gfx graphics)
             : base(id, strings, layout, costs, graphics)
        {
        }

        public override Type EntityType => typeof(EntityWindow);
    }
}
