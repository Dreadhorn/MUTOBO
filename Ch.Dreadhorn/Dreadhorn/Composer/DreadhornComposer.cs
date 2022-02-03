using Dreadhorn.Interfaces;
using Dreadhorn.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;

namespace Dreadhorn.Composer
{
    public class DreadhornComposer : IUserComposer
    {


        /// <summary>
        /// Composer to compose the web page
        /// </summary>
        /// <param name="composition"></param>
        public void Compose(Composition composition)
        {
            RegisterServices(composition);

            AddComponents(composition);

            RegisterComponents(composition);
        }

        /// <summary>
        /// Method to add custom implemented components which implements IComponent
        /// </summary>
        private void AddComponents(Composition composition)
        {
        }

        private void RegisterComponents(Composition composition)
        {

        }


        /// <summary>
        /// Method to register all custom implemented services
        /// </summary>
        /// <param name="composition"></param>
        private void RegisterServices(Composition composition)
        {
            composition.Register(typeof(IDreadhornContentService), typeof(DreadhornContentService), Lifetime.Scope);
            composition.Register(typeof(IDreadhornEasterEggService), typeof(DreadhornEasterEggService), Lifetime.Scope);
        }
    }
}
