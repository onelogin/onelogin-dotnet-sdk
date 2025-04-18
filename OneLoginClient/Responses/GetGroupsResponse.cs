﻿using System.Runtime.Serialization;

namespace OneLogin.Responses
{
    public class GetGroupsResponse : PaginationBaseResponse<Group>
    {
    }

    /// <summary>
    /// Think of groups as departments. Groups enable you to split your user base into smaller pieces that can be more easily managed.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Group’s unique ID in OneLogin.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Deprecated. Will always display the attribute null.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
