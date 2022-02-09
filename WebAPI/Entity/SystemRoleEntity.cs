﻿using System;
using System.Collections.Generic;
using WebAPI.Model;

namespace WebAPI.Entity
{
    // DTO or Data Transfer Object
    /*** 
     * DTO serves the purpose to transfer data from the server to the client.
     * 
     * we can use the model class to fetch the data from the database (returns a list of Employee objects) 
     * and also to return that result to the client.
     * 
     * And that is not a good practice.
     * 
     * A much better practice is to have a model class to fetch the data from the database and to have a DTO class to return that result to the client.
     * */
    public class SystemRoleEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
