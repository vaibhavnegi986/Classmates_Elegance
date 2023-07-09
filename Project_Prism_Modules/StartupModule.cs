using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Project_Prism_Modules.ViewModels;
using Project_Prism_Modules.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prism_Modules  
{
    public class StartupModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //View Register Only
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("LoginRegion", typeof(Login));
            regionManager.RegisterViewWithRegion("SignupRegion", typeof(Signup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //View Register Only
            containerRegistry.RegisterForNavigation<Login, LoginViewModel>();
            containerRegistry.RegisterForNavigation<Signup, SignupViewModel>();
        }
    }
}
