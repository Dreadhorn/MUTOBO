using Dit.Umb.Mutobo.Interfaces;
using Dit.Umb.Mutobo.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Dreadhorn.Interfaces
{
    public interface IDreadhornContentService
    { 
        IEnumerable<MutoboContentModule> GetContent(IPublishedContent content, string fieldName);
    }
}
