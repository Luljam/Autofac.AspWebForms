using Lib;
using Lib.Abstractions;
using System;
using System.Linq;

namespace WebFormClient
{
    public partial class Avengers : System.Web.UI.Page
    {
        public ISuperheroService _SuperheroService { private get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Modo sem injeção de dependência
            //Logger logger = new Logger();
            //AvengerRepository avengerRepository = new AvengerRepository(logger);
            //SuperheroService superheroService = new SuperheroService(avengerRepository, logger);

            grdAvengers.DataSource = _SuperheroService.GetAvengers();
            grdAvengers.DataBind();
        }
    }
}