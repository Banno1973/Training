using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Interfaces
{
    public interface IScreenWithData<T>
    {
        public void Render(T data);
    }
}
