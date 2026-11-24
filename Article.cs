using System;
using System.Collections.Generic;

namespace WPF_JSON_Circular
{ 
	public class Article
	{
		public uint ID { get; set; }
		public string Title { get; set; }
		public List<Author> Authors { get; set; }
		public DateTime DateofPublication { get; set; }

		public Article()
		{
			Authors=new List<Author>();
		}
	}
}