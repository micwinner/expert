using System.Collections.Generic;

namespace instrument.expert.web.Models
{
    public abstract class AbstractContent
    {
        public List<AbstractContent> _list;
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public double Score { get; set; }
        public abstract void Insert(AbstractContent statistics);
        public abstract void Delete(AbstractContent statistics);
    }
}