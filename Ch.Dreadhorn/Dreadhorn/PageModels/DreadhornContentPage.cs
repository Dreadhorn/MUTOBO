using Dit.Umb.Mutobo.PageModels;
using Dreadhorn.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Dreadhorn.PageModels
{
    public class DreadhornContentPage : ContentPage
    {
        public ETimes TimePeriod { get; set; }

        public DreadhornContentPage(IPublishedContent content) : base(content)
        {

        }
    }
}
