using CoreProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjesi.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName = "Yiğit"
				},
				new UserComment
				{
					ID = 2,
					UserName = "Ege"
				},
				new UserComment
				{
					ID = 3,
					UserName = "Merve"
				}
			};
			return View(commentValues);

		}
	}
}
