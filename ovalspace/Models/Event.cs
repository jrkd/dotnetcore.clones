using System;

namespace oval.models
{
    public class Event
    { 
        public int ID {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}

        public DateTime When {get;set;}
    }
}