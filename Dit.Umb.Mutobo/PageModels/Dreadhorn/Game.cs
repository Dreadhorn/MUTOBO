using Dit.Umb.Mutobo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Dit.Umb.Mutobo.PageModels.Dreadhorn
{
    public class Game : ArticlePage
    {
        public string Titel => Content.Value<string>(DocumentTypes.Game.Fields.Title);



        public Game(IPublishedContent content) : base(content)
        {
        }
    }
}
