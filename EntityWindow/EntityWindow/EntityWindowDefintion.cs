using Mafi.Base.Prototypes.Buildings;
using Mafi.Core.Entities.Static;
using Mafi.Core.Entities;
using Mafi.Core;
using Mafi.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Prototypes;
using Mafi;
using Mafi.Base;
using Mafi.Collections.ImmutableCollections;
using Mafi.Core.Mods;

namespace EntityWindowMod
{

    [GenerateSerializer(false, null, 0)]
    public class EntityWindow : LayoutEntity, IEntity, IStaticEntity
    {
        public EntityWindow(EntityId id, EntityWindowPrototype proto, TileTransform transform, EntityContext context) : base(id, proto, transform, context)

        {
        }

        public override bool CanBePaused => false;

        private static readonly Action<object, BlobWriter> s_serializeDataDelayedAction;

        private static readonly Action<object, BlobReader> s_deserializeDataDelayedAction;

        public static void Serialize(EntityWindow value, BlobWriter writer)
        {
            if (writer.TryStartClassSerialization(value))
            {
                writer.EnqueueDataSerialization(value, s_serializeDataDelayedAction);
            }
        }

        public static EntityWindow Deserialize(BlobReader reader)
        {
            if (reader.TryStartClassDeserialization(out EntityWindow obj, (Func<BlobReader, Type, EntityWindow>)null))
            {
                reader.EnqueueDataDeserialization(obj, s_deserializeDataDelayedAction);
            }

            return obj;
        }

        static EntityWindow()
        {
            //          eLxG93FZl5M3yHxFGb.MBiHIp97M4MqqbtZOh.waT7xm6r5();
            s_serializeDataDelayedAction = delegate (object obj, BlobWriter writer)
            {
                ((EntityWindow)obj).SerializeData(writer);
            };
            s_deserializeDataDelayedAction = delegate (object obj, BlobReader reader)
            {
                ((EntityWindow)obj).DeserializeData(reader);
            };
        }
    }
}
