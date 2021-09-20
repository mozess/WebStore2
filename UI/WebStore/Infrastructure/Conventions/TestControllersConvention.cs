using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebStore.Services.Conventions
{
    public class TestControllersConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            //controller.Actions.Add(new ActionModel());
        }
    }
}
