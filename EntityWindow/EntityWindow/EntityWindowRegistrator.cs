using Mafi.Base;
using Mafi.Collections.ImmutableCollections;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;
using Mafi.Core.Prototypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mafi.Base.Assets.Base.Machines.PowerPlant;
using static Mafi.Base.Assets.Base.Machines;
using static Mafi.Base.Assets;
using static Mafi.Unity.Assets.Unity;

namespace EntityWindowMod
{
    public class EntityWindowRegistrator : IModData
    {
        public void RegisterData(ProtoRegistrator registrator)
        {
            LogWrite.Info("Registrating prototype");
            Proto.Str ps = Proto.CreateStr(PrototypeIDs.LocalEntities.EntityWindowID, "EntityWindow", "EntityWindow description");
            EntityLayout el = registrator.LayoutParser.ParseLayoutOrThrow("[1]");
            EntityCosts ec = EntityCosts.None;
            LayoutEntityProto.Gfx lg =
                new LayoutEntityProto.Gfx("Assets/Base/Machines/Waste/SmokeStack.prefab",
                customIconPath: "Assets/Unity/Generated/Icons/LayoutEntity/SmokeStack.png",
                categories: new ImmutableArray<ToolbarCategoryProto>?(registrator.GetCategoriesProtos(Ids.ToolbarCategories.Landmarks)))
                ;
            EntityWindowPrototype bp =
                new EntityWindowPrototype(
                    PrototypeIDs.LocalEntities.EntityWindowID, ps, el, ec, lg);
            registrator.PrototypesDb.Add(bp);
        }
    }
}
