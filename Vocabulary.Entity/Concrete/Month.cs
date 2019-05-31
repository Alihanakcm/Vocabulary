using System;
using Vocabulary.Entity.Abstract;

namespace Vocabulary.Entity.Concrete
{
    public class Month:IEntity
    {
        public Int32 Monthid { get; set; }
        public Int32 January { get; set; }
        public Int32 Fabruary { get; set; }
        public Int32 March { get; set; }
        public Int32 April { get; set; }
        public Int32 May { get; set; }
        public Int32 June { get; set; }
        public Int32 July { get; set; }
        public Int32 August { get; set; }
        public Int32 September { get; set; }
        public Int32 October { get; set; }
        public Int32 November { get; set; }
        public Int32 December { get; set; }
    }
}
