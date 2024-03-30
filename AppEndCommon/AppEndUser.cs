﻿using System.Collections;

namespace AppEndCommon
{
    public class AppEndUser
    {
		public int Id { get; set; } = 0;
		public string UserName { get; set; } = "";
		public string[] Roles { set; get; } = [];
        public Hashtable? ContextInfo { set; get; }
		public string ContextCacheKey()
		{
			return $"U::Context,{UserName},{Id}";
		}

	}
}
