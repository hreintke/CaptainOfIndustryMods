using Mafi.Unity.InputControl.Inspectors;
using Mafi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mafi.Unity.UiFramework.Components;
using Mafi.Unity.UserInterface;
using Mafi.Core;
using Mafi.Core.Input;
using System.Runtime.Remoting.Lifetime;

namespace EntityWindowMod
{
    public class EntityWindowWindowView : StaticEntityInspectorBase<EntityWindow>
    {
        private readonly EntityWindowInspector _inspector;
        private Btn EntityWindowButton;

        public EntityWindowWindowView(EntityWindowInspector inspector) : base(inspector)
        {
            _inspector = inspector;
            LogWrite.Info("Window view instanciate");
        }

        protected override EntityWindow Entity => _inspector.SelectedEntity;

        protected override void AddCustomItems(StackContainer itemContainer)
        {
            LogWrite.Info("Adding custom items");
            LogWrite.Info("Getting base items");
            base.AddCustomItems(itemContainer);  // <================ this gives nullpointer exception
            LogWrite.Info("Base items done");
            AddSectionTitle(itemContainer, "These are the actions");
            EntityWindowButton = AddButton(itemContainer, () => { LogWrite.Info("EntityWindow action"); }, "Action Button");
            EntityWindowButton.SetEnabled(true);
            EntityWindowButton.OnClick(() => { Log.Info("Action Button pushed"); });
            LogWrite.Info("Done adding items");
        }
    }
}
