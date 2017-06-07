using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBiblio
{
    public interface IDataManager
    {
        IEnumerable<Phone> ListePhones { get; }

        void Add(Phone P);

        void Remove(Phone P);

        void Update(Phone P);
    }
}
