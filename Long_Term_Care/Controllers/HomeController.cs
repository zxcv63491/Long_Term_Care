using bigproject.Models;
using Long_Term_Care.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace Long_Term_Care.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly LongTermCareContext _context;

        public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
        
        public  IActionResult CareTeam(int id)
        {

            //CareTeamTexts.Add(new CareTeamText { cID = id });
          
            return View(CareTeamTexts);
        }
        List<CareTeamText> CareTeamTexts = new List<CareTeamText>
        {
            new CareTeamText{cID=1,cName="�s���",cLink="E001.png", cText="�򥻨���M��B���q�ͩR��H�B���P�~�X", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=2,cName="�s���",cLink="E002.png", cText="�򥻤�`���U�B��U�i���κ��������B�������@", cTime="�A�Ȯɶ� �g�G��g���W��10:00~�U��3:00" },
            new CareTeamText{cID=3,cName="�s���",cLink="E003.png", cText="�򥻨���M��B½����I�B���P�N��", cTime="�A�Ȯɶ� �g�|��g���W��10:00~�U��3:00" },
            new CareTeamText{cID=4,cName="�s���",cLink="E004.png", cText="�򥻤�`���U�B�N�ʩΥN��ΥN�e�A�ȡB�w���ݵ�", cTime="�A�Ȯɶ� �g�T��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=5,cName="�s���",cLink="E005.png", cText="�򥻨���M��B����A�ȡB�����A��", cTime="�A�Ȯɶ� �g�T�g�|�W��10:00~�U��5:00" },
            new CareTeamText{cID=6,cName="�s���",cLink="E006.png", cText="�򥻤�`���U�B��U�~�Y�B��U�ƪn", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=7,cName="�s���",cLink="E007.png", cText="�򥻨���M��B�\�����U�B�������`", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=8,cName="�s���",cLink="E008.png", cText="�򥻤�`���U�B�a�Ȩ�U�B�޸��M��", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=9,cName="�s���",cLink="E009.png", cText="�򥻨���M��B����A�ȡB�����A��", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=10,cName="�s���",cLink="E010.png", cText="�򥻤�`���U�B��U�W�U�ӱ�B�������@", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=12,cName="�s���",cLink="E011.png", cText="�򥻨���M��B��U�i���κ���B½����I", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=13,cName="�s���",cLink="E012.png", cText="�򥻤�`���U�B��}�����}�B�̪o�y�q�K", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=14,cName="�s���",cLink="E013.png", cText="�򥻨���M��B�w���ݵ��B���P�~�X", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=15,cName="�s���",cLink="E014.png", cText="�򥻤�`���U�B���q�ͩR��H�B�����A��", cTime="�A�Ȯɶ� �g���g��W��10:00~�U��5:00" },
            new CareTeamText{cID=16,cName="�s���",cLink="E015.png", cText="�򥻨���M��B��U�~�Y�B�̫��ܸm�J�Ĳ�", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=17,cName="�s���",cLink="E016.png", cText="�򥻤�`���U�B�޸��M��B�N�ʪA��", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=18,cName="�s���",cLink="E017.png", cText="�򥻨���M��B���P�N��B�������`", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=19,cName="�s���",cLink="E018.png", cText="�򥻤�`���U�B�������@�B�\�����U", cTime="�A�Ȯɶ� �g���g��W��10:00~�U��5:00" },
            new CareTeamText{cID=20,cName="�s���",cLink="E019.png", cText="�򥻨���M��B�N�ʪA�ȡB�̫��ܸm�J�Ĳ�", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=21,cName="�s���",cLink="E020.png", cText="�򥻤�`���U�B����A�ȡB��U�~�Y", cTime="�A�Ȯɶ� �g���g��W��10:00~�U��5:00" },
            new CareTeamText{cID=22,cName="�s���",cLink="E021.png", cText="�򥻨���M��B��U�ƪn�B½����I", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=23,cName="�s���",cLink="E022.png", cText="�򥻤�`���U�B��U�i���κ���B���P�N��", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=24,cName="�s���",cLink="E023.png", cText="�򥻨���M��B����A�ȡB��U�ƪn", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },
            new CareTeamText{cID=25,cName="�s���",cLink="E024.png", cText="�򥻤�`���U�B�a�Ȩ�U�B���P�~�X", cTime="�A�Ȯɶ� �g���g��W��10:00~�U��5:00" },
            new CareTeamText{cID=26,cName="�s���",cLink="E025.png", cText="�򥻨���M��B�̪o�y�q�K�B�w���ݵ�", cTime="�A�Ȯɶ� �g�@��g���W��10:00~�U��5:00" },

        };
	

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
