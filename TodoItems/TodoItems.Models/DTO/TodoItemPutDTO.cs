﻿using TodoItems.Models.Interfaces;

namespace TodoItems.Models.DTO
{
    public class TodoItemPutDTO : ITodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}