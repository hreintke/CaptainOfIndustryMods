using Mafi.Core.Input;
using Mafi.Core;
using Mafi.Unity.InputControl.Inspectors;
using Mafi.Unity.UserInterface;
using Mafi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWindowMod
{
    [GlobalDependency(RegistrationMode.AsEverything)]
    public class EntityWindowInspector : IEntityInspector<EntityWindow>
    {
        private UiBuilder _uiBuilder;
        private EntityWindowWindowView _windowView;

        public EntityWindowInspector(UiBuilder uiBuilder)
        {
            LogWrite.Info("Window inspector instanciate");
            _uiBuilder = uiBuilder;
        }

        public EntityWindow SelectedEntity { get; private set; }
        public InspectorContext Context { get; private set; }
        public bool DeactivateOnNonUiClick => true;

        public void Activate()
        {
            LogWrite.Info("Inspector Activate");
            _windowView = new EntityWindowWindowView(this);
            _windowView.BuildUi(_uiBuilder);
            _windowView.Show();
        }

        public void Deactivate()
        {
            LogWrite.Info("Inspector deactivate ");
            _windowView = new EntityWindowWindowView(this);
            _windowView.BuildUi(_uiBuilder);
            _windowView.Destroy();
        }

        public void SyncUpdate(GameTime time)
        {
            if (_windowView != null)
            {
                _windowView.SyncUpdate(time);
            }
        }

        public void RenderUpdate(GameTime time)
        {
            if (_windowView != null)
            {
                _windowView.RenderUpdate(time);
            }
        }

        public bool InputUpdate(IInputScheduler inputScheduler)
        {
            return false;
        }
        public IEntityInspector Create(EntityWindow entity)
        {
            SelectedEntity = entity.CheckNotNull();
            return this;
        }
    }

}
