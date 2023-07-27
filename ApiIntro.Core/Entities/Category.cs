using ApiIntro.Core.Entities.BaseEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ApiIntro.Core.Entities
{
	public class Category:BaseEntity
	{
		public string Name { get; set; }
	}
}

