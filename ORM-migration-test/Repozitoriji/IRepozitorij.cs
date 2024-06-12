using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_migration_test.Repozitoriji
{
    internal interface IRepozitorij<T>
    {
        T? dohvatiJedan();
        
        List<T> dohvatiSve();

        void spremi(T t);
    }
}
