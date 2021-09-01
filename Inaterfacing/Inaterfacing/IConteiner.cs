using System;
using System.Collections.Generic;
using System.Text;

namespace Inaterfacing
{
     public interface IContainer
    {
        double Capacity { get; set; }

        void AddContainer(double Amount);

        void RemoveConteiner(double Amount);
    }
}
