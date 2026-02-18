using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge_FactoryMethod
{
    internal abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();
    }
}
