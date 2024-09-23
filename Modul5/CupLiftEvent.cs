using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5
{
    public class CupLiftEvent
    {
        private List<int> _eventEyes;
        public DateTime _eventTime;

        public CupLiftEvent(List<int> _eventEyes, DateTime _eventTime)
        {
            this._eventEyes = _eventEyes; 
            this._eventTime = _eventTime;
        }
    }
}
