﻿namespace Tweetbook.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Posts
        {
            public const string GetAll = Base + "/posts";
            public const string Get = Base + "/posts/{postId}";
            public const string Update = Base + "/posts/{postId}";
            public const string Delete = Base + "/posts/{postId}";
            public const string Create = Base + "/posts";
        }

        public static class Identity
        {
            public const string Login = "/identity/login";
            public const string Register = "/identity/register";
            public const string Refresh = "/identity/refresh";
        }

        public static class Tags
        {
            public const string GetAll = Base + "/tags";
            public const string Get = Base + "/tags/{tagName}";
            public const string Create = Base + "/tags";
            public const string Delete = Base + "/tags/{tagName}";
        }
    }
}
