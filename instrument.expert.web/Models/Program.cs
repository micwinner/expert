using System.Collections.Generic;

namespace instrument.expert.web.Models
{
    //树枝
    public class Program : AbstractContent
    {
        public Program()
        {
            _list = new List<AbstractContent>();
        }

        public override void Insert(AbstractContent statistics)
        {
            _list.Add(statistics);
        }

        public override void Delete(AbstractContent statistics)
        {
            if (_list.Contains(statistics))
                _list.Remove(statistics);
        }
    }
}