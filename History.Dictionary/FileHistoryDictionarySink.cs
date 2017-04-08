using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using History.Dictionary.Interfaces;

namespace History.Dictionary
{
    public class FileHistoryDictionarySink : IHistoryDictionarySink
    {
        public bool Write(IHistoryDictionary historyDictionary)
        {
            throw new NotImplementedException();
        }
    }
}
