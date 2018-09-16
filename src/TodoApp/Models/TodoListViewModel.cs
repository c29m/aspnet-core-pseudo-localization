﻿// Copyright (c) Martin Costello, 2018. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace TodoApp.Models
{
    public class TodoListViewModel
    {
        public ICollection<TodoItemModel> Items { get; set; } = new List<TodoItemModel>();
    }
}
