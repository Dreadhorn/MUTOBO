using Dit.Umb.Mutobo.Interfaces;
using Dit.Umb.Mutobo.Modules;
using Dit.Umb.Mutobo.Services;
using Dreadhorn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Dreadhorn.Services
{
    public class DreadhornContentService : MutoboContentService, IDreadhornContentService
    {
        private readonly IImageService _imageService;

        public DreadhornContentService
            (IImageService imageService,
            ISliderService sliderService,
            IConfigurationService configurationService,
            ICardService cardService)
            : base(imageService, sliderService, configurationService, cardService)
        {
            _imageService = imageService;
        }

        public IEnumerable<MutoboContentModule> GetContent(IPublishedContent content, string fieldName)
        {
            if (content.HasValue(fieldName))
            {
                // get the mutobo base modules from the given fields as List
                var modules = base.GetContent(content, fieldName).ToList();

                // get the IPublishedElements from the given field
                var elements =
                    content.Value<IEnumerable<IPublishedElement>>(fieldName);

                // loop over the elements
                foreach (var element in elements.Select((value, index) => new { index, value }))
                {
                    switch (element.value.ContentType.Alias)
                    {
                        
                    }
                }
                // return the ordered collection with the the modules inside
                return modules.OrderBy(m => m.SortOrder);
            }

            return null;
        }
    }
}
