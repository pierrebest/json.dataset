using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using History.Dictionary.Interfaces;

namespace History.Dictionary
{
    public class FileHistoryDictionarySource : IHistoryDictionarySource
    {
        public bool Read(ref List<IEvent> events)
        {
            throw new NotImplementedException();
        }
    }
}
