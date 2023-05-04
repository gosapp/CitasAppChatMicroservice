﻿
using Domain.Entities;

namespace Application.Reponsive
{
    public class MessageInitalizeResponse
    {
        //public User FriendInfo { get; set; } = null!;
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalItems { get; set; }
        public IEnumerable<MessageResponse> Messages { get; set; } = null!;

    }
}
