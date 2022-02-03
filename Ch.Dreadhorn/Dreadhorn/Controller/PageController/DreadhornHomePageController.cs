using Dit.Umb.Mutobo.Constants;
using Dit.Umb.Mutobo.Controllers.PageControllers;
using Dit.Umb.Mutobo.Interfaces;
using Dreadhorn.Interfaces;
using Dreadhorn.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace Dreadhorn.Controller.PageController
{
    public class DreadhornHomePageController : HomePageController
    {
        private new readonly IDreadhornContentService _contentService;
        private readonly IDreadhornEasterEggService _easterEggService;

        public DreadhornHomePageController(IDreadhornContentService contentService, IDreadhornEasterEggService easterEggService) : base(contentService as IMutoboContentService)
        {
            _contentService = contentService;
            _easterEggService = easterEggService;
        }

        public override ActionResult Index(ContentModel model)
        {

            return base.Index<DreadhornHomePage>(new DreadhornHomePage(model.Content)
            {
                TimePeriod = _easterEggService.GetTimePeriod(),
                Modules = _contentService.GetContent(model.Content, DocumentTypes.HomePage.Fields.Modules)
            });
        }
    }
}
