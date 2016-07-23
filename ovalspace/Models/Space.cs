using System.Collections.Generic;

namespace oval.models
{
    public class Space
    {
        public int ID{get;set;}
        public string Location {get;set;}
        public List<Event> Events {get;set;}
    }
}